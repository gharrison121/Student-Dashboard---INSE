Public Class Reminder
    Private Sub Reminder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.DarkViolet
        DateLabel.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        DateLabel.BackColor = Color.DarkViolet
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Username.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        DateLabel.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub UploadButton_Click(sender As Object, e As EventArgs) Handles UploadButtonOne.Click
        Me.Hide()
        Main.ReminderOne.Visible = True
        Main.ReminderOne.Text = TitleText.Text
        Main.ReminderOneDate.Text = DateText.Text
        Main.ReminderOneComment.Text = SubjectText.Text + " - " + ReminderComment.Text
        UploadButtonOne.Visible = False
        UploadButtonTwo.Visible = True
        TitleText.Text = ""
        DateText.Text = ""
        SubjectText.Text = ""
        ReminderComment.Text = ""
    End Sub

    Private Sub UploadButtonTwo_Click(sender As Object, e As EventArgs) Handles UploadButtonTwo.Click
        Me.Hide()
        Main.ReminderTwo.Visible = True
        Main.ReminderTwo.Text = TitleText.Text
        Main.ReminderTwoDate.Text = DateText.Text
        Main.ReminderTwoComment.Text = SubjectText.Text + " - " + ReminderComment.Text
        TitleText.Text = ""
        DateText.Text = ""
        SubjectText.Text = ""
        ReminderComment.Text = ""
    End Sub

    Private Sub DateLabel_Click(sender As Object, e As EventArgs) Handles DateLabel.Click

    End Sub
End Class