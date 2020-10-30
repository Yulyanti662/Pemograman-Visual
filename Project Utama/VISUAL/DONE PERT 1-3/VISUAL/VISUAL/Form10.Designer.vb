<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Me.TxtKet = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmdProses = New System.Windows.Forms.Button()
        Me.TxtNA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtKet
        '
        Me.TxtKet.Location = New System.Drawing.Point(246, 264)
        Me.TxtKet.Name = "TxtKet"
        Me.TxtKet.Size = New System.Drawing.Size(150, 26)
        Me.TxtKet.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Keterangan"
        '
        'CmdProses
        '
        Me.CmdProses.Location = New System.Drawing.Point(246, 170)
        Me.CmdProses.Name = "CmdProses"
        Me.CmdProses.Size = New System.Drawing.Size(121, 38)
        Me.CmdProses.TabIndex = 7
        Me.CmdProses.Text = "PROSES"
        Me.CmdProses.UseVisualStyleBackColor = True
        '
        'TxtNA
        '
        Me.TxtNA.Location = New System.Drawing.Point(246, 64)
        Me.TxtNA.Name = "TxtNA"
        Me.TxtNA.Size = New System.Drawing.Size(150, 26)
        Me.TxtNA.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nilai Akhir"
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtKet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmdProses)
        Me.Controls.Add(Me.TxtNA)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form10"
        Me.Text = "Form10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtKet As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CmdProses As Button
    Friend WithEvents TxtNA As TextBox
    Friend WithEvents Label1 As Label
End Class
