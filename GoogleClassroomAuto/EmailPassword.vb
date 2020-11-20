Imports System.IO
Public Class EmailPassword
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim St As StreamWriter = New StreamWriter("tarc_email.txt")
        St.WriteLine(EmailBox.Text)
        St.Close()

        St = New StreamWriter("tarc_password.txt")
        St.WriteLine(PasswordBox.Text)
        St.Close()

        Me.Close()

        EmailBox.Text = ""
        PasswordBox.Text = ""

        Form1.statusbox.ForeColor = Color.Green
        Form1.statusbox.Text = "email and password added"
    End Sub
End Class