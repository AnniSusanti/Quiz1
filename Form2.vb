Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i, bawah, atas As Long
        lsthasil.ClearSelected()
        bawah = txtbawah.Text
        atas = txtatas.Text
        For i = bawah To atas
            If i Mod 2 <> 0 Then
                lsthasil.Items.Add(i)
            End If
        Next i
        txtbawah.Enabled = False
        txtatas.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i, bawah, atas As Long
        lsthasil.ClearSelected()
        bawah = txtbawah.Text
        atas = txtatas.Text
        For i = bawah To atas
            If i Mod 2 = 0 Then
                lsthasil.Items.Add(i)
            End If
        Next i
        txtbawah.Enabled = False
        txtatas.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txtbawah.Text = ""
        txtatas.Text = ""
        lsthasil.ClearSelected()
        txtbawah.Enabled = True
        txtatas.Enabled = True
    End Sub
End Class