<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Timetable
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Timetable))
        Me.TimetableBox = New System.Windows.Forms.GroupBox()
        Me.newSubject = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Type = New System.Windows.Forms.ComboBox()
        Me.ColourError = New System.Windows.Forms.Label()
        Me.DayError = New System.Windows.Forms.Label()
        Me.TimeError = New System.Windows.Forms.Label()
        Me.RoomError = New System.Windows.Forms.Label()
        Me.SubjectError = New System.Windows.Forms.Label()
        Me.submit = New System.Windows.Forms.Button()
        Me.Colour = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Comments = New System.Windows.Forms.RichTextBox()
        Me.Day = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Time = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Room = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Subject = New System.Windows.Forms.TextBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape11 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape10 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape9 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape8 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.newLesson = New System.Windows.Forms.Button()
        Me.BackMain = New System.Windows.Forms.Button()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TypeError = New System.Windows.Forms.Label()
        Me.TimetableBox.SuspendLayout()
        Me.newSubject.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimetableBox
        '
        Me.TimetableBox.BackColor = System.Drawing.SystemColors.Info
        Me.TimetableBox.Controls.Add(Me.Label16)
        Me.TimetableBox.Controls.Add(Me.Label15)
        Me.TimetableBox.Controls.Add(Me.Label14)
        Me.TimetableBox.Controls.Add(Me.Label13)
        Me.TimetableBox.Controls.Add(Me.Label12)
        Me.TimetableBox.Controls.Add(Me.Label11)
        Me.TimetableBox.Controls.Add(Me.Label10)
        Me.TimetableBox.Controls.Add(Me.Label9)
        Me.TimetableBox.Controls.Add(Me.Label8)
        Me.TimetableBox.Controls.Add(Me.Label7)
        Me.TimetableBox.Controls.Add(Me.Label6)
        Me.TimetableBox.Controls.Add(Me.Label5)
        Me.TimetableBox.Controls.Add(Me.Label4)
        Me.TimetableBox.Controls.Add(Me.Label3)
        Me.TimetableBox.Controls.Add(Me.Label2)
        Me.TimetableBox.Controls.Add(Me.Label1)
        Me.TimetableBox.Controls.Add(Me.ShapeContainer1)
        Me.TimetableBox.Location = New System.Drawing.Point(12, 34)
        Me.TimetableBox.Name = "TimetableBox"
        Me.TimetableBox.Size = New System.Drawing.Size(948, 576)
        Me.TimetableBox.TabIndex = 12
        Me.TimetableBox.TabStop = False
        Me.TimetableBox.Text = "Timetable"
        '
        'newSubject
        '
        Me.newSubject.Controls.Add(Me.TypeError)
        Me.newSubject.Controls.Add(Me.Label17)
        Me.newSubject.Controls.Add(Me.Type)
        Me.newSubject.Controls.Add(Me.ColourError)
        Me.newSubject.Controls.Add(Me.DayError)
        Me.newSubject.Controls.Add(Me.TimeError)
        Me.newSubject.Controls.Add(Me.RoomError)
        Me.newSubject.Controls.Add(Me.SubjectError)
        Me.newSubject.Controls.Add(Me.submit)
        Me.newSubject.Controls.Add(Me.Colour)
        Me.newSubject.Controls.Add(Me.Label19)
        Me.newSubject.Controls.Add(Me.Label20)
        Me.newSubject.Controls.Add(Me.Comments)
        Me.newSubject.Controls.Add(Me.Day)
        Me.newSubject.Controls.Add(Me.Label21)
        Me.newSubject.Controls.Add(Me.Time)
        Me.newSubject.Controls.Add(Me.Label22)
        Me.newSubject.Controls.Add(Me.Room)
        Me.newSubject.Controls.Add(Me.Label23)
        Me.newSubject.Controls.Add(Me.Label24)
        Me.newSubject.Controls.Add(Me.Subject)
        Me.newSubject.Controls.Add(Me.Cancel)
        Me.newSubject.Controls.Add(Me.Label25)
        Me.newSubject.Location = New System.Drawing.Point(9, 34)
        Me.newSubject.Name = "newSubject"
        Me.newSubject.Size = New System.Drawing.Size(945, 495)
        Me.newSubject.TabIndex = 18
        Me.newSubject.TabStop = False
        Me.newSubject.Text = " New Subject"
        Me.newSubject.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(54, 361)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(34, 13)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "Type:"
        '
        'Type
        '
        Me.Type.FormattingEnabled = True
        Me.Type.Items.AddRange(New Object() {"Pratcial", "Lecture", "Special Guest Speaker"})
        Me.Type.Location = New System.Drawing.Point(57, 377)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(121, 21)
        Me.Type.TabIndex = 50
        '
        'ColourError
        '
        Me.ColourError.AutoSize = True
        Me.ColourError.BackColor = System.Drawing.Color.LavenderBlush
        Me.ColourError.ForeColor = System.Drawing.Color.Red
        Me.ColourError.Location = New System.Drawing.Point(535, 262)
        Me.ColourError.Name = "ColourError"
        Me.ColourError.Size = New System.Drawing.Size(107, 13)
        Me.ColourError.TabIndex = 49
        Me.ColourError.Text = "Please enter a colour"
        Me.ColourError.Visible = False
        '
        'DayError
        '
        Me.DayError.AutoSize = True
        Me.DayError.BackColor = System.Drawing.Color.LavenderBlush
        Me.DayError.ForeColor = System.Drawing.Color.Red
        Me.DayError.Location = New System.Drawing.Point(194, 319)
        Me.DayError.Name = "DayError"
        Me.DayError.Size = New System.Drawing.Size(95, 13)
        Me.DayError.TabIndex = 48
        Me.DayError.Text = "Please enter a day"
        Me.DayError.Visible = False
        '
        'TimeError
        '
        Me.TimeError.AutoSize = True
        Me.TimeError.BackColor = System.Drawing.Color.LavenderBlush
        Me.TimeError.ForeColor = System.Drawing.Color.Red
        Me.TimeError.Location = New System.Drawing.Point(194, 259)
        Me.TimeError.Name = "TimeError"
        Me.TimeError.Size = New System.Drawing.Size(97, 13)
        Me.TimeError.TabIndex = 47
        Me.TimeError.Text = "Please enter a time"
        Me.TimeError.Visible = False
        '
        'RoomError
        '
        Me.RoomError.AutoSize = True
        Me.RoomError.BackColor = System.Drawing.Color.LavenderBlush
        Me.RoomError.ForeColor = System.Drawing.Color.Red
        Me.RoomError.Location = New System.Drawing.Point(175, 202)
        Me.RoomError.Name = "RoomError"
        Me.RoomError.Size = New System.Drawing.Size(126, 13)
        Me.RoomError.TabIndex = 46
        Me.RoomError.Text = "Please enter a valid room"
        Me.RoomError.Visible = False
        '
        'SubjectError
        '
        Me.SubjectError.AutoSize = True
        Me.SubjectError.BackColor = System.Drawing.Color.LavenderBlush
        Me.SubjectError.ForeColor = System.Drawing.Color.Red
        Me.SubjectError.Location = New System.Drawing.Point(175, 140)
        Me.SubjectError.Name = "SubjectError"
        Me.SubjectError.Size = New System.Drawing.Size(112, 13)
        Me.SubjectError.TabIndex = 45
        Me.SubjectError.Text = "Please enter a subject"
        Me.SubjectError.Visible = False
        '
        'submit
        '
        Me.submit.Location = New System.Drawing.Point(740, 406)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(75, 23)
        Me.submit.TabIndex = 44
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = True
        '
        'Colour
        '
        Me.Colour.FormattingEnabled = True
        Me.Colour.Items.AddRange(New Object() {"Red", "Orange", "Yellow", "Green", "Blue", "White", "Turquoise", "Pink", "Black", "Brown", "Grey"})
        Me.Colour.Location = New System.Drawing.Point(372, 259)
        Me.Colour.Name = "Colour"
        Me.Colour.Size = New System.Drawing.Size(121, 21)
        Me.Colour.TabIndex = 43
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(369, 243)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(37, 13)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "Colour"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(369, 123)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 13)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "Comments"
        '
        'Comments
        '
        Me.Comments.Location = New System.Drawing.Point(372, 140)
        Me.Comments.Name = "Comments"
        Me.Comments.Size = New System.Drawing.Size(308, 66)
        Me.Comments.TabIndex = 40
        Me.Comments.Text = ""
        '
        'Day
        '
        Me.Day.FormattingEnabled = True
        Me.Day.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"})
        Me.Day.Location = New System.Drawing.Point(57, 319)
        Me.Day.MaxDropDownItems = 5
        Me.Day.Name = "Day"
        Me.Day.Size = New System.Drawing.Size(121, 21)
        Me.Day.TabIndex = 39
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(54, 302)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(26, 13)
        Me.Label21.TabIndex = 38
        Me.Label21.Text = "Day"
        '
        'Time
        '
        Me.Time.FormattingEnabled = True
        Me.Time.Items.AddRange(New Object() {"09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00"})
        Me.Time.Location = New System.Drawing.Point(54, 259)
        Me.Time.MaxDropDownItems = 11
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(121, 21)
        Me.Time.TabIndex = 37
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(54, 243)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(30, 13)
        Me.Label22.TabIndex = 36
        Me.Label22.Text = "Time"
        '
        'Room
        '
        Me.Room.Location = New System.Drawing.Point(54, 202)
        Me.Room.Name = "Room"
        Me.Room.Size = New System.Drawing.Size(100, 20)
        Me.Room.TabIndex = 35
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(51, 185)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(99, 13)
        Me.Label23.TabIndex = 34
        Me.Label23.Text = "Building/room code"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(51, 167)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(0, 13)
        Me.Label24.TabIndex = 33
        '
        'Subject
        '
        Me.Subject.Location = New System.Drawing.Point(57, 141)
        Me.Subject.Name = "Subject"
        Me.Subject.Size = New System.Drawing.Size(100, 20)
        Me.Subject.TabIndex = 32
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(821, 406)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 31
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(48, 123)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(43, 13)
        Me.Label25.TabIndex = 30
        Me.Label25.Text = "Subject"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Location = New System.Drawing.Point(12, 528)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 15)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "19:00-20:00"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Location = New System.Drawing.Point(12, 480)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 15)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "18:00-19:00"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Location = New System.Drawing.Point(14, 432)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 15)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "17:00-18:00"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(12, 384)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 15)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "16:00-17:00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Location = New System.Drawing.Point(10, 336)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 15)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "15:00-16:00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(13, 288)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 15)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "14:00-15:00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(12, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 15)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "13:00-14:00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(12, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 15)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "12:00-13:00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(12, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "11:00-12:00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(12, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "10:00-11:00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(12, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "09:00-10:00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(774, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Friday"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(604, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Thursday"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(434, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Wednesday"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(264, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tuesday"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(94, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monday"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape11, Me.LineShape10, Me.LineShape9, Me.LineShape8, Me.LineShape7, Me.LineShape6, Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(942, 557)
        Me.ShapeContainer1.TabIndex = 16
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape11
        '
        Me.LineShape11.Name = "LineShape11"
        Me.LineShape11.X1 = 9
        Me.LineShape11.X2 = 915
        Me.LineShape11.Y1 = 510
        Me.LineShape11.Y2 = 510
        '
        'LineShape10
        '
        Me.LineShape10.Name = "LineShape10"
        Me.LineShape10.X1 = 9
        Me.LineShape10.X2 = 915
        Me.LineShape10.Y1 = 318
        Me.LineShape10.Y2 = 318
        '
        'LineShape9
        '
        Me.LineShape9.Name = "LineShape9"
        Me.LineShape9.X1 = 9
        Me.LineShape9.X2 = 915
        Me.LineShape9.Y1 = 462
        Me.LineShape9.Y2 = 462
        '
        'LineShape8
        '
        Me.LineShape8.Name = "LineShape8"
        Me.LineShape8.X1 = 9
        Me.LineShape8.X2 = 915
        Me.LineShape8.Y1 = 414
        Me.LineShape8.Y2 = 414
        '
        'LineShape7
        '
        Me.LineShape7.Name = "LineShape7"
        Me.LineShape7.X1 = 9
        Me.LineShape7.X2 = 915
        Me.LineShape7.Y1 = 366
        Me.LineShape7.Y2 = 366
        '
        'LineShape6
        '
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 9
        Me.LineShape6.X2 = 915
        Me.LineShape6.Y1 = 270
        Me.LineShape6.Y2 = 270
        '
        'LineShape5
        '
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 9
        Me.LineShape5.X2 = 915
        Me.LineShape5.Y1 = 222
        Me.LineShape5.Y2 = 222
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 9
        Me.LineShape4.X2 = 915
        Me.LineShape4.Y1 = 174
        Me.LineShape4.Y2 = 174
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 9
        Me.LineShape3.X2 = 915
        Me.LineShape3.Y1 = 126
        Me.LineShape3.Y2 = 126
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 9
        Me.LineShape2.X2 = 915
        Me.LineShape2.Y1 = 78
        Me.LineShape2.Y2 = 78
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 9
        Me.LineShape1.X2 = 915
        Me.LineShape1.Y1 = 30
        Me.LineShape1.Y2 = 30
        '
        'newLesson
        '
        Me.newLesson.Location = New System.Drawing.Point(13, 5)
        Me.newLesson.Name = "newLesson"
        Me.newLesson.Size = New System.Drawing.Size(75, 23)
        Me.newLesson.TabIndex = 13
        Me.newLesson.Text = "New Lesson"
        Me.newLesson.UseVisualStyleBackColor = True
        '
        'BackMain
        '
        Me.BackMain.Location = New System.Drawing.Point(106, 5)
        Me.BackMain.Name = "BackMain"
        Me.BackMain.Size = New System.Drawing.Size(75, 23)
        Me.BackMain.TabIndex = 14
        Me.BackMain.Text = "Back"
        Me.BackMain.UseVisualStyleBackColor = True
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DateLabel.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateLabel.Location = New System.Drawing.Point(678, 5)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(59, 27)
        Me.DateLabel.TabIndex = 15
        Me.DateLabel.Text = "Date"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'TypeError
        '
        Me.TypeError.AutoSize = True
        Me.TypeError.BackColor = System.Drawing.Color.LavenderBlush
        Me.TypeError.ForeColor = System.Drawing.Color.Red
        Me.TypeError.Location = New System.Drawing.Point(206, 385)
        Me.TypeError.Name = "TypeError"
        Me.TypeError.Size = New System.Drawing.Size(102, 13)
        Me.TypeError.TabIndex = 52
        Me.TypeError.Text = "Please select a type"
        Me.TypeError.Visible = False
        '
        'Timetable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 618)
        Me.Controls.Add(Me.newSubject)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.BackMain)
        Me.Controls.Add(Me.newLesson)
        Me.Controls.Add(Me.TimetableBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Timetable"
        Me.Text = "Timetable"
        Me.TimetableBox.ResumeLayout(False)
        Me.TimetableBox.PerformLayout()
        Me.newSubject.ResumeLayout(False)
        Me.newSubject.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimetableBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents newLesson As System.Windows.Forms.Button
    Friend WithEvents BackMain As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateLabel As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape11 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape10 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape9 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape8 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape7 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents newSubject As System.Windows.Forms.GroupBox
    Friend WithEvents ColourError As System.Windows.Forms.Label
    Friend WithEvents DayError As System.Windows.Forms.Label
    Friend WithEvents TimeError As System.Windows.Forms.Label
    Friend WithEvents RoomError As System.Windows.Forms.Label
    Friend WithEvents SubjectError As System.Windows.Forms.Label
    Friend WithEvents submit As System.Windows.Forms.Button
    Friend WithEvents Colour As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Comments As System.Windows.Forms.RichTextBox
    Friend WithEvents Day As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Time As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Room As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Subject As System.Windows.Forms.TextBox
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Type As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TypeError As System.Windows.Forms.Label
End Class
