Imports System.Windows.Forms
Imports System.Drawing

Public Class FormScaler
    ' Change reference width and height to 720p
    Private Const ReferenceWidth As Integer = 1920
    Private Const ReferenceHeight As Integer = 1080

    Public Sub ScaleForm(form As Form)
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height

        Dim scaleFactorWidth As Double = screenWidth / ReferenceWidth
        Dim scaleFactorHeight As Double = screenHeight / ReferenceHeight

        ' Use the smaller scale factor to maintain aspect ratio
        Dim scaleFactor As Double = Math.Min(scaleFactorWidth, scaleFactorHeight)

        ' Scale the form
        form.Width = CInt(form.Width * scaleFactor)
        form.Height = CInt(form.Height * scaleFactor)

        ' Scale and reposition each control
        For Each ctrl As Control In form.Controls
            ctrl.Width = CInt(ctrl.Width * scaleFactor)
            ctrl.Height = CInt(ctrl.Height * scaleFactor)
            ctrl.Left = CInt(ctrl.Left * scaleFactor)
            ctrl.Top = CInt(ctrl.Top * scaleFactor)

            ' Check if the control has a Font property
            If TypeOf ctrl Is Control Then
                ctrl.Font = New Font(ctrl.Font.FontFamily, ctrl.Font.Size * scaleFactor)
            End If
        Next
    End Sub
End Class