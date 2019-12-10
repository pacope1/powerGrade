<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PGForm4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PGForm4))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.studentChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.predButton = New System.Windows.Forms.Button()
        Me.trendButton = New System.Windows.Forms.Button()
        Me.returnButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.lowLabel = New System.Windows.Forms.Label()
        Me.highLabel = New System.Windows.Forms.Label()
        Me.averageLabel = New System.Windows.Forms.Label()
        Me.passLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.studentChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.MenuStrip1.TabIndex = 6
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
        Me.toolStripSeparator2.Size = New System.Drawing.Size(178, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'titleLabel
        '
        Me.titleLabel.BackColor = System.Drawing.Color.Transparent
        Me.titleLabel.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.Location = New System.Drawing.Point(304, 48)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(375, 50)
        Me.titleLabel.TabIndex = 9
        Me.titleLabel.Text = "PowerGrade"
        Me.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(485, 448)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(450, 297)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(529, 629)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Average Score:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'studentChart
        '
        Me.studentChart.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.studentChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight
        Me.studentChart.BorderlineColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.studentChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.studentChart.BorderlineWidth = 4
        ChartArea1.Name = "ChartArea1"
        Me.studentChart.ChartAreas.Add(ChartArea1)
        Legend1.BackColor = System.Drawing.Color.Transparent
        Legend1.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Legend1.TitleFont = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentChart.Legends.Add(Legend1)
        Me.studentChart.Location = New System.Drawing.Point(191, 111)
        Me.studentChart.Name = "studentChart"
        Me.studentChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.studentChart.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(145, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(68, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(51, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(59, Byte), Integer))}
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.studentChart.Series.Add(Series1)
        Me.studentChart.Size = New System.Drawing.Size(600, 314)
        Me.studentChart.TabIndex = 10
        Title1.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Title1.Text = "Student Scores"
        Me.studentChart.Titles.Add(Title1)
        '
        'predButton
        '
        Me.predButton.BackColor = System.Drawing.Color.Transparent
        Me.predButton.BackgroundImage = CType(resources.GetObject("predButton.BackgroundImage"), System.Drawing.Image)
        Me.predButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.predButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.predButton.FlatAppearance.BorderSize = 0
        Me.predButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.predButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.predButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.predButton.Location = New System.Drawing.Point(45, 448)
        Me.predButton.Name = "predButton"
        Me.predButton.Size = New System.Drawing.Size(350, 80)
        Me.predButton.TabIndex = 24
        Me.predButton.UseVisualStyleBackColor = False
        '
        'trendButton
        '
        Me.trendButton.BackColor = System.Drawing.Color.Transparent
        Me.trendButton.BackgroundImage = CType(resources.GetObject("trendButton.BackgroundImage"), System.Drawing.Image)
        Me.trendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.trendButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trendButton.FlatAppearance.BorderSize = 0
        Me.trendButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.trendButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.trendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.trendButton.Location = New System.Drawing.Point(45, 558)
        Me.trendButton.Name = "trendButton"
        Me.trendButton.Size = New System.Drawing.Size(350, 80)
        Me.trendButton.TabIndex = 25
        Me.trendButton.UseVisualStyleBackColor = False
        '
        'returnButton
        '
        Me.returnButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.returnButton.BackColor = System.Drawing.Color.Transparent
        Me.returnButton.BackgroundImage = CType(resources.GetObject("returnButton.BackgroundImage"), System.Drawing.Image)
        Me.returnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.returnButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.returnButton.FlatAppearance.BorderSize = 0
        Me.returnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.returnButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.returnButton.Location = New System.Drawing.Point(45, 668)
        Me.returnButton.Name = "returnButton"
        Me.returnButton.Size = New System.Drawing.Size(350, 80)
        Me.returnButton.TabIndex = 26
        Me.returnButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(525, 530)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 25)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Student Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(529, 596)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 25)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Highest Score:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(529, 563)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 25)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Lowest Score:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(529, 663)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 25)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Pass Probability:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nameLabel
        '
        Me.nameLabel.BackColor = System.Drawing.Color.White
        Me.nameLabel.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(695, 530)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(200, 25)
        Me.nameLabel.TabIndex = 32
        Me.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lowLabel
        '
        Me.lowLabel.BackColor = System.Drawing.Color.White
        Me.lowLabel.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lowLabel.Location = New System.Drawing.Point(695, 563)
        Me.lowLabel.Name = "lowLabel"
        Me.lowLabel.Size = New System.Drawing.Size(200, 25)
        Me.lowLabel.TabIndex = 33
        Me.lowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'highLabel
        '
        Me.highLabel.BackColor = System.Drawing.Color.White
        Me.highLabel.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.highLabel.Location = New System.Drawing.Point(695, 596)
        Me.highLabel.Name = "highLabel"
        Me.highLabel.Size = New System.Drawing.Size(200, 25)
        Me.highLabel.TabIndex = 34
        Me.highLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'averageLabel
        '
        Me.averageLabel.BackColor = System.Drawing.Color.White
        Me.averageLabel.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.averageLabel.Location = New System.Drawing.Point(695, 629)
        Me.averageLabel.Name = "averageLabel"
        Me.averageLabel.Size = New System.Drawing.Size(200, 25)
        Me.averageLabel.TabIndex = 35
        Me.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'passLabel
        '
        Me.passLabel.BackColor = System.Drawing.Color.White
        Me.passLabel.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passLabel.Location = New System.Drawing.Point(695, 663)
        Me.passLabel.Name = "passLabel"
        Me.passLabel.Size = New System.Drawing.Size(200, 25)
        Me.passLabel.TabIndex = 37
        Me.passLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PGForm4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 778)
        Me.Controls.Add(Me.passLabel)
        Me.Controls.Add(Me.averageLabel)
        Me.Controls.Add(Me.highLabel)
        Me.Controls.Add(Me.lowLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.returnButton)
        Me.Controls.Add(Me.trendButton)
        Me.Controls.Add(Me.predButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.studentChart)
        Me.Controls.Add(Me.titleLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Name = "PGForm4"
        Me.Text = "PowerGrade"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.studentChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents titleLabel As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents studentChart As DataVisualization.Charting.Chart
    Friend WithEvents predButton As Button
    Friend WithEvents trendButton As Button
    Friend WithEvents returnButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents lowLabel As Label
    Friend WithEvents highLabel As Label
    Friend WithEvents averageLabel As Label
    Friend WithEvents passLabel As Label
End Class
