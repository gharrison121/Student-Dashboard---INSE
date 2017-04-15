Imports System.Data.OleDb

Public Class LogIn

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.DarkViolet
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
        If usernameInp.TextLength <= 0 Then
            MessageBox.Show("Please enter your Username to login", "University Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UserNameInput.Focus()
            Return
        ElseIf passwordInp.TextLength <= 0 Then
            MessageBox.Show("Please enter your Password to login", "University Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PasswordInput.Focus()
            Return
        End If
        ' now that we know there's appropriate data, lets verify it
        If VerifyCredentials(username, password) Then
            Main.Show()
            Me.Hide()

        Else
            LogInError.Visible = True
            usernameInp.Text = ""
            passwordInp.Text = ""
            usernameInp.Focus()
        End If
    End Sub

    Public Function VerifyCredentials(username As String, password As String) As Boolean
        ' Here is where login details are verified against the MS Access Database
        ' Currently DB is local but could be hosted on a server
        Dim dbConString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & Environment.CurrentDirectory & "\Accounts.mdb"
        Dim dbCon As New OleDbConnection(dbConString)
        Dim dbCmd As OleDbCommand = New OleDbCommand("SELECT * FROM users WHERE username = '" & username & "' AND password = '" & password & "' ", dbCon)
        dbCon.Open()

        Dim sdr As OleDbDataReader = dbCmd.ExecuteReader()
        ' If the given username and password exists in users
        If (sdr.Read() = True) Then
            Return True
        Else
            Return False
        End If

        ' Old test validation
        ' Return username.Equals("up787321") And password.Equals("hey")
    End Function

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Me.Hide()
        ' Open Log In Page
        Dim newRegister As Register
        newRegister = New Register()
        newRegister.Show()
        newRegister.Show()
    End Sub

End Class