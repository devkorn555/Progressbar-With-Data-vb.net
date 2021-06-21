<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ProgressBarX1 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.Guna2ProgressBar1 = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bg1 = New System.ComponentModel.BackgroundWorker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbstafile = New System.Windows.Forms.Label()
        Me.lbpercen1 = New System.Windows.Forms.Label()
        Me.lbpercen2 = New System.Windows.Forms.Label()
        Me.lbpercen3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Path:"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(56, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(682, 23)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(56, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Select"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lbpercen3)
        Me.GroupBox1.Controls.Add(Me.lbpercen2)
        Me.GroupBox1.Controls.Add(Me.lbpercen1)
        Me.GroupBox1.Controls.Add(Me.ProgressBarX1)
        Me.GroupBox1.Controls.Add(Me.Guna2ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(732, 212)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Progressbar"
        '
        'ProgressBarX1
        '
        Me.ProgressBarX1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.ProgressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ProgressBarX1.Location = New System.Drawing.Point(6, 164)
        Me.ProgressBarX1.Name = "ProgressBarX1"
        Me.ProgressBarX1.Size = New System.Drawing.Size(720, 27)
        Me.ProgressBarX1.TabIndex = 2
        Me.ProgressBarX1.Text = "ProgressBarX1"
        '
        'Guna2ProgressBar1
        '
        Me.Guna2ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Guna2ProgressBar1.Location = New System.Drawing.Point(6, 105)
        Me.Guna2ProgressBar1.Name = "Guna2ProgressBar1"
        Me.Guna2ProgressBar1.ShadowDecoration.Parent = Me.Guna2ProgressBar1
        Me.Guna2ProgressBar1.Size = New System.Drawing.Size(720, 30)
        Me.Guna2ProgressBar1.TabIndex = 1
        Me.Guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 50)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(720, 23)
        Me.ProgressBar1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(336, 442)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 40)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Start"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'bg1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 347)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Files:"
        '
        'lbstafile
        '
        Me.lbstafile.Location = New System.Drawing.Point(5, 376)
        Me.lbstafile.Name = "lbstafile"
        Me.lbstafile.Size = New System.Drawing.Size(765, 44)
        Me.lbstafile.TabIndex = 0
        Me.lbstafile.Text = "..."
        '
        'lbpercen1
        '
        Me.lbpercen1.AutoSize = True
        Me.lbpercen1.Location = New System.Drawing.Point(6, 31)
        Me.lbpercen1.Name = "lbpercen1"
        Me.lbpercen1.Size = New System.Drawing.Size(27, 16)
        Me.lbpercen1.TabIndex = 3
        Me.lbpercen1.Text = "0%"
        '
        'lbpercen2
        '
        Me.lbpercen2.AutoSize = True
        Me.lbpercen2.Location = New System.Drawing.Point(6, 86)
        Me.lbpercen2.Name = "lbpercen2"
        Me.lbpercen2.Size = New System.Drawing.Size(27, 16)
        Me.lbpercen2.TabIndex = 3
        Me.lbpercen2.Text = "0%"
        '
        'lbpercen3
        '
        Me.lbpercen3.AutoSize = True
        Me.lbpercen3.Location = New System.Drawing.Point(6, 145)
        Me.lbpercen3.Name = "lbpercen3"
        Me.lbpercen3.Size = New System.Drawing.Size(27, 16)
        Me.lbpercen3.TabIndex = 3
        Me.lbpercen3.Text = "0%"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 531)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbstafile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Guna2ProgressBar1 As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ProgressBarX1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents Button2 As Button
    Friend WithEvents bg1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As Label
    Friend WithEvents lbstafile As Label
    Friend WithEvents lbpercen3 As Label
    Friend WithEvents lbpercen2 As Label
    Friend WithEvents lbpercen1 As Label
End Class
