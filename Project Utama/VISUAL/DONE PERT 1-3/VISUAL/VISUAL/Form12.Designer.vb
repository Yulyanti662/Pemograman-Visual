<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
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
        Me.RbKare = New System.Windows.Forms.RadioButton()
        Me.RbSoto = New System.Windows.Forms.RadioButton()
        Me.RbSate = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTampil
        '
        Me.BTampil.Location = New System.Drawing.Point(94, 263)
        Me.BTampil.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTampil.Name = "BTampil"
        Me.BTampil.Size = New System.Drawing.Size(165, 35)
        Me.BTampil.TabIndex = 9
        Me.BTampil.Text = "Tampilkan Pilihan"
        Me.BTampil.UseVisualStyleBackColor = True
        '
        'RbKare
        '
        Me.RbKare.AutoSize = True
        Me.RbKare.Location = New System.Drawing.Point(94, 183)
        Me.RbKare.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RbKare.Name = "RbKare"
        Me.RbKare.Size = New System.Drawing.Size(67, 24)
        Me.RbKare.TabIndex = 8
        Me.RbKare.TabStop = True
        Me.RbKare.Text = "Kare"
        Me.RbKare.UseVisualStyleBackColor = True
        '
        'RbSoto
        '
        Me.RbSoto.AutoSize = True
        Me.RbSoto.Location = New System.Drawing.Point(94, 146)
        Me.RbSoto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RbSoto.Name = "RbSoto"
        Me.RbSoto.Size = New System.Drawing.Size(68, 24)
        Me.RbSoto.TabIndex = 7
        Me.RbSoto.TabStop = True
        Me.RbSoto.Text = "Soto"
        Me.RbSoto.UseVisualStyleBackColor = True
        '
        'RbSate
        '
        Me.RbSate.AutoSize = True
        Me.RbSate.Location = New System.Drawing.Point(94, 109)
        Me.RbSate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RbSate.Name = "RbSate"
        Me.RbSate.Size = New System.Drawing.Size(68, 24)
        Me.RbSate.TabIndex = 6
        Me.RbSate.TabStop = True
        Me.RbSate.Text = "Sate"
        Me.RbSate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Makanan Favorit"
        '
        'Form12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTampil)
        Me.Controls.Add(Me.RbKare)
        Me.Controls.Add(Me.RbSoto)
        Me.Controls.Add(Me.RbSate)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form12"
        Me.Text = "Form12"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTampil As Button
    Friend WithEvents RbKare As RadioButton
    Friend WithEvents RbSoto As RadioButton
    Friend WithEvents RbSate As RadioButton
    Friend WithEvents Label1 As Label
End Class
