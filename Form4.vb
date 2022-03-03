Public Class Form4
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("https://mail.mpei.ru/CookieAuth.dll?GetLogon?curl=Z2FowaZ2F&reason=0&formdir=2")
    End Sub
End Class