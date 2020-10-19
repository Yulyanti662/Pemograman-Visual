<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Pertemuan1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MembuatPesanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pertemuan2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KursMataUangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HasilOperatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HasilOperator2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KonversiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LatihanKonversiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Pertemuan1ToolStripMenuItem, Me.Pertemuan2ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 36)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Pertemuan1ToolStripMenuItem
        '
        Me.Pertemuan1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelloToolStripMenuItem, Me.MembuatPesanToolStripMenuItem})
        Me.Pertemuan1ToolStripMenuItem.Name = "Pertemuan1ToolStripMenuItem"
        Me.Pertemuan1ToolStripMenuItem.Size = New System.Drawing.Size(127, 29)
        Me.Pertemuan1ToolStripMenuItem.Text = "Pertemuan 1"
        '
        'HelloToolStripMenuItem
        '
        Me.HelloToolStripMenuItem.Name = "HelloToolStripMenuItem"
        Me.HelloToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.HelloToolStripMenuItem.Text = "Hello"
        '
        'MembuatPesanToolStripMenuItem
        '
        Me.MembuatPesanToolStripMenuItem.Name = "MembuatPesanToolStripMenuItem"
        Me.MembuatPesanToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.MembuatPesanToolStripMenuItem.Text = "Membuat Pesan "
        '
        'Pertemuan2ToolStripMenuItem
        '
        Me.Pertemuan2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperatorToolStripMenuItem, Me.KursMataUangToolStripMenuItem, Me.HasilOperatorToolStripMenuItem, Me.HasilOperator2ToolStripMenuItem, Me.KonversiToolStripMenuItem, Me.LatihanKonversiToolStripMenuItem})
        Me.Pertemuan2ToolStripMenuItem.Name = "Pertemuan2ToolStripMenuItem"
        Me.Pertemuan2ToolStripMenuItem.Size = New System.Drawing.Size(127, 32)
        Me.Pertemuan2ToolStripMenuItem.Text = "Pertemuan 2"
        '
        'OperatorToolStripMenuItem
        '
        Me.OperatorToolStripMenuItem.Name = "OperatorToolStripMenuItem"
        Me.OperatorToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.OperatorToolStripMenuItem.Text = "Operator"
        '
        'KursMataUangToolStripMenuItem
        '
        Me.KursMataUangToolStripMenuItem.Name = "KursMataUangToolStripMenuItem"
        Me.KursMataUangToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.KursMataUangToolStripMenuItem.Text = "Kurs Mata Uang"
        '
        'HasilOperatorToolStripMenuItem
        '
        Me.HasilOperatorToolStripMenuItem.Name = "HasilOperatorToolStripMenuItem"
        Me.HasilOperatorToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.HasilOperatorToolStripMenuItem.Text = "Hasil Operator"
        '
        'HasilOperator2ToolStripMenuItem
        '
        Me.HasilOperator2ToolStripMenuItem.Name = "HasilOperator2ToolStripMenuItem"
        Me.HasilOperator2ToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.HasilOperator2ToolStripMenuItem.Text = "Hasil Operator 2"
        '
        'KonversiToolStripMenuItem
        '
        Me.KonversiToolStripMenuItem.Name = "KonversiToolStripMenuItem"
        Me.KonversiToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.KonversiToolStripMenuItem.Text = "Konversi"
        '
        'LatihanKonversiToolStripMenuItem
        '
        Me.LatihanKonversiToolStripMenuItem.Name = "LatihanKonversiToolStripMenuItem"
        Me.LatihanKonversiToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.LatihanKonversiToolStripMenuItem.Text = "Latihan Konversi"
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 476)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormUtama"
        Me.Text = "Form Utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Pertemuan1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MembuatPesanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Pertemuan2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KursMataUangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HasilOperatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HasilOperator2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KonversiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LatihanKonversiToolStripMenuItem As ToolStripMenuItem
End Class
