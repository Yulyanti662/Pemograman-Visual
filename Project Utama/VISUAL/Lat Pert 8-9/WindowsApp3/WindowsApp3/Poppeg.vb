Public Class poppeg
    Public colNIP, colNama, colbgn, coltgllhr, colAlamat, colPend, colstatus As String
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Counter.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)
        Call list_data()
    End Sub

    Private Sub TxtNama_TextChanged(sender As Object, e As EventArgs) Handles TxtNama.TextChanged
        Call list_data()
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        Call pilih()
    End Sub

    Private Sub listpegawai_DoubleClick(sender As Object, e As EventArgs) Handles ListPegawai.DoubleClick
        Call pilih()
    End Sub

    Private Sub poppeg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call list_data()
    End Sub

    Private Sub listpegawai_SelectedItems(sender As Object, e As EventArgs) Handles ListPegawai.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub pilih()
        Try
            colNIP = ListPegawai.SelectedItems(0).SubItems(0).Text.ToString
            colNama = ListPegawai.SelectedItems(0).SubItems(1).Text.ToString
            colbgn = ListPegawai.SelectedItems(0).SubItems(2).Text.ToString
            coltgllhr = ListPegawai.SelectedItems(0).SubItems(3).Text.ToString
            colAlamat = ListPegawai.SelectedItems(0).SubItems(4).Text.ToString
            colPend = ListPegawai.SelectedItems(0).SubItems(5).Text.ToString
            colstatus = ListPegawai.SelectedItems(0).SubItems(6).Text.ToString
            Me.Close()
        Catch ex As Exception
            MsgBox("pilih salah satu data", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub clear_list()
        While Val(Counter.Text) > 0
            ListPegawai.Items(0).Remove()
            Counter.Text = Val(Counter.Text) - 1
        End While
    End Sub

    Private Sub list_data()
        Call clear_list()

        Dim sqlx As String
        Dim x As Integer
        sqlx = "select * from poppegawai where [Nama Pegawai] like '%" &
        Trim(TxtNama.Text) & "%'"

        Dim cnn = New OleDb.OleDbConnection(KONEKSI)
        If cnn.State <> ConnectionState.Closed Then cnn.Close()
        cnn.Open()
        Dim cmmd = New OleDb.OleDbCommand(sqlx, cnn)
        Dim dReader = cmmd.ExecuteReader
        If IsDBNull(dReader) Then

        Else

        End If
        Try
            While dReader.Read = True
                x = Val(Counter.Text)
                Counter.Text = Str(Val(Counter.Text) + 1) & "Record"

                With ListPegawai
                    .Items.Add("")
                    .Items(.Items.Count - 1).SubItems.Add("")
                    .Items(.Items.Count - 1).SubItems.Add("")
                    .Items(.Items.Count - 1).SubItems.Add("")
                    .Items(.Items.Count - 1).SubItems.Add("")
                    .Items(.Items.Count - 1).SubItems.Add("")
                    .Items(.Items.Count - 1).SubItems.Add("")
                    .Items(.Items.Count - 1).SubItems.Add("")
                    .Items(x).SubItems(0).Text = dReader.GetString(0)
                    .Items(x).SubItems(1).Text = dReader.GetString(1)
                    .Items(x).SubItems(2).Text = dReader.GetString(2)
                    .Items(x).SubItems(3).Text = dReader.GetDateTime(3)
                    .Items(x).SubItems(4).Text = dReader.GetString(4)
                    .Items(x).SubItems(5).Text = dReader.GetString(5)
                    .Items(x).SubItems(6).Text = dReader.GetString(6)
                    '.Items(x).SubItems(1).Text = dReader.GetString(7)
                End With
            End While
        Finally
            dReader.Close()
        End Try
        cnn.Close()
    End Sub
End Class
