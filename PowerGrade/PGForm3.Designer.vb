<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PGForm3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PGForm3))
        Me.dataButton = New System.Windows.Forms.Button()
        Me.namesButton = New System.Windows.Forms.Button()
        Me.instructionLabel = New System.Windows.Forms.Label()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.viewButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.selectStudent1 = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dataButton
        '
        Me.dataButton.BackColor = System.Drawing.Color.Transparent
        Me.dataButton.BackgroundImage = CType(resources.GetObject("dataButton.BackgroundImage"), System.Drawing.Image)
        Me.dataButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.dataButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dataButton.FlatAppearance.BorderSize = 0
        Me.dataButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.dataButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.dataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dataButton.Location = New System.Drawing.Point(403, 726)
        Me.dataButton.Name = "dataButton"
        Me.dataButton.Size = New System.Drawing.Size(175, 93)
        Me.dataButton.TabIndex = 10
        Me.dataButton.UseVisualStyleBackColor = False
        '
        'namesButton
        '
        Me.namesButton.BackColor = System.Drawing.Color.Transparent
        Me.namesButton.BackgroundImage = CType(resources.GetObject("namesButton.BackgroundImage"), System.Drawing.Image)
        Me.namesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.namesButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.namesButton.FlatAppearance.BorderSize = 0
        Me.namesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.namesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.namesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.namesButton.Location = New System.Drawing.Point(201, 726)
        Me.namesButton.Name = "namesButton"
        Me.namesButton.Size = New System.Drawing.Size(175, 93)
        Me.namesButton.TabIndex = 11
        Me.namesButton.UseVisualStyleBackColor = False
        '
        'instructionLabel
        '
        Me.instructionLabel.BackColor = System.Drawing.Color.Transparent
        Me.instructionLabel.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.instructionLabel.Location = New System.Drawing.Point(110, 94)
        Me.instructionLabel.Name = "instructionLabel"
        Me.instructionLabel.Size = New System.Drawing.Size(762, 50)
        Me.instructionLabel.TabIndex = 13
        Me.instructionLabel.Text = "Please click the submit names button to begin the data process. After names are s" &
    "ubmitted, select a student to enter data."
        Me.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'titleLabel
        '
        Me.titleLabel.BackColor = System.Drawing.Color.Transparent
        Me.titleLabel.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.Location = New System.Drawing.Point(304, 34)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(375, 50)
        Me.titleLabel.TabIndex = 2
        Me.titleLabel.Text = "PowerGrade"
        Me.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'viewButton
        '
        Me.viewButton.BackColor = System.Drawing.Color.Transparent
        Me.viewButton.BackgroundImage = CType(resources.GetObject("viewButton.BackgroundImage"), System.Drawing.Image)
        Me.viewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.viewButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.viewButton.FlatAppearance.BorderSize = 0
        Me.viewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.viewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.viewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.viewButton.Location = New System.Drawing.Point(606, 726)
        Me.viewButton.Name = "viewButton"
        Me.viewButton.Size = New System.Drawing.Size(175, 93)
        Me.viewButton.TabIndex = 14
        Me.viewButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(211, 154)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(560, 80)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'selectStudent1
        '
        Me.selectStudent1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectStudent1.FormattingEnabled = True
        Me.selectStudent1.ItemHeight = 19
        Me.selectStudent1.Location = New System.Drawing.Point(353, 240)
        Me.selectStudent1.Name = "selectStudent1"
        Me.selectStudent1.Size = New System.Drawing.Size(276, 479)
        Me.selectStudent1.TabIndex = 15
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(982, 28)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.ToolStripMenuItem2})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(44, 24)
        Me.ToolStripMenuItem1.Text = "&File"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(104, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(181, 26)
        Me.ToolStripMenuItem2.Text = "E&xit"
        '
        'PGForm3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 853)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.selectStudent1)
        Me.Controls.Add(Me.viewButton)
        Me.Controls.Add(Me.instructionLabel)
        Me.Controls.Add(Me.namesButton)
        Me.Controls.Add(Me.dataButton)
        Me.Controls.Add(Me.titleLabel)
        Me.DoubleBuffered = True
        Me.Name = "PGForm3"
        Me.Text = "PowerGrade"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dataButton As Button
    Friend WithEvents namesButton As Button
    Friend WithEvents instructionLabel As Label
    Friend WithEvents titleLabel As Label
    Friend WithEvents viewButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents selectStudent1 As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
End Class
