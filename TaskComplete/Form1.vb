Imports System.IO

Public Class Form1
    ' Declare and instantiate NotifyIcon
    Private WithEvents notifyIcon1 As New NotifyIcon()
    Private logFolderPath As String = Path.Combine(Application.StartupPath, "DiaryLogs")
    Private isDragging As Boolean = False
    Private startPoint As Point
    Private currentMonth As Integer
    Private audioRecorder As AudioRecorder
    Private scaler As New FormScaler()
    Private form2Instance As Form2 = Nothing

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblRecentLog.Margin = New Padding(0, 0, 0, 0) ' Set margin for lblRecentLog
    End Sub

    ' Event Handlers for Mouse Actions
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            startPoint = New Point(e.X, e.Y)
        ElseIf e.Button = MouseButtons.Right Then
            ContextMenu.Show(Me, e.Location) ' Show the context menu
        End If
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If isDragging Then
            Dim p As Point = PointToScreen(e.Location)
            Location = New Point(p.X - startPoint.X, p.Y - startPoint.Y)
        End If
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        isDragging = False
    End Sub

    ' Form Load Event
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the form to start at the upper-right corner of the primary screen
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(Screen.PrimaryScreen.Bounds.Width - Me.Width, 0)
        Me.TopMost = True

        ' Initialize current month
        currentMonth = DateTime.Now.Month

        ' Set up NotifyIcon
        notifyIcon1.Icon = My.Resources.Resource1.TCicon
        notifyIcon1.Visible = True
        notifyIcon1.ContextMenuStrip = ContextMenu
        AddHandler notifyIcon1.DoubleClick, AddressOf NotifyIcon1_DoubleClick

        ' Set up the Timer
        timer.Interval = 1000 ' Update every second
        timer.Start()

        ' Initialize displays
        LoadEntries()
        UpdateClock()
        UpdateDate()

        ' Initialize Audio Recorder and scale the form
        audioRecorder = New AudioRecorder()
        scaler.ScaleForm(Me)
    End Sub

    ' Timer Tick Event
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        ' Update the clock and date every second
        UpdateClock()
        UpdateDate()

        ' Check for new entries only every 5 seconds (to reduce file I/O)
        Static lastEntryCheckTime As DateTime = DateTime.MinValue
        If (DateTime.Now - lastEntryCheckTime).TotalSeconds >= 5 Then
            LoadEntries()
            lastEntryCheckTime = DateTime.Now
        End If

        ' Check for month change
        Static currentMonth As Integer = DateTime.Now.Month
        Dim newMonth As Integer = DateTime.Now.Month
        If newMonth <> currentMonth Then
            currentMonth = newMonth
            ShowMonthChangeNotification()
        End If
    End Sub

    ' Helper Methods
    Private Sub UpdateClock()
        lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt") ' Update the clock label
    End Sub

    Private Sub UpdateDate()
        lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy") ' Update the date label
    End Sub
    Private Sub LoadEntries()
        Dim logFilePath As String = Path.Combine(logFolderPath, "daily_log.txt")
        If File.Exists(logFilePath) Then
            Try
                Dim entries As String() = File.ReadAllLines(logFilePath)

                ' Update the recent date and log labels
                If entries.Length > 0 Then
                    Dim latestEntry = entries.Last()
                    Dim entryParts = latestEntry.Split(" - ")
                    If entryParts.Length > 1 Then
                        lblRecentDateTime.Text = entryParts(0) ' Date and time
                        lblRecentLog.Text = entryParts(1) ' Activity log
                        AdjustLabelHeight(lblRecentLog) ' Adjust label height
                    End If
                Else
                    lblRecentDateTime.Text = "No entries found."
                    lblRecentLog.Text = ""
                End If
            Catch ex As Exception
                MessageBox.Show("Error loading log entries: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            lblRecentDateTime.Text = "No entries found."
            lblRecentLog.Text = ""
        End If
    End Sub

    Private Sub AdjustLabelHeight(label As Label)
        ' Measure the size of the text and adjust the label height
        Dim textSize As Size = TextRenderer.MeasureText(label.Text, label.Font, label.MaximumSize, TextFormatFlags.WordBreak)
        label.Height = textSize.Height
    End Sub

    Private Sub ShowMonthChangeNotification()
        ' Show a notification when the month changes
        notifyIcon1.BalloonTipTitle = "Month Change Notification"
        notifyIcon1.BalloonTipText = "The month has changed! Don't forget to clear and export your logs."
        notifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        notifyIcon1.ShowBalloonTip(3000) ' Show for 3 seconds
    End Sub

    ' NotifyIcon Double-Click Event
    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs)
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        BringToFront()
    End Sub

    ' Context Menu Event Handlers
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        notifyIcon1.Visible = False
        Application.Exit()
    End Sub

    ' Form Resize and Closing Events
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
        End If
    End Sub

    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub

    ' Button Event Handlers
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If form2Instance Is Nothing OrElse form2Instance.IsDisposed Then
            form2Instance = New Form2()
            form2Instance.Show()
        Else
            form2Instance.BringToFront()
        End If
    End Sub

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        If audioRecorder IsNot Nothing Then
            If btnRecord.Text = "R" Then
                audioRecorder.StartRecording()
                btnRecord.Text = "S"
            Else
                audioRecorder.StopRecording()
                btnRecord.Text = "R"
            End If
        End If
    End Sub

    Private Sub lblHide_Click(sender As Object, e As EventArgs) Handles lblHide.Click
        Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Application.Exit()
    End Sub

    ' Menu Item Event Handlers
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub NewLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewLogToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub DTRDateGeneratorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DTRDateGeneratorToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub ResetFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetFormToolStripMenuItem.Click
        Dim form2 As Form2 = Application.OpenForms.OfType(Of Form2)().FirstOrDefault()
        If form2 IsNot Nothing Then
            form2.ResetLocationAndCenter()
        Else
            MessageBox.Show("Form2 is not open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class