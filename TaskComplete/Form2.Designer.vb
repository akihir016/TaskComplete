<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Label1 = New Label()
        txtActivity = New TextBox()
        btnSave = New Button()
        btnExport = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 19)
        Label1.TabIndex = 1
        Label1.Text = "Log Details"
        ' 
        ' txtActivity
        ' 
        txtActivity.BorderStyle = BorderStyle.FixedSingle
        txtActivity.Location = New Point(33, 47)
        txtActivity.Name = "txtActivity"
        txtActivity.Size = New Size(346, 22)
        txtActivity.TabIndex = 2
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(12, 105)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 3
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnExport
        ' 
        btnExport.Location = New Point(304, 105)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(75, 23)
        btnExport.TabIndex = 4
        btnExport.Text = "Report"
        btnExport.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(93, 105)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 6
        Button1.Text = "Exit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AcceptButton = btnSave
        AllowDrop = True
        AutoScaleMode = AutoScaleMode.None
        BackColor = SystemColors.Control
        CancelButton = Button1
        ClientSize = New Size(400, 150)
        ControlBox = False
        Controls.Add(Button1)
        Controls.Add(btnExport)
        Controls.Add(btnSave)
        Controls.Add(txtActivity)
        Controls.Add(Label1)
        Font = New Font("Cambria", 9F)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        HelpButton = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        IsMdiContainer = True
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Activity Log 9000"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtActivity As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents Button1 As Button
End Class
