﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        NewLogToolStripMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        DTRDateGeneratorToolStripMenuItem = New ToolStripMenuItem()
        SettingsToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        SettingToolStripMenuItem = New ToolStripMenuItem()
        ResetFormToolStripMenuItem = New ToolStripMenuItem()
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
        lblRecentLog = New Label()
        btnRecord = New Button()
        GroupBox1 = New GroupBox()
        ContextMenu.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ContextMenu
        ' 
        ContextMenu.BackColor = Color.FromArgb(CByte(221), CByte(224), CByte(189))
        ContextMenu.ImageScalingSize = New Size(20, 20)
        ContextMenu.Items.AddRange(New ToolStripItem() {NewLogToolStripMenuItem, OpenToolStripMenuItem, DTRDateGeneratorToolStripMenuItem, SettingsToolStripMenuItem, ExitToolStripMenuItem, SettingToolStripMenuItem})
        ContextMenu.Name = "OpenToolStripMenuItem"
        ContextMenu.Size = New Size(185, 136)
        ' 
        ' NewLogToolStripMenuItem
        ' 
        NewLogToolStripMenuItem.Name = "NewLogToolStripMenuItem"
        NewLogToolStripMenuItem.Size = New Size(184, 22)
        NewLogToolStripMenuItem.Text = "New Log"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.Size = New Size(184, 22)
        OpenToolStripMenuItem.Text = "Show Task Complete"
        ' 
        ' DTRDateGeneratorToolStripMenuItem
        ' 
        DTRDateGeneratorToolStripMenuItem.Name = "DTRDateGeneratorToolStripMenuItem"
        DTRDateGeneratorToolStripMenuItem.Size = New Size(184, 22)
        DTRDateGeneratorToolStripMenuItem.Text = "DTR Date Generator"
        ' 
        ' SettingsToolStripMenuItem
        ' 
        SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        SettingsToolStripMenuItem.Size = New Size(184, 22)
        SettingsToolStripMenuItem.Text = "Log Retrieval"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(184, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' SettingToolStripMenuItem
        ' 
        SettingToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ResetFormToolStripMenuItem})
        SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        SettingToolStripMenuItem.Size = New Size(184, 22)
        SettingToolStripMenuItem.Text = "Setting"
        ' 
        ' ResetFormToolStripMenuItem
        ' 
        ResetFormToolStripMenuItem.Name = "ResetFormToolStripMenuItem"
        ResetFormToolStripMenuItem.Size = New Size(133, 22)
        ResetFormToolStripMenuItem.Text = "Reset Form"
        ' 
        ' lblClock
        ' 
        lblClock.AutoSize = True
        lblClock.BackColor = Color.Transparent
        lblClock.Font = New Font("Modern No. 20", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblClock.ForeColor = Color.FromArgb(CByte(31), CByte(39), CByte(27))
        lblClock.Location = New Point(42, 33)
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
        lblDate.Location = New Point(17, 58)
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
        lblRecentDateTime.Location = New Point(6, 106)
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
        Label4.Location = New Point(6, 89)
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
        Button1.Location = New Point(6, 223)
        Button1.Name = "Button1"
        Button1.Size = New Size(68, 23)
        Button1.TabIndex = 7
        Button1.Text = "New Log"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Bodoni MT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(138, 223)
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
        lblHide.Location = New Point(178, 8)
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
        Label1.Location = New Point(196, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(16, 16)
        Label1.TabIndex = 10
        Label1.Text = "x"
        ' 
        ' lblRecentLog
        ' 
        lblRecentLog.BackColor = Color.Transparent
        lblRecentLog.Font = New Font("MS PGothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRecentLog.ForeColor = Color.FromArgb(CByte(31), CByte(39), CByte(27))
        lblRecentLog.Location = New Point(6, 121)
        lblRecentLog.MaximumSize = New Size(200, 0)
        lblRecentLog.Name = "lblRecentLog"
        lblRecentLog.Size = New Size(200, 93)
        lblRecentLog.TabIndex = 4
        lblRecentLog.Text = "Log note"
        ' 
        ' btnRecord
        ' 
        btnRecord.Location = New Point(88, 217)
        btnRecord.Name = "btnRecord"
        btnRecord.Size = New Size(35, 31)
        btnRecord.TabIndex = 12
        btnRecord.Text = "R"
        btnRecord.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), Image)
        GroupBox1.BackgroundImageLayout = ImageLayout.Stretch
        GroupBox1.Controls.Add(lblClock)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(btnRecord)
        GroupBox1.Controls.Add(lblDate)
        GroupBox1.Controls.Add(lblRecentDateTime)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(lblRecentLog)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(lblHide)
        GroupBox1.Location = New Point(1, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(218, 279)
        GroupBox1.TabIndex = 13
        GroupBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(217, 261)
        Controls.Add(GroupBox1)
        DoubleBuffered = True
        Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Task Complete"
        ContextMenu.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
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
    Friend WithEvents lblRecentLog As Label
    Friend WithEvents btnRecord As Button
    Friend WithEvents NewLogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DTRDateGeneratorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox

End Class
