<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewClass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewClass))
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Subject = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Room = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Time = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Day = New System.Windows.Forms.ComboBox()
        Me.Comments = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Colour = New System.Windows.Forms.ComboBox()
        Me.submit = New System.Windows.Forms.Button()
        Me.SubjectError = New System.Windows.Forms.Label()
        Me.RoomError = New System.Windows.Forms.Label()
        Me.TimeError = New System.Windows.Forms.Label()
        Me.DayError = New System.Windows.Forms.Label()
        Me.ColourError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateLabel.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLabel.Location = New System.Drawing.Point(719, 9)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(57, 25)
        Me.DateLabel.TabIndex = 4
        Me.DateLabel.Text = "Date"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Subject"
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(838, 350)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 7
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Subject
        '
        Me.Subject.Location = New System.Drawing.Point(68, 84)
        Me.Subject.Name = "Subject"
        Me.Subject.Size = New System.Drawing.Size(100, 20)
        Me.Subject.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Building/room code"
        '
        'Room
        '
        Me.Room.Location = New System.Drawing.Point(71, 146)
        Me.Room.Name = "Room"
        Me.Room.Size = New System.Drawing.Size(100, 20)
        Me.Room.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Time"
        '
        'Time
        '
        Me.Time.FormattingEnabled = True
        Me.Time.Items.AddRange(New Object() {"09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00"})
        Me.Time.Location = New System.Drawing.Point(71, 203)
        Me.Time.MaxDropDownItems = 11
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(121, 21)
        Me.Time.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Day"
        '
        'Day
        '
        Me.Day.FormattingEnabled = True
        Me.Day.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"})
        Me.Day.Location = New System.Drawing.Point(74, 263)
        Me.Day.MaxDropDownItems = 5
        Me.Day.Name = "Day"
        Me.Day.Size = New System.Drawing.Size(121, 21)
        Me.Day.TabIndex = 15
        '
        'Comments
        '
        Me.Comments.Location = New System.Drawing.Point(389, 84)
        Me.Comments.Name = "Comments"
        Me.Comments.Size = New System.Drawing.Size(308, 66)
        Me.Comments.TabIndex = 19
        Me.Comments.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(386, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Comments"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(386, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Colour"
        '
        'Colour
        '
        Me.Colour.FormattingEnabled = True
        Me.Colour.Items.AddRange(New Object() {"Red", "Orange", "Yellow", "Green", "Blue", "White", "Turquoise", "Pink", "Black", "Brown", "Grey"})
        Me.Colour.Location = New System.Drawing.Point(389, 203)
        Me.Colour.Name = "Colour"
        Me.Colour.Size = New System.Drawing.Size(121, 21)
        Me.Colour.TabIndex = 22
        '
        'submit
        '
        Me.submit.Location = New System.Drawing.Point(757, 350)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(75, 23)
        Me.submit.TabIndex = 23
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = True
        '
        'SubjectError
        '
        Me.SubjectError.AutoSize = True
        Me.SubjectError.BackColor = System.Drawing.Color.LavenderBlush
        Me.SubjectError.ForeColor = System.Drawing.Color.Red
        Me.SubjectError.Location = New System.Drawing.Point(192, 84)
        Me.SubjectError.Name = "SubjectError"
        Me.SubjectError.Size = New System.Drawing.Size(112, 13)
        Me.SubjectError.TabIndex = 24
        Me.SubjectError.Text = "Please enter a subject"
        Me.SubjectError.Visible = False
        '
        'RoomError
        '
        Me.RoomError.AutoSize = True
        Me.RoomError.BackColor = System.Drawing.Color.LavenderBlush
        Me.RoomError.ForeColor = System.Drawing.Color.Red
        Me.RoomError.Location = New System.Drawing.Point(192, 146)
        Me.RoomError.Name = "RoomError"
        Me.RoomError.Size = New System.Drawing.Size(126, 13)
        Me.RoomError.TabIndex = 25
        Me.RoomError.Text = "Please enter a valid room"
        Me.RoomError.Visible = False
        '
        'TimeError
        '
        Me.TimeError.AutoSize = True
        Me.TimeError.BackColor = System.Drawing.Color.LavenderBlush
        Me.TimeError.ForeColor = System.Drawing.Color.Red
        Me.TimeError.Location = New System.Drawing.Point(211, 203)
        Me.TimeError.Name = "TimeError"
        Me.TimeError.Size = New System.Drawing.Size(97, 13)
        Me.TimeError.TabIndex = 26
        Me.TimeError.Text = "Please enter a time"
        Me.TimeError.Visible = False
        '
        'DayError
        '
        Me.DayError.AutoSize = True
        Me.DayError.BackColor = System.Drawing.Color.LavenderBlush
        Me.DayError.ForeColor = System.Drawing.Color.Red
        Me.DayError.Location = New System.Drawing.Point(211, 263)
        Me.DayError.Name = "DayError"
        Me.DayError.Size = New System.Drawing.Size(95, 13)
        Me.DayError.TabIndex = 27
        Me.DayError.Text = "Please enter a day"
        Me.DayError.Visible = False
        '
        'ColourError
        '
        Me.ColourError.AutoSize = True
        Me.ColourError.BackColor = System.Drawing.Color.LavenderBlush
        Me.ColourError.ForeColor = System.Drawing.Color.Red
        Me.ColourError.Location = New System.Drawing.Point(552, 206)
        Me.ColourError.Name = "ColourError"
        Me.ColourError.Size = New System.Drawing.Size(107, 13)
        Me.ColourError.TabIndex = 28
        Me.ColourError.Text = "Please enter a colour"
        Me.ColourError.Visible = False
        '
        'NewClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 397)
        Me.Controls.Add(Me.ColourError)
        Me.Controls.Add(Me.DayError)
        Me.Controls.Add(Me.TimeError)
        Me.Controls.Add(Me.RoomError)
        Me.Controls.Add(Me.SubjectError)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.Colour)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Comments)
        Me.Controls.Add(Me.Day)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Time)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Room)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Subject)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewClass"
        Me.Text = "New Class"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateLabel As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Subject As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Room As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Time As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Day As System.Windows.Forms.ComboBox
    Friend WithEvents Comments As System.Windows.Forms.RichTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Colour As System.Windows.Forms.ComboBox
    Friend WithEvents submit As System.Windows.Forms.Button
    Friend WithEvents SubjectError As System.Windows.Forms.Label
    Friend WithEvents RoomError As System.Windows.Forms.Label
    Friend WithEvents TimeError As System.Windows.Forms.Label
    Friend WithEvents DayError As System.Windows.Forms.Label
    Friend WithEvents ColourError As System.Windows.Forms.Label
End Class
