<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogIn))
        Me.UserNameInput = New System.Windows.Forms.TextBox()
        Me.PasswordInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LogInButton = New System.Windows.Forms.Button()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LogInError = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserNameInput
        '
        Me.UserNameInput.Location = New System.Drawing.Point(395, 354)
        Me.UserNameInput.Name = "UserNameInput"
        Me.UserNameInput.Size = New System.Drawing.Size(240, 20)
        Me.UserNameInput.TabIndex = 0
        '
        'PasswordInput
        '
        Me.PasswordInput.Location = New System.Drawing.Point(395, 389)
        Me.PasswordInput.Name = "PasswordInput"
        Me.PasswordInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordInput.Size = New System.Drawing.Size(240, 20)
        Me.PasswordInput.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(309, 361)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(309, 396)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'LogInButton
        '
        Me.LogInButton.Location = New System.Drawing.Point(423, 439)
        Me.LogInButton.Name = "LogInButton"
        Me.LogInButton.Size = New System.Drawing.Size(75, 23)
        Me.LogInButton.TabIndex = 5
        Me.LogInButton.Text = "Log in"
        Me.LogInButton.UseVisualStyleBackColor = True
        '
        'RegisterButton
        '
        Me.RegisterButton.Location = New System.Drawing.Point(518, 439)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(75, 23)
        Me.RegisterButton.TabIndex = 6
        Me.RegisterButton.Text = "Register"
        Me.RegisterButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StudentDashboard.My.Resources.Resources.log_in_logo
        Me.PictureBox1.Location = New System.Drawing.Point(423, 138)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(183, 193)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'LogInError
        '
        Me.LogInError.AutoSize = True
        Me.LogInError.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LogInError.Location = New System.Drawing.Point(405, 423)
        Me.LogInError.Name = "LogInError"
        Me.LogInError.Size = New System.Drawing.Size(218, 13)
        Me.LogInError.TabIndex = 7
        Me.LogInError.Text = "Please enter a valid usename and password!"
        Me.LogInError.Visible = False
        '
        'LogIn
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 632)
        Me.Controls.Add(Me.LogInError)
        Me.Controls.Add(Me.RegisterButton)
        Me.Controls.Add(Me.LogInButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PasswordInput)
        Me.Controls.Add(Me.UserNameInput)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LogIn"
        Me.Text = "Log In"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents PasswordInput As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LogInButton As System.Windows.Forms.Button
    Friend WithEvents RegisterButton As System.Windows.Forms.Button
    Friend WithEvents LogInError As System.Windows.Forms.Label
    Public WithEvents UserNameInput As System.Windows.Forms.TextBox
End Class
