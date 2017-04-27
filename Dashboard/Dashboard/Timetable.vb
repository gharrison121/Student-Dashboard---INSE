Public Class Timetable
    Private Sub newLesson_Click(sender As Object, e As EventArgs) Handles newLesson.Click
        'opens the new class input area
        'creates a group box to represent a lesson and a label to put information into the group box
        'The group box and label is assembled here and then placement info and colours are added when submitted in new class window
        newSubject.Visible = True
        AcceptButton = submit




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BackMain.Click
        'closes the timetable window and bring back the main window
        Me.Hide()
        newSubject.Visible = False
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
        ElseIf Type.SelectedIndex = -1 Then
            TypeError.Visible = True
        ElseIf Colour.SelectedIndex = -1 Then
            ColourError.Visible = True
        Else


            'creating groupbox, add to form, size it to fit timetable
            Dim newLesson As New GroupBox
            TimetableBox.Controls.Add(newLesson)
            newLesson.Size = New Size(250, 49)
            'create label for info to go into groupbox, add to groupbox, size and change location
            Dim roomLabel As New Label
            roomLabel.Size = New Size(100, 13)
            newLesson.Controls.Add(roomLabel)
            roomLabel.Location = New Point(6, 16)
            'set up the label for the type of lecture
            Dim TypeLecture As New Label
            newLesson.Controls.Add(TypeLecture)
            TypeLecture.Size = New Size(100, 13)
            TypeLecture.Location = New Point(6, 29)
            'set comments for info box
            Dim CommentsText As New Label
            newLesson.Controls.Add(CommentsText)
            CommentsText.Visible = False
            CommentsText.Location = New Point(6, 32)



            'if all validation has passed then all areas on the subject for need to be filled out.
            ' setting the x and y location of the new subject group box
            newLesson.Location = New Point((((Day.SelectedIndex) * 170) + 94), ((Time.SelectedIndex + 1) * 48))

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
                newLesson.ForeColor = Color.White
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
            'add click show info handler for subjects
            AddHandler newLesson.Click, AddressOf SubjectOne_Click
            'Add double click delet for each subject
            AddHandler newLesson.DoubleClick, AddressOf SubjectDouble_Click

            'setting the subject, room 
            newLesson.Text = Subject.Text
            'set the size of subject box
            newLesson.Size = New Size(169, 49)
            'set the room number label and add it to the groupox (subject)
            roomLabel.Text = "Room: " + Room.Text
            'change ID's of subject and bow to allow for new separate inputs
            newLesson.Name = Subject.Text
            roomLabel.Name = Subject.Text + Room.Name
            TypeLecture.Name = Subject.Text + Type.SelectedIndex.ToString()
            'set type of lecture
            TypeLecture.Text = "Type: " + Type.SelectedItem.ToString()
            'set comments
            CommentsText.Text = "Comments: " & Comments.Text

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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateLabel.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
    End Sub

    Private Sub newSubject_Enter(sender As Object, e As EventArgs) Handles newSubject.Enter

    End Sub
    Private Sub SubjectOne_Click(sender As Object, e As EventArgs)
        Dim SubjectInfo As New RichTextBox
        TimetableBox.Controls.Add(SubjectInfo)
        SubjectInfo.BringToFront()
        SubjectInfo.Visible = True
        SubjectInfo.ReadOnly = True
        SubjectInfo.Location = sender.Location
        SubjectInfo.Text = "Subject: " & sender.Name.ToString() & vbNewLine
        AddHandler SubjectInfo.DoubleClick, AddressOf SubjectDouble_Click
        For Each ctrl As Control In sender.Controls
            If TypeOf ctrl Is Label Then
                SubjectInfo.Text &= ctrl.Text & vbNewLine

            End If
        Next



    End Sub
    Private Sub SubjectDouble_Click(sender As Object, e As EventArgs)
        sender.Dispose()
    End Sub
End Class