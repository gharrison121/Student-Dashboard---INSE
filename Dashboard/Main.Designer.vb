<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim Footer As System.Windows.Forms.GroupBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.Label()
        Me.Reminders = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.ReminderButton = New System.Windows.Forms.Button()
        Me.ReminderOne = New System.Windows.Forms.GroupBox()
        Me.CloseR1 = New System.Windows.Forms.Button()
        Me.ReminderOneComment = New System.Windows.Forms.Label()
        Me.ReminderOneDate = New System.Windows.Forms.Label()
        Me.ReminderTwo = New System.Windows.Forms.GroupBox()
        Me.CloseR2 = New System.Windows.Forms.Button()
        Me.ReminderTwoComment = New System.Windows.Forms.Label()
        Me.ReminderTwoDate = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.ViewBusBtn = New System.Windows.Forms.Button()
        Me.TimetableButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Footer = New System.Windows.Forms.GroupBox()
        Footer.SuspendLayout()
        Me.ReminderOne.SuspendLayout()
        Me.ReminderTwo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Footer
        '
        Footer.BackColor = System.Drawing.Color.SlateBlue
        Footer.Controls.Add(Me.LinkLabel5)
        Footer.Controls.Add(Me.LinkLabel4)
        Footer.Controls.Add(Me.LinkLabel3)
        Footer.Controls.Add(Me.LinkLabel2)
        Footer.Controls.Add(Me.LinkLabel1)
        Footer.Location = New System.Drawing.Point(12, 544)
        Footer.Name = "Footer"
        Footer.Size = New System.Drawing.Size(1133, 109)
        Footer.TabIndex = 13
        Footer.TabStop = False
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel5.Location = New System.Drawing.Point(889, 20)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(113, 25)
        Me.LinkLabel5.TabIndex = 4
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "LinkLabel5"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel4.Location = New System.Drawing.Point(498, 57)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(113, 25)
        Me.LinkLabel4.TabIndex = 3
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "LinkLabel4"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.Location = New System.Drawing.Point(498, 20)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(113, 25)
        Me.LinkLabel3.TabIndex = 2
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "LinkLabel3"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(24, 57)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(113, 25)
        Me.LinkLabel2.TabIndex = 1
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "LinkLabel2"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(24, 20)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(113, 25)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 75)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hello"
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Font = New System.Drawing.Font("Cambria", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.Location = New System.Drawing.Point(183, 18)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(303, 75)
        Me.Username.TabIndex = 1
        Me.Username.Text = "username"
        '
        'Reminders
        '
        Me.Reminders.AutoSize = True
        Me.Reminders.Font = New System.Drawing.Font("Cambria", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reminders.Location = New System.Drawing.Point(86, 146)
        Me.Reminders.Name = "Reminders"
        Me.Reminders.Size = New System.Drawing.Size(191, 43)
        Me.Reminders.TabIndex = 2
        Me.Reminders.Text = "Reminders"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateLabel.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DateLabel.Location = New System.Drawing.Point(799, 123)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(57, 25)
        Me.DateLabel.TabIndex = 3
        Me.DateLabel.Text = "Date"
        '
        'ReminderButton
        '
        Me.ReminderButton.Location = New System.Drawing.Point(94, 202)
        Me.ReminderButton.Name = "ReminderButton"
        Me.ReminderButton.Size = New System.Drawing.Size(75, 23)
        Me.ReminderButton.TabIndex = 4
        Me.ReminderButton.Text = "Add New Reminder"
        Me.ReminderButton.UseVisualStyleBackColor = True
        '
        'ReminderOne
        '
        Me.ReminderOne.Controls.Add(Me.CloseR1)
        Me.ReminderOne.Controls.Add(Me.ReminderOneComment)
        Me.ReminderOne.Controls.Add(Me.ReminderOneDate)
        Me.ReminderOne.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReminderOne.Location = New System.Drawing.Point(94, 231)
        Me.ReminderOne.Name = "ReminderOne"
        Me.ReminderOne.Size = New System.Drawing.Size(336, 110)
        Me.ReminderOne.TabIndex = 10
        Me.ReminderOne.TabStop = False
        Me.ReminderOne.Text = "Reminder Block"
        Me.ReminderOne.Visible = False
        '
        'CloseR1
        '
        Me.CloseR1.FlatAppearance.BorderSize = 0
        Me.CloseR1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseR1.Font = New System.Drawing.Font("Wingdings 2", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.CloseR1.Location = New System.Drawing.Point(309, 15)
        Me.CloseR1.Name = "CloseR1"
        Me.CloseR1.Size = New System.Drawing.Size(21, 24)
        Me.CloseR1.TabIndex = 3
        Me.CloseR1.Text = "S"
        Me.CloseR1.UseVisualStyleBackColor = True
        '
        'ReminderOneComment
        '
        Me.ReminderOneComment.AutoSize = True
        Me.ReminderOneComment.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReminderOneComment.Location = New System.Drawing.Point(6, 63)
        Me.ReminderOneComment.Name = "ReminderOneComment"
        Me.ReminderOneComment.Size = New System.Drawing.Size(73, 25)
        Me.ReminderOneComment.TabIndex = 2
        Me.ReminderOneComment.Text = "Label4"
        '
        'ReminderOneDate
        '
        Me.ReminderOneDate.AutoSize = True
        Me.ReminderOneDate.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReminderOneDate.Location = New System.Drawing.Point(7, 27)
        Me.ReminderOneDate.Name = "ReminderOneDate"
        Me.ReminderOneDate.Size = New System.Drawing.Size(73, 25)
        Me.ReminderOneDate.TabIndex = 1
        Me.ReminderOneDate.Text = "Label3"
        '
        'ReminderTwo
        '
        Me.ReminderTwo.Controls.Add(Me.CloseR2)
        Me.ReminderTwo.Controls.Add(Me.ReminderTwoComment)
        Me.ReminderTwo.Controls.Add(Me.ReminderTwoDate)
        Me.ReminderTwo.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReminderTwo.Location = New System.Drawing.Point(94, 370)
        Me.ReminderTwo.Name = "ReminderTwo"
        Me.ReminderTwo.Size = New System.Drawing.Size(336, 123)
        Me.ReminderTwo.TabIndex = 11
        Me.ReminderTwo.TabStop = False
        Me.ReminderTwo.Text = "Reminder Block"
        Me.ReminderTwo.Visible = False
        '
        'CloseR2
        '
        Me.CloseR2.FlatAppearance.BorderSize = 0
        Me.CloseR2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseR2.Font = New System.Drawing.Font("Wingdings 2", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.CloseR2.Location = New System.Drawing.Point(309, 15)
        Me.CloseR2.Name = "CloseR2"
        Me.CloseR2.Size = New System.Drawing.Size(21, 24)
        Me.CloseR2.TabIndex = 4
        Me.CloseR2.Text = "S"
        Me.CloseR2.UseVisualStyleBackColor = True
        '
        'ReminderTwoComment
        '
        Me.ReminderTwoComment.AutoSize = True
        Me.ReminderTwoComment.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReminderTwoComment.Location = New System.Drawing.Point(6, 79)
        Me.ReminderTwoComment.Name = "ReminderTwoComment"
        Me.ReminderTwoComment.Size = New System.Drawing.Size(64, 22)
        Me.ReminderTwoComment.TabIndex = 2
        Me.ReminderTwoComment.Text = "Label4"
        '
        'ReminderTwoDate
        '
        Me.ReminderTwoDate.AutoSize = True
        Me.ReminderTwoDate.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReminderTwoDate.Location = New System.Drawing.Point(6, 39)
        Me.ReminderTwoDate.Name = "ReminderTwoDate"
        Me.ReminderTwoDate.Size = New System.Drawing.Size(64, 22)
        Me.ReminderTwoDate.TabIndex = 1
        Me.ReminderTwoDate.Text = "Label3"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(804, 157)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 12
        '
        'ViewBusBtn
        '
        Me.ViewBusBtn.Location = New System.Drawing.Point(46, 94)
        Me.ViewBusBtn.Name = "ViewBusBtn"
        Me.ViewBusBtn.Size = New System.Drawing.Size(108, 23)
        Me.ViewBusBtn.TabIndex = 14
        Me.ViewBusBtn.Text = "View Bus Timetable"
        Me.ViewBusBtn.UseVisualStyleBackColor = True
        '
        'TimetableButton
        '
        Me.TimetableButton.Location = New System.Drawing.Point(175, 94)
        Me.TimetableButton.Name = "TimetableButton"
        Me.TimetableButton.Size = New System.Drawing.Size(75, 23)
        Me.TimetableButton.TabIndex = 15
        Me.TimetableButton.Text = "Timetable"
        Me.TimetableButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(956, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 665)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TimetableButton)
        Me.Controls.Add(Me.ViewBusBtn)
        Me.Controls.Add(Footer)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.ReminderTwo)
        Me.Controls.Add(Me.ReminderOne)
        Me.Controls.Add(Me.ReminderButton)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.Reminders)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "University Manager"
        Footer.ResumeLayout(False)
        Footer.PerformLayout()
        Me.ReminderOne.ResumeLayout(False)
        Me.ReminderOne.PerformLayout()
        Me.ReminderTwo.ResumeLayout(False)
        Me.ReminderTwo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Username As System.Windows.Forms.Label
    Friend WithEvents Reminders As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DateLabel As System.Windows.Forms.Label
    Friend WithEvents ReminderButton As System.Windows.Forms.Button
    Friend WithEvents ReminderOne As System.Windows.Forms.GroupBox
    Friend WithEvents ReminderOneComment As System.Windows.Forms.Label
    Friend WithEvents ReminderOneDate As System.Windows.Forms.Label
    Friend WithEvents ReminderTwo As System.Windows.Forms.GroupBox
    Friend WithEvents ReminderTwoComment As System.Windows.Forms.Label
    Friend WithEvents ReminderTwoDate As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents ViewBusBtn As System.Windows.Forms.Button
    Friend WithEvents TimetableButton As System.Windows.Forms.Button
    Friend WithEvents LinkLabel5 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents CloseR1 As System.Windows.Forms.Button
    Friend WithEvents CloseR2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
