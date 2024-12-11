<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        ContextMenu = New ContextMenuStrip(components)
        OpenToolStripMenuItem = New ToolStripMenuItem()
        SettingsToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        lblClock = New Label()
        timer = New Timer(components)
        notifyIcon = New NotifyIcon(components)
        lblDate = New Label()
        lblRecentDateTime = New Label()
        Label4 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        lblHide = New Label()
        Label1 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        lblRecentLog = New Label()
        ContextMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' ContextMenu
        ' 
        ContextMenu.BackColor = Color.FromArgb(CByte(221), CByte(224), CByte(189))
        ContextMenu.Items.AddRange(New ToolStripItem() {OpenToolStripMenuItem, SettingsToolStripMenuItem, ExitToolStripMenuItem})
        ContextMenu.Name = "OpenToolStripMenuItem"
        ContextMenu.Size = New Size(117, 70)
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.Size = New Size(116, 22)
        OpenToolStripMenuItem.Text = "Show"
        ' 
        ' SettingsToolStripMenuItem
        ' 
        SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        SettingsToolStripMenuItem.Size = New Size(116, 22)
        SettingsToolStripMenuItem.Text = "Settings"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(116, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' lblClock
        ' 
        lblClock.AutoSize = True
        lblClock.BackColor = Color.Transparent
        lblClock.Font = New Font("Modern No. 20", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblClock.ForeColor = Color.FromArgb(CByte(31), CByte(39), CByte(27))
        lblClock.Location = New Point(42, 23)
        lblClock.Name = "lblClock"
        lblClock.Size = New Size(61, 25)
        lblClock.TabIndex = 1
        lblClock.Text = "12:00"
        ' 
        ' timer
        ' 
        ' 
        ' notifyIcon
        ' 
        notifyIcon.Text = "notifyIcon"
        notifyIcon.Visible = True
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.BackColor = Color.Transparent
        lblDate.Font = New Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDate.ForeColor = Color.FromArgb(CByte(31), CByte(39), CByte(27))
        lblDate.Location = New Point(4, 56)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(70, 17)
        lblDate.TabIndex = 3
        lblDate.Text = "12/05/2024"
        lblDate.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblRecentDateTime
        ' 
        lblRecentDateTime.AutoSize = True
        lblRecentDateTime.BackColor = Color.Transparent
        lblRecentDateTime.Font = New Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRecentDateTime.ForeColor = Color.FromArgb(CByte(31), CByte(39), CByte(27))
        lblRecentDateTime.Location = New Point(2, 99)
        lblRecentDateTime.Name = "lblRecentDateTime"
        lblRecentDateTime.Size = New Size(167, 15)
        lblRecentDateTime.TabIndex = 5
        lblRecentDateTime.Text = "time and date of log"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(31), CByte(39), CByte(27))
        Label4.Location = New Point(2, 83)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 17)
        Label4.TabIndex = 6
        Label4.Text = "Latest Log: "
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Font = New Font("Bodoni MT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ControlText
        Button1.Location = New Point(7, 225)
        Button1.Name = "Button1"
        Button1.Size = New Size(68, 23)
        Button1.TabIndex = 7
        Button1.Text = "New Log"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Bodoni MT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(140, 225)
        Button2.Name = "Button2"
        Button2.Size = New Size(68, 23)
        Button2.TabIndex = 8
        Button2.Text = "Report"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' lblHide
        ' 
        lblHide.AutoSize = True
        lblHide.BackColor = Color.Transparent
        lblHide.Font = New Font("Bauhaus 93", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHide.ForeColor = Color.FromArgb(CByte(31), CByte(39), CByte(27))
        lblHide.Location = New Point(188, 8)
        lblHide.Name = "lblHide"
        lblHide.Size = New Size(15, 21)
        lblHide.TabIndex = 9
        lblHide.Text = "-"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bauhaus 93", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(31), CByte(39), CByte(27))
        Label1.Location = New Point(202, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(16, 16)
        Label1.TabIndex = 10
        Label1.Text = "x"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.Transparent
        FlowLayoutPanel1.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FlowLayoutPanel1.Location = New Point(3, 128)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(204, 86)
        FlowLayoutPanel1.TabIndex = 11
        ' 
        ' lblRecentLog
        ' 
        lblRecentLog.BackColor = Color.Transparent
        lblRecentLog.Font = New Font("MS PGothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRecentLog.ForeColor = Color.FromArgb(CByte(31), CByte(39), CByte(27))
        lblRecentLog.Location = New Point(1, 126)
        lblRecentLog.MaximumSize = New Size(200, 0)
        lblRecentLog.Name = "lblRecentLog"
        lblRecentLog.Size = New Size(200, 93)
        lblRecentLog.TabIndex = 4
        lblRecentLog.Text = "Log note"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(217, 261)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Label1)
        Controls.Add(lblHide)
        Controls.Add(lblRecentDateTime)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(lblRecentLog)
        Controls.Add(lblDate)
        Controls.Add(lblClock)
        DoubleBuffered = True
        Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Task Complete"
        ContextMenu.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ContextMenu As ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblClock As Label
    Friend WithEvents timer As Timer
    Friend WithEvents notifyIcon As NotifyIcon
    Friend WithEvents lblDate As Label
    Friend WithEvents lblRecentDateTime As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblHide As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblRecentLog As Label

End Class
