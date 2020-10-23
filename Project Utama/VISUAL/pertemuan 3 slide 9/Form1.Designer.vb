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
        Me.RbSate = New System.Windows.Forms.RadioButton()
        Me.RbSoto = New System.Windows.Forms.RadioButton()
        Me.RbKare = New System.Windows.Forms.RadioButton()
        Me.BTampil = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Makanan Favorit"
        '
        'RbSate
        '
        Me.RbSate.AutoSize = True
        Me.RbSate.Location = New System.Drawing.Point(72, 76)
        Me.RbSate.Name = "RbSate"
        Me.RbSate.Size = New System.Drawing.Size(47, 17)
        Me.RbSate.TabIndex = 1
        Me.RbSate.TabStop = True
        Me.RbSate.Text = "Sate"
        Me.RbSate.UseVisualStyleBackColor = True
        '
        'RbSoto
        '
        Me.RbSoto.AutoSize = True
        Me.RbSoto.Location = New System.Drawing.Point(72, 100)
        Me.RbSoto.Name = "RbSoto"
        Me.RbSoto.Size = New System.Drawing.Size(47, 17)
        Me.RbSoto.TabIndex = 2
        Me.RbSoto.TabStop = True
        Me.RbSoto.Text = "Soto"
        Me.RbSoto.UseVisualStyleBackColor = True
        '
        'RbKare
        '
        Me.RbKare.AutoSize = True
        Me.RbKare.Location = New System.Drawing.Point(72, 124)
        Me.RbKare.Name = "RbKare"
        Me.RbKare.Size = New System.Drawing.Size(47, 17)
        Me.RbKare.TabIndex = 3
        Me.RbKare.TabStop = True
        Me.RbKare.Text = "Kare"
        Me.RbKare.UseVisualStyleBackColor = True
        '
        'BTampil
        '
        Me.BTampil.Location = New System.Drawing.Point(72, 176)
        Me.BTampil.Name = "BTampil"
        Me.BTampil.Size = New System.Drawing.Size(110, 23)
        Me.BTampil.TabIndex = 4
        Me.BTampil.Text = "Tampilkan Pilihan"
        Me.BTampil.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTampil)
        Me.Controls.Add(Me.RbKare)
        Me.Controls.Add(Me.RbSoto)
        Me.Controls.Add(Me.RbSate)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RbSate As RadioButton
    Friend WithEvents RbSoto As RadioButton
    Friend WithEvents RbKare As RadioButton
    Friend WithEvents BTampil As Button
End Class
