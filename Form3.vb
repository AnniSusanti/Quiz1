Public Class Form3

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        TextNIM.Text = ""
        TextNama.Text = ""
        TextKelas.Text = ""
        TextTugas.Text = ""
        TextUTS.Text = ""
        TextUAS.Text = ""
        TextAngka.Text = ""
        TextHuruf.Text = ""
        TextKomentar.Text = ""
        TextNama.Focus()
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        End
    End Sub

    Private Sub BtnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHitung.Click
        Dim NIM As String
        Dim Nama As String
        Dim Kelas As String
        Dim Tugas As Double
        Dim UTS As Double
        Dim UAS As Double
        Dim Nilai As Double
        Dim Huruf As String
        Dim Angka As Double
        Dim Komentar As String
        NIM = TextNIM.Text
        Nama = TextNama.Text
        Kelas = TextKelas.Text
        Tugas = Val(TextTugas.Text)
        UTS = Val(TextUTS.Text)
        UAS = Val(TextUAS.Text)
        Nilai = (0.2 * Tugas + 0.3 * UTS + 0.5 * UAS)
        TextAngka.Text = Nilai

        If Nilai <= 56 Then
            Huruf = "E"
            Komentar = "Nilai Anda Sangat kurang! Maaf, Anda Gagal! :'("
        ElseIf Nilai <= 65 Then
            Huruf = "D"
            Komentar = "Nilai Anda Kurang! Maaf, Maaf, Anda Gagal! :("
        ElseIf Nilai <= 75 Then
            Huruf = "C"
            Komentar = "Nilai Anda Cukup! Anda Lulus, tingkatkan lagi! :|"
        ElseIf Nilai <= 85 Then
            Huruf = "B"
            Komentar = "Nilai Anda Baik! Anda Lulus, Pertahankan! :)"
        ElseIf Nilai > 85 Then
            Huruf = "A"
            Komentar = "Nilai Anda Sangat Baik! Anda Lulus, Selamat! :')"
        End If
        TextHuruf.Text = Huruf
        TextKomentar.Text = Komentar
    End Sub
End Class