Public Class LogIn

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.DarkViolet
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles UserNameInput.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub LogInButton_Click(sender As Object, e As EventArgs) Handles LogInButton.Click
        If UserNameInput.Text = "" Then
            MessageBox.Show("Please enter your Student Id to login", "Portsmouth University", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UserNameInput.Focus()
        ElseIf PasswordInput.Text = "" Then
            MessageBox.Show("Please enter your Password to login", "Portsmouth University", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PasswordInput.Focus() 
        ElseIf UserNameInput.Text = "up787321" And PasswordInput.Text = "hey" Then
            Me.Hide()
            Main.Show()
            Main.Username.Text = UserNameInput.Text
        Else
            LogInError.Visible = True
            UserNameInput.Text = ""
            PasswordInput.Text = ""
            UserNameInput.Focus()
        End If
    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Me.Hide()
        Register.Show()
    End Sub

    Private Sub PasswordInput_TextChanged(sender As Object, e As EventArgs) Handles PasswordInput.TextChanged

    End Sub
End Class