Imports System.IO

Public Class Form3
    Private logFolderPath As String = Path.Combine(Application.StartupPath, "DiaryLogs")
    Private isDragging As Boolean = False
    Private startPoint As Point
    Private Shared instance As Form3 = Nothing

    ' Singleton pattern to show the form
    Public Shared Sub ShowForm()
        If instance Is Nothing OrElse instance.IsDisposed Then
            instance = New Form3()
            instance.Show()
        Else
            instance.BringToFront()
        End If
    End Sub

    ' Form load event
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnsureLogFolderExists()
        RestoreFormPosition()
        InitializeListView()
        LoadEntriesForCurrentMonth()
    End Sub

    ' Ensure the log folder exists
    Private Sub EnsureLogFolderExists()
        If Not Directory.Exists(logFolderPath) Then
            Directory.CreateDirectory(logFolderPath)
        End If
    End Sub

    ' Restore the form's last position
    Private Sub RestoreFormPosition()
        Dim lastX As Integer = My.Settings.Form3LocationX
        Dim lastY As Integer = My.Settings.Form3LocationY

        If lastX >= 0 AndAlso lastY >= 0 Then
            Me.Location = New Point(lastX, lastY)
        End If
    End Sub

    ' Initialize the ListView
    Private Sub InitializeListView()
        ListView1.View = View.Details
        ListView1.Columns.Add("Date", 85)
        ListView1.Columns.Add("Entry", 325)
    End Sub

    ' Load entries for the current month
    Private Sub LoadEntriesForCurrentMonth()
        ListView1.Items.Clear()
        Dim dailyEntries = GetEntriesForCurrentMonth()

        If dailyEntries.Count = 0 Then
            MessageBox.Show("No entries found for the current month.")
        Else
            For Each kvp In dailyEntries
                Dim dateString As String = kvp.Key.ToString("yyyy-MM-dd")
                Dim entryDetails As String = String.Join(", ", kvp.Value)
                ListView1.Items.Add(New ListViewItem({dateString, entryDetails}))
            Next
        End If
    End Sub

    ' Get entries for the current month
    Private Function GetEntriesForCurrentMonth() As Dictionary(Of DateTime, List(Of String))
        Dim dailyEntries As New Dictionary(Of DateTime, List(Of String))
        Dim logFiles As String() = Directory.GetFiles(logFolderPath, "*.txt")

        For Each logFile As String In logFiles
            Dim entries As String() = File.ReadAllLines(logFile)

            For Each entry As String In entries
                Dim entryDate As DateTime
                Dim activityPart As String = ExtractActivityPart(entry)

                If DateTime.TryParse(entry.Substring(0, 19), entryDate) AndAlso
                   entryDate.Month = DateTime.Now.Month AndAlso
                   entryDate.Year = DateTime.Now.Year Then

                    If Not dailyEntries.ContainsKey(entryDate) Then
                        dailyEntries(entryDate) = New List(Of String)()
                    End If
                    dailyEntries(entryDate).Add(activityPart.Trim())
                End If
            Next
        Next

        Return dailyEntries
    End Function

    ' Extract the activity part from the log entry
    Private Function ExtractActivityPart(entry As String) As String
        Dim activityIndex As Integer = entry.IndexOf("Activity: ")
        If activityIndex >= 0 Then
            Return entry.Substring(activityIndex + 10)
        End If
        Return String.Empty
    End Function

    ' Export log file
    Private Sub ExportLog()
        Dim logFilePath As String = Path.Combine(logFolderPath, "daily_log.txt")

        If File.Exists(logFilePath) Then
            Using saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
                saveFileDialog.Title = "Export Log File"
                saveFileDialog.FileName = $"monthly_log_{DateTime.Now.ToString("yyyy-MM")}.txt"

                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    File.Copy(logFilePath, saveFileDialog.FileName, True)
                    MessageBox.Show($"Log exported to {saveFileDialog.FileName}")
                End If
            End Using
        Else
            MessageBox.Show("No log entries found to export.")
        End If
    End Sub

    ' Clear log file
    Private Sub ClearLog()
        Dim logFilePath As String = Path.Combine(logFolderPath, "daily_log.txt")

        If File.Exists(logFilePath) Then
            Try
                File.Delete(logFilePath)
                MessageBox.Show("Log file has been cleared.")
            Catch ex As IOException
                MessageBox.Show("Error clearing log file: " & ex.Message)
            End Try
        End If
    End Sub

    ' Form closing event
    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.Form3LocationX = Me.Location.X
        My.Settings.Form3LocationY = Me.Location.Y
        My.Settings.Save()
    End Sub

    ' Button click events
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ExportLog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("Are you sure you want to clear the log file?", "Clear Log File", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            ClearLog()
        End If
    End Sub

    ' Form dragging logic
    Private Sub Form3_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            startPoint = New Point(e.X, e.Y)
        End If
    End Sub

    Private Sub Form3_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If isDragging Then
            Dim p As Point = PointToScreen(e.Location)
            Location = New Point(p.X - startPoint.X, p.Y - startPoint.Y)
        End If
    End Sub

    Private Sub Form3_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        isDragging = False
    End Sub
End Class