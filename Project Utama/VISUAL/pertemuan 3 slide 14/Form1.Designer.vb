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
        Me.TxtNIM = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.CmbJur = New System.Windows.Forms.ComboBox()
        Me.RbP = New System.Windows.Forms.RadioButton()
        Me.RbW = New System.Windows.Forms.RadioButton()
        Me.CmdProses = New System.Windows.Forms.Button()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.LblJur = New System.Windows.Forms.Label()
        Me.LblGender = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jurusan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gender"
        '
        'TxtNIM
        '
        Me.TxtNIM.Location = New System.Drawing.Point(143, 31)
        Me.TxtNIM.Name = "TxtNIM"
        Me.TxtNIM.Size = New System.Drawing.Size(100, 20)
        Me.TxtNIM.TabIndex = 4
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(143, 64)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(134, 20)
        Me.TxtNama.TabIndex = 5
        '
        'CmbJur
        '
        Me.CmbJur.FormattingEnabled = True
        Me.CmbJur.Location = New System.Drawing.Point(143, 101)
        Me.CmbJur.Name = "CmbJur"
        Me.CmbJur.Size = New System.Drawing.Size(134, 21)
        Me.CmbJur.TabIndex = 6
        '
        'RbP
        '
        Me.RbP.AutoSize = True
        Me.RbP.Location = New System.Drawing.Point(143, 142)
        Me.RbP.Name = "RbP"
        Me.RbP.Size = New System.Drawing.Size(43, 17)
        Me.RbP.TabIndex = 7
        Me.RbP.TabStop = True
        Me.RbP.Text = "Pria"
        Me.RbP.UseVisualStyleBackColor = True
        '
        'RbW
        '
        Me.RbW.AutoSize = True
        Me.RbW.Location = New System.Drawing.Point(206, 142)
        Me.RbW.Name = "RbW"
        Me.RbW.Size = New System.Drawing.Size(59, 17)
        Me.RbW.TabIndex = 8
        Me.RbW.TabStop = True
        Me.RbW.Text = "Wanita"
        Me.RbW.UseVisualStyleBackColor = True
        '
        'CmdProses
        '
        Me.CmdProses.Location = New System.Drawing.Point(158, 180)
        Me.CmdProses.Name = "CmdProses"
        Me.CmdProses.Size = New System.Drawing.Size(85, 23)
        Me.CmdProses.TabIndex = 9
        Me.CmdProses.Text = "PROSES"
        Me.CmdProses.UseVisualStyleBackColor = True
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Location = New System.Drawing.Point(44, 230)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(0, 13)
        Me.LblNama.TabIndex = 10
        '
        'LblJur
        '
        Me.LblJur.AutoSize = True
        Me.LblJur.Location = New System.Drawing.Point(44, 257)
        Me.LblJur.Name = "LblJur"
        Me.LblJur.Size = New System.Drawing.Size(0, 13)
        Me.LblJur.TabIndex = 11
        '
        'LblGender
        '
        Me.LblGender.AutoSize = True
        Me.LblGender.Location = New System.Drawing.Point(44, 284)
        Me.LblGender.Name = "LblGender"
        Me.LblGender.Size = New System.Drawing.Size(0, 13)
        Me.LblGender.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblGender)
        Me.Controls.Add(Me.LblJur)
        Me.Controls.Add(Me.LblNama)
        Me.Controls.Add(Me.CmdProses)
        Me.Controls.Add(Me.RbW)
        Me.Controls.Add(Me.RbP)
        Me.Controls.Add(Me.CmbJur)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.TxtNIM)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNIM As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents CmbJur As ComboBox
    Friend WithEvents RbP As RadioButton
    Friend WithEvents RbW As RadioButton
    Friend WithEvents CmdProses As Button
    Friend WithEvents LblNama As Label
    Friend WithEvents LblJur As Label
    Friend WithEvents LblGender As Label
End Class
