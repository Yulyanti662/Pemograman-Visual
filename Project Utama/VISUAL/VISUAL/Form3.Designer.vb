<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.psn1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'psn1
        '
        Me.psn1.Location = New System.Drawing.Point(37, 38)
        Me.psn1.Name = "psn1"
        Me.psn1.Size = New System.Drawing.Size(114, 43)
        Me.psn1.TabIndex = 0
        Me.psn1.Text = "Pesan 1"
        Me.psn1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(38, 98)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 38)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Pesan 2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(38, 155)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 42)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Pesan 3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(42, 221)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(107, 44)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Pesan 4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(246, 38)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(139, 48)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Rubah Text"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(246, 98)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(139, 38)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Hapus Text"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(38, 360)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(110, 37)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Close"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(41, 420)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(106, 32)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "End"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(238, 418)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(146, 33)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "Pesan Keluar"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 530)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.psn1)
        Me.Name = "Form3"
        Me.Text = "Membuat Pesan"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents psn1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
End Class
