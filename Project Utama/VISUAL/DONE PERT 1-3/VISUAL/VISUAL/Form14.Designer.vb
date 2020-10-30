<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form14
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
        Me.cmdProses = New System.Windows.Forms.Button()
        Me.CmbStatus = New System.Windows.Forms.ComboBox()
        Me.RbW = New System.Windows.Forms.RadioButton()
        Me.RbP = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Ket = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdProses
        '
        Me.cmdProses.Location = New System.Drawing.Point(208, 184)
        Me.cmdProses.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdProses.Name = "cmdProses"
        Me.cmdProses.Size = New System.Drawing.Size(112, 35)
        Me.cmdProses.TabIndex = 15
        Me.cmdProses.Text = "PROSES"
        Me.cmdProses.UseVisualStyleBackColor = True
        '
        'CmbStatus
        '
        Me.CmbStatus.FormattingEnabled = True
        Me.CmbStatus.Location = New System.Drawing.Point(226, 115)
        Me.CmbStatus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Size = New System.Drawing.Size(180, 28)
        Me.CmbStatus.TabIndex = 13
        '
        'RbW
        '
        Me.RbW.AutoSize = True
        Me.RbW.Location = New System.Drawing.Point(318, 73)
        Me.RbW.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RbW.Name = "RbW"
        Me.RbW.Size = New System.Drawing.Size(84, 24)
        Me.RbW.TabIndex = 12
        Me.RbW.TabStop = True
        Me.RbW.Text = "Wanita"
        Me.RbW.UseVisualStyleBackColor = True
        '
        'RbP
        '
        Me.RbP.AutoSize = True
        Me.RbP.Location = New System.Drawing.Point(226, 73)
        Me.RbP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RbP.Name = "RbP"
        Me.RbP.Size = New System.Drawing.Size(61, 24)
        Me.RbP.TabIndex = 11
        Me.RbP.TabStop = True
        Me.RbP.Text = "Pria"
        Me.RbP.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 250)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Keterangan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 120)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Gender"
        '
        'Ket
        '
        Me.Ket.BackColor = System.Drawing.SystemColors.Control
        Me.Ket.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Ket.Location = New System.Drawing.Point(226, 250)
        Me.Ket.Name = "Ket"
        Me.Ket.Size = New System.Drawing.Size(151, 26)
        Me.Ket.TabIndex = 16
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Ket)
        Me.Controls.Add(Me.cmdProses)
        Me.Controls.Add(Me.CmbStatus)
        Me.Controls.Add(Me.RbW)
        Me.Controls.Add(Me.RbP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form14"
        Me.Text = "Form14"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdProses As Button
    Friend WithEvents CmbStatus As ComboBox
    Friend WithEvents RbW As RadioButton
    Friend WithEvents RbP As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Ket As TextBox
End Class
