<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form1
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
        Me.components = New System.ComponentModel.Container()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.AccID = New System.Windows.Forms.TextBox()
        Me.AccPass = New System.Windows.Forms.TextBox()
        Me.LinkSignUp = New System.Windows.Forms.LinkLabel()
        Me.LabelNewAcc = New System.Windows.Forms.Label()
        Me.Background = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList3 = New System.Windows.Forms.ImageList(Me.components)
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.exitIcon = New System.Windows.Forms.PictureBox()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginBtn
        '
        Me.LoginBtn.BackColor = System.Drawing.SystemColors.GrayText
        Me.LoginBtn.Font = New System.Drawing.Font("REVOLUTION", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LoginBtn.Location = New System.Drawing.Point(343, 317)
        Me.LoginBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(99, 35)
        Me.LoginBtn.TabIndex = 0
        Me.LoginBtn.Text = "Log In"
        Me.LoginBtn.UseVisualStyleBackColor = False
        '
        'AccID
        '
        Me.AccID.Location = New System.Drawing.Point(281, 218)
        Me.AccID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AccID.Name = "AccID"
        Me.AccID.PlaceholderText = "Account ID"
        Me.AccID.Size = New System.Drawing.Size(226, 23)
        Me.AccID.TabIndex = 2
        '
        'AccPass
        '
        Me.AccPass.Location = New System.Drawing.Point(281, 273)
        Me.AccPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AccPass.Name = "AccPass"
        Me.AccPass.PlaceholderText = "Password"
        Me.AccPass.Size = New System.Drawing.Size(226, 23)
        Me.AccPass.TabIndex = 3
        '
        'LinkSignUp
        '
        Me.LinkSignUp.AutoSize = True
        Me.LinkSignUp.LinkColor = System.Drawing.Color.Yellow
        Me.LinkSignUp.Location = New System.Drawing.Point(367, 412)
        Me.LinkSignUp.Name = "LinkSignUp"
        Me.LinkSignUp.Size = New System.Drawing.Size(48, 15)
        Me.LinkSignUp.TabIndex = 4
        Me.LinkSignUp.TabStop = True
        Me.LinkSignUp.Text = "Sign Up"
        '
        'LabelNewAcc
        '
        Me.LabelNewAcc.AutoSize = True
        Me.LabelNewAcc.ForeColor = System.Drawing.Color.White
        Me.LabelNewAcc.Location = New System.Drawing.Point(331, 385)
        Me.LabelNewAcc.Name = "LabelNewAcc"
        Me.LabelNewAcc.Size = New System.Drawing.Size(121, 15)
        Me.LabelNewAcc.TabIndex = 5
        Me.LabelNewAcc.Text = "Create New Account?"
        '
        'Background
        '
        Me.Background.Image = Global.JMGv2._0.My.Resources.Resources.Login_Small
        Me.Background.Location = New System.Drawing.Point(-6, -6)
        Me.Background.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Background.Name = "Background"
        Me.Background.Size = New System.Drawing.Size(796, 571)
        Me.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Background.TabIndex = 6
        Me.Background.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImageList3
        '
        Me.ImageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList3.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList3.TransparentColor = System.Drawing.Color.Transparent
        '
        'Logo
        '
        Me.Logo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Logo.Image = Global.JMGv2._0.My.Resources.Resources.logo_small_2
        Me.Logo.Location = New System.Drawing.Point(347, 110)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(95, 94)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo.TabIndex = 7
        Me.Logo.TabStop = False
        '
        'exitIcon
        '
        Me.exitIcon.Image = Global.JMGv2._0.My.Resources.Resources.Red_wrong_mark_icon_vector_PNG
        Me.exitIcon.Location = New System.Drawing.Point(732, 6)
        Me.exitIcon.Name = "exitIcon"
        Me.exitIcon.Size = New System.Drawing.Size(48, 42)
        Me.exitIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.exitIcon.TabIndex = 8
        Me.exitIcon.TabStop = False
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.exitIcon)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.LabelNewAcc)
        Me.Controls.Add(Me.LinkSignUp)
        Me.Controls.Add(Me.AccPass)
        Me.Controls.Add(Me.AccID)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.Background)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "form1"
        Me.Text = "Form1"
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exitIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginBtn As Button
    Friend WithEvents AccID As TextBox
    Friend WithEvents AccPass As TextBox
    Friend WithEvents LinkSignUp As LinkLabel
    Friend WithEvents LabelNewAcc As Label
    Friend WithEvents Background As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents ImageList3 As ImageList
    Friend WithEvents Logo As PictureBox
    Friend WithEvents exitIcon As PictureBox
End Class
