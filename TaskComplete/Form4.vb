Imports System.IO

Public Class Form4  ' Class name is Form4
    Private logs As New List(Of LogEntry)
    Private logFolderPath As String = Path.Combine(Application.StartupPath, "DiaryLogs")
    Private logFilePath As String = Path.Combine(logFolderPath, "daily_log.txt")

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckLogFile()
        LoadLogs()
    End Sub

    Private Sub CheckLogFile()
        ' Check if the log file exists
        If File.Exists(logFilePath) Then
            lblConnectionStatus.Text = "Log File Found"  ' Update label to show connection status
        Else
            lblConnectionStatus.Text = "Log file not found"  ' Update label if log file is missing
        End If
    End Sub

    Private Sub LoadLogs()
        ' Check if the log file exists
        If Not File.Exists(logFilePath) Then
            lblConnectionStatus.Text = "Log file not found"  ' Update label if log file is missing
            Return  ' Exit if the log file does not exist
        End If

        lblConnectionStatus.Text = "Log File Found"  ' Update label to show connection status

        Dim lines() As String = File.ReadAllLines(logFilePath)

        For Each line In lines
            Dim parts() As String = line.Split(" - ")
            If parts.Length = 2 Then
                Dim datePart As String = parts(0).Trim()  ' No need to replace "Date: "
                Dim activityPart As String = parts(1).Replace("Activity: ", "").Trim()  ' Remove "Activity: " prefix
                Dim logDate As DateTime

                ' Try to parse the date part into a DateTime object
                If DateTime.TryParse(datePart, logDate) Then
                    logs.Add(New LogEntry(logDate, activityPart))
                End If
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ButtonShowLogs_Click(sender As Object, e As EventArgs) Handles ButtonShowLogs.Click
        ShowLogsForSelectedDate()
    End Sub

    Private Sub ShowLogsForSelectedDate()
        ListBoxLogs.Items.Clear()
        Dim selectedDate As DateTime = DateTimePicker1.Value.Date
        For Each log In logs
            If log.LogDate.Date = selectedDate Then
                ListBoxLogs.Items.Add(log.LogDate.ToString("MM/dd/yyyy") & " - " & log.Activity)
            End If
        Next
    End Sub

    Private Class LogEntry
        Public Property LogDate As DateTime  ' Change to DateTime type
        Public Property Activity As String

        Public Sub New(logDate As DateTime, activity As String)
            Me.LogDate = logDate
            Me.Activity = activity
        End Sub
    End Class
End Class
