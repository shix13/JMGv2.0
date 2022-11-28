<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtAccID = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.lblSignUp = New System.Windows.Forms.Label()
        Me.linkSignUp = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(152, 163)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(550, 550)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PictureBox1.BackgroundImage = Global.JMGv2._0.My.Resources.Resources.logo_small_2
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(354, 218)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 178)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'txtAccID
        '
        Me.txtAccID.Location = New System.Drawing.Point(298, 415)
        Me.txtAccID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAccID.Name = "txtAccID"
        Me.txtAccID.PlaceholderText = "Account ID"
        Me.txtAccID.Size = New System.Drawing.Size(277, 27)
        Me.txtAccID.TabIndex = 4
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(298, 466)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.PlaceholderText = "Password"
        Me.txtPass.Size = New System.Drawing.Size(277, 27)
        Me.txtPass.TabIndex = 6
        '
        'LoginBtn
        '
        Me.LoginBtn.BackColor = System.Drawing.Color.Transparent
        Me.LoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LoginBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LoginBtn.ForeColor = System.Drawing.Color.Snow
        Me.LoginBtn.Location = New System.Drawing.Point(376, 527)
        Me.LoginBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(111, 39)
        Me.LoginBtn.TabIndex = 13
        Me.LoginBtn.Text = "Login"
        Me.LoginBtn.UseVisualStyleBackColor = False
        '
        'lblSignUp
        '
        Me.lblSignUp.AutoSize = True
        Me.lblSignUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.lblSignUp.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSignUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSignUp.Location = New System.Drawing.Point(354, 606)
        Me.lblSignUp.Name = "lblSignUp"
        Me.lblSignUp.Size = New System.Drawing.Size(157, 23)
        Me.lblSignUp.TabIndex = 15
        Me.lblSignUp.Text = "Create an account?"
        '
        'linkSignUp
        '
        Me.linkSignUp.ActiveLinkColor = System.Drawing.Color.Red
        Me.linkSignUp.AutoSize = True
        Me.linkSignUp.LinkColor = System.Drawing.Color.Yellow
        Me.linkSignUp.Location = New System.Drawing.Point(400, 637)
        Me.linkSignUp.Name = "linkSignUp"
        Me.linkSignUp.Size = New System.Drawing.Size(61, 20)
        Me.linkSignUp.TabIndex = 16
        Me.linkSignUp.TabStop = True
        Me.linkSignUp.Text = "Sign Up"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.BackgroundImage = Global.JMGv2._0.My.Resources.Resources.Background_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(882, 853)
        Me.Controls.Add(Me.linkSignUp)
        Me.Controls.Add(Me.lblSignUp)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtAccID)
        Me.Controls.Add(Me.PictureBox2)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CreateLabel As Label
    Friend WithEvents Lname As TextBox
    Friend WithEvents Fname As TextBox
    Friend WithEvents Mname As TextBox
    Friend WithEvents position As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents SignUpBtn As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtAccID As TextBox
    Friend WithEvents LoginBtn As Button
    Friend WithEvents lblSignUp As Label
    Friend WithEvents linkSignUp As LinkLabel
    Protected Friend WithEvents txtPass As TextBox
End Class
