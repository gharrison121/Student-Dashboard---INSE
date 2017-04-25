Public Class NewClass

    Private Sub NewClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.DarkViolet
        DateLabel.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        DateLabel.BackColor = Color.DarkViolet
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Timetable.newLesson.Dispose()
        Timetable.lessonInfo.Dispose()
        Me.Hide()
        Subject.Text = ""
        Room.Text = ""
        Time.SelectedIndex = -1
        Day.SelectedIndex = -1
        Comments.Text = ""
        Colour.SelectedIndex = -1
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        If Subject.Text = "" Then
            SubjectError.Visible = True
        ElseIf Room.Text = "" Then
            RoomError.Visible = True
        ElseIf Time.SelectedIndex = -1 Then
            TimeError.Visible = True
        ElseIf Day.SelectedIndex = -1 Then
            DayError.Visible = True
        ElseIf Colour.SelectedIndex = -1 Then
            ColourError.Visible = True
        Else



            Timetable.newLesson.Text = Subject.Text
            If Colour.SelectedIndex = 0 Then
                Timetable.newLesson.BackColor = Color.Red
            ElseIf Colour.SelectedIndex = 1 Then
                Timetable.newLesson.BackColor = Color.Orange
            ElseIf Colour.SelectedIndex = 2 Then
                Timetable.newLesson.BackColor = Color.Yellow
            ElseIf Colour.SelectedIndex = 3 Then
                Timetable.newLesson.BackColor = Color.Green
            ElseIf Colour.SelectedIndex = 4 Then
                Timetable.newLesson.BackColor = Color.Blue
                Timetable.newLesson.ForeColor = Color.White
            ElseIf Colour.SelectedIndex = 5 Then
                Timetable.newLesson.BackColor = Color.White
            ElseIf Colour.SelectedIndex = 6 Then
                Timetable.newLesson.BackColor = Color.Cyan
            ElseIf Colour.SelectedIndex = 7 Then
                Timetable.newLesson.BackColor = Color.Pink
            ElseIf Colour.SelectedIndex = 8 Then
                Timetable.newLesson.BackColor = Color.Black
                Timetable.newLesson.ForeColor = Color.White
            ElseIf Colour.SelectedIndex = 9 Then
                Timetable.newLesson.BackColor = Color.Brown
                Timetable.newLesson.ForeColor = Color.White
            ElseIf Colour.SelectedIndex = 10 Then
                Timetable.newLesson.BackColor = Color.Gray
            End If
            Timetable.lessonInfo.Name = Room.Text
            Timetable.newLesson.Name = Subject.Text
            SubjectError.Visible = False
            RoomError.Visible = False
            ColourError.Visible = False
            TimeError.Visible = False
            DayError.Visible = False
            Me.Hide()
            Subject.Text = ""
            Room.Text = ""
            Time.SelectedIndex = -1
            Day.SelectedIndex = -1
            Comments.Text = ""
            Colour.SelectedIndex = -1
        End If
    End Sub
End Class