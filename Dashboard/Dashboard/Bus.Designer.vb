<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bus))
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.WeekdayButton = New System.Windows.Forms.Button()
        Me.WeekendButton = New System.Windows.Forms.Button()
        Me.OutOfTerm = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Weekend = New System.Windows.Forms.FlowLayoutPanel()
        Me.OffTerm = New System.Windows.Forms.FlowLayoutPanel()
        Me.Weekday = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateLabel.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DateLabel.Location = New System.Drawing.Point(802, 9)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(57, 25)
        Me.DateLabel.TabIndex = 4
        Me.DateLabel.Text = "Date"
        '
        'WeekdayButton
        '
        Me.WeekdayButton.Location = New System.Drawing.Point(32, 12)
        Me.WeekdayButton.Name = "WeekdayButton"
        Me.WeekdayButton.Size = New System.Drawing.Size(75, 23)
        Me.WeekdayButton.TabIndex = 9
        Me.WeekdayButton.Text = "Week Day"
        Me.WeekdayButton.UseVisualStyleBackColor = True
        '
        'WeekendButton
        '
        Me.WeekendButton.Location = New System.Drawing.Point(113, 12)
        Me.WeekendButton.Name = "WeekendButton"
        Me.WeekendButton.Size = New System.Drawing.Size(75, 23)
        Me.WeekendButton.TabIndex = 10
        Me.WeekendButton.Text = "Weekend"
        Me.WeekendButton.UseVisualStyleBackColor = True
        '
        'OutOfTerm
        '
        Me.OutOfTerm.Location = New System.Drawing.Point(194, 12)
        Me.OutOfTerm.Name = "OutOfTerm"
        Me.OutOfTerm.Size = New System.Drawing.Size(76, 23)
        Me.OutOfTerm.TabIndex = 12
        Me.OutOfTerm.Text = "Out Of Term"
        Me.OutOfTerm.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Weekend
        '
        Me.Weekend.BackgroundImage = CType(resources.GetObject("Weekend.BackgroundImage"), System.Drawing.Image)
        Me.Weekend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Weekend.Location = New System.Drawing.Point(22, 41)
        Me.Weekend.Name = "Weekend"
        Me.Weekend.Size = New System.Drawing.Size(894, 356)
        Me.Weekend.TabIndex = 15
        '
        'OffTerm
        '
        Me.OffTerm.BackgroundImage = Global.StudentDashboard.My.Resources.Resources.out_of_term_table_new
        Me.OffTerm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.OffTerm.Location = New System.Drawing.Point(22, 41)
        Me.OffTerm.Name = "OffTerm"
        Me.OffTerm.Size = New System.Drawing.Size(1005, 635)
        Me.OffTerm.TabIndex = 14
        '
        'Weekday
        '
        Me.Weekday.AutoScroll = True
        Me.Weekday.BackgroundImage = Global.StudentDashboard.My.Resources.Resources.term_table_new
        Me.Weekday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Weekday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Weekday.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.Weekday.Location = New System.Drawing.Point(22, 41)
        Me.Weekday.Name = "Weekday"
        Me.Weekday.Size = New System.Drawing.Size(1141, 881)
        Me.Weekday.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(680, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Bus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1195, 532)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Weekend)
        Me.Controls.Add(Me.OffTerm)
        Me.Controls.Add(Me.OutOfTerm)
        Me.Controls.Add(Me.WeekendButton)
        Me.Controls.Add(Me.WeekdayButton)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.Weekday)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Bus"
        Me.Text = "Shuttle Bus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateLabel As System.Windows.Forms.Label
    Friend WithEvents WeekdayButton As System.Windows.Forms.Button
    Friend WithEvents WeekendButton As System.Windows.Forms.Button
    Friend WithEvents OutOfTerm As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Weekday As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents OffTerm As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Weekend As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
