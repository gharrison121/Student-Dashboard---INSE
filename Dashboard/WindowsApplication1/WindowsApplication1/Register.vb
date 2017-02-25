Public Class Register

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.DarkViolet
        PasswordError.Hide()
    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        If PasswordInput.Text = ConfirmPasswordInput.Text Then
            Me.Hide()
            Main.Show()
            Main.Username.Text = UserNameInput.Text
        Else
            PasswordError.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        LogIn.Show()
    End Sub
End Class