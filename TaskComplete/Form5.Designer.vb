<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        btnGenerateDates = New Button()
        lstDates = New ListBox()
        btnCopyAll = New Button()
        SuspendLayout()
        ' 
        ' btnGenerateDates
        ' 
        btnGenerateDates.Location = New Point(12, 12)
        btnGenerateDates.Name = "btnGenerateDates"
        btnGenerateDates.Size = New Size(68, 22)
        btnGenerateDates.TabIndex = 0
        btnGenerateDates.Text = "Generate"
        btnGenerateDates.UseVisualStyleBackColor = True
        ' 
        ' lstDates
        ' 
        lstDates.FormattingEnabled = True
        lstDates.ItemHeight = 15
        lstDates.Location = New Point(12, 40)
        lstDates.Name = "lstDates"
        lstDates.Size = New Size(201, 259)
        lstDates.TabIndex = 1
        ' 
        ' btnCopyAll
        ' 
        btnCopyAll.Location = New Point(143, 9)
        btnCopyAll.Name = "btnCopyAll"
        btnCopyAll.Size = New Size(70, 25)
        btnCopyAll.TabIndex = 2
        btnCopyAll.Text = "Copy All"
        btnCopyAll.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(229, 313)
        Controls.Add(btnCopyAll)
        Controls.Add(lstDates)
        Controls.Add(btnGenerateDates)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form5"
        Text = "Date Generator"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnGenerateDates As Button
    Friend WithEvents lstDates As ListBox
    Friend WithEvents btnCopyAll As Button
End Class
