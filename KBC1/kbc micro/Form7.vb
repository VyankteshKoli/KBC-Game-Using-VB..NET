Imports System.Windows
Imports System.Windows.Forms.DataFormats

Public Class Form7
    Dim a As Integer = 30
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = a

        Label13.Hide()
        Button5.Hide()

        My.Computer.Audio.Play("D:\POLYTECHNIC ALL\Projects\KBC1\resources\kbcstart.wav")
        System.Threading.Thread.Sleep(1000)

        My.Computer.Audio.Play("D:\POLYTECHNIC ALL\Projects\KBC1\resources\timer.wav")
        PictureBox6.Hide()

        PictureBox9.Hide()
        PictureBox8.Hide()
        PictureBox10.Hide()
        PictureBox7.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Label1.Hide()
        Button1.BackColor = Color.Green
        Label13.Show()
        Me.Timer1.Stop()
        My.Computer.Audio.Stop()
        Button5.Show()
        My.Computer.Audio.Play("D:\POLYTECHNIC ALL\Projects\KBC1\resources\KBC Clapping.wav")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Play("D:\POLYTECHNIC ALL\Projects\KBC1\resources\kbcque.wav")
        Form12.Show()
        Form11.Label4.Text = Form6.Label6.Text()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Audio.Play("D:\POLYTECHNIC ALL\Projects\KBC1\resources\kbcque.wav")
        Form12.Show()
        Form11.Label4.Text = Form6.Label6.Text()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Computer.Audio.Play("D:\POLYTECHNIC ALL\Projects\KBC1\resources\kbcque.wav")
        Form12.Show()
        Form11.Label4.Text = Form6.Label6.Text()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
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

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PictureBox3.Image = Image.FromFile("D:\POLYTECHNIC ALL\Projects\KBC1\resources\lifeline.png")

        My.Computer.Audio.Stop()
        Timer1.Stop()
        Label1.Hide()

        Button2.Hide()
        Button3.Hide()

        Form8.PictureBox1.Hide()
        Form8.PictureBox2.Show()
        Form9.PictureBox1.Hide()
        Form9.PictureBox2.Show()
        Form10.PictureBox6.Hide()
        Form10.PictureBox5.Show()

        Timer1.Start()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        PictureBox4.Image = Image.FromFile("D:\POLYTECHNIC ALL\Projects\KBC1\resources\usepoll.jpg")
        My.Computer.Audio.Play("D:\POLYTECHNIC ALL\Projects\KBC1\resources\Audiencepole.wav")
        '   My.Computer.Audio.Stop()
        Timer1.Stop()
        Label1.Hide()

        PictureBox6.Show()

        PictureBox9.Show()
        PictureBox8.Show()
        PictureBox10.Show()
        PictureBox7.Show()

        Form8.PictureBox3.Hide()
        Form8.PictureBox5.Show()
        Form9.PictureBox3.Hide()
        Form9.PictureBox5.Show()
        Form10.PictureBox9.Hide()
        Form10.PictureBox8.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form8.Show()
        Me.Hide()
    End Sub
End Class