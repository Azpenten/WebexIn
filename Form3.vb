Public Class Form3
    Dim URL(5) As String
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        URL(0) = "https://us04web.zoom.us/j/9827675567?pwd=VG9wNVlTcmVKVXBxTE9XOWxYc0NsQT09"
        URL(1) = "https://mpei.webex.com/mpei/j.php?MTID=mcfa19abd12e5543130f333971b414e17"
        URL(2) = "https://mpei.webex.com/mpei/j.php?MTID=m95700e2ca550474fdb678a9838ff9dbd"
        URL(3) = "https://us02web.zoom.us/j/6937908410?pwd=dVFIS2ZwV0poRVhJV1REMTRIUnA3Zz09"
        URL(4) = "https://mpei.webex.com/mpei/j.php?MTID=m02d392302b4e4a356ca9ccb2f30e4cd3"
        URL(5) = "https://mpei.webex.com/mpei/j.php?MTID=mda4a703403d644c1bd474ea407d9b7f3"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start(URL(0))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start(URL(1))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start(URL(2))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.ShowDialog()
        System.Diagnostics.Process.Start(URL(3))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        System.Diagnostics.Process.Start(URL(4))
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        System.Diagnostics.Process.Start(URL(5))
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form4.ShowDialog()
    End Sub
End Class