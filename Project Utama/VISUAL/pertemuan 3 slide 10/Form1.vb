Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("paket 1")
        ComboBox1.Items.Add("paket 2")
        ComboBox1.Items.Add("paket 3")
        ComboBox1.Items.Add("paket 4")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "paket 1" Then
            ComboBox1.Text = ComboBox1.Text
            Me.TextBox1.Text = "Rendang"
            Me.TextBox2.Text = "Teh Manis"
            Me.TextBox3.Text = "110000"
        ElseIf ComboBox1.Text = "paket 2" Then
            ComboBox1.Text = ComboBox1.Text
            Me.TextBox1.Text = "Ayam Goreng"
            Me.TextBox2.Text = "Juice Jeruk"
            Me.TextBox3.Text = "150000"
        ElseIf ComboBox1.Text = "paket 3" Then
            ComboBox1.Text = ComboBox1.Text
            Me.TextBox1.Text = "Nasi Goreng"
            Me.TextBox2.Text = "Es Teh"
            Me.TextBox3.Text = "80000"
        Else
            ComboBox1.Text = ComboBox1.Text
            Me.TextBox1.Text = "Nasi Bakar"
            Me.TextBox2.Text = "Kopi"
            Me.TextBox3.Text = "170000"
        End If
    End Sub
End Class
