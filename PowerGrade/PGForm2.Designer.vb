<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PGForm2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PGForm2))
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.instructionLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.studentBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dataBox = New System.Windows.Forms.TextBox()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'titleLabel
        '
        Me.titleLabel.BackColor = System.Drawing.Color.Transparent
        Me.titleLabel.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.Location = New System.Drawing.Point(304, 33)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(375, 72)
        Me.titleLabel.TabIndex = 1
        Me.titleLabel.Text = "PowerGrade"
        Me.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'instructionLabel
        '
        Me.instructionLabel.BackColor = System.Drawing.Color.Transparent
        Me.instructionLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.instructionLabel.Location = New System.Drawing.Point(116, 174)
        Me.instructionLabel.Name = "instructionLabel"
        Me.instructionLabel.Size = New System.Drawing.Size(751, 59)
        Me.instructionLabel.TabIndex = 2
        Me.instructionLabel.Text = "Please input the number of students in your classroom, and the total number of da" &
    "ta points you would like to examine for each student."
        Me.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(304, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(375, 54)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Instructions"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'studentBox
        '
        Me.studentBox.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentBox.Location = New System.Drawing.Point(329, 313)
        Me.studentBox.Name = "studentBox"
        Me.studentBox.Size = New System.Drawing.Size(325, 41)
        Me.studentBox.TabIndex = 5
        Me.studentBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(304, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(375, 54)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "# of Students"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(304, 366)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(375, 54)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "# of Data Points"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dataBox
        '
        Me.dataBox.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataBox.Location = New System.Drawing.Point(329, 423)
        Me.dataBox.Name = "dataBox"
        Me.dataBox.Size = New System.Drawing.Size(325, 41)
        Me.dataBox.TabIndex = 7
        Me.dataBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'submitButton
        '
        Me.submitButton.BackColor = System.Drawing.Color.Transparent
        Me.submitButton.BackgroundImage = CType(resources.GetObject("submitButton.BackgroundImage"), System.Drawing.Image)
        Me.submitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.submitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.submitButton.FlatAppearance.BorderSize = 0
        Me.submitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.submitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.submitButton.Location = New System.Drawing.Point(531, 509)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(225, 120)
        Me.submitButton.TabIndex = 9
        Me.submitButton.UseVisualStyleBackColor = False
        '
        'clearButton
        '
        Me.clearButton.BackColor = System.Drawing.Color.Transparent
        Me.clearButton.BackgroundImage = CType(resources.GetObject("clearButton.BackgroundImage"), System.Drawing.Image)
        Me.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.clearButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearButton.FlatAppearance.BorderSize = 0
        Me.clearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.clearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearButton.Location = New System.Drawing.Point(226, 509)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(225, 120)
        Me.clearButton.TabIndex = 10
        Me.clearButton.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(982, 28)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(104, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(107, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'PGForm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 653)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dataBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.studentBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.instructionLabel)
        Me.Controls.Add(Me.titleLabel)
        Me.DoubleBuffered = True
        Me.Name = "PGForm2"
        Me.Text = "PowerGrade"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titleLabel As Label
    Friend WithEvents instructionLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents studentBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dataBox As TextBox
    Friend WithEvents submitButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
