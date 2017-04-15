Public Class NewClass

    Private Sub NewClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.DarkViolet
        DateLabel.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        DateLabel.BackColor = Color.DarkViolet
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Submit1.Click
        Me.Hide()
        Timetable.Gude.Visible = True
        Submit1.Visible = False
        Submit2.Visible = True
        Subject.Text = ""
        Room.Text = ""
        Time.SelectedIndex = -1
        Day.SelectedIndex = -1
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Hide()
        Subject.Text = ""
        Room.Text = ""
        Time.SelectedIndex = -1
        Day.SelectedIndex = -1
    End Sub

    Private Sub Submit2_Click(sender As Object, e As EventArgs) Handles Submit2.Click
        Me.Hide()
        Timetable.MathFun.Visible = True
        Submit2.Visible = False
        Submit3.Visible = True
        Subject.Text = ""
        Room.Text = ""
        Time.SelectedIndex = -1
        Day.SelectedIndex = -1
    End Sub

    Private Sub Submit4_Click(sender As Object, e As EventArgs) Handles Submit4.Click
        Me.Hide()
        Timetable.Inse.Visible = True
        Subject.Text = ""
        Room.Text = ""
        Time.SelectedIndex = -1
        Day.SelectedIndex = -1
    End Sub

    Private Sub Submit3_Click(sender As Object, e As EventArgs) Handles Submit3.Click
        Me.Hide()
        Timetable.Web.Visible = True
        Submit3.Visible = False
        Submit4.Visible = True
        Subject.Text = ""
        Room.Text = ""
        Time.SelectedIndex = -1
        Day.SelectedIndex = -1
    End Sub
End Class