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
        Me.RbP = New System.Windows.Forms.RadioButton()
        Me.RbW = New System.Windows.Forms.RadioButton()
        Me.CmbStatus = New System.Windows.Forms.ComboBox()
        Me.TxtKet = New System.Windows.Forms.TextBox()
        Me.CmdProses = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Keterangan"
        '
        'RbP
        '
        Me.RbP.AutoSize = True
        Me.RbP.Location = New System.Drawing.Point(177, 62)
        Me.RbP.Name = "RbP"
        Me.RbP.Size = New System.Drawing.Size(43, 17)
        Me.RbP.TabIndex = 3
        Me.RbP.TabStop = True
        Me.RbP.Text = "Pria"
        Me.RbP.UseVisualStyleBackColor = True
        '
        'RbW
        '
        Me.RbW.AutoSize = True
        Me.RbW.Location = New System.Drawing.Point(239, 62)
        Me.RbW.Name = "RbW"
        Me.RbW.Size = New System.Drawing.Size(59, 17)
        Me.RbW.TabIndex = 4
        Me.RbW.TabStop = True
        Me.RbW.Text = "Wanita"
        Me.RbW.UseVisualStyleBackColor = True
        '
        'CmbStatus
        '
        Me.CmbStatus.FormattingEnabled = True
        Me.CmbStatus.Location = New System.Drawing.Point(177, 89)
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Size = New System.Drawing.Size(121, 21)
        Me.CmbStatus.TabIndex = 5
        '
        'TxtKet
        '
        Me.TxtKet.Location = New System.Drawing.Point(165, 174)
        Me.TxtKet.Name = "TxtKet"
        Me.TxtKet.ReadOnly = True
        Me.TxtKet.Size = New System.Drawing.Size(100, 20)
        Me.TxtKet.TabIndex = 6
        '
        'CmdProses
        '
        Me.CmdProses.Location = New System.Drawing.Point(165, 134)
        Me.CmdProses.Name = "CmdProses"
        Me.CmdProses.Size = New System.Drawing.Size(75, 23)
        Me.CmdProses.TabIndex = 7
        Me.CmdProses.Text = "PROSES"
        Me.CmdProses.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CmdProses)
        Me.Controls.Add(Me.TxtKet)
        Me.Controls.Add(Me.CmbStatus)
        Me.Controls.Add(Me.RbW)
        Me.Controls.Add(Me.RbP)
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
    Friend WithEvents RbP As RadioButton
    Friend WithEvents RbW As RadioButton
    Friend WithEvents CmbStatus As ComboBox
    Friend WithEvents TxtKet As TextBox
    Friend WithEvents CmdProses As Button
End Class
