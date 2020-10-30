Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nilai1, nilai2 As Double

        nilai1 = TextBox1.Text
        nilai2 = TextBox2.Text

        If RadioButton1.Checked = True Then
            TextBox3.Text = nilai1 / nilai2
        End If
        If RadioButton2.Checked = True Then
            TextBox3.Text = nilai1 Mod nilai2
        End If
        If RadioButton3.Checked = True Then
            TextBox3.Text = nilai1 ^ nilai2
        End If
        If RadioButton4.Checked = True Then
            TextBox3.Text = nilai1 & nilai2
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class