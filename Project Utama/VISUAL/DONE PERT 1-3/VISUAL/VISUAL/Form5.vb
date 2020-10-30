Public Class Form5
    Private Sub Kurs_TextChanged(sender As Object, e As EventArgs) Handles Kurs.TextChanged
        Kurs.Text = "Rp." & Val(Dolar.Text) * Val(Kurs.Text)
    End Sub

    Private Sub Dolar_TextChanged(sender As Object, e As EventArgs) Handles Dolar.TextChanged

    End Sub
End Class