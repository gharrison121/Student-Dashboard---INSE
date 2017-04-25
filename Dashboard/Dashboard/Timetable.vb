Public Class Timetable

    Friend Shared lessonInfo As Object

    Private Sub newLesson_Click(sender As Object, e As EventArgs) Handles newLesson.Click
        NewClass.Show()
        Dim newLesson As New GroupBox
        newLesson.Visible = True
        newLesson.Size = New Size(178, 49)
        Dim lessonInfo As New Label
        lessonInfo.Visible = True
        lessonInfo.Size = New Size(45, 13)

        ' newLesson.Controls.Add(info)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub Timetable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.DarkViolet
        DateLabel.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        DateLabel.BackColor = Color.DarkViolet
    End Sub
End Class