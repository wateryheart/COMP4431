Option Explicit On
Public Class frmMain
    Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents cmdAmplification As System.Windows.Forms.Button
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents cmdPlayOriginal As System.Windows.Forms.Button
    Public WithEvents lblLength As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents mnuFileOpen As System.Windows.Forms.MenuItem
    Public WithEvents mnuFileSave As System.Windows.Forms.MenuItem
    Public WithEvents mnuFileExit As System.Windows.Forms.MenuItem
    Public WithEvents mnuFile As System.Windows.Forms.MenuItem
    Public WithEvents mnuPlayOriginal As System.Windows.Forms.MenuItem
    Public WithEvents mnuPlay As System.Windows.Forms.MenuItem
    Public MainMenu1 As System.Windows.Forms.MainMenu
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents cmdPlayOuput As System.Windows.Forms.Button
    Public WithEvents slrAmplification As System.Windows.Forms.TrackBar
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents slrFrequency As System.Windows.Forms.TrackBar
    Friend WithEvents slrTre As System.Windows.Forms.TrackBar
    Friend WithEvents cmdTremolo As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSource As System.Windows.Forms.TextBox
    Friend WithEvents cmdBoost As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.slrAmplification = New System.Windows.Forms.TrackBar()
        Me.cmdAmplification = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.cmdPlayOriginal = New System.Windows.Forms.Button()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.MenuItem()
        Me.mnuFileSave = New System.Windows.Forms.MenuItem()
        Me.mnuFileExit = New System.Windows.Forms.MenuItem()
        Me.mnuPlay = New System.Windows.Forms.MenuItem()
        Me.mnuPlayOriginal = New System.Windows.Forms.MenuItem()
        Me.cmdPlayOuput = New System.Windows.Forms.Button()
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmdTremolo = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.slrFrequency = New System.Windows.Forms.TrackBar()
        Me.slrTre = New System.Windows.Forms.TrackBar()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdBoost = New System.Windows.Forms.Button()
        Me.Frame2.SuspendLayout()
        CType(Me.slrAmplification, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.slrFrequency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slrTre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame2
        '
        Me.Frame2.Controls.Add(Me.Label11)
        Me.Frame2.Controls.Add(Me.Label10)
        Me.Frame2.Controls.Add(Me.Label9)
        Me.Frame2.Controls.Add(Me.Label8)
        Me.Frame2.Controls.Add(Me.slrAmplification)
        Me.Frame2.Controls.Add(Me.cmdAmplification)
        Me.Frame2.Location = New System.Drawing.Point(12, 110)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Size = New System.Drawing.Size(354, 82)
        Me.Frame2.TabIndex = 6
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Amplification"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(245, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "800%"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "0%"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(39, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 12)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "100%"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(120, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Amplification (%)"
        '
        'slrAmplification
        '
        Me.slrAmplification.Location = New System.Drawing.Point(12, 20)
        Me.slrAmplification.Maximum = 800
        Me.slrAmplification.Name = "slrAmplification"
        Me.slrAmplification.Size = New System.Drawing.Size(260, 45)
        Me.slrAmplification.TabIndex = 13
        Me.slrAmplification.TickFrequency = 100
        Me.slrAmplification.Value = 100
        '
        'cmdAmplification
        '
        Me.cmdAmplification.Enabled = False
        Me.cmdAmplification.Location = New System.Drawing.Point(282, 32)
        Me.cmdAmplification.Name = "cmdAmplification"
        Me.cmdAmplification.Size = New System.Drawing.Size(60, 24)
        Me.cmdAmplification.TabIndex = 12
        Me.cmdAmplification.Text = "Apply"
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.txtSource)
        Me.Frame1.Controls.Add(Me.cmdPlayOriginal)
        Me.Frame1.Controls.Add(Me.lblLength)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Location = New System.Drawing.Point(12, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(450, 86)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Audio Information"
        '
        'txtSource
        '
        Me.txtSource.Location = New System.Drawing.Point(72, 20)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.ReadOnly = True
        Me.txtSource.Size = New System.Drawing.Size(366, 20)
        Me.txtSource.TabIndex = 16
        Me.txtSource.Text = "<Empty>"
        '
        'cmdPlayOriginal
        '
        Me.cmdPlayOriginal.Enabled = False
        Me.cmdPlayOriginal.Location = New System.Drawing.Point(175, 50)
        Me.cmdPlayOriginal.Name = "cmdPlayOriginal"
        Me.cmdPlayOriginal.Size = New System.Drawing.Size(80, 24)
        Me.cmdPlayOriginal.TabIndex = 15
        Me.cmdPlayOriginal.Text = "Play"
        '
        'lblLength
        '
        Me.lblLength.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLength.Location = New System.Drawing.Point(72, 52)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(97, 20)
        Me.lblLength.TabIndex = 5
        Me.lblLength.Text = "0 byte"
        Me.lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Length :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Location :"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuPlay})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileOpen, Me.mnuFileSave, Me.mnuFileExit})
        Me.mnuFile.Text = "&File"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Index = 0
        Me.mnuFileOpen.Text = "&Open..."
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Enabled = False
        Me.mnuFileSave.Index = 1
        Me.mnuFileSave.Text = "&Save"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Index = 2
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuPlay
        '
        Me.mnuPlay.Enabled = False
        Me.mnuPlay.Index = 1
        Me.mnuPlay.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuPlayOriginal})
        Me.mnuPlay.Text = "&Play"
        '
        'mnuPlayOriginal
        '
        Me.mnuPlayOriginal.Index = 0
        Me.mnuPlayOriginal.Text = "Play &Original Sound"
        '
        'cmdPlayOuput
        '
        Me.cmdPlayOuput.Location = New System.Drawing.Point(140, 298)
        Me.cmdPlayOuput.Name = "cmdPlayOuput"
        Me.cmdPlayOuput.Size = New System.Drawing.Size(200, 24)
        Me.cmdPlayOuput.TabIndex = 15
        Me.cmdPlayOuput.Text = "Play Processed Sound"
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 337)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(474, 16)
        Me.StatusBar1.TabIndex = 16
        Me.StatusBar1.Text = "Please open a sound file!"
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Text = "Please open a sound file!"
        Me.StatusBarPanel1.Width = 503
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.cmdTremolo)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.slrFrequency)
        Me.GroupBox2.Controls.Add(Me.slrTre)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 204)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(450, 82)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tremolo (Sine Wave)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(346, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 13)
        Me.Label15.TabIndex = 90
        Me.Label15.Text = "1"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(201, 54)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 13)
        Me.Label14.TabIndex = 89
        Me.Label14.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(156, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 88
        Me.Label13.Text = "10Hz"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 13)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "0Hz"
        '
        'cmdTremolo
        '
        Me.cmdTremolo.Enabled = False
        Me.cmdTremolo.Location = New System.Drawing.Point(378, 32)
        Me.cmdTremolo.Name = "cmdTremolo"
        Me.cmdTremolo.Size = New System.Drawing.Size(60, 24)
        Me.cmdTremolo.TabIndex = 86
        Me.cmdTremolo.Text = "Apply"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(257, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Wetness"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(69, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Frequency"
        '
        'slrFrequency
        '
        Me.slrFrequency.Location = New System.Drawing.Point(12, 20)
        Me.slrFrequency.Name = "slrFrequency"
        Me.slrFrequency.Size = New System.Drawing.Size(172, 45)
        Me.slrFrequency.TabIndex = 2
        '
        'slrTre
        '
        Me.slrTre.Location = New System.Drawing.Point(194, 20)
        Me.slrTre.Name = "slrTre"
        Me.slrTre.Size = New System.Drawing.Size(172, 45)
        Me.slrTre.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdBoost)
        Me.GroupBox3.Location = New System.Drawing.Point(378, 110)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(84, 82)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Boost"
        '
        'cmdBoost
        '
        Me.cmdBoost.Enabled = False
        Me.cmdBoost.Location = New System.Drawing.Point(12, 32)
        Me.cmdBoost.Name = "cmdBoost"
        Me.cmdBoost.Size = New System.Drawing.Size(60, 24)
        Me.cmdBoost.TabIndex = 0
        Me.cmdBoost.Text = "Apply"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(474, 353)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.cmdPlayOuput)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(10, 48)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Audio Processing - High quality"
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        CType(Me.slrAmplification, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.slrFrequency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slrTre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region

    'This program is intended for processing AU files with 1 byte per sample in the 2's complement format

    Private Const INVALID_NOTE As Short = -1

    'Every time that an audio processing operation is made, a new temporary AU file is created 'behind the scenes'
    Private Const TempNamePart1 As String = "temp"
    Private Const TempNamePart2 As String = ".au"
    Private TempFileName As String = ""
    Private TempFileCount As Integer = 0
    Private LoadFlag As Boolean

    Private soundData As AuData 'Used to store the input AU file

    Private Sub ConvertByteToInteger()
        ' Subroutine for converting byte representation in two's complement form
        ' to integer representation
        Dim i As Integer
        For i = 0 To soundData.Sample.Length - 1
            If soundData.Sample(i) > 32767 Then
                soundData.Sample(i) = soundData.Sample(i) - 65536
            End If
        Next i
    End Sub

    Private Sub ConvertIntegerToByte()
        ' Subroutine for converting integer representation to
        ' byte representation in two's complement form
        Dim i As Integer
        For i = 0 To soundData.Sample.Length - 1
            If soundData.Sample(i) < 0 Then
                soundData.Sample(i) = 65536 + soundData.Sample(i)
            End If
        Next i
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadFlag = False
        PMC = Nothing
    End Sub

    Private Sub frmMain_Closed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        PMC = Nothing
        If TempFileName <> "" And Dir(TempFileName) <> "" Then
            If MessageBox.Show("Do you want to keep file " + TempFileName + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Exit Sub
            Else
                Kill(TempFileName) 'the file already exists, we delete it
            End If
        End If
        Exit Sub
    End Sub

    Public Sub mnuFileSave_Popup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileSave.Popup
        mnuFileSave_Click(sender, e)
    End Sub

    Public Sub mnuFileSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileSave.Click
        Dim dlg As New SaveFileDialog

        dlg.Filter = "AU files (*.au)|*.au"
        dlg.FilterIndex = 2
        dlg.RestoreDirectory = True

        If dlg.ShowDialog() = DialogResult.OK Then
            PMC = Nothing
            Save_au_File(dlg.FileName, soundData) 'Save file
            StatusBar1.Panels(0).Text = "Saved a AU file!"
        End If
    End Sub

    Public Sub mnuFileExit_Popup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Popup
        mnuFileExit_Click(sender, e)
    End Sub

    Public Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Public Sub mnuFileOpen_Popup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileOpen.Popup
        mnuFileOpen_Click(sender, e)
    End Sub

    Public Sub mnuFileOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileOpen.Click
        Dim dlg As New OpenFileDialog

        dlg.Filter = "AU files (*.au)|*.au"
        dlg.FilterIndex = 2
        dlg.RestoreDirectory = True

        If dlg.ShowDialog() = DialogResult.OK Then
            LoadFlag = Load_au_File(dlg.FileName, soundData) 'Load the file

            ' Update various parameters
            If LoadFlag Then
                txtSource.Text = dlg.FileName
                lblLength.Text = soundData.Data_Length & " bytes"
                mnuPlay.Enabled = True
                cmdPlayOriginal.Enabled = True
                mnuFileSave.Enabled = True
                StatusBar1.Panels(0).Text = "Play the sound file!"
                cmdAmplification.Enabled = True
                cmdBoost.Enabled = True
                cmdTremolo.Enabled = True
            End If
        End If
    End Sub

    Public Sub mnuPlayOriginal_Popup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPlayOriginal.Popup
        mnuPlayOriginal_Click(sender, e)
    End Sub

    Public Sub mnuPlayOriginal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPlayOriginal.Click
        ' This subroutine is used to play the input sound file (with no processing applied)
        Play_au_File(txtSource.Text)
    End Sub

    Private Sub cmdPlayOriginal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPlayOriginal.Click
        mnuPlayOriginal_Click(mnuPlayOriginal, New System.EventArgs)
    End Sub

    Private Sub cmdPlayOuput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPlayOuput.Click
        ' This subroutine is used to play the processed sound file
        PMC = Nothing

        If TempFileName <> "" And Dir(TempFileName) <> "" Then
            Kill(TempFileName)
        End If

        ' After previous file "TempFileName" has been loaded and played, 
        ' it cannot be killed before the program ends.
        ' Another temp file is created
        TempFileName = TempNamePart1 + CStr(TempFileCount) + TempNamePart2
        TempFileCount = TempFileCount + 1

        Save_au_File(TempFileName, soundData)
        Play_au_File(TempFileName)
    End Sub

    Private Sub cmdAmplification_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAmplification.Click

        '1. Amplification
        'Change onto integer dormat for easy multiplication
        ConvertByteToInteger()
        Dim i As Integer
        For i = 0 To soundData.Sample.Length - 1
            soundData.Sample(i) = System.Math.Round(soundData.Sample(i) * CDbl(slrAmplification.Value / 100))
            If soundData.Sample(i) > 32767 Then
                soundData.Sample(i) = 32767
            ElseIf soundData.Sample(i) < -32768 Then
                soundData.Sample(i) = -32768
            End If
        Next
        'Convert the sample back to the two's complement format
        ConvertIntegerToByte()
    End Sub

    Private Sub cmdBoost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBoost.Click
        '2. Boost
        'Change onto integer dormat for easy multiplication
        ConvertByteToInteger()
        Dim boost_max As Integer = -32768
        Dim boost_min As Integer = 32767
        Dim i As Integer
        For i = 0 To soundData.Sample.Length - 1
            If boost_max < soundData.Sample(i) Then
                boost_max = soundData.Sample(i)
            End If
            If boost_min > soundData.Sample(i) Then
                boost_min = soundData.Sample(i)
            End If
        Next
        Dim boost_multiplier As Double
        If (System.Math.Abs(boost_max) > System.Math.Abs(boost_min)) Then
            boost_multiplier = 32767 / System.Math.Abs(boost_max)
        Else
            boost_multiplier = 32768 / System.Math.Abs(boost_min)
        End If
        For i = 0 To soundData.Sample.Length - 1
            soundData.Sample(i) = soundData.Sample(i) * boost_multiplier
        Next
        'Convert the sample back to the two's complement format
        ConvertIntegerToByte()
    End Sub

    Private Sub cmdTremolo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTremolo.Click

        '3. Tremolo
        'Change onto integer dormat for easy multiplication
        ConvertByteToInteger()
        Dim multiplier As Double
        Dim frequency As Short
        Dim wetness As Double
        Dim i As Integer
        frequency = slrFrequency.Value
        wetness = slrTre.Value / 10
        For i = 0 To soundData.Sample.Length - 1
            multiplier = 0.5 + (0.5 * System.Math.Sin(2 * System.Math.PI * frequency * (i / soundData.Sampling_Rate)))
            multiplier = (1 - wetness) + (multiplier * wetness)
            soundData.Sample(i) = soundData.Sample(i) * multiplier
        Next
        'Convert the sample back to the two's complement format
        ConvertIntegerToByte()
    End Sub

End Class
