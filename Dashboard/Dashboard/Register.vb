Imports System.Data.OleDb
Public Class Register

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.DarkViolet
        PasswordError.Visible = False
    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        ' Check length
        If UserNameInput.TextLength <= 0 Then
            MessageBox.Show("Please enter your Username to login", "University Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UserNameInput.Focus()
            Return
        ElseIf PasswordInput.TextLength <= 0 Then
            MessageBox.Show("Please enter your Password to login", "University Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PasswordInput.Focus()
            Return
        End If

        ' Check if passwords match
        If PasswordInput.Text = ConfirmPasswordInput.Text Then
            ' If passwords match
            Dim username As String = UserNameInput.Text
            Dim password As String = PasswordInput.Text

            Dim dbConString As String = My.Settings.AccountsConnectionString
            Dim dbCon As New OleDbConnection(dbConString)

            ' Open connection
            dbCon.Open()

            Dim dbCmd As OleDbCommand = New OleDbCommand("INSERT INTO users ([username], [password]) VALUES (@username, @password)", dbCon)
            dbCmd.Parameters.AddWithValue("@username", username)
            dbCmd.Parameters.AddWithValue("@password", password)
            ' Execute Query
            dbCmd.ExecuteNonQuery()
            ' Close Connection - Registration complete

            ' Open Log In Page
            LogIn.UserNameInput.Text = ""
            LogIn.PasswordInput.Text = ""
            LogIn.Show()
            ' Close Current Page
            Me.Hide()

        Else
            PasswordError.Visible = True
        End If
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Hide()
        ' Clear any old values and open LogIn
        LogIn.UserNameInput.Text = ""
        LogIn.PasswordInput.Text = ""
        LogIn.Show()
    End Sub
End Class