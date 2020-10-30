Public Class Form16
    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtHasilAbsen.Enabled = False
        txtHasilTugas.Enabled = False
        txtHasilUts.Enabled = False
        txtHasilUas.Enabled = False

        txtNilaiAbsen.TabIndex = 0
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNilaiAbsen.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles txtHasilAbsen.TextChanged, txtHasilAbsen.TextChanged
        txtHasilAbsen.Text = 0.1 * Val(txtNilaiAbsen.Text)
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtHasilTugas.TextChanged
        txtHasilTugas.Text = 0.2 * Val(txtNilaiTugas.Text)
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles txtHasilUts.TextChanged
        txtHasilUts.Text = 0.3 * Val(txtNilaiUts.Text)
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles txtHasilUas.TextChanged
        txtHasilUas.Text = 0.4 * Val(txtNilaiUas.Text)
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles txtTotalNilai.TextChanged
        txtTotalNilai.Text = Val(txtHasilAbsen.Text) + Val(txtHasilTugas.Text) + Val(txtHasilUts.Text) + Val(txtHasilUas.Text)

        If txtTotalNilai.Text >= 80 And txtTotalNilai.Text <= 100 Then txtTotalGrade.Text = "A" Else
        If txtTotalNilai.Text >= 69 And txtTotalNilai.Text <= 78 Then txtTotalGrade.Text = "B" Else
        If txtTotalNilai.Text >= 56 And txtTotalNilai.Text <= 68 Then txtTotalGrade.Text = "C" Else
        If txtTotalNilai.Text >= 40 And txtTotalNilai.Text <= 55 Then txtTotalGrade.Text = "D" Else
        If txtTotalNilai.Text >= 36 And txtTotalNilai.Text <= 45 Then txtTotalGrade.Text = "E" Else


    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles txtTotalGrade.TextChanged
        If txtTotalNilai.Text >= 80 And txtTotalNilai.Text <= 100 Then txtTotalGrade.Text = "A" Else
        If txtTotalNilai.Text >= 69 And txtTotalNilai.Text <= 78 Then txtTotalGrade.Text = "B" Else
        If txtTotalNilai.Text >= 56 And txtTotalNilai.Text <= 68 Then txtTotalGrade.Text = "C" Else
        If txtTotalNilai.Text >= 40 And txtTotalNilai.Text <= 55 Then txtTotalGrade.Text = "D" Else
        If txtTotalNilai.Text >= 36 And txtTotalNilai.Text <= 45 Then txtTotalGrade.Text = "E" Else



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtNilaiAbsen.Text = ""
        txtNilaiTugas.Text = ""
        txtNilaiUts.Text = ""
        txtNilaiUas.Text = ""
        txtHasilAbsen.Text = ""
        txtHasilTugas.Text = ""
        txtHasilUts.Text = ""
        txtHasilUas.Text = ""
        txtTotalNilai.Text = ""
        txtTotalGrade.Text = ""
        TxtKet.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdHitung.Click
        txtHasilAbsen.Text = 0.1 * Val(txtNilaiAbsen.Text)
        txtHasilTugas.Text = 0.2 * Val(txtNilaiTugas.Text)
        txtHasilUts.Text = 0.3 * Val(txtNilaiUts.Text)
        txtHasilUas.Text = 0.4 * Val(txtNilaiUas.Text)

        txtTotalNilai.Text = Val(txtHasilAbsen.Text) + Val(txtHasilTugas.Text) + Val(txtHasilUts.Text) + Val(txtHasilUas.Text)

        If txtTotalNilai.Text >= 80 And txtTotalNilai.Text <= 100 Then txtTotalGrade.Text = "A" Else
        If txtTotalNilai.Text >= 69 And txtTotalNilai.Text <= 79 Then txtTotalGrade.Text = "B" Else
        If txtTotalNilai.Text >= 56 And txtTotalNilai.Text <= 68 Then txtTotalGrade.Text = "C" Else
        If txtTotalNilai.Text >= 40 And txtTotalNilai.Text <= 55 Then txtTotalGrade.Text = "D" Else
        txtTotalGrade.Text = "E"


        Dim ket As String
        ket = ""
        If txtTotalNilai.Text >= 60 Then
            TxtKet.Text = "Anda Lulus"
        Else
            TxtKet.Text = "Anda Gagal"
        End If

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim keluar As MsgBoxResult
        keluar = MsgBox("Apakan anda akan keluar?", MsgBoxStyle.YesNo, "Peringatan")
        If keluar = MsgBoxResult.Yes Then Else
        Close()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Ket_TextChanged(sender As Object, e As EventArgs) Handles TxtKet.TextChanged

    End Sub
End Class