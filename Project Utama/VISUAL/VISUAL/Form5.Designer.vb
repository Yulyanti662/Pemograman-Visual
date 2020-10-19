<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.Dolar = New System.Windows.Forms.TextBox()
        Me.Kurs = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(630, 64)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cange Kurs Mata Uang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jumlah Dolar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(344, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nilai 1 $ Dalam Rupiah"
        '
        'Dolar
        '
        Me.Dolar.Location = New System.Drawing.Point(465, 160)
        Me.Dolar.Name = "Dolar"
        Me.Dolar.Size = New System.Drawing.Size(199, 26)
        Me.Dolar.TabIndex = 3
        '
        'Kurs
        '
        Me.Kurs.Location = New System.Drawing.Point(465, 228)
        Me.Kurs.Name = "Kurs"
        Me.Kurs.Size = New System.Drawing.Size(199, 26)
        Me.Kurs.TabIndex = 4
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 548)
        Me.Controls.Add(Me.Kurs)
        Me.Controls.Add(Me.Dolar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Dolar As TextBox
    Friend WithEvents Kurs As TextBox
End Class
