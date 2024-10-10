Imports System.Windows

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "" And TextBox2.Text = "") Then
            MsgBox("LOGIN DONE")
            Form2.Show()

            Me.Hide()
        Else
            MsgBox("INVALID LOGIN...")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
