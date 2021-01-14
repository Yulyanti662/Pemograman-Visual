Public Class MenuUtama
    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs)

    End Sub

    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MenuItem1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuItem1ToolStripMenuItem.Click

    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Tutup Aplikasi?", "",
MessageBoxButtons.YesNo) =
Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub
End Class