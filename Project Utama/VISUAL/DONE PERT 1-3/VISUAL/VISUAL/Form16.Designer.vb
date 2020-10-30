<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form16
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNilaiAbsen = New System.Windows.Forms.TextBox()
        Me.txtNilaiTugas = New System.Windows.Forms.TextBox()
        Me.txtNilaiUts = New System.Windows.Forms.TextBox()
        Me.txtNilaiUas = New System.Windows.Forms.TextBox()
        Me.txtHasilTugas = New System.Windows.Forms.TextBox()
        Me.txtHasilAbsen = New System.Windows.Forms.TextBox()
        Me.txtHasilUts = New System.Windows.Forms.TextBox()
        Me.txtHasilUas = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmdHitung = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTotalNilai = New System.Windows.Forms.TextBox()
        Me.txtTotalGrade = New System.Windows.Forms.TextBox()
        Me.TxtKet = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(170, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(462, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menghitung Nilai Mahasiswa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nilai Absen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nilai Tugas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nilai UTS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(58, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nilai UAS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(411, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "10%"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(411, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "20%"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(411, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 23)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "30%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(411, 222)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 23)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "40%"
        '
        'txtNilaiAbsen
        '
        Me.txtNilaiAbsen.Location = New System.Drawing.Point(194, 77)
        Me.txtNilaiAbsen.Name = "txtNilaiAbsen"
        Me.txtNilaiAbsen.Size = New System.Drawing.Size(115, 26)
        Me.txtNilaiAbsen.TabIndex = 9
        '
        'txtNilaiTugas
        '
        Me.txtNilaiTugas.Location = New System.Drawing.Point(194, 128)
        Me.txtNilaiTugas.Name = "txtNilaiTugas"
        Me.txtNilaiTugas.Size = New System.Drawing.Size(115, 26)
        Me.txtNilaiTugas.TabIndex = 10
        '
        'txtNilaiUts
        '
        Me.txtNilaiUts.Location = New System.Drawing.Point(194, 176)
        Me.txtNilaiUts.Name = "txtNilaiUts"
        Me.txtNilaiUts.Size = New System.Drawing.Size(115, 26)
        Me.txtNilaiUts.TabIndex = 11
        '
        'txtNilaiUas
        '
        Me.txtNilaiUas.Location = New System.Drawing.Point(194, 222)
        Me.txtNilaiUas.Name = "txtNilaiUas"
        Me.txtNilaiUas.Size = New System.Drawing.Size(115, 26)
        Me.txtNilaiUas.TabIndex = 12
        '
        'txtHasilTugas
        '
        Me.txtHasilTugas.Location = New System.Drawing.Point(512, 128)
        Me.txtHasilTugas.Name = "txtHasilTugas"
        Me.txtHasilTugas.Size = New System.Drawing.Size(100, 26)
        Me.txtHasilTugas.TabIndex = 13
        '
        'txtHasilAbsen
        '
        Me.txtHasilAbsen.Location = New System.Drawing.Point(512, 77)
        Me.txtHasilAbsen.Name = "txtHasilAbsen"
        Me.txtHasilAbsen.Size = New System.Drawing.Size(100, 26)
        Me.txtHasilAbsen.TabIndex = 14
        '
        'txtHasilUts
        '
        Me.txtHasilUts.Location = New System.Drawing.Point(512, 177)
        Me.txtHasilUts.Name = "txtHasilUts"
        Me.txtHasilUts.Size = New System.Drawing.Size(100, 26)
        Me.txtHasilUts.TabIndex = 15
        '
        'txtHasilUas
        '
        Me.txtHasilUas.Location = New System.Drawing.Point(512, 221)
        Me.txtHasilUas.Name = "txtHasilUas"
        Me.txtHasilUas.Size = New System.Drawing.Size(100, 26)
        Me.txtHasilUas.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.cmdHitung)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(71, 295)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 167)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tombol"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(159, 50)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 99)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Keluar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 38)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Ulang"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmdHitung
        '
        Me.cmdHitung.Location = New System.Drawing.Point(6, 51)
        Me.cmdHitung.Name = "cmdHitung"
        Me.cmdHitung.Size = New System.Drawing.Size(116, 38)
        Me.cmdHitung.TabIndex = 0
        Me.cmdHitung.Text = "Hitung"
        Me.cmdHitung.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(411, 305)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 23)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Total Nilai"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(411, 354)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 23)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Grade"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(411, 407)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 23)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Keterangan"
        '
        'txtTotalNilai
        '
        Me.txtTotalNilai.Location = New System.Drawing.Point(582, 305)
        Me.txtTotalNilai.Name = "txtTotalNilai"
        Me.txtTotalNilai.Size = New System.Drawing.Size(137, 26)
        Me.txtTotalNilai.TabIndex = 21
        '
        'txtTotalGrade
        '
        Me.txtTotalGrade.Location = New System.Drawing.Point(582, 351)
        Me.txtTotalGrade.Name = "txtTotalGrade"
        Me.txtTotalGrade.Size = New System.Drawing.Size(137, 26)
        Me.txtTotalGrade.TabIndex = 22
        '
        'TxtKet
        '
        Me.TxtKet.Location = New System.Drawing.Point(582, 404)
        Me.TxtKet.Name = "TxtKet"
        Me.TxtKet.Size = New System.Drawing.Size(137, 26)
        Me.TxtKet.TabIndex = 23
        '
        'Form16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 544)
        Me.Controls.Add(Me.TxtKet)
        Me.Controls.Add(Me.txtTotalGrade)
        Me.Controls.Add(Me.txtTotalNilai)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtHasilUas)
        Me.Controls.Add(Me.txtHasilUts)
        Me.Controls.Add(Me.txtHasilAbsen)
        Me.Controls.Add(Me.txtHasilTugas)
        Me.Controls.Add(Me.txtNilaiUas)
        Me.Controls.Add(Me.txtNilaiUts)
        Me.Controls.Add(Me.txtNilaiTugas)
        Me.Controls.Add(Me.txtNilaiAbsen)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form16"
        Me.Text = "Form16"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNilaiAbsen As TextBox
    Friend WithEvents txtNilaiTugas As TextBox
    Friend WithEvents txtNilaiUts As TextBox
    Friend WithEvents txtNilaiUas As TextBox
    Friend WithEvents txtHasilTugas As TextBox
    Friend WithEvents txtHasilUts As TextBox
    Friend WithEvents txtHasilUas As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cmdHitung As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTotalNilai As TextBox
    Friend WithEvents txtTotalGrade As TextBox
    Friend WithEvents TxtKet As TextBox
    Friend WithEvents txtHasilAbsen As TextBox
End Class
