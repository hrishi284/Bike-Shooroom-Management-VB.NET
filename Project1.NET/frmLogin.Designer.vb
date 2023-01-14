<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmLogin
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents txtPassword As System.Windows.Forms.TextBox
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents txtUserName As System.Windows.Forms.TextBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents _lblLabels_1 As System.Windows.Forms.Label
	Public WithEvents _lblLabels_0 As System.Windows.Forms.Label
	Public WithEvents Image1 As System.Windows.Forms.PictureBox
	Public WithEvents lblLabels As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLogin))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Command2 = New System.Windows.Forms.Button
		Me.Command1 = New System.Windows.Forms.Button
		Me.txtPassword = New System.Windows.Forms.TextBox
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdOK = New System.Windows.Forms.Button
		Me.txtUserName = New System.Windows.Forms.TextBox
		Me.Label1 = New System.Windows.Forms.Label
		Me._lblLabels_1 = New System.Windows.Forms.Label
		Me._lblLabels_0 = New System.Windows.Forms.Label
		Me.Image1 = New System.Windows.Forms.PictureBox
		Me.lblLabels = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.lblLabels, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Text = "Login"
		Me.ClientSize = New System.Drawing.Size(833, 557)
		Me.Location = New System.Drawing.Point(186, 207)
		Me.Icon = CType(resources.GetObject("frmLogin.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmLogin"
		Me.Command2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Command2.BackColor = System.Drawing.Color.Black
		Me.Command2.Size = New System.Drawing.Size(33, 33)
		Me.Command2.Location = New System.Drawing.Point(248, 400)
		Me.Command2.Image = CType(resources.GetObject("Command2.Image"), System.Drawing.Image)
		Me.Command2.TabIndex = 8
		Me.Command2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command2.CausesValidation = True
		Me.Command2.Enabled = True
		Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command2.TabStop = True
		Me.Command2.Name = "Command2"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Command1.BackColor = System.Drawing.Color.White
		Me.Command1.Size = New System.Drawing.Size(41, 33)
		Me.Command1.Location = New System.Drawing.Point(152, 400)
		Me.Command1.Image = CType(resources.GetObject("Command1.Image"), System.Drawing.Image)
		Me.Command1.TabIndex = 7
		Me.Command1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.txtPassword.AutoSize = False
		Me.txtPassword.Size = New System.Drawing.Size(123, 23)
		Me.txtPassword.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtPassword.Location = New System.Drawing.Point(208, 288)
		Me.txtPassword.PasswordChar = ChrW(42)
		Me.txtPassword.TabIndex = 3
		Me.txtPassword.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPassword.AcceptsReturn = True
		Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
		Me.txtPassword.CausesValidation = True
		Me.txtPassword.Enabled = True
		Me.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPassword.HideSelection = True
		Me.txtPassword.ReadOnly = False
		Me.txtPassword.Maxlength = 0
		Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPassword.MultiLine = False
		Me.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPassword.TabStop = True
		Me.txtPassword.Visible = True
		Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPassword.Name = "txtPassword"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(76, 26)
		Me.cmdCancel.Location = New System.Drawing.Point(224, 336)
		Me.cmdCancel.TabIndex = 2
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.TabStop = True
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOK.Text = "OK"
		Me.AcceptButton = Me.cmdOK
		Me.cmdOK.Size = New System.Drawing.Size(76, 26)
		Me.cmdOK.Location = New System.Drawing.Point(112, 336)
		Me.cmdOK.TabIndex = 1
		Me.cmdOK.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOK.CausesValidation = True
		Me.cmdOK.Enabled = True
		Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOK.TabStop = True
		Me.cmdOK.Name = "cmdOK"
		Me.txtUserName.AutoSize = False
		Me.txtUserName.Size = New System.Drawing.Size(115, 23)
		Me.txtUserName.Location = New System.Drawing.Point(208, 232)
		Me.txtUserName.TabIndex = 0
		Me.txtUserName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtUserName.AcceptsReturn = True
		Me.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtUserName.BackColor = System.Drawing.SystemColors.Window
		Me.txtUserName.CausesValidation = True
		Me.txtUserName.Enabled = True
		Me.txtUserName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtUserName.HideSelection = True
		Me.txtUserName.ReadOnly = False
		Me.txtUserName.Maxlength = 0
		Me.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtUserName.MultiLine = False
		Me.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtUserName.TabStop = True
		Me.txtUserName.Visible = True
		Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtUserName.Name = "txtUserName"
		Me.Label1.Text = "Forgot Password"
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Size = New System.Drawing.Size(97, 25)
		Me.Label1.Location = New System.Drawing.Point(168, 376)
		Me.Label1.TabIndex = 6
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Enabled = True
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me._lblLabels_1.Text = "Password:"
		Me._lblLabels_1.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblLabels_1.ForeColor = System.Drawing.Color.White
		Me._lblLabels_1.Size = New System.Drawing.Size(88, 18)
		Me._lblLabels_1.Location = New System.Drawing.Point(104, 288)
		Me._lblLabels_1.TabIndex = 5
		Me._lblLabels_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLabels_1.BackColor = System.Drawing.Color.Transparent
		Me._lblLabels_1.Enabled = True
		Me._lblLabels_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLabels_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLabels_1.UseMnemonic = True
		Me._lblLabels_1.Visible = True
		Me._lblLabels_1.AutoSize = False
		Me._lblLabels_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLabels_1.Name = "_lblLabels_1"
		Me._lblLabels_0.Text = "User Name:"
		Me._lblLabels_0.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblLabels_0.ForeColor = System.Drawing.Color.White
		Me._lblLabels_0.Size = New System.Drawing.Size(128, 18)
		Me._lblLabels_0.Location = New System.Drawing.Point(104, 232)
		Me._lblLabels_0.TabIndex = 4
		Me._lblLabels_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLabels_0.BackColor = System.Drawing.Color.Transparent
		Me._lblLabels_0.Enabled = True
		Me._lblLabels_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLabels_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLabels_0.UseMnemonic = True
		Me._lblLabels_0.Visible = True
		Me._lblLabels_0.AutoSize = False
		Me._lblLabels_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLabels_0.Name = "_lblLabels_0"
		Me.Image1.Size = New System.Drawing.Size(1582, 1025)
		Me.Image1.Location = New System.Drawing.Point(-152, -232)
		Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
		Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.Image1.Enabled = True
		Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Image1.Visible = True
		Me.Image1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Image1.Name = "Image1"
		Me.Controls.Add(Command2)
		Me.Controls.Add(Command1)
		Me.Controls.Add(txtPassword)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdOK)
		Me.Controls.Add(txtUserName)
		Me.Controls.Add(Label1)
		Me.Controls.Add(_lblLabels_1)
		Me.Controls.Add(_lblLabels_0)
		Me.Controls.Add(Image1)
		Me.lblLabels.SetIndex(_lblLabels_1, CType(1, Short))
		Me.lblLabels.SetIndex(_lblLabels_0, CType(0, Short))
		CType(Me.lblLabels, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class