
Public Class Form1
    Dim Connect As Integer          'число 
    Dim Classes(6, 5) As String     'матрица переменных, содержащая информацию о парах
    Dim Temp(2) As Integer          'временная матрица, содержащая информацию о сегодняшних парах
    Dim j As Integer = 0
    Dim Number_Week As Integer
    Dim Name_Day As String
    Dim D As Date
    Private Sub Init()
        Classes(0, 0) = "Теория принятия решений"
        Classes(0, 1) = "Михеев Игорь Михайлович"
        Classes(0, 2) = "9:20 - 10:55"
        Classes(0, 3) = 2
        Classes(0, 4) = "Ср"
        Classes(0, 5) = "https://us04web.zoom.us/j/9827675567?pwd=VG9wNVlTcmVKVXBxTE9XOWxYc0NsQT09"
        Classes(1, 0) = "Лекция ЭПРиМ"
        Classes(1, 1) = "Сафонов Юрий Михайлович"
        Classes(1, 2) = "11:10 - 12:45"
        Classes(1, 3) = 2
        Classes(1, 4) = "Ср"
        Classes(1, 5) = "https://mpei.webex.com/mpei/j.php?MTID=mcfa19abd12e5543130f333971b414e17"
        Classes(2, 0) = "Практика ЭПРиМ"
        Classes(2, 1) = "Сафонов Юрий Михайлович"
        Classes(2, 2) = "13:45 - 15:20"
        Classes(2, 3) = 0
        Classes(2, 4) = "Ср"
        Classes(2, 5) = "https://mpei.webex.com/mpei/j.php?MTID=m95700e2ca550474fdb678a9838ff9dbd"
        Classes(3, 0) = "Инф. и комп. техн. в ЭП"
        Classes(3, 1) = "Рассудов Лев Николаевич"
        Classes(3, 2) = "13:45 - 15:20"
        Classes(3, 3) = 1
        Classes(3, 4) = "Ср"
        Classes(3, 5) = "https://us02web.zoom.us/j/6937908410?pwd=dVFIS2ZwV0poRVhJV1REMTRIUnA3Zz09"
        Classes(4, 0) = "СУЭП"
        Classes(4, 1) = "Анучин Алексей Сергеевич"
        Classes(4, 2) = "9:20 - 10:55"
        Classes(4, 3) = 2
        Classes(4, 4) = "Пт"
        Classes(4, 5) = "https://mpei.webex.com/mpei/j.php?MTID=m02d392302b4e4a356ca9ccb2f30e4cd3"
        Classes(5, 0) = "Типовые решения в ЭП"
        Classes(5, 1) = "Осипов Олег Иванович"
        Classes(5, 2) = "11:10 - 12:45"
        Classes(5, 3) = 2
        Classes(5, 4) = "Пт"
        Classes(5, 5) = "https://google.ru"
        Classes(6, 0) = "Иностранный язык"
        Classes(6, 1) = "Лопаткина Ирина Александровна"
        Classes(6, 2) = "13:45 - 15:20"
        Classes(6, 3) = 2
        Classes(6, 4) = "Пт"
        Classes(6, 5) = "https://mpei.webex.com/mpei/j.php?MTID=mda4a703403d644c1bd474ea407d9b7f3"
        Label2.Text = Format(D, "dddd, dd MMMM")
        Label12.Text = Format(D, "HH:mm")
        Number_Week = DatePart("ww", D)
        Number_Week = Number_Week Mod 2
        Name_Day = Format(D, "ddd")
    End Sub
    Private Sub Dstr()
        If (j > 0) Then
            Name1.Text = Classes(Temp(0), 0)
            Time1.Text = Classes(Temp(0), 2)
            Prof1.Text = Classes(Temp(0), 1)
            Name2.Text = Classes(Temp(1), 0)
            Time2.Text = Classes(Temp(1), 2)
            Prof2.Text = Classes(Temp(1), 1)
            Name3.Text = Classes(Temp(2), 0)
            Time3.Text = Classes(Temp(2), 2)
            Prof3.Text = Classes(Temp(2), 1)
            If (Format(D, "HH:mm") <= "09:09") Then
                Label2.Text = Format(D, "dddd, dd MMMM") + ", пары скоро начнутся"
            ElseIf ((Format(D, "HH:mm") >= "09:10") And (Format(D, "HH:mm") <= "09:19")) Then
                Label13.Text = "<Начинается>"
                Label13.Visible = True
                GroupBox2.ForeColor = SystemColors.ControlDark
                GroupBox3.ForeColor = SystemColors.ControlDark
                Connect = 0
                Button1.Enabled = True
            ElseIf ((Format(D, "HH:mm") >= "09:20") And (Format(D, "HH:mm") <= "10:55")) Then
                Label13.Text = "<Идёт>"
                Label13.Visible = True
                GroupBox2.ForeColor = SystemColors.ControlDark
                GroupBox3.ForeColor = SystemColors.ControlDark
                Connect = 0
                Button1.Enabled = True
            ElseIf ((Format(D, "HH:mm") >= "10:56") And (Format(D, "HH:mm") <= "11:09")) Then
                Label14.Text = "<Начинается>"
                Label14.Visible = True
                GroupBox1.ForeColor = SystemColors.ControlDark
                GroupBox3.ForeColor = SystemColors.ControlDark
                Connect = 1
                Button1.Enabled = True
            ElseIf ((Format(D, "HH:mm") >= "11:10") And (Format(D, "HH:mm") <= "12:45")) Then
                Label14.Text = "<Идёт>"
                Label14.Visible = True
                GroupBox1.ForeColor = SystemColors.ControlDark
                GroupBox3.ForeColor = SystemColors.ControlDark
                Connect = 1
                Button1.Enabled = True
            ElseIf ((Format(D, "HH:mm") >= "12:46") And (Format(D, "HH:mm") <= "13:34")) Then
                Label15.Text = "<Скоро начнётся>"
                Label15.Visible = True
                GroupBox1.ForeColor = SystemColors.ControlDark
                GroupBox2.ForeColor = SystemColors.ControlDark
            ElseIf ((Format(D, "HH:mm") >= "13:35") And (Format(D, "HH:mm") <= "13:44")) Then
                Label15.Text = "<Начинается>"
                Label15.Visible = True
                GroupBox1.ForeColor = SystemColors.ControlDark
                GroupBox2.ForeColor = SystemColors.ControlDark
                Connect = 2
                Button1.Enabled = True
            ElseIf ((Format(D, "HH:mm") >= "13:45") And (Format(D, "HH:mm") <= "15:20")) Then
                Label15.Text = "<Идёт>"
                Label15.Visible = True
                GroupBox1.ForeColor = SystemColors.ControlDark
                GroupBox2.ForeColor = SystemColors.ControlDark
                Connect = 2
                Button1.Enabled = True
            Else
                Label2.Text = Format(D, "dddd, dd MMMM") + ", пары кончились"
                GroupBox1.ForeColor = SystemColors.ControlDark
                GroupBox2.ForeColor = SystemColors.ControlDark
                GroupBox3.ForeColor = SystemColors.ControlDark
            End If
        Else
            Label2.Text = Format(D, "dddd, dd MMMM") + ", пар нет"
            GroupBox1.Visible = False
            GroupBox2.Visible = False
            GroupBox3.Visible = False
            Button1.Enabled = False
        End If
    End Sub
    Private Sub Clear()
        GroupBox1.ForeColor = SystemColors.ControlText
        GroupBox2.ForeColor = SystemColors.ControlText
        GroupBox3.ForeColor = SystemColors.ControlText
        GroupBox1.Visible = True
        GroupBox2.Visible = True
        GroupBox3.Visible = True
        Label13.Visible = False
        Label14.Visible = False
        Label15.Visible = False
        Button1.Enabled = False
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Timer1.Tick
        Dim New_Font As Font = New Font(Me.GroupBox1.Font, FontStyle.Bold)
        D = Now
        j = 0
        'для отладки:
        'D = "26.03.2021 11:14:34"
        Init()
        For i As Integer = 0 To 6
            If ((Classes(i, 4) = Name_Day) And ((Classes(i, 3) = Number_Week) Or (Classes(i, 3) = 2))) Then
                Temp(j) = i
                j += 1
            End If
        Next
        Clear()
        Dstr()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ((Prof3.Text = "Рассудов Лев Николаевич") And (Connect = 2)) Then
            Form2.ShowDialog()
            System.Diagnostics.Process.Start(Classes(Temp(Connect), 5))
        ElseIf ((Prof2.Text = "Осипов Олег Иванович") And (Connect = 1)) Then
            Form4.ShowDialog()
        Else
            System.Diagnostics.Process.Start(Classes(Temp(Connect), 5))
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.ShowDialog()
    End Sub
End Class
