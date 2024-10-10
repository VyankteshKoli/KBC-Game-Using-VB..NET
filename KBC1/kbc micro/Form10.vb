Public Class Form10
    Dim a As Integer = 30
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = a

        Label13.Hide()
        Button5.Hide()

        My.Computer.Audio.Play("D:\POLYTECHNIC ALL\Projects\KBC1\resources\kbcstart.wav")
        System.Threading.Thread.Sleep(1000)

        My.Computer.Audio.Play("D:\POLYTECHNIC ALL\Projects\KBC1\resources\timer.wav")
        PictureBox4.Hide()

        PictureBox3.Hide()
        PictureBox2.Hide()
        PictureBox1.Hide()
        PictureBox7.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        My.Computer.Audio.Play("D:\POLYTECHNIC ALL\Projects\KBC1\resources\kbcque.wav")
        Form12.Show()
        Form11.Label4.Text = Form9.Label9.Text()
        Me.Hide()
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        Form11.Label4.Text = Me.Label10.Text()

        Label1.Hide()
        Button2.BackColor = Color.Green
        Label13.Show()
        Me.Timer1.Stop()
        My.Computer.Audio.Stop()
        Button5.Show()
        My.Computer.Audio.Play("D:\POLYTECHNIC ALL\Projects\KBC1\resources\KBC Clapping.wav")
    End Sub
    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        My.Computer.Audio.Play("D:\POLYTECHNIC ALL\Projects\KBC1\resources\kbcque.wav")
        Form12.Show()
        Form11.Label4.Text = Form9.Label9.Text()
        Me.Hide()
    End Sub
    Private Sub Button4_Click_1(sender As Object, e As EventArgs)
        My.Computer.Audio.Play("D:\POLYTECHNIC ALL\Projects\KBC1\resources\kbcque.wav")
        Form12.Show()
        Form11.Label4.Text = Form9.Label9.Text()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        Timer1.Interval = 1000


        If Label1.Text = 10 Then
            Label1.ForeColor = Color.Red
            Label1.Text = Val(Label1.Text) - 1
        ElseIf Label1.Text = 0 Then
            Timer1.Enabled = False
        Else
            Label1.Text = Val(Label1.Text) - 1
        End If
    End Sub

    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs) Handles PictureBox6.Click
        PictureBox6.Image = Image.FromFile("D:\POLYTECHNIC ALL\Projects\KBC1\resources\lifeline.png")

        My.Computer.Audio.Stop()
        Timer1.Stop()
        Label1.Hide()

        Button1.Hide()
        Button3.Hide()

        Form9.PictureBox1.Hide()
        Timer1.Stop()
    End Sub

    Private Sub PictureBox9_Click_1(sender As Object, e As EventArgs) Handles PictureBox9.Click
        PictureBox2.Image = Image.FromFile("D:\POLYTECHNIC ALL\Projects\KBC1\resources\usepoll.jpg")
        My.Computer.Audio.Play("D:\POLYTECHNIC ALL\Projects\KBC1\resources\Audiencepole.wav")
        '     My.Computer.Audio.Stop()
        Timer1.Stop()
        Label1.Hide()

        PictureBox4.Show()

        PictureBox3.Show()
        PictureBox2.Show()
        PictureBox1.Show()
        PictureBox7.Show()

        Timer1.Stop()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form13.Show()
        Me.Hide()
    End Sub
End Class