<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.Text1 = New System.Windows.Forms.Label()
        Me.Text2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Bagi = New System.Windows.Forms.Button()
        Me.Kali = New System.Windows.Forms.Button()
        Me.Kurang = New System.Windows.Forms.Button()
        Me.Tambah = New System.Windows.Forms.Button()
        Me.Text3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.clear = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Text1
        '
        Me.Text1.AutoSize = True
        Me.Text1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1.Location = New System.Drawing.Point(37, 30)
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(147, 25)
        Me.Text1.TabIndex = 0
        Me.Text1.Text = "Angka Pertama"
        '
        'Text2
        '
        Me.Text2.AutoSize = True
        Me.Text2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text2.Location = New System.Drawing.Point(37, 87)
        Me.Text2.Name = "Text2"
        Me.Text2.Size = New System.Drawing.Size(132, 25)
        Me.Text2.TabIndex = 1
        Me.Text2.Text = "Angka Kedua"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(214, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(188, 26)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(214, 90)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(188, 26)
        Me.TextBox2.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Bagi)
        Me.GroupBox1.Controls.Add(Me.Kali)
        Me.GroupBox1.Controls.Add(Me.Kurang)
        Me.GroupBox1.Controls.Add(Me.Tambah)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 157)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 144)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operator"
        '
        'Bagi
        '
        Me.Bagi.Location = New System.Drawing.Point(359, 60)
        Me.Bagi.Name = "Bagi"
        Me.Bagi.Size = New System.Drawing.Size(44, 33)
        Me.Bagi.TabIndex = 3
        Me.Bagi.Text = "/"
        Me.Bagi.UseVisualStyleBackColor = True
        '
        'Kali
        '
        Me.Kali.Location = New System.Drawing.Point(243, 62)
        Me.Kali.Name = "Kali"
        Me.Kali.Size = New System.Drawing.Size(49, 31)
        Me.Kali.TabIndex = 2
        Me.Kali.Text = "X"
        Me.Kali.UseVisualStyleBackColor = True
        '
        'Kurang
        '
        Me.Kurang.Location = New System.Drawing.Point(136, 62)
        Me.Kurang.Name = "Kurang"
        Me.Kurang.Size = New System.Drawing.Size(46, 31)
        Me.Kurang.TabIndex = 1
        Me.Kurang.Text = "-"
        Me.Kurang.UseVisualStyleBackColor = True
        '
        'Tambah
        '
        Me.Tambah.Location = New System.Drawing.Point(26, 60)
        Me.Tambah.Name = "Tambah"
        Me.Tambah.Size = New System.Drawing.Size(49, 31)
        Me.Tambah.TabIndex = 0
        Me.Tambah.Text = "+"
        Me.Tambah.UseVisualStyleBackColor = True
        '
        'Text3
        '
        Me.Text3.AutoSize = True
        Me.Text3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text3.Location = New System.Drawing.Point(37, 341)
        Me.Text3.Name = "Text3"
        Me.Text3.Size = New System.Drawing.Size(174, 25)
        Me.Text3.TabIndex = 5
        Me.Text3.Text = "Hasil dari Operator"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(237, 342)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(188, 26)
        Me.TextBox3.TabIndex = 6
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(401, 441)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(91, 37)
        Me.clear.TabIndex = 7
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(514, 441)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(84, 37)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Keluar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 515)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Text3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Text2)
        Me.Controls.Add(Me.Text1)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Text1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Bagi As Button
    Friend WithEvents Kali As Button
    Friend WithEvents Kurang As Button
    Friend WithEvents Tambah As Button
    Friend WithEvents Text3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents clear As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Text2 As Label
End Class
