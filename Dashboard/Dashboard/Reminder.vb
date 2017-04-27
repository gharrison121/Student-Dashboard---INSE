Public Class Reminder
    Private Sub Reminder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.DarkViolet
        Me.Location = New Point(2, 2)
        DateLabel.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        DateLabel.BackColor = Color.DarkViolet

        ' Reminder Button Visibility
        'UploadButtonOne.Visible = Not My.Settings.RemOneVis
        ' UploadButtonTwo.Visible = Not My.Settings.RemTwoVis
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Get Date
        DateLabel.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
    End Sub

    Private Sub UploadButtonOne_Click(sender As Object, e As EventArgs) Handles UploadButtonOne.Click
        Me.Hide()

        ' Set Visibility to true and save change
        Main.ReminderOne.Visible = True
        My.Settings.RemOneVis = True
        My.Settings.Save()

        ' Set text to inputs
        Main.ReminderOne.Text = TitleText.Text
        Main.ReminderOneDate.Text = DateText.Text
        Main.ReminderOneComment.Text = SubjectText.Text + " - " + ReminderComment.Text

        ' Store inputs and save
        My.Settings.RemOneTitle = Main.ReminderOne.Text
        My.Settings.RemOneDate = Main.ReminderOneDate.Text
        My.Settings.RemOneCmt = Main.ReminderOneComment.Text
        My.Settings.Save()

        UploadButtonOne.Visible = False
        UploadButtonTwo.Visible = True

        ' Reset Input Fields
        TitleText.Text = ""
        DateText.Text = ""
        SubjectText.Text = ""
        ReminderComment.Text = ""
    End Sub

    Private Sub UploadButtonTwo_Click(sender As Object, e As EventArgs) Handles UploadButtonTwo.Click
        Me.Hide()

        ' Set Visibility to true and save change
        Main.ReminderTwo.Visible = True
        My.Settings.RemTwoVis = True
        My.Settings.Save()

        ' Set text to inputs
        Main.ReminderTwo.Text = TitleText.Text
        Main.ReminderTwoDate.Text = DateText.Text
        Main.ReminderTwoComment.Text = SubjectText.Text + " - " + ReminderComment.Text

        ' Store inputs and save
        My.Settings.RemTwoTitle = Main.ReminderTwo.Text
        My.Settings.RemTwoDate = Main.ReminderTwoDate.Text
        My.Settings.RemTwoCmt = Main.ReminderTwoComment.Text
        My.Settings.Save()

        ' Reset Input Fields
        TitleText.Text = ""
        DateText.Text = ""
        SubjectText.Text = ""
        ReminderComment.Text = ""
    End Sub

    ' Cancel Reminder
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Hide()
    End Sub
End Class