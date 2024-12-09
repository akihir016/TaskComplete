Imports System.IO

Public Class Form1

    Private WithEvents notifyIcon1 As New NotifyIcon() ' Declare and instantiate NotifyIcon
    Private logFolderPath As String = Path.Combine(Application.StartupPath, "DiaryLogs")

    Private Sub LoadEntries()
        Dim logFilePath As String = Path.Combine(logFolderPath, "daily_log.txt")
        If File.Exists(logFilePath) Then
            Dim entries As String() = File.ReadAllLines(logFilePath)

            ' Update the recent date and log labels
            If entries.Length > 0 Then
                Dim latestEntry = entries.Last()
                Dim entryParts = latestEntry.Split(" - ")
                If entryParts.Length > 1 Then
                    lblRecentDateTime.Text = entryParts(0) ' Date and time
                    lblRecentLog.Text = entryParts(1) ' Activity log

                    ' Adjust the height of lblRecentLog based on the text
                    AdjustLabelHeight(lblRecentLog)
                End If
            Else
                lblRecentDateTime.Text = "No entries found."
                lblRecentLog.Text = ""
            End If
        Else
            lblRecentDateTime.Text = "No entries found."
            lblRecentLog.Text = ""
        End If
    End Sub

    Private Sub AdjustLabelHeight(label As Label)
        ' Measure the size of the text
        Dim textSize As Size = TextRenderer.MeasureText(label.Text, label.Font, label.MaximumSize, TextFormatFlags.WordBreak)

        ' Set the height of the label based on the measured size
        label.Height = textSize.Height
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the form to start at the upper-right corner of the primary screen
        Me.StartPosition = FormStartPosition.Manual ' Allow manual positioning

        ' Calculate the upper-right corner position
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height

        ' Set the location to upper-right corner
        Me.Location = New Point(screenWidth - Me.Width, 0) ' X = screen width - form width, Y = 0

        ' Make the form stay on top of other windows
        Me.TopMost = True

        ' Set up NotifyIcon
        notifyIcon1.Icon = My.Resources.Resource1.TCicon ' Use the icon from Resources.resx
        notifyIcon1.Visible = True
        notifyIcon1.ContextMenuStrip = ContextMenu ' Use the correct context menu name

        ' Set up the Timer
        timer.Interval = 1000 ' Update every second
        timer.Start()

        ' Load entries to display recent logs
        LoadEntries()
        UpdateClock()
        UpdateDate()
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        UpdateClock() ' Update the clock every second
        UpdateDate() ' Update the date every tick (but it will show the same date)
        LoadEntries()
    End Sub

    Private Sub UpdateClock()
        lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt") ' Format the time
    End Sub

    Private Sub UpdateDate()
        lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy") ' Format the date
    End Sub

    ' Handle the MouseDown event to show context menu
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Right Then
            ContextMenu.Show(Me, e.Location) ' Show the context menu
        End If
    End Sub

    ' Handle the Open menu item click
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        ' Show the form when the "Open" menu item is clicked
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub

    ' Handle the Exit menu item click
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        notifyIcon1.Visible = False ' Hide the icon
        Application.Exit() ' Exit the application
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        If Me.WindowState = FormWindowState.Minimized Then
            ' Hide the form when minimized
            Me.Hide()
        End If
    End Sub

    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        ' Prevent the form from closing, just hide it
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub

    Private form2Instance As Form2 = Nothing

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If form2Instance Is Nothing OrElse form2Instance.IsDisposed Then
            form2Instance = New Form2()
            form2Instance.Show()
        Else
            form2Instance.BringToFront()
        End If
    End Sub

    Private Sub lblRecentDateTime_Click(sender As Object, e As EventArgs) Handles lblRecentDateTime.Click

    End Sub

    Private Sub lblHide_Click(sender As Object, e As EventArgs) Handles lblHide.Click
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub
End Class