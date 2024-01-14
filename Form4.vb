Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmbKamar.Items.Clear() 'Fungsi untuk mengahapus item yang ada didalam combobox ketika  form pertama dijalankan
        cmbKamar.Items.Add("Standart Room") 'Fungsi untuk menambah item didalam combobox
        cmbKamar.Items.Add("Superior Room")
        cmbKamar.Items.Add("Deluxe Room")
        cmbKamar.Items.Add("Suite Room")
        cmbTambahan.Items.Add("Dengan Breakfast")
        cmbTambahan.Items.Add("Tidak Dengan Breakfast")
        Call ListHotel()
        Call Simpan()
    End Sub
    Sub Simpan()
        Dim Si As New ListViewItem
        Si.Text = TextBox1.Text
        Si.SubItems.Add(TextBox2.Text)
        Si.SubItems.Add(TextBox3.Text)
        Si.SubItems.Add(TextBox4.Text)
        Si.SubItems.Add(TanggalBO.Text)
        Si.SubItems.Add(cmbKamar.Text)
        Si.SubItems.Add(txtHarga.Text)
        Si.SubItems.Add(txtlayanan.Text)
        Si.SubItems.Add(TextBox5.Text)
        Si.SubItems.Add(txtTambahan.Text)
        Si.SubItems.Add(txtTambahan.Text)
        Si.SubItems.Add(txtBiaya.Text)
        Hotel1.Items.Add(Si)
    End Sub
    Sub ListHotel()
        Hotel1.Columns.Add("No Identitas", 80, HorizontalAlignment.Center)
        Hotel1.Columns.Add("Nama", 100, HorizontalAlignment.Center)
        Hotel1.Columns.Add("No Telepon", 80, HorizontalAlignment.Center)
        Hotel1.Columns.Add("Alamat", 100, HorizontalAlignment.Center)
        Hotel1.Columns.Add("Tanggal Booking", 100, HorizontalAlignment.Center)
        Hotel1.Columns.Add("Jenis Kamar", 100, HorizontalAlignment.Center)
        Hotel1.Columns.Add("Harga Sewa Perhari", 100, HorizontalAlignment.Center)
        Hotel1.Columns.Add("Tipe Layanan", 80, HorizontalAlignment.Center)
        Hotel1.Columns.Add("Lama Menginap", 100, HorizontalAlignment.Center)
        Hotel1.Columns.Add("Biaya Tambahan", 10, HorizontalAlignment.Center)
        Hotel1.Columns.Add("Keterangan", 100, HorizontalAlignment.Center)
        Hotel1.Columns.Add("Total Biaya", 80, HorizontalAlignment.Center)
        Hotel1.GridLines = True
        Hotel1.View = View.Details
        Hotel1.FullRowSelect = True
    End Sub


    Private Sub cmbKamar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKamar.SelectedIndexChanged
        If cmbKamar.Text = "Standart Room" Then
            txtHarga.Text = "200000"
            txtlayanan.Text = "Tidak dengan Breakfast"
        ElseIf cmbKamar.Text = "Superior Room" Then
            txtHarga.Text = "300000"
            txtlayanan.Text = "Tidak dengan Breakfast"
        ElseIf cmbKamar.Text = "Deluxe Room" Then
            txtHarga.Text = "350000"
            txtlayanan.Text = "Tidak dengan Breakfast"
        ElseIf cmbKamar.Text = "Suite Room" Then
            txtHarga.Text = "550000"
            txtlayanan.Text = "dengan Breakfast"
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub cmbTambahan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTambahan.SelectedIndexChanged
        If cmbTambahan.Text = "Dengan Breakfast" Then
            txtTambahan.Text = "20000"
        ElseIf cmbTambahan.Text = "Tidak Dengan Breakfast" Then
            txtTambahan.Text = "0"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtBiaya.Text = txtHarga.Text * TextBox5.Text + txtTambahan.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        txtBiaya.Text = ""
        txtHarga.Text = ""
        txtlayanan.Text = ""
        txtTambahan.Text = ""
        cmbKamar.Text = ""
        cmbTambahan.Text = ""
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Pesan As String
        Pesan = MsgBox("Apakah anda ingin menyimpan data ini?", MsgBoxStyle.YesNo, "Konfirmasi")
        If Pesan = vbYes Then
            Call Simpan()
        Else
            Exit Sub
        End If
    End Sub
End Class