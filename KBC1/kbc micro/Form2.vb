Imports System.Windows
Imports Microsoft.VisualBasic.Devices

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.Threading.Thread.Sleep(0)
        Form3.Show()
        Form3.Label12.Text = Me.TextBox1.Text()
        Form4.Label12.Text = Me.TextBox1.Text()
        Form5.Label12.Text = Me.TextBox1.Text()
        Form6.Label12.Text = Me.TextBox1.Text()
        Form7.Label12.Text = Me.TextBox1.Text()
        Form8.Label12.Text = Me.TextBox1.Text()
        Form9.Label12.Text = Me.TextBox1.Text()
        Form10.Label12.Text = Me.TextBox1.Text()
        Form11.Label1.Text = Me.TextBox1.Text()
        Me.Hide()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("D:\POLYTECHNIC ALL\Projects\KBC1\resources\KBC.wav")


    End Sub
End Class