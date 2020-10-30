Public Class Form15
    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbJur.Items.Clear()
        CmbJur.Items.Add("Sistem Informasi")
        CmbJur.Items.Add("Manajemen Informatika")
        CmbJur.Items.Add("Teknik Komputer")
        CmbJur.Items.Add("Komputerisasi Akuntansi")
    End Sub

    Private Sub CmdProses_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CmdProses_Click_1(sender As Object, e As EventArgs) Handles CmdProses.Click
        LblNama.Text = "Selamat Datang " & TxtNama.Text
        If CmbJur.Text = "Sistem Informasi" Then
            LblJur.Text = "Anda Masuk Jurusan SI"
        ElseIf CmbJur.Text = "Manajemen Informatika" Then
            LblJur.Text = "Anda Masuk Jurusan MI"
        ElseIf CmbJur.Text = "Teknik Komputer" Then
            LblJur.Text = "Anda Masuk Jurusan TK"
        Else
            LblJur.Text = "Anda Masuk Jurusan KA"
        End If
        If RbP.Checked = True Then
            LblGender.Text = "Anda Cowok !!"
        Else
            LblGender.Text = "Anda Cewek !!"
        End If
    End Sub
End Class