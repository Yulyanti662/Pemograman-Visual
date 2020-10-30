Public Class Form12
    Private Sub BTampil_Click(sender As Object, e As EventArgs) Handles BTampil.Click
        Dim pilihan As String
        pilihan = "Anda Memilih "
        If RbSate.Checked = True Then
            pilihan = pilihan & "Sate"
        End If
        If RbSoto.Checked = True Then
            pilihan = pilihan & "Soto"
        End If
        If RbKare.Checked = True Then
            pilihan = pilihan & "Kare"
        End If
        MsgBox(pilihan & ", Pesan Segera Diantar")
    End Sub
End Class