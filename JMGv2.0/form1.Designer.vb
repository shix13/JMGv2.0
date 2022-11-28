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
        Me.AccPass = New System.Windows.Forms.TextBox()
        Me.LinkSignUp = New System.Windows.Forms.LinkLabel()
        Me.LabelNewAcc = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList3 = New System.Windows.Forms.ImageList(Me.components)
        Me.AccID = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginBtn
        '
        Me.LoginBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LoginBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LoginBtn.Location = New System.Drawing.Point(195, 312)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(114, 47)
        Me.LoginBtn.TabIndex = 0
        Me.LoginBtn.Text = "Login"
        Me.LoginBtn.UseVisualStyleBackColor = False
        '
        'AccPass
        '
        Me.AccPass.Location = New System.Drawing.Point(124, 247)
        Me.AccPass.Name = "AccPass"
        Me.AccPass.PlaceholderText = "Password"
        Me.AccPass.Size = New System.Drawing.Size(258, 27)
        Me.AccPass.TabIndex = 3
        '
        'LinkSignUp
        '
        Me.LinkSignUp.AutoSize = True
        Me.LinkSignUp.LinkColor = System.Drawing.Color.Yellow
        Me.LinkSignUp.Location = New System.Drawing.Point(212, 427)
        Me.LinkSignUp.Name = "LinkSignUp"
        Me.LinkSignUp.Size = New System.Drawing.Size(61, 20)
        Me.LinkSignUp.TabIndex = 4
        Me.LinkSignUp.TabStop = True
        Me.LinkSignUp.Text = "Sign Up"
        '
        'LabelNewAcc
        '
        Me.LabelNewAcc.AutoSize = True
        Me.LabelNewAcc.ForeColor = System.Drawing.Color.White
        Me.LabelNewAcc.Location = New System.Drawing.Point(169, 400)
        Me.LabelNewAcc.Name = "LabelNewAcc"
        Me.LabelNewAcc.Size = New System.Drawing.Size(151, 20)
        Me.LabelNewAcc.TabIndex = 5
        Me.LabelNewAcc.Text = "Create New Account?"
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
        'AccID
        '
        Me.AccID.Location = New System.Drawing.Point(124, 176)
        Me.AccID.Name = "AccID"
        Me.AccID.PlaceholderText = "Account ID"
        Me.AccID.Size = New System.Drawing.Size(258, 27)
        Me.AccID.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.LabelNewAcc)
        Me.Panel1.Controls.Add(Me.AccID)
        Me.Panel1.Controls.Add(Me.LinkSignUp)
        Me.Panel1.Controls.Add(Me.AccPass)
        Me.Panel1.Controls.Add(Me.LoginBtn)
        Me.Panel1.Location = New System.Drawing.Point(186, 126)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 500)
        Me.Panel1.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.JMGv2._0.My.Resources.Resources.logo_small_2
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(176, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.BackgroundImage = Global.JMGv2._0.My.Resources.Resources.Background_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(882, 753)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.Name = "form1"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoginBtn As Button
    Friend WithEvents AccPass As TextBox
    Friend WithEvents LinkSignUp As LinkLabel
    Friend WithEvents LabelNewAcc As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents ImageList3 As ImageList
    Friend WithEvents AccID As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
