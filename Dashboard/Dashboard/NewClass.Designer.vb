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
        Me.Submit1 = New System.Windows.Forms.Button()
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
        Me.Submit2 = New System.Windows.Forms.Button()
        Me.Submit3 = New System.Windows.Forms.Button()
        Me.Submit4 = New System.Windows.Forms.Button()
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
        'Submit1
        '
        Me.Submit1.Location = New System.Drawing.Point(756, 350)
        Me.Submit1.Name = "Submit1"
        Me.Submit1.Size = New System.Drawing.Size(75, 23)
        Me.Submit1.TabIndex = 5
        Me.Submit1.Text = "Submit"
        Me.Submit1.UseVisualStyleBackColor = True
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
        'Submit2
        '
        Me.Submit2.Location = New System.Drawing.Point(756, 350)
        Me.Submit2.Name = "Submit2"
        Me.Submit2.Size = New System.Drawing.Size(75, 23)
        Me.Submit2.TabIndex = 16
        Me.Submit2.Text = "Submit"
        Me.Submit2.UseVisualStyleBackColor = True
        Me.Submit2.Visible = False
        '
        'Submit3
        '
        Me.Submit3.Location = New System.Drawing.Point(756, 350)
        Me.Submit3.Name = "Submit3"
        Me.Submit3.Size = New System.Drawing.Size(75, 23)
        Me.Submit3.TabIndex = 17
        Me.Submit3.Text = "Submit"
        Me.Submit3.UseVisualStyleBackColor = True
        Me.Submit3.Visible = False
        '
        'Submit4
        '
        Me.Submit4.Location = New System.Drawing.Point(756, 350)
        Me.Submit4.Name = "Submit4"
        Me.Submit4.Size = New System.Drawing.Size(75, 23)
        Me.Submit4.TabIndex = 18
        Me.Submit4.Text = "Submit"
        Me.Submit4.UseVisualStyleBackColor = True
        Me.Submit4.Visible = False
        '
        'NewClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 397)
        Me.Controls.Add(Me.Submit4)
        Me.Controls.Add(Me.Submit3)
        Me.Controls.Add(Me.Submit2)
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
        Me.Controls.Add(Me.Submit1)
        Me.Controls.Add(Me.DateLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewClass"
        Me.Text = "New Class"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateLabel As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Submit1 As System.Windows.Forms.Button
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
    Public WithEvents Submit2 As System.Windows.Forms.Button
    Friend WithEvents Submit3 As System.Windows.Forms.Button
    Friend WithEvents Submit4 As System.Windows.Forms.Button
End Class
