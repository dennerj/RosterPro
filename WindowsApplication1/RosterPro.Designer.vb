<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RosterPro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RosterPro))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbProcessFrom = New System.Windows.Forms.TextBox()
        Me.tbProcessTo1 = New System.Windows.Forms.TextBox()
        Me.tbStatus = New System.Windows.Forms.Label()
        Me.btnFromDir = New System.Windows.Forms.Button()
        Me.btnToDir1 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnToDir2 = New System.Windows.Forms.Button()
        Me.tbProcessTo2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnToDir3 = New System.Windows.Forms.Button()
        Me.tbProcessTo3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.IntegralHeight = False
        Me.ListBox1.ItemHeight = 19
        Me.ListBox1.Location = New System.Drawing.Point(28, 188)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(1369, 386)
        Me.ListBox1.TabIndex = 2
        '
        'btnRun
        '
        Me.btnRun.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRun.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRun.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRun.Location = New System.Drawing.Point(1309, 19)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(88, 42)
        Me.btnRun.TabIndex = 4
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Process FROM:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Process TO:"
        '
        'tbProcessFrom
        '
        Me.tbProcessFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbProcessFrom.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProcessFrom.Location = New System.Drawing.Point(135, 20)
        Me.tbProcessFrom.Name = "tbProcessFrom"
        Me.tbProcessFrom.Size = New System.Drawing.Size(1099, 27)
        Me.tbProcessFrom.TabIndex = 7
        '
        'tbProcessTo1
        '
        Me.tbProcessTo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbProcessTo1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProcessTo1.Location = New System.Drawing.Point(135, 53)
        Me.tbProcessTo1.Name = "tbProcessTo1"
        Me.tbProcessTo1.Size = New System.Drawing.Size(1099, 27)
        Me.tbProcessTo1.TabIndex = 8
        '
        'tbStatus
        '
        Me.tbStatus.AutoSize = True
        Me.tbStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStatus.ForeColor = System.Drawing.Color.Red
        Me.tbStatus.Location = New System.Drawing.Point(131, 146)
        Me.tbStatus.Name = "tbStatus"
        Me.tbStatus.Size = New System.Drawing.Size(67, 21)
        Me.tbStatus.TabIndex = 9
        Me.tbStatus.Text = "tbStatus"
        Me.tbStatus.Visible = False
        '
        'btnFromDir
        '
        Me.btnFromDir.BackgroundImage = CType(resources.GetObject("btnFromDir.BackgroundImage"), System.Drawing.Image)
        Me.btnFromDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFromDir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnFromDir.FlatAppearance.BorderSize = 0
        Me.btnFromDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFromDir.Location = New System.Drawing.Point(1240, 23)
        Me.btnFromDir.Name = "btnFromDir"
        Me.btnFromDir.Size = New System.Drawing.Size(24, 24)
        Me.btnFromDir.TabIndex = 10
        Me.btnFromDir.UseVisualStyleBackColor = True
        '
        'btnToDir1
        '
        Me.btnToDir1.BackgroundImage = CType(resources.GetObject("btnToDir1.BackgroundImage"), System.Drawing.Image)
        Me.btnToDir1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnToDir1.FlatAppearance.BorderSize = 0
        Me.btnToDir1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToDir1.Location = New System.Drawing.Point(1240, 56)
        Me.btnToDir1.Name = "btnToDir1"
        Me.btnToDir1.Size = New System.Drawing.Size(24, 24)
        Me.btnToDir1.TabIndex = 11
        Me.btnToDir1.UseVisualStyleBackColor = True
        '
        'btnToDir2
        '
        Me.btnToDir2.BackgroundImage = CType(resources.GetObject("btnToDir2.BackgroundImage"), System.Drawing.Image)
        Me.btnToDir2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnToDir2.FlatAppearance.BorderSize = 0
        Me.btnToDir2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToDir2.Location = New System.Drawing.Point(1240, 89)
        Me.btnToDir2.Name = "btnToDir2"
        Me.btnToDir2.Size = New System.Drawing.Size(24, 24)
        Me.btnToDir2.TabIndex = 14
        Me.btnToDir2.UseVisualStyleBackColor = True
        '
        'tbProcessTo2
        '
        Me.tbProcessTo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbProcessTo2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProcessTo2.Location = New System.Drawing.Point(135, 86)
        Me.tbProcessTo2.Name = "tbProcessTo2"
        Me.tbProcessTo2.Size = New System.Drawing.Size(1099, 27)
        Me.tbProcessTo2.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Process TO:"
        '
        'btnToDir3
        '
        Me.btnToDir3.BackgroundImage = CType(resources.GetObject("btnToDir3.BackgroundImage"), System.Drawing.Image)
        Me.btnToDir3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnToDir3.FlatAppearance.BorderSize = 0
        Me.btnToDir3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToDir3.Location = New System.Drawing.Point(1240, 122)
        Me.btnToDir3.Name = "btnToDir3"
        Me.btnToDir3.Size = New System.Drawing.Size(24, 24)
        Me.btnToDir3.TabIndex = 17
        Me.btnToDir3.UseVisualStyleBackColor = True
        '
        'tbProcessTo3
        '
        Me.tbProcessTo3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbProcessTo3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProcessTo3.Location = New System.Drawing.Point(135, 119)
        Me.tbProcessTo3.Name = "tbProcessTo3"
        Me.tbProcessTo3.Size = New System.Drawing.Size(1099, 27)
        Me.tbProcessTo3.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Process TO:"
        '
        'RosterPro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1422, 596)
        Me.Controls.Add(Me.btnToDir3)
        Me.Controls.Add(Me.tbProcessTo3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnToDir2)
        Me.Controls.Add(Me.tbProcessTo2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnToDir1)
        Me.Controls.Add(Me.btnFromDir)
        Me.Controls.Add(Me.tbStatus)
        Me.Controls.Add(Me.tbProcessTo1)
        Me.Controls.Add(Me.tbProcessFrom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.ListBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RosterPro"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Roster Pro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbProcessFrom As System.Windows.Forms.TextBox
    Friend WithEvents tbProcessTo1 As System.Windows.Forms.TextBox
    Friend WithEvents tbStatus As System.Windows.Forms.Label
    Friend WithEvents btnFromDir As System.Windows.Forms.Button
    Friend WithEvents btnToDir1 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnToDir2 As Button
    Friend WithEvents tbProcessTo2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnToDir3 As Button
    Friend WithEvents tbProcessTo3 As TextBox
    Friend WithEvents Label4 As Label
End Class
