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
        Dim Footer As System.Windows.Forms.GroupBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Timetable))
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.UniPorts = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Footer = New System.Windows.Forms.GroupBox()
        Footer.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Footer.Location = New System.Drawing.Point(10, 628)
        Footer.Name = "Footer"
        Footer.Size = New System.Drawing.Size(974, 109)
        Footer.TabIndex = 11
        Footer.TabStop = False
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(948, 576)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Timetable"
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
        Me.Label5.Location = New System.Drawing.Point(850, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Friday"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(670, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Thursday"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(490, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Wednesday"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(310, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tuesday"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(130, 20)
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(106, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DateLabel.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLabel.Location = New System.Drawing.Point(838, 5)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(59, 27)
        Me.DateLabel.TabIndex = 15
        Me.DateLabel.Text = "Date"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timetable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 749)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.newLesson)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Footer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Timetable"
        Me.Text = "Timetable"
        Footer.ResumeLayout(False)
        Footer.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LinkLabel6 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel5 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents UniPorts As System.Windows.Forms.LinkLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents newLesson As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
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
End Class
