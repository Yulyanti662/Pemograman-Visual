<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form15
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
        Me.LblGender = New System.Windows.Forms.Label()
        Me.LblJur = New System.Windows.Forms.Label()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.CmdProses = New System.Windows.Forms.Button()
        Me.RbW = New System.Windows.Forms.RadioButton()
        Me.RbP = New System.Windows.Forms.RadioButton()
        Me.CmbJur = New System.Windows.Forms.ComboBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtNIM = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblGender
        '
        Me.LblGender.AutoSize = True
        Me.LblGender.Location = New System.Drawing.Point(101, 424)
        Me.LblGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblGender.Name = "LblGender"
        Me.LblGender.Size = New System.Drawing.Size(0, 20)
        Me.LblGender.TabIndex = 25
        '
        'LblJur
        '
        Me.LblJur.AutoSize = True
        Me.LblJur.Location = New System.Drawing.Point(101, 382)
        Me.LblJur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblJur.Name = "LblJur"
        Me.LblJur.Size = New System.Drawing.Size(0, 20)
        Me.LblJur.TabIndex = 24
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Location = New System.Drawing.Point(101, 341)
        Me.LblNama.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(0, 20)
        Me.LblNama.TabIndex = 23
        '
        'CmdProses
        '
        Me.CmdProses.Location = New System.Drawing.Point(272, 264)
        Me.CmdProses.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmdProses.Name = "CmdProses"
        Me.CmdProses.Size = New System.Drawing.Size(128, 35)
        Me.CmdProses.TabIndex = 22
        Me.CmdProses.Text = "PROSES"
        Me.CmdProses.UseVisualStyleBackColor = True
        '
        'RbW
        '
        Me.RbW.AutoSize = True
        Me.RbW.Location = New System.Drawing.Point(344, 205)
        Me.RbW.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RbW.Name = "RbW"
        Me.RbW.Size = New System.Drawing.Size(84, 24)
        Me.RbW.TabIndex = 21
        Me.RbW.TabStop = True
        Me.RbW.Text = "Wanita"
        Me.RbW.UseVisualStyleBackColor = True
        '
        'RbP
        '
        Me.RbP.AutoSize = True
        Me.RbP.Location = New System.Drawing.Point(249, 205)
        Me.RbP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RbP.Name = "RbP"
        Me.RbP.Size = New System.Drawing.Size(61, 24)
        Me.RbP.TabIndex = 20
        Me.RbP.TabStop = True
        Me.RbP.Text = "Pria"
        Me.RbP.UseVisualStyleBackColor = True
        '
        'CmbJur
        '
        Me.CmbJur.FormattingEnabled = True
        Me.CmbJur.Location = New System.Drawing.Point(249, 142)
        Me.CmbJur.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmbJur.Name = "CmbJur"
        Me.CmbJur.Size = New System.Drawing.Size(199, 28)
        Me.CmbJur.TabIndex = 19
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(249, 85)
        Me.TxtNama.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(199, 26)
        Me.TxtNama.TabIndex = 18
        '
        'TxtNIM
        '
        Me.TxtNIM.Location = New System.Drawing.Point(249, 35)
        Me.TxtNIM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtNIM.Name = "TxtNIM"
        Me.TxtNIM.Size = New System.Drawing.Size(148, 26)
        Me.TxtNIM.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(97, 209)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(97, 147)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Jurusan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "NIM"
        '
        'Form15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 495)
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
        Me.Name = "Form15"
        Me.Text = "Form15"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblGender As Label
    Friend WithEvents LblJur As Label
    Friend WithEvents LblNama As Label
    Friend WithEvents CmdProses As Button
    Friend WithEvents RbW As RadioButton
    Friend WithEvents RbP As RadioButton
    Friend WithEvents CmbJur As ComboBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtNIM As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
