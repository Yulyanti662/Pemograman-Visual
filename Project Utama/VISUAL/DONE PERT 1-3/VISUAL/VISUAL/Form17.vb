Public Class Form17
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim harga, jumlah, diskon, pajak, total As Integer
        harga = TextBox2.Text
        jumlah = TextBox3.Text
        diskon = TextBox4.Text

        total = ((harga * jumlah) - (((harga * jumlah) * diskon) / 100))
        pajak = total * 0.02

        TextBox5.Text = pajak
        TextBox6.Text = total
        TextBox7.Enabled = True
    End Sub

    Private Sub total_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        If TextBox7.Text = "" Then
            TextBox7.Text = 0
        End If
        TextBox8.Text = CInt(TextBox7.Text) - CInt(TextBox6.Text)
    End Sub
End Class