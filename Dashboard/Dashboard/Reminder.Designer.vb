<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reminder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reminder))
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.UniPorts = New System.Windows.Forms.LinkLabel()
        Me.UploadButtonOne = New System.Windows.Forms.Button()
        Me.TitleText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SubjectText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateText = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ReminderComment = New System.Windows.Forms.TextBox()
        Me.UploadButtonTwo = New System.Windows.Forms.Button()
        Footer = New System.Windows.Forms.GroupBox()
        Footer.SuspendLayout()
        Me.SuspendLayout()
        '
        'Footer
        '
        Footer.BackColor = System.Drawing.Color.SlateBlue
        Footer.Controls.Add(Me.LinkLabel6)
        Footer.Controls.Add(Me.LinkLabel5)
        Footer.Controls.Add(Me.LinkLabel3)
        Footer.Controls.Add(Me.LinkLabel2)
        Footer.Controls.Add(Me.UniPorts)
        Footer.Location = New System.Drawing.Point(12, 418)
        Footer.Name = "Footer"
        Footer.Size = New System.Drawing.Size(969, 109)
        Footer.TabIndex = 10
        Footer.TabStop = False
        AddHandler Footer.Enter, AddressOf Me.GroupBox1_Enter_2
        '
        'LinkLabel6
        '
        Me.LinkLabel6.AutoSize = True
        Me.LinkLabel6.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel6.Location = New System.Drawing.Point(775, 54)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(128, 24)
        Me.LinkLabel6.TabIndex = 5
        Me.LinkLabel6.TabStop = True
        Me.LinkLabel6.Tag = "https://www.upsu.net/"
        Me.LinkLabel6.Text = "Students Union"
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel5.Location = New System.Drawing.Point(384, 54)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(70, 24)
        Me.LinkLabel5.TabIndex = 4
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Tag = "http://www.port.ac.uk/library/home/"
        Me.LinkLabel5.Text = "Library"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.Location = New System.Drawing.Point(30, 54)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(69, 24)
        Me.LinkLabel3.TabIndex = 2
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Tag = "http://moodle.port.ac.uk/"
        Me.LinkLabel3.Text = "Moodle"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(384, 20)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(71, 24)
        Me.LinkLabel2.TabIndex = 1
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Tag = "http://www.myport.ac.uk/"
        Me.LinkLabel2.Text = "My Port"
        '
        'UniPorts
        '
        Me.UniPorts.AutoSize = True
        Me.UniPorts.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UniPorts.Location = New System.Drawing.Point(30, 20)
        Me.UniPorts.Name = "UniPorts"
        Me.UniPorts.Size = New System.Drawing.Size(207, 24)
        Me.UniPorts.TabIndex = 0
        Me.UniPorts.TabStop = True
        Me.UniPorts.Tag = "http://www.port.ac.uk/"
        Me.UniPorts.Text = "University Of Portsmouth"
        '
        'UploadButtonOne
        '
        Me.UploadButtonOne.Location = New System.Drawing.Point(815, 374)
        Me.UploadButtonOne.Name = "UploadButtonOne"
        Me.UploadButtonOne.Size = New System.Drawing.Size(75, 23)
        Me.UploadButtonOne.TabIndex = 0
        Me.UploadButtonOne.Text = "Submit"
        Me.UploadButtonOne.UseVisualStyleBackColor = True
        '
        'TitleText
        '
        Me.TitleText.Location = New System.Drawing.Point(102, 157)
        Me.TitleText.Name = "TitleText"
        Me.TitleText.Size = New System.Drawing.Size(210, 20)
        Me.TitleText.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Title"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateLabel.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLabel.Location = New System.Drawing.Point(741, 9)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(74, 24)
        Me.DateLabel.TabIndex = 4
        Me.DateLabel.Text = "Label3"
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Font = New System.Drawing.Font("Poor Richard", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.Location = New System.Drawing.Point(95, 71)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(112, 41)
        Me.Username.TabIndex = 5
        Me.Username.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Subject"
        '
        'SubjectText
        '
        Me.SubjectText.Location = New System.Drawing.Point(102, 212)
        Me.SubjectText.Name = "SubjectText"
        Me.SubjectText.Size = New System.Drawing.Size(210, 20)
        Me.SubjectText.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(105, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Date Due"
        '
        'DateText
        '
        Me.DateText.Location = New System.Drawing.Point(102, 275)
        Me.DateText.Name = "DateText"
        Me.DateText.Size = New System.Drawing.Size(210, 20)
        Me.DateText.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(105, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Comments"
        '
        'ReminderComment
        '
        Me.ReminderComment.Location = New System.Drawing.Point(102, 335)
        Me.ReminderComment.Multiline = True
        Me.ReminderComment.Name = "ReminderComment"
        Me.ReminderComment.Size = New System.Drawing.Size(377, 62)
        Me.ReminderComment.TabIndex = 14
        '
        'UploadButtonTwo
        '
        Me.UploadButtonTwo.Location = New System.Drawing.Point(815, 374)
        Me.UploadButtonTwo.Name = "UploadButtonTwo"
        Me.UploadButtonTwo.Size = New System.Drawing.Size(75, 23)
        Me.UploadButtonTwo.TabIndex = 15
        Me.UploadButtonTwo.Text = "Submit"
        Me.UploadButtonTwo.UseVisualStyleBackColor = True
        Me.UploadButtonTwo.Visible = False
        '
        'Reminder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 539)
        Me.Controls.Add(Me.UploadButtonTwo)
        Me.Controls.Add(Me.ReminderComment)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateText)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Footer)
        Me.Controls.Add(Me.SubjectText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TitleText)
        Me.Controls.Add(Me.UploadButtonOne)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reminder"
        Me.Text = "New Reminders"
        Footer.ResumeLayout(False)
        Footer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UploadButtonOne As System.Windows.Forms.Button
    Friend WithEvents TitleText As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DateLabel As System.Windows.Forms.Label
    Friend WithEvents Username As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SubjectText As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateText As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ReminderComment As System.Windows.Forms.TextBox
    Friend WithEvents UploadButtonTwo As System.Windows.Forms.Button
    Friend WithEvents LinkLabel6 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel5 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents UniPorts As System.Windows.Forms.LinkLabel
End Class
