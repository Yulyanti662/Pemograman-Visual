Public Class Form10
    Private Sub CmdProses_Click(sender As Object, e As EventArgs) Handles CmdProses.Click
        Dim ket As String
        ket = ""
        If Val(TxtNA.Text) >= 56 Then
            ket = "LULUS"
        Else
            ket = "GAGAL"
        End If
        TxtKet.Text = ket
    End Sub
End Class