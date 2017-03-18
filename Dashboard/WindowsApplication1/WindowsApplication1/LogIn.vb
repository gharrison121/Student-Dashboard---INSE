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
        LogIn(UserNameInput, PasswordInput)
    End Sub

    Public Sub LogIn(usernameInp As TextBox, passwordInp As TextBox)
        ' lets grab our user's credentials
        Dim username As String = usernameInp.Text
        Dim password As String = passwordInp.Text
        ' first we'll make sure we have a valid input, and if not ask 
        ' the user to correct it
        If passwordInp.TextLength <= 0 Then
            MessageBox.Show("Please enter your Student Id to login", "Portsmouth University", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UserNameInput.Focus()
            Return
        ElseIf passwordInp.TextLength <= 0 Then
            MessageBox.Show("Please enter your Password to login", "Portsmouth University", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PasswordInput.Focus()
            Return
        End If
        ' now that we know there's appropriate data, lets verify it
        If VerifyCredentials(username, password) Then
            Me.Hide()
            Main.Show()
            Main.Username.Text = username
        Else
            LogInError.Visible = True
            usernameInp.Text = ""
            passwordInp.Text = ""
            usernameInp.Focus()
        End If
    End Sub

    Public Function VerifyCredentials(username As String, password As String) As Boolean
        Return username.Equals("up787321") And password.Equals("hey")
    End Function

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Me.Hide()
        Register.Show()
    End Sub

    Private Sub PasswordInput_TextChanged(sender As Object, e As EventArgs) Handles PasswordInput.TextChanged

    End Sub
End Class