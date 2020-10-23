Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbStatus.Items.Clear()
        CmbStatus.Items.Add("Menikah")
        CmbStatus.Items.Add("Bujang")
    End Sub

    Private Sub CmdProses_Click(sender As Object, e As EventArgs) Handles CmdProses.Click
        If RbP.Checked = True Then
            If CmbStatus.Text = "Menikah" Then
                TxtKet.Text = "Ayah"
            Else
                TxtKet.Text = "Jejaka"
            End If
        Else
            If CmbStatus.Text = "Menikah" Then
                TxtKet.Text = "Ibu"
            Else
                TxtKet.Text = "Gadis"
            End If
        End If
    End Sub


End Class
