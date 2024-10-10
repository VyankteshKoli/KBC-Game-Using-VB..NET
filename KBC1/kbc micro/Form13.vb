Public Class Form13
    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("D:\POLYTECHNIC ALL\Projects\KBC1\resources\KBC Clapping.wav")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form11.Show()
        Me.Hide()
    End Sub
End Class


