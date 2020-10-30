Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles psn1.Click
        MsgBox("Coba Belajar VB.Net")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Tanda Seru", MsgBoxStyle.Exclamation, "Baca Pesan")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Tanda I", MsgBoxStyle.Information, "Baca Pesan")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Error", MsgBoxStyle.Critical, "Baca Pesan")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        End
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim pesan As String
        pesan = MsgBox("Keluar Dari Program??", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Exit")
        If pesan = vbOK Then
            Me.Close()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button5.Text = ""
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Button6.Text = "Percobaan VB.Net"
        Button5.Text = "OK...!!!"
    End Sub
End Class