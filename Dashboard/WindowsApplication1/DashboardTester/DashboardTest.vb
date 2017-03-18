Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Windows
Imports StudentDashboard

<TestClass()> Public Class DashboardTest

    ' Represents a dummy and theoretical environment of our application and its forms, 
    ' providing a class instance of data tracked by the title o the form - may access 
    ' data using the below GetForm(title) function
    Dim TestForms(,) As Object = New Object(,) {
        {"Bus", New Bus},
        {"Log In", New LogIn},
        {"Main", New Main},
        {"NewClass", New NewClass},
        {"Register", New Register},
        {"Reminder", New Reminder},
        {"Timetable", New Timetable}
    }

    'Private Sub InitForms()
    '    Dim index As Integer = 0
    '    TestForms(index, index) = {"Bus", New Bus}
    '    index = index + 1
    '    TestForms(index, index) = {"Log In", New LogIn}
    '    index = index + 1
    '    TestForms(index, index) = {"Main", New Main}
    '    index = index + 1
    '    TestForms(index, index) =
    '    index = index + 1
    '    TestForms(index, index) = {"Register", New Register}
    '    index = index + 1
    '    TestForms(index, index) = {"Reminder", New Reminder}
    '    index = index + 1
    '    TestForms(index, index) = {"Timetable", New Timetable}
    'End Sub

    ' Allows us to grab a form of choice from our dummy environment, using the 
    ' title of the form desired
    Private Function GetForm(title As String)
        For Each element As Object In TestForms
            Dim name As String = element(0)
            If name.Equals(title) Then
                Dim src = element(1)
                Return src
            End If
        Next
        Return Nothing
    End Function

    <TestMethod()> Public Sub TestLogIn()
        Dim logIn As LogIn = GetForm("LogIn") ' get the log in form
        ' generate some test data
        Dim testDataName As String = "up787321"
        Dim testDataPass As String = "hey"
        ' simulate a user entering their details into the form
        logIn.UserNameInput.Text = testDataName
        logIn.PasswordInput.Text = testDataPass
        Assert.AreEqual(testDataName, logIn.UserNameInput, True)
        Assert.AreEqual(testDataPass, logIn.PasswordInput, False)
        ' lets find out if the program likes out information..
        Assert.IsTrue(logIn.VerifyCredentials(testDataName, testDataPass))
        ' .. and lets simulate the user submitting their details
        logIn.LogIn(logIn.UserNameInput, logIn.PasswordInput)
        Assert.AreEqual(testDataName, GetForm("Main").UserName.Text())
    End Sub

    ' can't be tested until we have database or something similar
    <TestMethod()> Public Sub TestRegistration()
        Dim register As Register = GetForm("Register")

    End Sub

End Class