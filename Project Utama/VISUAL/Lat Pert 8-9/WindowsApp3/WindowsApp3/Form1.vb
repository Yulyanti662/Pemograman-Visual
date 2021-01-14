Public Class Form1
    Sub BERSIH()
        txtNIP.Text = ""
        txtNama.Text = ""
        txtAlamat.Text = ""
        cmbBgn.Text = ""
        cmbPend.Text = ""
    End Sub

    Private Sub BSave_Click(sender As Object, e As EventArgs) Handles BSave.Click
        Dim kawin As String

        If txtNIP.Text = "" Or txtNama.Text = "" Then
            MsgBox("Isi data dengan Benar", MsgBoxStyle.Exclamation, "Kesalahan")
            Exit Sub
        End If
        If RBlmKwn.Checked = True Then
            kawin = "Belum Kawin"
        Else
            kawin = "Kawin"
        End If
        Dim CNN = New OleDb.OleDbConnection(KONEKSI)
        If CNN.state <> ConnectionState.Closed Then CNN.close()
        CNN.open()
        Dim OLECMD = New OleDb.OleDbCommand("Insert into poppegawai (NIP,[Nama Pegawai], Bagian, [Tanggal lhr], Alamat, Pendidikan, Status)
        Values ('" & txtNIP.Text & "', '" & txtNama.Text & "','" & cmbBgn.Text & "','" & DTglLhr.Text & "','" & txtAlamat.Text & "','" & cmbPend.Text & "','" & kawin & "')", CNN)

        X = OlECMD.ExecuteNonQuery
        If X = 1 Then
            MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Informasi")
            Call BERSIH()
            txtNIP.Focus()
        Else
            MsgBox("Gagal Menyimpan Data", MsgBoxStyle.Exclamation, "Kesalahan")
        End If
    End Sub

    Private Sub BCancel_Click(sender As Object, e As EventArgs) Handles BCancel.Click
        Call BERSIH()
        BSave.Enabled = True
        BEdit.Enabled = False
        BDelete.Enabled = False
        txtNIP.Enabled = True
        txtNIP.Focus()
    End Sub

    Private Sub txtNIP_TextChanged(sender As Object, e As EventArgs) Handles txtNIP.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub

    Private Sub BEdit_Click(sender As Object, e As EventArgs) Handles BEdit.Click
        Dim kawin As Integer

        If txtNIP.Text = "" Or txtNama.Text = "" Then
            MsgBox("Isi Data dengan benar", MsgBoxStyle.Exclamation, "Kesalahan")
            Exit Sub
        End If
        If RBlmKwn.Checked = True Then
            kawin = "Belum Kawin"
        Else
            kawin = "Kawin"
        End If
        CNN = New OleDb.OleDbConnection(KONEKSI)
        If CNN.state <> ConnectionState.Closed Then CNN.close()
        CNN.open()
        OLECMD = New OleDb.OleDbCommand("Update pegawai set NamaPgw='" & txtNama.Text &
                                  "', Bagian ='" & cmbBgn.Text &
                                  "', Tanggal Lhr='" & DTglLhr.Text &
                                  "', Alamat ='" & txtAlamat.Text &
                                  "', Pendidikan ='" & cmbPend.Text &
                                  "', Status'" & kawin & "' where NIP = '" & "'", CNN)
        X = OlECMD.ExecuteNonQuery
        If x = 1 Then
            MsgBox("Data berhasil di edit", MsgBoxStyle.Information, "Informasi")
            Call BERSIH()
            txtNIP.Focus()
        Else
            MsgBox("Gagal Mengedit Data ", MsgBoxStyle.Exclamation, "Kesalahan")
        End If
    End Sub

    Private Sub BDelete_Click(sender As Object, e As EventArgs) Handles BDelete.Click
        If MsgBox("Ingin Menghapus data?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            CNN = New OleDb.OleDbConnection(KONEKSI)
            If CNN.state <> ConnectionState.Closed Then CNN.close()
            CNN.Open()
            OLECMD = New OleDb.OleDbCommand("Delete from Pegawai where NIP='" & txtNIP.Text & "'", CNN)
            X = OLECMD.ExecuteNonQuery
            If x = 1 Then
                Call BERSIH()
                BSave.Enabled = True
                BEdit.Enabled = False
                BDelete.Enabled = False
                txtNIP.Focus()
            Else
                MsgBox("Gagal menghapus data", MsgBoxStyle.Exclamation, "Kesalahan")
            End If
        End If
    End Sub

    Private Sub BExit_Click(sender As Object, e As EventArgs) Handles BExit.Click
        Me.Dispose()
    End Sub

    Private Sub BCari_Click(sender As Object, e As EventArgs) Handles BCari.Click
        Dim poppegawai As New Poppeg
        poppegawai.showdialog()
        If poppegawai.colNama <> "" Then
            txtNIP.Text = poppegawai.colNIP
            txtNama.Text = poppegawai.colNama
            cmbBgn.Text = poppegawai.colBgn
            DTglLhr.Text = poppegawai.colTglLhr
            txtAlamat.Text = poppegawai.colAlamat
            cmbPend.Text = poppegawai.colpend
            If poppegawai.colstatus = "Kawin" Then
                RKwn.Checked = True
            Else
                RKwn.Checked = False
            End If
            txtNIP.Enabled = True
            txtNama.Focus()
        End If
        BEdit.Enabled = True
        BDelete.Enabled = True
    End Sub

    Private Sub txtNIP_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNIP.KeyDown
        If Asc(e.KeyCode) = 13 Then
            cmbBgn.Focus()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
