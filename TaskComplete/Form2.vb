﻿Imports System.IO

Public Class Form2

    Private logFolderPath As String = Path.Combine(Application.StartupPath, "DiaryLogs")

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Check if the log folder exists; if not, create it
        If Not Directory.Exists(logFolderPath) Then
            Directory.CreateDirectory(logFolderPath)
        End If

        ' Restore the last position of Form2
        Dim lastX As Integer = My.Settings.Form2LocationX
        Dim lastY As Integer = My.Settings.Form2LocationY

        ' Set the location only if the values are valid
        If lastX >= 0 AndAlso lastY >= 0 Then
            Me.Location = New Point(lastX, lastY)
        End If
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            ' Save the current position of Form2
            My.Settings.Form2LocationX = Me.Location.X
            My.Settings.Form2LocationY = Me.Location.Y
            My.Settings.Save() ' Save the settings
    End Sub
        Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim activity As String = txtActivity.Text.Trim()
        If Not String.IsNullOrEmpty(activity) Then
            LogEntry(activity)
            txtActivity.Clear()

        Else
            MessageBox.Show("Please enter an activity.")
        End If
    End Sub

    Private Sub LogEntry(activity As String)
        Dim dateStr As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") ' Include time
        Dim entry As String = $"Date: {dateStr} - Activity: {activity}"

        ' Append the entry to the log file in the log folder
        Using writer As New StreamWriter(Path.Combine(logFolderPath, "daily_log.txt"), True)
            writer.WriteLine(entry)
        End Using
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
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

End Class