Public Class Form5

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmbJenis.Items.Clear() 'Fungsi untuk mengahapus item yang ada didalam combobox ketika  form pertama dijalankan
        CmbJenis.Items.Add("Toyota Avanza") 'Fungsi untuk menambah item didalam combobox
        CmbJenis.Items.Add("Toyota Calya")
        CmbJenis.Items.Add("Toyota Inova")
        CmbJenis.Items.Add("Daihatsu Xenia")
        CmbJenis.Items.Add("Daihatsu Sigra")
        CmbJenis.Items.Add("Honda Brio")
        CmbJenis.Items.Add("Honda Mobilio")
        CmbJenis.Items.Add("Mitsubishi Xpander")
        cmbTambahan.Items.Add("Dengan Supir")
        cmbTambahan.Items.Add("Tidak Dengan Supir")
        Call ListMobil()
        Call Simpan()
    End Sub
    Sub Simpan()
        Dim Si As New ListViewItem
        Si.Text = TextBox1.Text
        Si.SubItems.Add(TextBox2.Text)
        Si.SubItems.Add(TextBox3.Text)
        Si.SubItems.Add(CmbJenis.Text)
        Si.SubItems.Add(txtHarga.Text)
        Si.SubItems.Add(txtLama.Text)
        Si.SubItems.Add(cmbTambahan.Text)
        Si.SubItems.Add(txtTambahan.Text)
        Si.SubItems.Add(txtBiaya.Text)
        ListView1.Items.Add(Si)
    End Sub
    Sub ListMobil()
        ListView1.Columns.Add("No Identitas", 80, HorizontalAlignment.Center)
        ListView1.Columns.Add("Nama", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("No Telepon", 80, HorizontalAlignment.Center)
        ListView1.Columns.Add("Jenis Mobil", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Harga Sewa Perhari", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Tipe Layanan", 80, HorizontalAlignment.Center)
        ListView1.Columns.Add("Lama Sewa", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Biaya Tambahan", 80, HorizontalAlignment.Center)
        ListView1.Columns.Add("Total Biaya", 80, HorizontalAlignment.Center)
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.FullRowSelect = True
    End Sub
    Private Sub CmbJenis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbJenis.SelectedIndexChanged
        If CmbJenis.Text = "Toyota Avanza" Then
            txtHarga.Text = "240000"
        ElseIf CmbJenis.Text = "Toyota Calya" Then
            txtHarga.Text = "210000"
        ElseIf CmbJenis.Text = "Toyota Inova" Then
            txtHarga.Text = "340000"
        ElseIf CmbJenis.Text = "Daihatsu Xenia" Then
            txtHarga.Text = "230000"
        ElseIf CmbJenis.Text = "Daihatsu Sigra" Then
            txtHarga.Text = "200000"
        ElseIf CmbJenis.Text = "Honda Brio" Then
            txtHarga.Text = "230000"
        ElseIf CmbJenis.Text = "Honda Mobilio" Then
            txtHarga.Text = "240000"
        ElseIf CmbJenis.Text = "Mitsubishi Xpander" Then
            txtHarga.Text = "300000"

        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTambahan.SelectedIndexChanged
        If cmbTambahan.Text = "Dengan Supir" Then
            txtTambahan.Text = "150000"
        ElseIf cmbTambahan.Text = "Tidak Dengan Supir" Then
            txtTambahan.Text = "0"
        End If
    End Sub

    Private Sub Hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hitung.Click
        txtBiaya.Text = txtHarga.Text * txtLama.Text + txtTambahan.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Pesan As String
        Pesan = MsgBox("Apakah anda ingin menyimpan data ini?", MsgBoxStyle.YesNo, "Konfirmasi")
        If Pesan = vbYes Then
            Call Simpan()
        Else
            Exit Sub
        End If
    End Sub
End Class