Public Class Main

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(2, 2)
        ' Style
        Me.BackColor = Color.DarkViolet
        ' Set username to one logged in with, saves connection to DB
        Username.Text = LogIn.UserNameInput.Text

        ' Get Date
        DateLabel.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        ReminderButton.Text = "Set New Reminder"
        DateLabel.BackColor = Color.DarkViolet
        LinkLabel1.Text = "University Of Portsmouth"
        LinkLabel1.Links.Add(0, 24, "www.port.ac.uk/")
        LinkLabel2.Text = "Moodle"
        LinkLabel2.Links.Add(0, 6, "www.moodle.port.ac.uk/")
        LinkLabel3.Text = "My Port"
        LinkLabel3.Links.Add(0, 7, "www.myport.ac.uk/")
        LinkLabel4.Text = "Library"
        LinkLabel4.Links.Add(0, 7, "www.port.ac.uk/library/home/")
        LinkLabel5.Text = "Union"
        LinkLabel5.Links.Add(0, 5, "www.upsu.net")

        ' Reminder Visibility
        ReminderOne.Visible = My.Settings.RemOneVis
        ReminderTwo.Visible = My.Settings.RemTwoVis

        ' Reminder Content
        ReminderOne.Text = My.Settings.RemOneTitle
        ReminderOneDate.Text = My.Settings.RemOneDate
        ReminderOneComment.Text = My.Settings.RemOneCmt

        ' Reminder Content
        ReminderTwo.Text = My.Settings.RemTwoTitle
        ReminderTwoDate.Text = My.Settings.RemTwoDate
        ReminderTwoComment.Text = My.Settings.RemTwoCmt


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        DateLabel.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")

    End Sub

    Private Sub ReminderButton_Click(sender As Object, e As EventArgs) Handles ReminderButton.Click
        Reminder.Show()
    End Sub

   
    Private Sub ViewBusBtn_Click(sender As Object, e As EventArgs) Handles ViewBusBtn.Click
        Me.Hide()
        Bus.Show()
    End Sub

    Private Sub Timetable_Click(sender As Object, e As EventArgs) Handles TimetableButton.Click
        Me.Hide()
        Timetable.Show()
    End Sub
    
  
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal _
e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles _
LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub
    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal _
e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles _
LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub
    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal _
e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles _
LinkLabel3.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub
    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal _
e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles _
LinkLabel4.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub
    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal _
e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles _
LinkLabel5.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub

    Private Sub CloseR1_Click(sender As Object, e As EventArgs) Handles CloseR1.Click
        ReminderOne.Visible = False
        My.Settings.RemOneVis = False
        My.Settings.Save()
    End Sub

    Private Sub CloseR2_Click(sender As Object, e As EventArgs) Handles CloseR2.Click
        ReminderTwo.Visible = False
        My.Settings.RemTwoVis = False
        My.Settings.Save()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        LogIn.Show()
    End Sub
End Class
