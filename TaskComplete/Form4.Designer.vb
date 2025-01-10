<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button2 = New Button()
        DateTimePicker1 = New DateTimePicker()
        ButtonShowLogs = New Button()
        ListBoxLogs = New ListBox()
        lblConnectionStatus = New Label()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(218, 231)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 1
        Button2.Text = "Close"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(12, 12)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 2
        ' 
        ' ButtonShowLogs
        ' 
        ButtonShowLogs.Location = New Point(12, 231)
        ButtonShowLogs.Name = "ButtonShowLogs"
        ButtonShowLogs.Size = New Size(75, 23)
        ButtonShowLogs.TabIndex = 3
        ButtonShowLogs.Text = "Retrieve"
        ButtonShowLogs.UseVisualStyleBackColor = True
        ' 
        ' ListBoxLogs
        ' 
        ListBoxLogs.FormattingEnabled = True
        ListBoxLogs.ItemHeight = 15
        ListBoxLogs.Location = New Point(12, 41)
        ListBoxLogs.Name = "ListBoxLogs"
        ListBoxLogs.Size = New Size(281, 169)
        ListBoxLogs.TabIndex = 4
        ' 
        ' lblConnectionStatus
        ' 
        lblConnectionStatus.AutoSize = True
        lblConnectionStatus.Location = New Point(12, 213)
        lblConnectionStatus.Name = "lblConnectionStatus"
        lblConnectionStatus.Size = New Size(114, 15)
        lblConnectionStatus.TabIndex = 7
        lblConnectionStatus.Text = "lblConnectionStatus"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(305, 266)
        ControlBox = False
        Controls.Add(lblConnectionStatus)
        Controls.Add(ListBoxLogs)
        Controls.Add(ButtonShowLogs)
        Controls.Add(DateTimePicker1)
        Controls.Add(Button2)
        Name = "Form4"
        Text = "Log Retrieval"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ButtonShowLogs As Button
    Friend WithEvents ListBoxLogs As ListBox
    Friend WithEvents lblConnectionStatus As Label
End Class
