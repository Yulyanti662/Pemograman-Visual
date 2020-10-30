<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        Me.BTampil = New System.Windows.Forms.Button()
        Me.chkKare = New System.Windows.Forms.RadioButton()
        Me.chkSoto = New System.Windows.Forms.RadioButton()
        Me.chkSate = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTampil
        '
        Me.BTampil.Location = New System.Drawing.Point(77, 267)
        Me.BTampil.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTampil.Name = "BTampil"
        Me.BTampil.Size = New System.Drawing.Size(165, 35)
        Me.BTampil.TabIndex = 9
        Me.BTampil.Text = "Tampilkan Pilihan"
        Me.BTampil.UseVisualStyleBackColor = True
        '
        'chkKare
        '
        Me.chkKare.AutoSize = True
        Me.chkKare.Location = New System.Drawing.Point(76, 195)
        Me.chkKare.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkKare.Name = "chkKare"
        Me.chkKare.Size = New System.Drawing.Size(67, 24)
        Me.chkKare.TabIndex = 8
        Me.chkKare.TabStop = True
        Me.chkKare.Text = "Kare"
        Me.chkKare.UseVisualStyleBackColor = True
        '
        'chkSoto
        '
        Me.chkSoto.AutoSize = True
        Me.chkSoto.Location = New System.Drawing.Point(76, 149)
        Me.chkSoto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkSoto.Name = "chkSoto"
        Me.chkSoto.Size = New System.Drawing.Size(68, 24)
        Me.chkSoto.TabIndex = 7
        Me.chkSoto.TabStop = True
        Me.chkSoto.Text = "Soto"
        Me.chkSoto.UseVisualStyleBackColor = True
        '
        'chkSate
        '
        Me.chkSate.AutoSize = True
        Me.chkSate.Location = New System.Drawing.Point(76, 98)
        Me.chkSate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkSate.Name = "chkSate"
        Me.chkSate.Size = New System.Drawing.Size(68, 24)
        Me.chkSate.TabIndex = 6
        Me.chkSate.TabStop = True
        Me.chkSate.Text = "Sate"
        Me.chkSate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Makanan Favorit"
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTampil)
        Me.Controls.Add(Me.chkKare)
        Me.Controls.Add(Me.chkSoto)
        Me.Controls.Add(Me.chkSate)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form11"
        Me.Text = "Form11"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTampil As Button
    Friend WithEvents chkKare As RadioButton
    Friend WithEvents chkSoto As RadioButton
    Friend WithEvents chkSate As RadioButton
    Friend WithEvents Label1 As Label
End Class
