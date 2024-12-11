Imports System.IO

Public Class Form3
    Private logFolderPath As String = Path.Combine(Application.StartupPath, "DiaryLogs")
    Private isDragging As Boolean = False
    Private startPoint As Point
    Private Shared instance As Form3 = Nothing
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


    Public Shared Sub ShowForm()
        If instance Is Nothing OrElse instance.IsDisposed Then
            instance = New Form3()
            instance.Show()
        Else
            instance.BringToFront()
        End If
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Check if the log folder exists; if not, create it
        If Not Directory.Exists(logFolderPath) Then
            Directory.CreateDirectory(logFolderPath)
        End If

        ' Restore the last position of Form2
        Dim lastX As Integer = My.Settings.Form3LocationX
        Dim lastY As Integer = My.Settings.Form3LocationY

        ' Set the location only if the values are valid
        If lastX >= 0 AndAlso lastY >= 0 Then
            Me.Location = New Point(lastX, lastY)
        End If
        ' Set up the ListView
        ListView1.View = View.Details
        ListView1.Columns.Add("Date", 85)
        ListView1.Columns.Add("Entry", 325)

        ' Load the entries for the current month
        LoadEntriesForCurrentMonth()
    End Sub
    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Save the current position of Form2
        My.Settings.Form3LocationX = Me.Location.X
        My.Settings.Form3LocationY = Me.Location.Y
        My.Settings.Save() ' Save the settings
    End Sub
    Private Sub LoadEntriesForCurrentMonth()
        Dim currentMonth As Integer = DateTime.Now.Month
        Dim currentYear As Integer = DateTime.Now.Year

        ' Clear existing items
        ListView1.Items.Clear()

        ' Get all text files in the log folder
        Dim logFiles As String() = Directory.GetFiles(logFolderPath, "*.txt")
        ' MessageBox.Show("Number of log files found: " & logFiles.Length)

        ' Group entries by day
        Dim dailyEntries As New Dictionary(Of DateTime, List(Of String))

        For Each logFile As String In logFiles
            Dim entries As String() = File.ReadAllLines(logFile)

            For Each entry As String In entries
                ' Split the entry to extract the date and activity
                Dim datePart As String = entry.Substring(entry.IndexOf("Date: ") + 6, 19) ' Extract the date part
                Dim activityPart As String = entry.Substring(entry.IndexOf("Activity: ") + 10) ' Extract the activity part

                Dim entryDate As DateTime
                If DateTime.TryParse(datePart, entryDate) Then
                    If entryDate.Month = currentMonth AndAlso entryDate.Year = currentYear Then
                        If Not dailyEntries.ContainsKey(entryDate) Then
                            dailyEntries(entryDate) = New List(Of String)()
                        End If
                        dailyEntries(entryDate).Add(activityPart.Trim())
                    End If
                End If
            Next
        Next

        ' Add entries to the ListView
        For Each kvp In dailyEntries
            Dim dateString As String = kvp.Key.ToString("yyyy-MM-dd")
            Dim entryDetails As String = String.Join(", ", kvp.Value)
            Dim listViewItem As New ListViewItem(dateString)
            listViewItem.SubItems.Add(entryDetails)
            ListView1.Items.Add(listViewItem)
        Next

        ' Check if any entries were added
        If ListView1.Items.Count = 0 Then
            MessageBox.Show("No entries found for the current month.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ExportLog()
    End Sub
    Private Sub ExportLog()
        Dim logFilePath As String = Path.Combine(logFolderPath, "daily_log.txt")
        If File.Exists(logFilePath) Then
            ' Use SaveFileDialog to allow the user to choose the export location
            Using saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
                saveFileDialog.Title = "Export Log File"
                saveFileDialog.FileName = $"monthly_log_{DateTime.Now.ToString("yyyy-MM")}.txt"

                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    ' Copy the log file to the selected location
                    File.Copy(logFilePath, saveFileDialog.FileName, True)
                    MessageBox.Show($"Log exported to {saveFileDialog.FileName}")
                End If
            End Using
        Else
            MessageBox.Show("No log entries found to export.")
        End If
    End Sub
    Private Sub ClearLog()
        Dim logFilePath As String = Path.Combine(logFolderPath, "daily_log.txt")
        If File.Exists(logFilePath) Then
            Try
                File.Delete(logFilePath)
            Catch ex As IOException
                MessageBox.Show("Error clearing log file: " & ex.Message)
            End Try
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("Are you sure you want to clear the log file?", "Clear Log File", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            ClearLog()
            MessageBox.Show("Log file has been cleared.")
            Me.Close()
        End If
    End Sub
End Class