Public Class Form1
    Dim f2 As Form2 = New Form2
    Dim f3 As Form3 = New Form3
    Dim f4 As Form4 = New Form4
    Dim f5 As Form5 = New Form5
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If f2.IsDisposed Then
            f2 = New Form2
        Else
            f2.Show()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If f3.IsDisposed Then
            f3 = New Form3
        Else
            f3.Show()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If f4.IsDisposed Then
            f4 = New Form4
        Else
            f4.Show()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If f5.IsDisposed Then
            f5 = New Form5
        Else
            f5.Show()
        End If
    End Sub
End Class
