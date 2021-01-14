Public Class Login2
    Private Sub Blogin_Click(sender As Object, e As EventArgs) Handles Blogin.Click
        CNN = New OleDb.OleDbConnection(KONEKSI)
        If CNN.State <> ConnectionState.Closed Then CNN.Close()
        CNN.Open()
        OLECMD = New OleDb.OleDbCommand("Select * FROM login WHERE username='" & TxtUser.Text &
                                        "' and password = '" & TxtPassword.Text & "'", CNN)
        OLERDR = OLECMD.ExecuteReader
        If (OLERDR.Read()) Then
            MenuUtama.Show()
            Me.Hide()
        Else
            MsgBox("Maaf, Username dan Password tidak ditemukan....!", MsgBoxStyle.OkOnly &
                   "Login Gagal")
            TxtUser.Text = ""
            TxtPassword.Text = ""
            TxtUser.Focus()
        End If
    End Sub

    Private Sub Bexit_Click(sender As Object, e As EventArgs) Handles Bexit.Click
        End
    End Sub
End Class