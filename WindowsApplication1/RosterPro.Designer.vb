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
        Me.tbProcessTo = New System.Windows.Forms.TextBox()
        Me.tbStatus = New System.Windows.Forms.Label()
        Me.btnFromDir = New System.Windows.Forms.Button()
        Me.btnToDir = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.IntegralHeight = False
        Me.ListBox1.ItemHeight = 21
        Me.ListBox1.Location = New System.Drawing.Point(21, 109)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(472, 36)
        Me.ListBox1.TabIndex = 2
        '
        'btnRun
        '
        Me.btnRun.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRun.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRun.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRun.Location = New System.Drawing.Point(543, 86)
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
        Me.tbProcessFrom.Size = New System.Drawing.Size(496, 27)
        Me.tbProcessFrom.TabIndex = 7
        '
        'tbProcessTo
        '
        Me.tbProcessTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbProcessTo.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProcessTo.Location = New System.Drawing.Point(135, 53)
        Me.tbProcessTo.Name = "tbProcessTo"
        Me.tbProcessTo.Size = New System.Drawing.Size(496, 27)
        Me.tbProcessTo.TabIndex = 8
        '
        'tbStatus
        '
        Me.tbStatus.AutoSize = True
        Me.tbStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStatus.ForeColor = System.Drawing.Color.Red
        Me.tbStatus.Location = New System.Drawing.Point(131, 83)
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
        Me.btnFromDir.Location = New System.Drawing.Point(637, 19)
        Me.btnFromDir.Name = "btnFromDir"
        Me.btnFromDir.Size = New System.Drawing.Size(24, 24)
        Me.btnFromDir.TabIndex = 10
        Me.btnFromDir.UseVisualStyleBackColor = True
        '
        'btnToDir
        '
        Me.btnToDir.BackgroundImage = CType(resources.GetObject("btnToDir.BackgroundImage"), System.Drawing.Image)
        Me.btnToDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnToDir.FlatAppearance.BorderSize = 0
        Me.btnToDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToDir.Location = New System.Drawing.Point(637, 52)
        Me.btnToDir.Name = "btnToDir"
        Me.btnToDir.Size = New System.Drawing.Size(24, 24)
        Me.btnToDir.TabIndex = 11
        Me.btnToDir.UseVisualStyleBackColor = True
        '
        'RosterPro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(694, 156)
        Me.Controls.Add(Me.btnToDir)
        Me.Controls.Add(Me.btnFromDir)
        Me.Controls.Add(Me.tbStatus)
        Me.Controls.Add(Me.tbProcessTo)
        Me.Controls.Add(Me.tbProcessFrom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RosterPro"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
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
    Friend WithEvents tbProcessTo As System.Windows.Forms.TextBox
    Friend WithEvents tbStatus As System.Windows.Forms.Label
    Friend WithEvents btnFromDir As System.Windows.Forms.Button
    Friend WithEvents btnToDir As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog

End Class
