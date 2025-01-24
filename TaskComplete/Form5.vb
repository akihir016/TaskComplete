Imports System
Imports System.Windows.Forms

Public Class Form5
    Private Sub btnGenerateDates_Click(sender As Object, e As EventArgs) Handles btnGenerateDates.Click
        CreateWeekdayQuickParts()
    End Sub

    Private Sub CreateWeekdayQuickParts()
        Dim currentYear As Integer
        Dim startDate As Date
        Dim endDate As Date
        Dim currentDate As Date
        Dim quickPartName As String
        Dim startMonth As Integer
        Dim startDay As Integer
        Dim endDay As Integer

        ' Get the current year
        currentYear = DateTime.Now.Year

        ' Prompt user for start month (numeric) and day
        startMonth = CInt(InputBox("Enter the start month (1-12):"))
        startDay = CInt(InputBox("Enter the start day (1-31):"))

        ' Construct the start date
        Try
            startDate = New Date(currentYear, startMonth, startDay)
        Catch ex As Exception
            MessageBox.Show("Invalid start date input. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        ' Prompt user for end day
        endDay = CInt(InputBox("Enter the end day (1-31):"))

        ' Construct the end date
        Try
            endDate = New Date(currentYear, startMonth, endDay)
        Catch ex As Exception
            MessageBox.Show("Invalid end date input. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        ' Ensure end date is after start date
        If endDate < startDate Then
            MessageBox.Show("End date must be after start date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        ' Loop through the date range
        lstDates.Items.Clear() ' Clear the ListBox before adding new dates
        currentDate = startDate
        Do While currentDate <= endDate
            ' Check if it's a weekday (Monday to Friday)
            If currentDate.DayOfWeek >= DayOfWeek.Monday AndAlso currentDate.DayOfWeek <= DayOfWeek.Friday Then
                quickPartName = currentDate.ToString("MMMM dd")
                lstDates.Items.Add(quickPartName) ' Add the date to the ListBox
            End If
            currentDate = currentDate.AddDays(1)
        Loop

        MessageBox.Show("Weekdays generated for the specified date range.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub lstDates_KeyDown(sender As Object, e As KeyEventArgs) Handles lstDates.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.C Then
            CopyDatesToClipboard()
        End If
    End Sub

    Private Sub CopyDatesToClipboard()
        If lstDates.Items.Count > 0 Then
            Dim clipboardText As String = String.Join(Environment.NewLine, lstDates.Items.Cast(Of String)())
            Clipboard.SetText(clipboardText)
            MessageBox.Show("Dates copied to clipboard.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnCopyAll_Click(sender As Object, e As EventArgs) Handles btnCopyAll.Click
        CopyAllDatesToClipboard()
    End Sub

    Private Sub CopyAllDatesToClipboard()
        If lstDates.Items.Count > 0 Then
            Dim allDates As String = String.Join(Environment.NewLine, lstDates.Items.Cast(Of String)())
            Clipboard.SetText(allDates)
            MessageBox.Show("All dates copied to clipboard.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No dates to copy.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class
