Public Class Bus

    Private Sub Bus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.DarkViolet
        Me.Location = New Point(2, 2)
        DateLabel.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        DateLabel.BackColor = Color.DarkViolet
        Weekend.Visible = False
        Langstone.Visible = False
        OffTerm.Visible = False
        Weekday.Visible = True
    End Sub

    Private Sub WeekdayButton_Click(sender As Object, e As EventArgs) Handles WeekdayButton.Click
        Weekend.Visible = False
        Langstone.Visible = False
        OffTerm.Visible = False
        Weekday.Visible = True
    End Sub

    Private Sub WeekendButton_Click(sender As Object, e As EventArgs) Handles WeekendButton.Click
        Weekday.Visible = False
        Langstone.Visible = False
        OffTerm.Visible = False
        Weekend.Visible = True
    End Sub

    Private Sub Langstone_Click(sender As Object, e As EventArgs) Handles Lansgstone.Click
        Weekday.Visible = False
        Weekend.Visible = False
        OffTerm.Visible = False
        Langstone.Visible = True
    End Sub

    Private Sub OutOfTerm_Click(sender As Object, e As EventArgs) Handles OutOfTerm.Click
        Weekday.Visible = False
        Weekend.Visible = False
        Langstone.Visible = False
        OffTerm.Visible = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateLabel.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Main.Show()
    End Sub
End Class