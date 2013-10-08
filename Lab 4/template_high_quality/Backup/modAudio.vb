Module modAudio
    'This module is intended for processing AU files with 1 byte per sample
    'in the 2's complement format

    'The following constants give positional information
    'concerning where to find various pieces of information
    'in the AU file header
    Private Const Base As Short = 1
    Private Const Bytes_For_Head As Short = 4
    Private Const Head_Offset_Position As Short = 4 + Base
    Private Const Data_Length_Position As Short = 8 + Base
    Private Const Sound_Format_Position As Short = 12 + Base
    Private Const Sampling_Rate_Position As Short = 16 + Base
    Private Const Channel_Position As Short = 20 + Base
    Private Const Text_Description_Position As Short = 24 + Base

    Public PMC As New QuartzTypeLib.FilgraphManager()

    'The following data structure is used to represent all the
    'information stored inside a single AU file
    Public Structure AuData
        Dim Sampling_Rate As Integer 'The sampling rate
        Dim Head_Offset As Integer 'Indicates the position of the first sample
        Dim Data_Length As Integer 'Total number of samples
        Dim Sound_Format As Integer 'Indicates the way in which the samples are stored
        Dim Channel As Integer 'How many channels are used
        Dim Text_Description As String 'This is an optional component of an AU file
        Dim Sampling_Bytes As Short 'Indicates the way in which the samples are stored
        Dim Sample() As Integer 'The actual audio samples
    End Structure

    Public Sub Play_au_File(ByRef FileName As String) 'play an au file
        Try
            PMC = New QuartzTypeLib.FilgraphManager()
            PMC.RenderFile(FileName)
            PMC.Run()
        Catch e As Exception
            MessageBox.Show("Cannot play au file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Load_au_Head(ByRef FileNum As Short, ByRef Data As AuData) As Boolean
        Dim i As Short
        Dim bData As Byte

        'Get head data
        Data.Head_Offset = Get_Long_Data(FileNum, Head_Offset_Position)
        Data.Data_Length = Get_Long_Data(FileNum, Data_Length_Position)
        Data.Sound_Format = Get_Long_Data(FileNum, Sound_Format_Position)
        Data.Sampling_Rate = Get_Long_Data(FileNum, Sampling_Rate_Position)
        Data.Channel = Get_Long_Data(FileNum, Channel_Position)

        'Get text description
        For i = Text_Description_Position To Data.Head_Offset
            FileGet(FileNum, bData, i)
            Data.Text_Description = Data.Text_Description & Chr(bData)
        Next
        ' Find the actual sound format e.g. number of bits per sample
        Select Case Data.Sound_Format
            Case 2
                Data.Sampling_Bytes = 1
            Case 3
                Data.Sampling_Bytes = 2
            Case 4
                Data.Sampling_Bytes = 3
            Case 5
                Data.Sampling_Bytes = 4
            Case 1
                Data.Sampling_Bytes = 1
            Case Else
                Data.Sampling_Bytes = 0
        End Select

        If Data.Sampling_Bytes <> 2 Then
            MessageBox.Show("This is not an 16-bit au file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Load_au_Head = False
        Else
            Load_au_Head = True
        End If
    End Function

    Public Function Load_au_File(ByRef FileName As String, ByRef Data As AuData) As Boolean
        Dim FileNum As Short

        FileNum = FreeFile() 'prepare to load an au file
        FileOpen(FileNum, FileName, OpenMode.Binary) 'open a file for random access
        If Not Check_Valid_au_File(FileNum) Then 'check whether it is a valid au file
            Load_au_File = False
            FileClose(FileNum)
            Exit Function
        End If
        If Not Load_au_Head(FileNum, Data) Then 'get the head of the au file
            Load_au_File = False
            FileClose(FileNum)
            Exit Function
        End If
        ReDim Data.Sample(Data.Data_Length / 2 - 1) 'allocate memory space for storing sound data
        Get_Sound_Data(FileNum, Data) 'get sound data and store it in Original_Data
        FileClose(FileNum)
        Load_au_File = True
    End Function

    Public Sub Save_au_File(ByRef FileName As String, ByRef Data As AuData)

        Dim FileNum As Short
        Dim i As Integer
        Dim bData As Byte
        Dim Pos As Integer
        Dim tmp As Integer
        Dim result As Integer

        Try
            If Dir(FileName) <> "" Then
                If MessageBox.Show(FileName & " exits, do you want to overwrite it?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.Cancel Then
                    Exit Sub
                Else
                    Kill(FileName) 'the file already exists, we delete it
                End If
            End If
            FileNum = FreeFile()
            FileOpen(FileNum, FileName, OpenMode.Binary)
            Write_au_File_Head(FileNum, Data)
            i = 0
            Pos = 0

            While i <= Data.Sample.Length - 1
                tmp = Data.Sample(i)
                result = tmp >> 8
                bData = CByte(result)

                FilePut(FileNum, bData, Data.Head_Offset + 1 + Pos)
                Pos = Pos + 1

                tmp = (tmp And 255)
                bData = CByte(tmp)
                FilePut(FileNum, bData, Data.Head_Offset + 1 + Pos)
                Pos = Pos + 1
                i = i + 1
            End While

            FileClose(FileNum)
        Catch e As Exception
            MessageBox.Show("Cannot save au file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub Get_Sound_Data(ByRef FileNum As Short, ByRef Data As AuData)
        'This routine loads all samples into memory
        Dim i As Integer
        Dim bData As Byte
        Dim tmp As Integer
        i = 0
        While i <= Data.Data_Length - 1
            FileGet(FileNum, bData, Data.Head_Offset + i + 1)
            tmp = CInt(bData)
            tmp = tmp * 2 ^ 8

            FileGet(FileNum, bData, Data.Head_Offset + i + 2)
            Data.Sample(i / 2) = CInt(bData)
            Data.Sample(i / 2) = Data.Sample(i / 2) + tmp

            i = i + 2
        End While
    End Sub

    Private Sub Write_au_File_Head(ByRef FileNum As Short, ByRef Data As AuData)
        Dim bData As Byte

        'write '.snd' to the beginning of the file
        bData = Asc(".")
        FilePut(FileNum, bData, 1)
        bData = Asc("s")
        FilePut(FileNum, bData, 2)
        bData = Asc("n")
        FilePut(FileNum, bData, 3)
        bData = Asc("d")
        FilePut(FileNum, bData, 4)

        'write head data
        Write_Long_Data(FileNum, Head_Offset_Position, Data.Head_Offset)
        Write_Long_Data(FileNum, Data_Length_Position, Data.Data_Length)
        Write_Long_Data(FileNum, Sound_Format_Position, Data.Sound_Format)
        Write_Long_Data(FileNum, Sampling_Rate_Position, Data.Sampling_Rate)
        Write_Long_Data(FileNum, Channel_Position, Data.Channel)
        Write_Long_Data(FileNum, Data_Length_Position, Data.Data_Length)
    End Sub

    'if the beginning four chars are '.snd', then we regard it as a valid au file
    Private Function Check_Valid_au_File(ByRef FileNum As Short) As Boolean
        Dim bData As Byte
        Dim Header As String

        FileGet(FileNum, bData, 1)
        Header = Chr(bData)
        FileGet(FileNum, bData, 2)
        Header = Header & Chr(bData)
        FileGet(FileNum, bData, 3)
        Header = Header & Chr(bData)
        FileGet(FileNum, bData, 4)
        Header = Header & Chr(bData)

        If Header <> ".snd" Then
            MessageBox.Show("This file is not a valid au file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Check_Valid_au_File = False
        Else
            Check_Valid_au_File = True
        End If
    End Function

    'read 4-byte data from the file
    Private Function Get_Long_Data(ByRef FileNum As Short, ByRef Pos As Integer) As Integer
        Dim bData As Byte
        Dim i As Short

        Get_Long_Data = 0
        For i = 0 To 3
            FileGet(FileNum, bData, Pos + i)
            Get_Long_Data = Get_Long_Data * 256 + CInt(bData)
        Next
    End Function

    'write 4-byte data to the file
    Private Sub Write_Long_Data(ByRef FileNum As Short, ByRef Pos As Integer, ByVal Data As Integer)
        Dim bData As Byte
        Dim i As Short

        For i = 0 To 3
            bData = CByte(Data Mod 256)
            Data = Data \ 256
            FilePut(FileNum, bData, Pos + 3 - i)
        Next
    End Sub
End Module
