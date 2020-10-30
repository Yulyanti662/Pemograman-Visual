Public Class Form11
    Private Sub BTampil_Click(sender As Object, e As EventArgs) Handles BTampil.Click
        Dim pilihan As String
        pilihan = "Anda Memilih "
        If chkSate.Checked = True Then
            pilihan = pilihan & "Sate"
        ElseIf chkSoto.Checked = True Then
            pilihan = pilihan & "Soto"
        ElseIf chkKare.Checked = True Then
            pilihan = pilihan & "Kare"
        End If
        MsgBox(pilihan & ", Pesan Segera Diantar")
    End Sub
End Class