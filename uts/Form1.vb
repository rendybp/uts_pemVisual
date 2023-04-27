Public Class Form1
    Dim harga As Integer
    Dim totalBayar As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hargaInput.ReadOnly = True
        jumlahInput.ReadOnly = True
        totalHargaOutput.ReadOnly = True
        totalBayarOutput.ReadOnly = True
        diskonOutput.ReadOnly = True
        bayarInput.ReadOnly = True
        kembalianOutput.ReadOnly = True
        btnProses.Enabled = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles jenisPaket.SelectedIndexChanged
        jumlahInput.ReadOnly = False
        jumlahInput.Text = ""
        If jenisPaket.Text.Trim = "" Then
            jumlahInput.Text = ""
            hargaInput.Text = ""
            jumlahInput.ReadOnly = True
        End If
        Select Case jenisPaket.Text.Trim.ToUpper
            Case "REGULER"
                harga = 6000
                hargaInput.Text = harga
            Case "VIP"
                harga = 10000
                hargaInput.Text = harga
            Case "BATTLE ARENA"
                harga = 13000
                hargaInput.Text = harga
        End Select
    End Sub

    Private Sub jumlahInput_TextChanged(sender As Object, e As EventArgs) Handles jumlahInput.TextChanged
        Dim jumlah As Integer
        Dim totalHarga As Integer
        Dim diskon As Integer
        If jumlahInput.Text.Trim = "" Then
            totalHargaOutput.Text = ""
            diskonOutput.Text = ""
            totalBayarOutput.Text = ""
            bayarInput.Text = ""
            bayarInput.ReadOnly = True
        End If
        If IsNumeric(jumlahInput.Text) Then
            jumlah = CInt(jumlahInput.Text)
            totalHarga = jumlah * harga
            totalHargaOutput.Text = totalHarga
            diskon = (5 / 100) * totalHarga
            diskonOutput.Text = diskon
            totalBayar = totalHarga - diskon
            totalBayarOutput.Text = totalBayar
            bayarInput.ReadOnly = False
        End If
    End Sub

    Private Sub jumlahInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jumlahInput.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub bayarInput_TextChanged(sender As Object, e As EventArgs) Handles bayarInput.TextChanged
        btnProses.Enabled = True
        If bayarInput.Text.Trim = "" Then
            btnProses.Enabled = False
        End If
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Dim bayar As Integer
        Dim kembalian As Integer
        If IsNumeric(bayarInput.Text) Then
            bayar = CInt(bayarInput.Text)
            If bayar >= totalBayar Then
                kembalian = bayar - totalBayar
                kembalianOutput.Text = kembalian
            Else
                MessageBox.Show("Maaf Uang Anda Kurang Bro", "PERINGATAN")
                bayarInput.Text = ""
                kembalianOutput.Text = ""
                bayarInput.Focus()
            End If
        End If
    End Sub

    Private Sub btnUlangi_Click(sender As Object, e As EventArgs) Handles btnUlangi.Click
        jenisPaket.Text = ""
        hargaInput.Text = ""
        jumlahInput.Text = ""
        bayarInput.Text = ""
        kembalianOutput.Text = ""
        jumlahInput.ReadOnly = True
        btnProses.Enabled = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
