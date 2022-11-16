<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.exitIcon = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.exitIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.exitIcon.Image = Global.JMGv2._0.My.Resources.Resources.Login_Small
        Me.exitIcon.Location = New System.Drawing.Point(-1, -3)
        Me.exitIcon.Name = "PictureBox1"
        Me.exitIcon.Size = New System.Drawing.Size(790, 567)
        Me.exitIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.exitIcon.TabIndex = 0
        Me.exitIcon.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(65, 42)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(521, 444)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.exitIcon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.exitIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents exitIcon As PictureBox
    Friend WithEvents CreateLabel As Label
    Friend WithEvents Lname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Fname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Mname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents position As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents password As TextBox
    Friend WithEvents SignUpBtn As Button
    Friend WithEvents PictureBox3 As PictureBox
End Class
