Public Class Form14
    Private Sub TxtKet_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CmdProses_Click(sender As Object, e As EventArgs) Handles cmdProses.Click
        If RbP.Checked = True Then
            If CmbStatus.Text = "Menikah" Then
                Ket.Text = "Ayah"
            Else
                Ket.Text = "Jejaka"
            End If
        Else
            If CmbStatus.Text = "Menikah" Then
                Ket.Text = "Ibu"
            Else
                Ket.Text = "Gadis"
            End If
        End If

    End Sub

    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbStatus.Items.Clear()
        CmbStatus.Items.Add("Menikah")
        CmbStatus.Items.Add("Bujang")
    End Sub

    Private Sub TxtKet_TextChanged_1(sender As Object, e As EventArgs) Handles Ket.TextChanged

    End Sub

    Private Sub CmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbStatus.SelectedIndexChanged

    End Sub

    Private Sub RbP_CheckedChanged(sender As Object, e As EventArgs) Handles RbP.CheckedChanged

    End Sub
End Class