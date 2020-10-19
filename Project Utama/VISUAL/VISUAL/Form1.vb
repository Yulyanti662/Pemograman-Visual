Public Class FormUtama
    Public Property Fromfrom As Object

    Private Sub HelloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelloToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub MembuatPesanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MembuatPesanToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OperatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperatorToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub KursMataUangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KursMataUangToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub HasilOperatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HasilOperatorToolStripMenuItem.Click
        Form6.Show()
    End Sub
End Class
