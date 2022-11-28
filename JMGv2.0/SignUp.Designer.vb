<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignUp
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.txtbLName = New System.Windows.Forms.TextBox()
        Me.txtbFName = New System.Windows.Forms.TextBox()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.txtbMName = New System.Windows.Forms.TextBox()
        Me.lblMName = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.txtbPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbPosition = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(132, 101)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(650, 650)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Myanmar Text", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(213, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(481, 71)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CREATE NEW ACCOUNT"
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.lblLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblLName.Location = New System.Drawing.Point(305, 233)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(123, 29)
        Me.lblLName.TabIndex = 3
        Me.lblLName.Text = "Last name"
        '
        'txtbLName
        '
        Me.txtbLName.Location = New System.Drawing.Point(305, 265)
        Me.txtbLName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbLName.Name = "txtbLName"
        Me.txtbLName.Size = New System.Drawing.Size(277, 27)
        Me.txtbLName.TabIndex = 4
        '
        'txtbFName
        '
        Me.txtbFName.Location = New System.Drawing.Point(305, 343)
        Me.txtbFName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbFName.Name = "txtbFName"
        Me.txtbFName.Size = New System.Drawing.Size(277, 27)
        Me.txtbFName.TabIndex = 6
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.lblFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblFName.Location = New System.Drawing.Point(305, 310)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(126, 29)
        Me.lblFName.TabIndex = 5
        Me.lblFName.Text = "First name"
        '
        'txtbMName
        '
        Me.txtbMName.Location = New System.Drawing.Point(305, 423)
        Me.txtbMName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbMName.Name = "txtbMName"
        Me.txtbMName.Size = New System.Drawing.Size(277, 27)
        Me.txtbMName.TabIndex = 8
        '
        'lblMName
        '
        Me.lblMName.AutoSize = True
        Me.lblMName.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.lblMName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblMName.Location = New System.Drawing.Point(305, 391)
        Me.lblMName.Name = "lblMName"
        Me.lblMName.Size = New System.Drawing.Size(153, 29)
        Me.lblMName.TabIndex = 7
        Me.lblMName.Text = "Middle name"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.lblPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPosition.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblPosition.Location = New System.Drawing.Point(305, 471)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(100, 29)
        Me.lblPosition.TabIndex = 9
        Me.lblPosition.Text = "Position"
        '
        'txtbPassword
        '
        Me.txtbPassword.Location = New System.Drawing.Point(305, 587)
        Me.txtbPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbPassword.Name = "txtbPassword"
        Me.txtbPassword.Size = New System.Drawing.Size(277, 27)
        Me.txtbPassword.TabIndex = 12
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPassword.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblPassword.Location = New System.Drawing.Point(305, 554)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(120, 29)
        Me.lblPassword.TabIndex = 11
        Me.lblPassword.Text = "Password"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.Snow
        Me.Button1.Location = New System.Drawing.Point(385, 658)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 52)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "SIGN UP"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmbPosition
        '
        Me.cmbPosition.FormattingEnabled = True
        Me.cmbPosition.Location = New System.Drawing.Point(305, 503)
        Me.cmbPosition.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.Size = New System.Drawing.Size(277, 28)
        Me.cmbPosition.TabIndex = 14
        Me.cmbPosition.Text = "Select"
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.BackgroundImage = Global.JMGv2._0.My.Resources.Resources.Background_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(882, 853)
        Me.Controls.Add(Me.cmbPosition)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtbPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.txtbMName)
        Me.Controls.Add(Me.lblMName)
        Me.Controls.Add(Me.txtbFName)
        Me.Controls.Add(Me.lblFName)
        Me.Controls.Add(Me.txtbLName)
        Me.Controls.Add(Me.lblLName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.MaximizeBox = False
        Me.Name = "SignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign Up"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CreateLabel As Label
    Friend WithEvents Lname As TextBox
    Friend WithEvents lblLName As Label
    Friend WithEvents lblFName As Label
    Friend WithEvents Fname As TextBox
    Friend WithEvents lblMName As Label
    Friend WithEvents Mname As TextBox
    Friend WithEvents lblPosition As Label
    Friend WithEvents position As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents password As TextBox
    Friend WithEvents SignUpBtn As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbLName As TextBox
    Friend WithEvents txtbFName As TextBox
    Friend WithEvents txtbMName As TextBox
    Friend WithEvents txtbPassword As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbPosition As ComboBox
End Class
