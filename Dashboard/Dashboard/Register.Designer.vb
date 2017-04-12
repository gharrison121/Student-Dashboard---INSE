<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PasswordInput = New System.Windows.Forms.TextBox()
        Me.UserNameInput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ConfirmPasswordInput = New System.Windows.Forms.TextBox()
        Me.PasswordError = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RegisterButton
        '
        Me.RegisterButton.Location = New System.Drawing.Point(473, 463)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(75, 23)
        Me.RegisterButton.TabIndex = 13
        Me.RegisterButton.Text = "Register"
        Me.RegisterButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(284, 378)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(284, 347)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Username:"
        '
        'PasswordInput
        '
        Me.PasswordInput.Location = New System.Drawing.Point(394, 375)
        Me.PasswordInput.Name = "PasswordInput"
        Me.PasswordInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordInput.Size = New System.Drawing.Size(240, 20)
        Me.PasswordInput.TabIndex = 8
        '
        'UserNameInput
        '
        Me.UserNameInput.Location = New System.Drawing.Point(394, 340)
        Me.UserNameInput.Name = "UserNameInput"
        Me.UserNameInput.Size = New System.Drawing.Size(240, 20)
        Me.UserNameInput.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(284, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Email:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(394, 302)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(240, 20)
        Me.TextBox1.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(284, 420)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Confirm password:"
        '
        'ConfirmPasswordInput
        '
        Me.ConfirmPasswordInput.Location = New System.Drawing.Point(394, 413)
        Me.ConfirmPasswordInput.Name = "ConfirmPasswordInput"
        Me.ConfirmPasswordInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPasswordInput.Size = New System.Drawing.Size(240, 20)
        Me.ConfirmPasswordInput.TabIndex = 16
        '
        'PasswordError
        '
        Me.PasswordError.AutoSize = True
        Me.PasswordError.ForeColor = System.Drawing.Color.White
        Me.PasswordError.Location = New System.Drawing.Point(419, 436)
        Me.PasswordError.Name = "PasswordError"
        Me.PasswordError.Size = New System.Drawing.Size(168, 13)
        Me.PasswordError.TabIndex = 18
        Me.PasswordError.Text = "Both Passwords Must Be Identical"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StudentDashboard.My.Resources.Resources.log_in_logo
        Me.PictureBox1.Location = New System.Drawing.Point(422, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(183, 193)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 601)
        Me.Controls.Add(Me.PasswordError)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ConfirmPasswordInput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RegisterButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PasswordInput)
        Me.Controls.Add(Me.UserNameInput)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Register"
        Me.Text = "Register"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RegisterButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PasswordInput As System.Windows.Forms.TextBox
    Friend WithEvents UserNameInput As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ConfirmPasswordInput As System.Windows.Forms.TextBox
    Friend WithEvents PasswordError As System.Windows.Forms.Label
End Class
