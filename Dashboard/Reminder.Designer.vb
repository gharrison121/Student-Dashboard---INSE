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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reminder))
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
        Me.Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UploadButtonOne
        '
        Me.UploadButtonOne.Location = New System.Drawing.Point(763, 408)
        Me.UploadButtonOne.Name = "UploadButtonOne"
        Me.UploadButtonOne.Size = New System.Drawing.Size(75, 23)
        Me.UploadButtonOne.TabIndex = 0
        Me.UploadButtonOne.Text = "Submit"
        Me.UploadButtonOne.UseVisualStyleBackColor = True
        '
        'TitleText
        '
        Me.TitleText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleText.Location = New System.Drawing.Point(83, 180)
        Me.TitleText.Name = "TitleText"
        Me.TitleText.Size = New System.Drawing.Size(210, 24)
        Me.TitleText.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 18)
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
        Me.DateLabel.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLabel.Location = New System.Drawing.Point(741, 9)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(50, 22)
        Me.DateLabel.TabIndex = 4
        Me.DateLabel.Text = "Date"
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.Location = New System.Drawing.Point(79, 110)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(132, 22)
        Me.Username.TabIndex = 5
        Me.Username.Text = "New Reminder"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Subject"
        '
        'SubjectText
        '
        Me.SubjectText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectText.Location = New System.Drawing.Point(83, 235)
        Me.SubjectText.Name = "SubjectText"
        Me.SubjectText.Size = New System.Drawing.Size(210, 24)
        Me.SubjectText.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(86, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Date Due"
        '
        'DateText
        '
        Me.DateText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateText.Location = New System.Drawing.Point(83, 298)
        Me.DateText.Name = "DateText"
        Me.DateText.Size = New System.Drawing.Size(210, 24)
        Me.DateText.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(83, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 18)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Comments"
        '
        'ReminderComment
        '
        Me.ReminderComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReminderComment.Location = New System.Drawing.Point(83, 358)
        Me.ReminderComment.Multiline = True
        Me.ReminderComment.Name = "ReminderComment"
        Me.ReminderComment.Size = New System.Drawing.Size(377, 73)
        Me.ReminderComment.TabIndex = 14
        '
        'UploadButtonTwo
        '
        Me.UploadButtonTwo.Location = New System.Drawing.Point(763, 408)
        Me.UploadButtonTwo.Name = "UploadButtonTwo"
        Me.UploadButtonTwo.Size = New System.Drawing.Size(75, 23)
        Me.UploadButtonTwo.TabIndex = 15
        Me.UploadButtonTwo.Text = "Submit"
        Me.UploadButtonTwo.UseVisualStyleBackColor = True
        Me.UploadButtonTwo.Visible = False
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(844, 408)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 16
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Reminder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 539)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.UploadButtonTwo)
        Me.Controls.Add(Me.ReminderComment)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateText)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SubjectText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TitleText)
        Me.Controls.Add(Me.UploadButtonOne)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reminder"
        Me.Text = "New Reminder"
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
    Friend WithEvents Cancel As System.Windows.Forms.Button
End Class
