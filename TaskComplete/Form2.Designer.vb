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
        txtActivity = New TextBox()
        btnSave = New Button()
        btnExport = New Button()
        Button1 = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txtActivity
        ' 
        txtActivity.BackColor = Color.FromArgb(CByte(221), CByte(224), CByte(189))
        txtActivity.BorderStyle = BorderStyle.FixedSingle
        txtActivity.Location = New Point(12, 35)
        txtActivity.Name = "txtActivity"
        txtActivity.Size = New Size(367, 22)
        txtActivity.TabIndex = 2
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(12, 72)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 3
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnExport
        ' 
        btnExport.Location = New Point(304, 72)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(75, 23)
        btnExport.TabIndex = 4
        btnExport.Text = "Report"
        btnExport.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(88, 72)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 6
        Button1.Text = "Exit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 14)
        Label1.TabIndex = 7
        Label1.Text = "New Log"
        ' 
        ' Form2
        ' 
        AcceptButton = btnSave
        AllowDrop = True
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(221), CByte(224), CByte(189))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        CancelButton = Button1
        ClientSize = New Size(406, 106)
        ControlBox = False
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(btnExport)
        Controls.Add(btnSave)
        Controls.Add(txtActivity)
        DoubleBuffered = True
        Font = New Font("Cambria", 9F)
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = " Log Details"
        TransparencyKey = Color.Transparent
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtActivity As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
