<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pay
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
        Me.leftSideBar = New System.Windows.Forms.Panel()
        Me.PurIconBtn = New System.Windows.Forms.Button()
        Me.AccIconBtn = New System.Windows.Forms.Button()
        Me.MainIconBtn = New System.Windows.Forms.Button()
        Me.dtpPanelDate = New System.Windows.Forms.DateTimePicker()
        Me.logoutBtn = New System.Windows.Forms.Button()
        Me.PayIconBtn = New System.Windows.Forms.Button()
        Me.lblPanelWelcome = New System.Windows.Forms.Label()
        Me.OrderIconBtn = New System.Windows.Forms.Button()
        Me.PurBtn = New System.Windows.Forms.Button()
        Me.AccBtn = New System.Windows.Forms.Button()
        Me.MainBtn = New System.Windows.Forms.Button()
        Me.PayBtn = New System.Windows.Forms.Button()
        Me.OrderBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPanelMenuBar = New System.Windows.Forms.Label()
        Me.MenuBarBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblOrderNo = New System.Windows.Forms.Label()
        Me.txtbOrderNo = New System.Windows.Forms.TextBox()
        Me.ConfirmBtn = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.dgvPayment = New System.Windows.Forms.DataGridView()
        Me.lblReceiptNo = New System.Windows.Forms.Label()
        Me.lblAmountPay = New System.Windows.Forms.Label()
        Me.lblTableNum = New System.Windows.Forms.Label()
        Me.txtbAmountPay = New System.Windows.Forms.TextBox()
        Me.cmbTableNum = New System.Windows.Forms.ComboBox()
        Me.txtbReceiptNo = New System.Windows.Forms.TextBox()
        Me.leftSideBar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'leftSideBar
        '
        Me.leftSideBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.leftSideBar.Controls.Add(Me.PurIconBtn)
        Me.leftSideBar.Controls.Add(Me.AccIconBtn)
        Me.leftSideBar.Controls.Add(Me.MainIconBtn)
        Me.leftSideBar.Controls.Add(Me.dtpPanelDate)
        Me.leftSideBar.Controls.Add(Me.logoutBtn)
        Me.leftSideBar.Controls.Add(Me.PayIconBtn)
        Me.leftSideBar.Controls.Add(Me.lblPanelWelcome)
        Me.leftSideBar.Controls.Add(Me.OrderIconBtn)
        Me.leftSideBar.Controls.Add(Me.PurBtn)
        Me.leftSideBar.Controls.Add(Me.AccBtn)
        Me.leftSideBar.Controls.Add(Me.MainBtn)
        Me.leftSideBar.Controls.Add(Me.PayBtn)
        Me.leftSideBar.Controls.Add(Me.OrderBtn)
        Me.leftSideBar.Controls.Add(Me.Panel1)
        Me.leftSideBar.Location = New System.Drawing.Point(0, 0)
        Me.leftSideBar.Margin = New System.Windows.Forms.Padding(0)
        Me.leftSideBar.Name = "leftSideBar"
        Me.leftSideBar.Size = New System.Drawing.Size(60, 859)
        Me.leftSideBar.TabIndex = 0
        '
        'PurIconBtn
        '
        Me.PurIconBtn.BackColor = System.Drawing.Color.Transparent
        Me.PurIconBtn.BackgroundImage = Global.JMGv2._0.My.Resources.Resources.kart
        Me.PurIconBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PurIconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PurIconBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PurIconBtn.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.PurIconBtn.Location = New System.Drawing.Point(5, 625)
        Me.PurIconBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PurIconBtn.Name = "PurIconBtn"
        Me.PurIconBtn.Size = New System.Drawing.Size(49, 65)
        Me.PurIconBtn.TabIndex = 26
        Me.PurIconBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.PurIconBtn.UseVisualStyleBackColor = False
        '
        'AccIconBtn
        '
        Me.AccIconBtn.BackColor = System.Drawing.Color.Transparent
        Me.AccIconBtn.BackgroundImage = Global.JMGv2._0.My.Resources.Resources.profile_acc
        Me.AccIconBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AccIconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AccIconBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.AccIconBtn.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.AccIconBtn.Location = New System.Drawing.Point(6, 520)
        Me.AccIconBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AccIconBtn.Name = "AccIconBtn"
        Me.AccIconBtn.Size = New System.Drawing.Size(49, 65)
        Me.AccIconBtn.TabIndex = 25
        Me.AccIconBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AccIconBtn.UseVisualStyleBackColor = False
        '
        'MainIconBtn
        '
        Me.MainIconBtn.BackColor = System.Drawing.Color.Transparent
        Me.MainIconBtn.BackgroundImage = Global.JMGv2._0.My.Resources.Resources.Daco_4626465
        Me.MainIconBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MainIconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainIconBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.MainIconBtn.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.MainIconBtn.Location = New System.Drawing.Point(6, 415)
        Me.MainIconBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MainIconBtn.Name = "MainIconBtn"
        Me.MainIconBtn.Size = New System.Drawing.Size(49, 65)
        Me.MainIconBtn.TabIndex = 24
        Me.MainIconBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MainIconBtn.UseVisualStyleBackColor = False
        '
        'dtpPanelDate
        '
        Me.dtpPanelDate.CalendarMonthBackground = System.Drawing.Color.DarkGray
        Me.dtpPanelDate.Enabled = False
        Me.dtpPanelDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPanelDate.Location = New System.Drawing.Point(78, 124)
        Me.dtpPanelDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpPanelDate.Name = "dtpPanelDate"
        Me.dtpPanelDate.Size = New System.Drawing.Size(114, 27)
        Me.dtpPanelDate.TabIndex = 22
        '
        'logoutBtn
        '
        Me.logoutBtn.BackColor = System.Drawing.Color.White
        Me.logoutBtn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.logoutBtn.Location = New System.Drawing.Point(78, 747)
        Me.logoutBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.logoutBtn.Name = "logoutBtn"
        Me.logoutBtn.Size = New System.Drawing.Size(101, 49)
        Me.logoutBtn.TabIndex = 19
        Me.logoutBtn.Text = "LOGOUT"
        Me.logoutBtn.UseVisualStyleBackColor = False
        '
        'PayIconBtn
        '
        Me.PayIconBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.PayIconBtn.BackgroundImage = Global.JMGv2._0.My.Resources.Resources.PngItem_877239
        Me.PayIconBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PayIconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PayIconBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PayIconBtn.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.PayIconBtn.Location = New System.Drawing.Point(6, 309)
        Me.PayIconBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PayIconBtn.Name = "PayIconBtn"
        Me.PayIconBtn.Size = New System.Drawing.Size(49, 65)
        Me.PayIconBtn.TabIndex = 15
        Me.PayIconBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.PayIconBtn.UseVisualStyleBackColor = False
        '
        'lblPanelWelcome
        '
        Me.lblPanelWelcome.AutoSize = True
        Me.lblPanelWelcome.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPanelWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPanelWelcome.Location = New System.Drawing.Point(54, 86)
        Me.lblPanelWelcome.Name = "lblPanelWelcome"
        Me.lblPanelWelcome.Size = New System.Drawing.Size(178, 25)
        Me.lblPanelWelcome.TabIndex = 23
        Me.lblPanelWelcome.Text = "WELCOME, ADMIN"
        Me.lblPanelWelcome.Visible = False
        '
        'OrderIconBtn
        '
        Me.OrderIconBtn.BackColor = System.Drawing.Color.Transparent
        Me.OrderIconBtn.BackgroundImage = Global.JMGv2._0.My.Resources.Resources.pinpng_com_checklist_icon_png_2009984
        Me.OrderIconBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.OrderIconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OrderIconBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.OrderIconBtn.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.OrderIconBtn.Location = New System.Drawing.Point(6, 207)
        Me.OrderIconBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OrderIconBtn.Name = "OrderIconBtn"
        Me.OrderIconBtn.Size = New System.Drawing.Size(49, 65)
        Me.OrderIconBtn.TabIndex = 14
        Me.OrderIconBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.OrderIconBtn.UseVisualStyleBackColor = False
        '
        'PurBtn
        '
        Me.PurBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PurBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PurBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PurBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PurBtn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PurBtn.ForeColor = System.Drawing.Color.White
        Me.PurBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PurBtn.Location = New System.Drawing.Point(54, 625)
        Me.PurBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PurBtn.Name = "PurBtn"
        Me.PurBtn.Size = New System.Drawing.Size(200, 65)
        Me.PurBtn.TabIndex = 12
        Me.PurBtn.Text = "PURCHASE ORDER"
        Me.PurBtn.UseVisualStyleBackColor = False
        '
        'AccBtn
        '
        Me.AccBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.AccBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.AccBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.AccBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AccBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AccBtn.ForeColor = System.Drawing.Color.White
        Me.AccBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AccBtn.Location = New System.Drawing.Point(57, 520)
        Me.AccBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AccBtn.Name = "AccBtn"
        Me.AccBtn.Size = New System.Drawing.Size(200, 65)
        Me.AccBtn.TabIndex = 10
        Me.AccBtn.Text = "ACCOUNT"
        Me.AccBtn.UseVisualStyleBackColor = False
        '
        'MainBtn
        '
        Me.MainBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.MainBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MainBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.MainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainBtn.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MainBtn.ForeColor = System.Drawing.Color.White
        Me.MainBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainBtn.Location = New System.Drawing.Point(54, 415)
        Me.MainBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MainBtn.Name = "MainBtn"
        Me.MainBtn.Size = New System.Drawing.Size(200, 65)
        Me.MainBtn.TabIndex = 8
        Me.MainBtn.Text = " MAINTENANCE"
        Me.MainBtn.UseVisualStyleBackColor = False
        '
        'PayBtn
        '
        Me.PayBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.PayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PayBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PayBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PayBtn.ForeColor = System.Drawing.Color.White
        Me.PayBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PayBtn.Location = New System.Drawing.Point(54, 309)
        Me.PayBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PayBtn.Name = "PayBtn"
        Me.PayBtn.Size = New System.Drawing.Size(200, 65)
        Me.PayBtn.TabIndex = 6
        Me.PayBtn.Text = "PAYMENT"
        Me.PayBtn.UseVisualStyleBackColor = False
        '
        'OrderBtn
        '
        Me.OrderBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.OrderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.OrderBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.OrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OrderBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OrderBtn.ForeColor = System.Drawing.Color.White
        Me.OrderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OrderBtn.Location = New System.Drawing.Point(54, 207)
        Me.OrderBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OrderBtn.Name = "OrderBtn"
        Me.OrderBtn.Size = New System.Drawing.Size(200, 65)
        Me.OrderBtn.TabIndex = 4
        Me.OrderBtn.Text = "ORDER"
        Me.OrderBtn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblPanelMenuBar)
        Me.Panel1.Controls.Add(Me.MenuBarBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(60, 56)
        Me.Panel1.TabIndex = 16
        '
        'lblPanelMenuBar
        '
        Me.lblPanelMenuBar.AutoSize = True
        Me.lblPanelMenuBar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPanelMenuBar.ForeColor = System.Drawing.Color.White
        Me.lblPanelMenuBar.Location = New System.Drawing.Point(62, 16)
        Me.lblPanelMenuBar.Name = "lblPanelMenuBar"
        Me.lblPanelMenuBar.Size = New System.Drawing.Size(99, 23)
        Me.lblPanelMenuBar.TabIndex = 14
        Me.lblPanelMenuBar.Text = "MENU BAR"
        '
        'MenuBarBtn
        '
        Me.MenuBarBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.MenuBarBtn.BackgroundImage = Global.JMGv2._0.My.Resources.Resources.clipart365828
        Me.MenuBarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MenuBarBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.MenuBarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuBarBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.MenuBarBtn.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.MenuBarBtn.Location = New System.Drawing.Point(14, 0)
        Me.MenuBarBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MenuBarBtn.Name = "MenuBarBtn"
        Me.MenuBarBtn.Size = New System.Drawing.Size(46, 56)
        Me.MenuBarBtn.TabIndex = 13
        Me.MenuBarBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MenuBarBtn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.BackgroundImage = Global.JMGv2._0.My.Resources.Resources.Background_1
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1286, 120)
        Me.Panel2.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(414, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(537, 74)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "CREATE PAYMENT"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Controls.Add(Me.lblOrderNo)
        Me.Panel3.Controls.Add(Me.txtbOrderNo)
        Me.Panel3.Controls.Add(Me.ConfirmBtn)
        Me.Panel3.Controls.Add(Me.CloseBtn)
        Me.Panel3.Controls.Add(Me.dgvPayment)
        Me.Panel3.Controls.Add(Me.lblReceiptNo)
        Me.Panel3.Controls.Add(Me.lblAmountPay)
        Me.Panel3.Controls.Add(Me.lblTableNum)
        Me.Panel3.Controls.Add(Me.txtbAmountPay)
        Me.Panel3.Controls.Add(Me.cmbTableNum)
        Me.Panel3.Controls.Add(Me.txtbReceiptNo)
        Me.Panel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(54, 120)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1232, 739)
        Me.Panel3.TabIndex = 2
        '
        'lblOrderNo
        '
        Me.lblOrderNo.AutoSize = True
        Me.lblOrderNo.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblOrderNo.ForeColor = System.Drawing.Color.White
        Me.lblOrderNo.Location = New System.Drawing.Point(127, 302)
        Me.lblOrderNo.Name = "lblOrderNo"
        Me.lblOrderNo.Size = New System.Drawing.Size(171, 27)
        Me.lblOrderNo.TabIndex = 3
        Me.lblOrderNo.Text = "Order Number"
        '
        'txtbOrderNo
        '
        Me.txtbOrderNo.Location = New System.Drawing.Point(127, 333)
        Me.txtbOrderNo.Name = "txtbOrderNo"
        Me.txtbOrderNo.Size = New System.Drawing.Size(306, 27)
        Me.txtbOrderNo.TabIndex = 14
        '
        'ConfirmBtn
        '
        Me.ConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ConfirmBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ConfirmBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ConfirmBtn.Location = New System.Drawing.Point(127, 537)
        Me.ConfirmBtn.Name = "ConfirmBtn"
        Me.ConfirmBtn.Size = New System.Drawing.Size(178, 37)
        Me.ConfirmBtn.TabIndex = 13
        Me.ConfirmBtn.Text = "Confirm Payment"
        Me.ConfirmBtn.UseVisualStyleBackColor = True
        '
        'CloseBtn
        '
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CloseBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CloseBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.CloseBtn.Location = New System.Drawing.Point(334, 537)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(99, 37)
        Me.CloseBtn.TabIndex = 11
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'dgvPayment
        '
        Me.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPayment.Location = New System.Drawing.Point(521, 71)
        Me.dgvPayment.Name = "dgvPayment"
        Me.dgvPayment.RowHeadersWidth = 51
        Me.dgvPayment.RowTemplate.Height = 29
        Me.dgvPayment.Size = New System.Drawing.Size(609, 592)
        Me.dgvPayment.TabIndex = 7
        '
        'lblReceiptNo
        '
        Me.lblReceiptNo.AutoSize = True
        Me.lblReceiptNo.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblReceiptNo.ForeColor = System.Drawing.Color.White
        Me.lblReceiptNo.Location = New System.Drawing.Point(127, 104)
        Me.lblReceiptNo.Name = "lblReceiptNo"
        Me.lblReceiptNo.Size = New System.Drawing.Size(194, 27)
        Me.lblReceiptNo.TabIndex = 5
        Me.lblReceiptNo.Text = "Receipt Number"
        '
        'lblAmountPay
        '
        Me.lblAmountPay.AutoSize = True
        Me.lblAmountPay.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAmountPay.ForeColor = System.Drawing.Color.White
        Me.lblAmountPay.Location = New System.Drawing.Point(127, 402)
        Me.lblAmountPay.Name = "lblAmountPay"
        Me.lblAmountPay.Size = New System.Drawing.Size(178, 27)
        Me.lblAmountPay.TabIndex = 4
        Me.lblAmountPay.Text = "Amount to pay"
        '
        'lblTableNum
        '
        Me.lblTableNum.AutoSize = True
        Me.lblTableNum.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTableNum.ForeColor = System.Drawing.Color.White
        Me.lblTableNum.Location = New System.Drawing.Point(127, 203)
        Me.lblTableNum.Name = "lblTableNum"
        Me.lblTableNum.Size = New System.Drawing.Size(169, 27)
        Me.lblTableNum.TabIndex = 3
        Me.lblTableNum.Text = "Table Number"
        '
        'txtbAmountPay
        '
        Me.txtbAmountPay.Location = New System.Drawing.Point(127, 433)
        Me.txtbAmountPay.Name = "txtbAmountPay"
        Me.txtbAmountPay.Size = New System.Drawing.Size(306, 27)
        Me.txtbAmountPay.TabIndex = 2
        '
        'cmbTableNum
        '
        Me.cmbTableNum.FormattingEnabled = True
        Me.cmbTableNum.Location = New System.Drawing.Point(127, 233)
        Me.cmbTableNum.Name = "cmbTableNum"
        Me.cmbTableNum.Size = New System.Drawing.Size(306, 28)
        Me.cmbTableNum.TabIndex = 1
        '
        'txtbReceiptNo
        '
        Me.txtbReceiptNo.Location = New System.Drawing.Point(127, 135)
        Me.txtbReceiptNo.Name = "txtbReceiptNo"
        Me.txtbReceiptNo.Size = New System.Drawing.Size(306, 27)
        Me.txtbReceiptNo.TabIndex = 0
        '
        'Pay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1282, 853)
        Me.Controls.Add(Me.leftSideBar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Pay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAYMENT"
        Me.leftSideBar.ResumeLayout(False)
        Me.leftSideBar.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents leftSideBar As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents OrderBtn As Button
    Friend WithEvents PurBtn As Button
    Friend WithEvents AccBtn As Button
    Friend WithEvents MainBtn As Button
    Friend WithEvents PayBtn As Button
    Friend WithEvents MenuBarBtn As Button
    Friend WithEvents PayIconBtn As Button
    Friend WithEvents OrderIconBtn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblPanelMenuBar As Label
    Friend WithEvents logoutBtn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblPanelWelcome As Label
    Friend WithEvents dtpPanelDate As DateTimePicker
    Friend WithEvents MainIconBtn As Button
    Friend WithEvents PurIconBtn As Button
    Friend WithEvents AccIconBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblReceiptNo As Label
    Friend WithEvents lblAmountPay As Label
    Friend WithEvents lblTableNum As Label
    Friend WithEvents txtbAmountPay As TextBox
    Friend WithEvents cmbTableNum As ComboBox
    Friend WithEvents txtbReceiptNo As TextBox
    Friend WithEvents dgvPayment As DataGridView
    Friend WithEvents ConfirmBtn As Button
    Friend WithEvents CloseBtn As Button
    Friend WithEvents lblOrderNo As Label
    Friend WithEvents txtbOrderNo As TextBox
End Class
