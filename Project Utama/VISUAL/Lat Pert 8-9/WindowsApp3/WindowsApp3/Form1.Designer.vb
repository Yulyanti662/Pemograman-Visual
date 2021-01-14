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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNIP = New System.Windows.Forms.TextBox()
        Me.BCari = New System.Windows.Forms.Button()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.cmbBgn = New System.Windows.Forms.ComboBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.cmbPend = New System.Windows.Forms.ComboBox()
        Me.RBlmKwn = New System.Windows.Forms.RadioButton()
        Me.RKwn = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BExit = New System.Windows.Forms.Button()
        Me.BCancel = New System.Windows.Forms.Button()
        Me.BDelete = New System.Windows.Forms.Button()
        Me.BEdit = New System.Windows.Forms.Button()
        Me.BSave = New System.Windows.Forms.Button()
        Me.DTglLhr = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Pegawai"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Bagian"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal lhr"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(60, 414)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Pendidikan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(63, 459)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Status"
        '
        'txtNIP
        '
        Me.txtNIP.Location = New System.Drawing.Point(210, 77)
        Me.txtNIP.Name = "txtNIP"
        Me.txtNIP.Size = New System.Drawing.Size(275, 26)
        Me.txtNIP.TabIndex = 7
        '
        'BCari
        '
        Me.BCari.Location = New System.Drawing.Point(526, 68)
        Me.BCari.Name = "BCari"
        Me.BCari.Size = New System.Drawing.Size(77, 35)
        Me.BCari.TabIndex = 8
        Me.BCari.Text = "Cari"
        Me.BCari.UseVisualStyleBackColor = True
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(207, 123)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(277, 26)
        Me.txtNama.TabIndex = 9
        '
        'cmbBgn
        '
        Me.cmbBgn.FormattingEnabled = True
        Me.cmbBgn.Items.AddRange(New Object() {"Administrasi", "Accounting", "Manager", "Kasir"})
        Me.cmbBgn.Location = New System.Drawing.Point(207, 159)
        Me.cmbBgn.Name = "cmbBgn"
        Me.cmbBgn.Size = New System.Drawing.Size(203, 28)
        Me.cmbBgn.TabIndex = 10
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(204, 244)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(3, 3, 4, 4)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.ShortcutsEnabled = False
        Me.txtAlamat.Size = New System.Drawing.Size(399, 150)
        Me.txtAlamat.TabIndex = 12
        '
        'cmbPend
        '
        Me.cmbPend.FormattingEnabled = True
        Me.cmbPend.Items.AddRange(New Object() {"SMP", "SMA", "SMK", "S1", "S2", "S3"})
        Me.cmbPend.Location = New System.Drawing.Point(203, 411)
        Me.cmbPend.Name = "cmbPend"
        Me.cmbPend.Size = New System.Drawing.Size(206, 28)
        Me.cmbPend.TabIndex = 13
        '
        'RBlmKwn
        '
        Me.RBlmKwn.AutoSize = True
        Me.RBlmKwn.Location = New System.Drawing.Point(203, 457)
        Me.RBlmKwn.Name = "RBlmKwn"
        Me.RBlmKwn.Size = New System.Drawing.Size(125, 24)
        Me.RBlmKwn.TabIndex = 14
        Me.RBlmKwn.TabStop = True
        Me.RBlmKwn.Text = "Belum Kawin"
        Me.RBlmKwn.UseVisualStyleBackColor = True
        '
        'RKwn
        '
        Me.RKwn.AutoSize = True
        Me.RKwn.Location = New System.Drawing.Point(371, 459)
        Me.RKwn.Name = "RKwn"
        Me.RKwn.Size = New System.Drawing.Size(76, 24)
        Me.RKwn.TabIndex = 15
        Me.RKwn.TabStop = True
        Me.RKwn.Text = "Kawin"
        Me.RKwn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.BExit)
        Me.Panel1.Controls.Add(Me.BCancel)
        Me.Panel1.Controls.Add(Me.BDelete)
        Me.Panel1.Controls.Add(Me.BEdit)
        Me.Panel1.Controls.Add(Me.BSave)
        Me.Panel1.Location = New System.Drawing.Point(716, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(235, 453)
        Me.Panel1.TabIndex = 16
        '
        'BExit
        '
        Me.BExit.Location = New System.Drawing.Point(59, 368)
        Me.BExit.Name = "BExit"
        Me.BExit.Size = New System.Drawing.Size(125, 35)
        Me.BExit.TabIndex = 4
        Me.BExit.Text = "Exit"
        Me.BExit.UseVisualStyleBackColor = True
        '
        'BCancel
        '
        Me.BCancel.Location = New System.Drawing.Point(59, 170)
        Me.BCancel.Name = "BCancel"
        Me.BCancel.Size = New System.Drawing.Size(125, 35)
        Me.BCancel.TabIndex = 3
        Me.BCancel.Text = "Cancel"
        Me.BCancel.UseVisualStyleBackColor = True
        '
        'BDelete
        '
        Me.BDelete.Enabled = False
        Me.BDelete.Location = New System.Drawing.Point(59, 123)
        Me.BDelete.Name = "BDelete"
        Me.BDelete.Size = New System.Drawing.Size(125, 36)
        Me.BDelete.TabIndex = 2
        Me.BDelete.Text = "Delete"
        Me.BDelete.UseVisualStyleBackColor = True
        '
        'BEdit
        '
        Me.BEdit.Enabled = False
        Me.BEdit.Location = New System.Drawing.Point(59, 76)
        Me.BEdit.Name = "BEdit"
        Me.BEdit.Size = New System.Drawing.Size(125, 36)
        Me.BEdit.TabIndex = 1
        Me.BEdit.Text = "Edit"
        Me.BEdit.UseVisualStyleBackColor = True
        '
        'BSave
        '
        Me.BSave.Location = New System.Drawing.Point(59, 24)
        Me.BSave.Name = "BSave"
        Me.BSave.Size = New System.Drawing.Size(125, 39)
        Me.BSave.TabIndex = 0
        Me.BSave.Text = "Save"
        Me.BSave.UseVisualStyleBackColor = True
        '
        'DTglLhr
        '
        Me.DTglLhr.Location = New System.Drawing.Point(207, 201)
        Me.DTglLhr.Name = "DTglLhr"
        Me.DTglLhr.Size = New System.Drawing.Size(278, 26)
        Me.DTglLhr.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 579)
        Me.Controls.Add(Me.DTglLhr)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RKwn)
        Me.Controls.Add(Me.RBlmKwn)
        Me.Controls.Add(Me.cmbPend)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.cmbBgn)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.BCari)
        Me.Controls.Add(Me.txtNIP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
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
    Friend WithEvents txtNIP As TextBox
    Friend WithEvents BCari As Button
    Friend WithEvents txtNama As TextBox
    Friend WithEvents cmbBgn As ComboBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents cmbPend As ComboBox
    Friend WithEvents RBlmKwn As RadioButton
    Friend WithEvents RKwn As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BExit As Button
    Friend WithEvents BCancel As Button
    Friend WithEvents BDelete As Button
    Friend WithEvents BEdit As Button
    Friend WithEvents BSave As Button
    Friend WithEvents DTglLhr As DateTimePicker
End Class
