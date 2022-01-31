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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.appTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.textboxUsername = New System.Windows.Forms.TextBox()
        Me.textboxPassword = New System.Windows.Forms.TextBox()
        Me.buttonSignIn = New System.Windows.Forms.Button()
        Me.buttonRegister = New System.Windows.Forms.Button()
        Me.panelUp = New System.Windows.Forms.Panel()
        Me.hideButton = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.panelLogin = New System.Windows.Forms.Panel()
        Me.superadminButton = New System.Windows.Forms.RadioButton()
        Me.adminButton = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.panelRegister = New System.Windows.Forms.Panel()
        Me.admin_number = New System.Windows.Forms.Label()
        Me.textboxBday = New System.Windows.Forms.TextBox()
        Me.birthdatePicker = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.textboxcPass = New System.Windows.Forms.TextBox()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.textboxPass = New System.Windows.Forms.TextBox()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.textboxUname = New System.Windows.Forms.TextBox()
        Me.textboxEmail = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.textboxAddress = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.textboxlName = New System.Windows.Forms.TextBox()
        Me.textboxMname = New System.Windows.Forms.TextBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.textboxFname = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.buttonBack = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.loginContainer = New System.Windows.Forms.Panel()
        Me.panelUp.SuspendLayout()
        Me.panelLogin.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelRegister.SuspendLayout()
        Me.loginContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'appTitle
        '
        Me.appTitle.AutoSize = True
        Me.appTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.appTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.appTitle.Location = New System.Drawing.Point(16, 50)
        Me.appTitle.Name = "appTitle"
        Me.appTitle.Size = New System.Drawing.Size(382, 31)
        Me.appTitle.TabIndex = 1
        Me.appTitle.Text = "Alumni Management System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(172, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Login"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(74, 303)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(265, 2)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(76, 364)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(265, 2)
        Me.Panel2.TabIndex = 6
        '
        'textboxUsername
        '
        Me.textboxUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.textboxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textboxUsername.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.textboxUsername.Location = New System.Drawing.Point(117, 271)
        Me.textboxUsername.Name = "textboxUsername"
        Me.textboxUsername.Size = New System.Drawing.Size(222, 26)
        Me.textboxUsername.TabIndex = 7
        Me.textboxUsername.Text = "Username"
        '
        'textboxPassword
        '
        Me.textboxPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.textboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textboxPassword.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.textboxPassword.Location = New System.Drawing.Point(117, 332)
        Me.textboxPassword.Name = "textboxPassword"
        Me.textboxPassword.Size = New System.Drawing.Size(194, 26)
        Me.textboxPassword.TabIndex = 8
        Me.textboxPassword.Text = "Password"
        '
        'buttonSignIn
        '
        Me.buttonSignIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.buttonSignIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.buttonSignIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonSignIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.buttonSignIn.Location = New System.Drawing.Point(72, 427)
        Me.buttonSignIn.Name = "buttonSignIn"
        Me.buttonSignIn.Size = New System.Drawing.Size(268, 53)
        Me.buttonSignIn.TabIndex = 9
        Me.buttonSignIn.Text = "Sign In"
        Me.buttonSignIn.UseVisualStyleBackColor = False
        '
        'buttonRegister
        '
        Me.buttonRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.buttonRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.buttonRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonRegister.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.buttonRegister.Location = New System.Drawing.Point(72, 487)
        Me.buttonRegister.Name = "buttonRegister"
        Me.buttonRegister.Size = New System.Drawing.Size(268, 53)
        Me.buttonRegister.TabIndex = 11
        Me.buttonRegister.Text = "Register"
        Me.buttonRegister.UseVisualStyleBackColor = False
        '
        'panelUp
        '
        Me.panelUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.panelUp.Controls.Add(Me.hideButton)
        Me.panelUp.Controls.Add(Me.closeButton)
        Me.panelUp.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelUp.Location = New System.Drawing.Point(0, 0)
        Me.panelUp.Name = "panelUp"
        Me.panelUp.Size = New System.Drawing.Size(410, 19)
        Me.panelUp.TabIndex = 12
        '
        'hideButton
        '
        Me.hideButton.BackgroundImage = CType(resources.GetObject("hideButton.BackgroundImage"), System.Drawing.Image)
        Me.hideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.hideButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.hideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hideButton.Location = New System.Drawing.Point(362, -4)
        Me.hideButton.Name = "hideButton"
        Me.hideButton.Size = New System.Drawing.Size(23, 25)
        Me.hideButton.TabIndex = 14
        Me.hideButton.UseVisualStyleBackColor = True
        '
        'closeButton
        '
        Me.closeButton.BackgroundImage = CType(resources.GetObject("closeButton.BackgroundImage"), System.Drawing.Image)
        Me.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeButton.Location = New System.Drawing.Point(385, -3)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(23, 25)
        Me.closeButton.TabIndex = 13
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'panelLogin
        '
        Me.panelLogin.Controls.Add(Me.superadminButton)
        Me.panelLogin.Controls.Add(Me.adminButton)
        Me.panelLogin.Controls.Add(Me.Button2)
        Me.panelLogin.Controls.Add(Me.Logo)
        Me.panelLogin.Controls.Add(Me.Label1)
        Me.panelLogin.Controls.Add(Me.buttonRegister)
        Me.panelLogin.Controls.Add(Me.textboxPassword)
        Me.panelLogin.Controls.Add(Me.buttonSignIn)
        Me.panelLogin.Controls.Add(Me.PictureBox2)
        Me.panelLogin.Controls.Add(Me.Panel2)
        Me.panelLogin.Controls.Add(Me.textboxUsername)
        Me.panelLogin.Controls.Add(Me.PictureBox3)
        Me.panelLogin.Controls.Add(Me.Panel1)
        Me.panelLogin.Controls.Add(Me.appTitle)
        Me.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelLogin.Location = New System.Drawing.Point(0, 0)
        Me.panelLogin.Name = "panelLogin"
        Me.panelLogin.Size = New System.Drawing.Size(410, 636)
        Me.panelLogin.TabIndex = 14
        '
        'superadminButton
        '
        Me.superadminButton.AutoSize = True
        Me.superadminButton.Font = New System.Drawing.Font("Tahoma", 15.75!)
        Me.superadminButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.superadminButton.Location = New System.Drawing.Point(190, 376)
        Me.superadminButton.Name = "superadminButton"
        Me.superadminButton.Size = New System.Drawing.Size(152, 29)
        Me.superadminButton.TabIndex = 15
        Me.superadminButton.TabStop = True
        Me.superadminButton.Text = "Super Admin"
        Me.superadminButton.UseVisualStyleBackColor = True
        '
        'adminButton
        '
        Me.adminButton.AutoSize = True
        Me.adminButton.Font = New System.Drawing.Font("Tahoma", 15.75!)
        Me.adminButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.adminButton.Location = New System.Drawing.Point(81, 376)
        Me.adminButton.Name = "adminButton"
        Me.adminButton.Size = New System.Drawing.Size(90, 29)
        Me.adminButton.TabIndex = 14
        Me.adminButton.TabStop = True
        Me.adminButton.Text = "Admin"
        Me.adminButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(308, 327)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(34, 36)
        Me.Button2.TabIndex = 13
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Logo
        '
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(117, 101)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(172, 102)
        Me.Logo.TabIndex = 0
        Me.Logo.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(76, 260)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(39, 41)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(81, 320)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 41)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'panelRegister
        '
        Me.panelRegister.Controls.Add(Me.admin_number)
        Me.panelRegister.Controls.Add(Me.textboxBday)
        Me.panelRegister.Controls.Add(Me.birthdatePicker)
        Me.panelRegister.Controls.Add(Me.Button1)
        Me.panelRegister.Controls.Add(Me.Panel15)
        Me.panelRegister.Controls.Add(Me.textboxcPass)
        Me.panelRegister.Controls.Add(Me.Panel13)
        Me.panelRegister.Controls.Add(Me.textboxPass)
        Me.panelRegister.Controls.Add(Me.Panel14)
        Me.panelRegister.Controls.Add(Me.textboxUname)
        Me.panelRegister.Controls.Add(Me.textboxEmail)
        Me.panelRegister.Controls.Add(Me.TextBox8)
        Me.panelRegister.Controls.Add(Me.TextBox7)
        Me.panelRegister.Controls.Add(Me.Panel12)
        Me.panelRegister.Controls.Add(Me.RadioButton2)
        Me.panelRegister.Controls.Add(Me.RadioButton1)
        Me.panelRegister.Controls.Add(Me.Panel11)
        Me.panelRegister.Controls.Add(Me.Panel9)
        Me.panelRegister.Controls.Add(Me.textboxAddress)
        Me.panelRegister.Controls.Add(Me.Panel8)
        Me.panelRegister.Controls.Add(Me.textboxlName)
        Me.panelRegister.Controls.Add(Me.textboxMname)
        Me.panelRegister.Controls.Add(Me.Panel10)
        Me.panelRegister.Controls.Add(Me.textboxFname)
        Me.panelRegister.Controls.Add(Me.Panel7)
        Me.panelRegister.Controls.Add(Me.buttonBack)
        Me.panelRegister.Controls.Add(Me.Panel5)
        Me.panelRegister.Controls.Add(Me.Label3)
        Me.panelRegister.Controls.Add(Me.Button3)
        Me.panelRegister.Controls.Add(Me.Button4)
        Me.panelRegister.Controls.Add(Me.Button5)
        Me.panelRegister.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelRegister.Location = New System.Drawing.Point(0, 0)
        Me.panelRegister.Name = "panelRegister"
        Me.panelRegister.Size = New System.Drawing.Size(410, 636)
        Me.panelRegister.TabIndex = 14
        Me.panelRegister.Visible = False
        '
        'admin_number
        '
        Me.admin_number.AutoSize = True
        Me.admin_number.Location = New System.Drawing.Point(100, 579)
        Me.admin_number.Name = "admin_number"
        Me.admin_number.Size = New System.Drawing.Size(53, 13)
        Me.admin_number.TabIndex = 37
        Me.admin_number.Text = "admin_no"
        Me.admin_number.Visible = False
        '
        'textboxBday
        '
        Me.textboxBday.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.textboxBday.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textboxBday.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxBday.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.textboxBday.Location = New System.Drawing.Point(64, 288)
        Me.textboxBday.Name = "textboxBday"
        Me.textboxBday.Size = New System.Drawing.Size(261, 26)
        Me.textboxBday.TabIndex = 34
        Me.textboxBday.Text = "Birthday"
        '
        'birthdatePicker
        '
        Me.birthdatePicker.BaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.birthdatePicker.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.birthdatePicker.CustomFormat = Nothing
        Me.birthdatePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.birthdatePicker.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.birthdatePicker.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.birthdatePicker.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.birthdatePicker.Location = New System.Drawing.Point(66, 245)
        Me.birthdatePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.birthdatePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.birthdatePicker.Name = "birthdatePicker"
        Me.birthdatePicker.OnHoverBaseColor = System.Drawing.Color.White
        Me.birthdatePicker.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.birthdatePicker.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.birthdatePicker.OnPressedColor = System.Drawing.Color.Black
        Me.birthdatePicker.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.birthdatePicker.Size = New System.Drawing.Size(267, 27)
        Me.birthdatePicker.TabIndex = 33
        Me.birthdatePicker.Text = "30 November 2019"
        Me.birthdatePicker.Value = New Date(2019, 11, 30, 18, 20, 35, 302)
        Me.birthdatePicker.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(64, 505)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(265, 42)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel15.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Panel15.Location = New System.Drawing.Point(68, 478)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(265, 2)
        Me.Panel15.TabIndex = 29
        '
        'textboxcPass
        '
        Me.textboxcPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.textboxcPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textboxcPass.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxcPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.textboxcPass.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.textboxcPass.Location = New System.Drawing.Point(70, 451)
        Me.textboxcPass.Name = "textboxcPass"
        Me.textboxcPass.Size = New System.Drawing.Size(240, 26)
        Me.textboxcPass.TabIndex = 30
        Me.textboxcPass.Text = "Confirm Password"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel13.Location = New System.Drawing.Point(68, 448)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(265, 2)
        Me.Panel13.TabIndex = 27
        '
        'textboxPass
        '
        Me.textboxPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.textboxPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textboxPass.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.textboxPass.Location = New System.Drawing.Point(69, 422)
        Me.textboxPass.Name = "textboxPass"
        Me.textboxPass.Size = New System.Drawing.Size(241, 26)
        Me.textboxPass.TabIndex = 28
        Me.textboxPass.Text = "Password"
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel14.Location = New System.Drawing.Point(67, 418)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(265, 2)
        Me.Panel14.TabIndex = 22
        '
        'textboxUname
        '
        Me.textboxUname.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.textboxUname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textboxUname.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxUname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.textboxUname.Location = New System.Drawing.Point(69, 392)
        Me.textboxUname.Name = "textboxUname"
        Me.textboxUname.Size = New System.Drawing.Size(263, 26)
        Me.textboxUname.TabIndex = 26
        Me.textboxUname.Text = "Username"
        '
        'textboxEmail
        '
        Me.textboxEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.textboxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textboxEmail.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.textboxEmail.Location = New System.Drawing.Point(69, 360)
        Me.textboxEmail.Name = "textboxEmail"
        Me.textboxEmail.Size = New System.Drawing.Size(263, 26)
        Me.textboxEmail.TabIndex = 24
        Me.textboxEmail.Text = "Email"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox8.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TextBox8.Location = New System.Drawing.Point(93, 328)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(217, 26)
        Me.TextBox8.TabIndex = 23
        Me.TextBox8.Text = "Account Information"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TextBox7.Location = New System.Drawing.Point(94, 87)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(198, 26)
        Me.TextBox7.TabIndex = 22
        Me.TextBox7.Text = "Basic Information"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel12.Location = New System.Drawing.Point(67, 387)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(265, 2)
        Me.Panel12.TabIndex = 21
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Tahoma", 15.75!)
        Me.RadioButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.RadioButton2.Location = New System.Drawing.Point(70, 276)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(97, 29)
        Me.RadioButton2.TabIndex = 20
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Female"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Tahoma", 15.75!)
        Me.RadioButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.RadioButton1.Location = New System.Drawing.Point(201, 276)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(73, 29)
        Me.RadioButton1.TabIndex = 19
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Male"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel11.Location = New System.Drawing.Point(67, 305)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(265, 2)
        Me.Panel11.TabIndex = 16
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel9.Location = New System.Drawing.Point(67, 273)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(265, 2)
        Me.Panel9.TabIndex = 14
        '
        'textboxAddress
        '
        Me.textboxAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.textboxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textboxAddress.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.textboxAddress.Location = New System.Drawing.Point(70, 214)
        Me.textboxAddress.Name = "textboxAddress"
        Me.textboxAddress.Size = New System.Drawing.Size(263, 26)
        Me.textboxAddress.TabIndex = 13
        Me.textboxAddress.Text = "Address"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel8.Location = New System.Drawing.Point(67, 242)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(265, 2)
        Me.Panel8.TabIndex = 12
        '
        'textboxlName
        '
        Me.textboxlName.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.textboxlName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textboxlName.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxlName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.textboxlName.Location = New System.Drawing.Point(68, 184)
        Me.textboxlName.Name = "textboxlName"
        Me.textboxlName.Size = New System.Drawing.Size(263, 26)
        Me.textboxlName.TabIndex = 9
        Me.textboxlName.Text = "Last Name"
        '
        'textboxMname
        '
        Me.textboxMname.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.textboxMname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textboxMname.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxMname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.textboxMname.Location = New System.Drawing.Point(68, 153)
        Me.textboxMname.Name = "textboxMname"
        Me.textboxMname.Size = New System.Drawing.Size(263, 26)
        Me.textboxMname.TabIndex = 10
        Me.textboxMname.Text = "Middle Name"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel10.Location = New System.Drawing.Point(67, 212)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(265, 2)
        Me.Panel10.TabIndex = 6
        '
        'textboxFname
        '
        Me.textboxFname.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.textboxFname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textboxFname.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxFname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.textboxFname.Location = New System.Drawing.Point(68, 119)
        Me.textboxFname.Name = "textboxFname"
        Me.textboxFname.Size = New System.Drawing.Size(263, 26)
        Me.textboxFname.TabIndex = 9
        Me.textboxFname.Text = "First Name"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(65, 180)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(265, 2)
        Me.Panel7.TabIndex = 8
        '
        'buttonBack
        '
        Me.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonBack.Image = Global.Alumni_Manager.My.Resources.Resources.backIcon
        Me.buttonBack.Location = New System.Drawing.Point(3, 25)
        Me.buttonBack.Name = "buttonBack"
        Me.buttonBack.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.buttonBack.Size = New System.Drawing.Size(48, 37)
        Me.buttonBack.TabIndex = 4
        Me.buttonBack.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(64, 148)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(265, 2)
        Me.Panel5.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(81, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(261, 33)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Registration Form"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(64, 542)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(265, 34)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Already a member?"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(308, 421)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(25, 29)
        Me.Button4.TabIndex = 35
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(308, 450)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(25, 30)
        Me.Button5.TabIndex = 36
        Me.Button5.UseVisualStyleBackColor = False
        '
        'loginContainer
        '
        Me.loginContainer.Controls.Add(Me.panelUp)
        Me.loginContainer.Controls.Add(Me.panelRegister)
        Me.loginContainer.Controls.Add(Me.panelLogin)
        Me.loginContainer.Dock = System.Windows.Forms.DockStyle.Top
        Me.loginContainer.Location = New System.Drawing.Point(0, 0)
        Me.loginContainer.Name = "loginContainer"
        Me.loginContainer.Size = New System.Drawing.Size(410, 636)
        Me.loginContainer.TabIndex = 15
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(410, 634)
        Me.Controls.Add(Me.loginContainer)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.panelUp.ResumeLayout(False)
        Me.panelLogin.ResumeLayout(False)
        Me.panelLogin.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelRegister.ResumeLayout(False)
        Me.panelRegister.PerformLayout()
        Me.loginContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Logo As PictureBox
    Friend WithEvents appTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents textboxUsername As TextBox
    Friend WithEvents textboxPassword As TextBox
    Friend WithEvents buttonSignIn As Button
    Friend WithEvents buttonRegister As Button
    Friend WithEvents panelUp As Panel
    Friend WithEvents closeButton As Button
    Friend WithEvents hideButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents panelLogin As Panel
    Friend WithEvents panelRegister As Panel
    Friend WithEvents buttonBack As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents textboxMname As TextBox
    Friend WithEvents textboxFname As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents textboxlName As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents textboxAddress As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents textboxUname As TextBox
    Friend WithEvents textboxEmail As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents textboxcPass As TextBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents textboxPass As TextBox
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents birthdatePicker As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents loginContainer As Panel
    Friend WithEvents textboxBday As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents superadminButton As RadioButton
    Friend WithEvents adminButton As RadioButton
    Friend WithEvents admin_number As Label
End Class
