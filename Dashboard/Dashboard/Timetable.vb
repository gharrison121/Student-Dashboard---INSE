Public Class Timetable
    Private Sub newLesson_Click(sender As Object, e As EventArgs) Handles newLesson.Click
        'opens the new class input area
        'creates a group box to represent a lesson and a label to put information into the group box
        'The group box and label is assembled here and then placement info and colours are added when submitted in new class window
        newSubject.Visible = True





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BackMain.Click
        'closes the timetable window and bring back the main window
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub Timetable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'main set up of timetable page, background colour and initiantion of the date and time
        Me.BackColor = Color.DarkViolet
        DateLabel.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        DateLabel.BackColor = Color.DarkViolet
        Me.Location = New Point(1, 1)

    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        ' validation of subject for each entity input, this makes sure all needed area are filled out so subject can be properly created

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


            'creating groupbox, add to form, size it to fit timetable
            Dim newLesson As New GroupBox
            Me.Controls.Add(newLesson)
            TimetableBox.Controls.Add(newLesson)
            newLesson.Size = New Size(178, 49)
            'create label for info to go into groupbox, add to groupbox, size and change location
            Dim roomLabel As New Label
            Me.Controls.Add(roomLabel)
            TimetableBox.Controls.Add(roomLabel)
            roomLabel.Size = New Size(45, 13)


            'if all validation has passed then all areas on the subject for need to be filled out.
            ' setting the x and y location of the new subject group box
            newLesson.Location = New Point((((Day.SelectedIndex + 1) * 170) + 94), ((Time.SelectedIndex + 1) * 48))

            'setting the attributes of the subject once validation is complete
            newLesson.Text = Subject.Text
            If Colour.SelectedIndex = 0 Then
                newLesson.BackColor = Color.Red
            ElseIf Colour.SelectedIndex = 1 Then
                newLesson.BackColor = Color.Orange
            ElseIf Colour.SelectedIndex = 2 Then
                newLesson.BackColor = Color.Yellow
            ElseIf Colour.SelectedIndex = 3 Then
                newLesson.BackColor = Color.Green
            ElseIf Colour.SelectedIndex = 4 Then
                newLesson.BackColor = Color.Blue
                newLesson.ForeColor = Color.White
            ElseIf Colour.SelectedIndex = 5 Then
                newLesson.BackColor = Color.White
            ElseIf Colour.SelectedIndex = 6 Then
                newLesson.BackColor = Color.Cyan
            ElseIf Colour.SelectedIndex = 7 Then
                newLesson.BackColor = Color.Pink
            ElseIf Colour.SelectedIndex = 8 Then
                newLesson.BackColor = Color.Black
                newLesson.ForeColor = Color.White
            ElseIf Colour.SelectedIndex = 9 Then
                newLesson.BackColor = Color.Brown
                newLesson.ForeColor = Color.White
            ElseIf Colour.SelectedIndex = 10 Then
                newLesson.BackColor = Color.Gray
            End If
            'setting the subject, room 
            newLesson.Text = Subject.Text
            'set the size of subject box
            newLesson.Size = New Size(169, 49)
            'set the room number label and add it to the groupox (subject)
            roomLabel.Text = "Room: " + Room.Text


            'hide all error messages for next input
            SubjectError.Visible = False
            RoomError.Visible = False
            ColourError.Visible = False
            TimeError.Visible = False
            DayError.Visible = False

            'reset all inputs to 0 or null
            newSubject.Visible = False
            Subject.Text = ""
            Room.Text = ""
            Time.SelectedIndex = -1
            Day.SelectedIndex = -1
            Comments.Text = ""
            Colour.SelectedIndex = -1
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        newSubject.Visible = False
        Subject.Text = ""
        Room.Text = ""
        Time.SelectedIndex = -1
        Day.SelectedIndex = -1
        Comments.Text = ""
        Colour.SelectedIndex = -1
    End Sub
End Class