<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmEmi
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
	Public WithEvents cmbet As System.Windows.Forms.ComboBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents txtloan As System.Windows.Forms.TextBox
	Public WithEvents txtint As System.Windows.Forms.TextBox
	Public WithEvents txtyr As System.Windows.Forms.TextBox
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Lblpayment As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents lblpa As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents cmb123 As System.Windows.Forms.ComboBox
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents cmbbike As System.Windows.Forms.ComboBox
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents Image1 As System.Windows.Forms.PictureBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEmi))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.cmbet = New System.Windows.Forms.ComboBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.txtloan = New System.Windows.Forms.TextBox
		Me.txtint = New System.Windows.Forms.TextBox
		Me.txtyr = New System.Windows.Forms.TextBox
		Me.Command1 = New System.Windows.Forms.Button
		Me.Command2 = New System.Windows.Forms.Button
		Me.Label10 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Lblpayment = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.lblpa = New System.Windows.Forms.Label
		Me.Label9 = New System.Windows.Forms.Label
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me.cmb123 = New System.Windows.Forms.ComboBox
		Me.Label6 = New System.Windows.Forms.Label
		Me.Frame4 = New System.Windows.Forms.GroupBox
		Me.cmbbike = New System.Windows.Forms.ComboBox
		Me.Label7 = New System.Windows.Forms.Label
		Me.Image1 = New System.Windows.Forms.PictureBox
		Me.Frame1.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.Frame4.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "EMI  Options "
		Me.ClientSize = New System.Drawing.Size(873, 564)
		Me.Location = New System.Drawing.Point(166, 151)
		Me.Icon = CType(resources.GetObject("frmEmi.Icon"), System.Drawing.Icon)
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmEmi"
		Me.Frame1.BackColor = System.Drawing.Color.FromARGB(128, 0, 0)
		Me.Frame1.Text = "EMI Details"
		Me.Frame1.ForeColor = System.Drawing.SystemColors.highlightText
		Me.Frame1.Size = New System.Drawing.Size(233, 65)
		Me.Frame1.Location = New System.Drawing.Point(32, 80)
		Me.Frame1.TabIndex = 20
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.Enabled = True
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.cmbet.Size = New System.Drawing.Size(137, 21)
		Me.cmbet.Location = New System.Drawing.Point(88, 24)
		Me.cmbet.Items.AddRange(New Object(){"Floating ", "Flat ", "Reducing"})
		Me.cmbet.TabIndex = 21
		Me.cmbet.Text = "Select EMI Type"
		Me.cmbet.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbet.BackColor = System.Drawing.SystemColors.Window
		Me.cmbet.CausesValidation = True
		Me.cmbet.Enabled = True
		Me.cmbet.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbet.IntegralHeight = True
		Me.cmbet.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbet.Sorted = False
		Me.cmbet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cmbet.TabStop = True
		Me.cmbet.Visible = True
		Me.cmbet.Name = "cmbet"
		Me.Label1.Text = "EMI Types "
		Me.Label1.ForeColor = System.Drawing.SystemColors.highlightText
		Me.Label1.Size = New System.Drawing.Size(73, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 32)
		Me.Label1.TabIndex = 22
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
		Me.Frame2.BackColor = System.Drawing.Color.FromARGB(128, 0, 0)
		Me.Frame2.Text = "EMI Calulator"
		Me.Frame2.ForeColor = System.Drawing.SystemColors.highlightText
		Me.Frame2.Size = New System.Drawing.Size(465, 289)
		Me.Frame2.Location = New System.Drawing.Point(24, 152)
		Me.Frame2.TabIndex = 6
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.Enabled = True
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.txtloan.AutoSize = False
		Me.txtloan.Size = New System.Drawing.Size(153, 25)
		Me.txtloan.Location = New System.Drawing.Point(96, 32)
		Me.txtloan.TabIndex = 11
		Me.txtloan.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtloan.AcceptsReturn = True
		Me.txtloan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtloan.BackColor = System.Drawing.SystemColors.Window
		Me.txtloan.CausesValidation = True
		Me.txtloan.Enabled = True
		Me.txtloan.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtloan.HideSelection = True
		Me.txtloan.ReadOnly = False
		Me.txtloan.Maxlength = 0
		Me.txtloan.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtloan.MultiLine = False
		Me.txtloan.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtloan.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtloan.TabStop = True
		Me.txtloan.Visible = True
		Me.txtloan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtloan.Name = "txtloan"
		Me.txtint.AutoSize = False
		Me.txtint.Size = New System.Drawing.Size(153, 25)
		Me.txtint.Location = New System.Drawing.Point(96, 64)
		Me.txtint.TabIndex = 10
		Me.txtint.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtint.AcceptsReturn = True
		Me.txtint.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtint.BackColor = System.Drawing.SystemColors.Window
		Me.txtint.CausesValidation = True
		Me.txtint.Enabled = True
		Me.txtint.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtint.HideSelection = True
		Me.txtint.ReadOnly = False
		Me.txtint.Maxlength = 0
		Me.txtint.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtint.MultiLine = False
		Me.txtint.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtint.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtint.TabStop = True
		Me.txtint.Visible = True
		Me.txtint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtint.Name = "txtint"
		Me.txtyr.AutoSize = False
		Me.txtyr.Size = New System.Drawing.Size(177, 25)
		Me.txtyr.Location = New System.Drawing.Point(80, 128)
		Me.txtyr.TabIndex = 9
		Me.txtyr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtyr.AcceptsReturn = True
		Me.txtyr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtyr.BackColor = System.Drawing.SystemColors.Window
		Me.txtyr.CausesValidation = True
		Me.txtyr.Enabled = True
		Me.txtyr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtyr.HideSelection = True
		Me.txtyr.ReadOnly = False
		Me.txtyr.Maxlength = 0
		Me.txtyr.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtyr.MultiLine = False
		Me.txtyr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtyr.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtyr.TabStop = True
		Me.txtyr.Visible = True
		Me.txtyr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtyr.Name = "txtyr"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "Submit"
		Me.Command1.Size = New System.Drawing.Size(137, 33)
		Me.Command1.Location = New System.Drawing.Point(24, 248)
		Me.Command1.TabIndex = 8
		Me.Command1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.Command2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command2.Text = "Save"
		Me.Command2.Size = New System.Drawing.Size(169, 41)
		Me.Command2.Location = New System.Drawing.Point(192, 240)
		Me.Command2.TabIndex = 7
		Me.Command2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command2.BackColor = System.Drawing.SystemColors.Control
		Me.Command2.CausesValidation = True
		Me.Command2.Enabled = True
		Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command2.TabStop = True
		Me.Command2.Name = "Command2"
		Me.Label10.Text = "Amount of Intrest"
		Me.Label10.ForeColor = System.Drawing.SystemColors.highlightText
		Me.Label10.Size = New System.Drawing.Size(73, 25)
		Me.Label10.Location = New System.Drawing.Point(16, 96)
		Me.Label10.TabIndex = 23
		Me.Label10.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label10.BackColor = System.Drawing.Color.Transparent
		Me.Label10.Enabled = True
		Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label10.UseMnemonic = True
		Me.Label10.Visible = True
		Me.Label10.AutoSize = False
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label10.Name = "Label10"
		Me.Label2.Text = "Amount of Loan "
		Me.Label2.ForeColor = System.Drawing.SystemColors.highlightText
		Me.Label2.Size = New System.Drawing.Size(81, 17)
		Me.Label2.Location = New System.Drawing.Point(8, 32)
		Me.Label2.TabIndex = 19
		Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Enabled = True
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label3.Text = "Intrest Rate"
		Me.Label3.ForeColor = System.Drawing.SystemColors.highlightText
		Me.Label3.Size = New System.Drawing.Size(65, 17)
		Me.Label3.Location = New System.Drawing.Point(8, 64)
		Me.Label3.TabIndex = 18
		Me.Label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Enabled = True
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label4.Text = "Year"
		Me.Label4.ForeColor = System.Drawing.SystemColors.highlightText
		Me.Label4.Size = New System.Drawing.Size(57, 25)
		Me.Label4.Location = New System.Drawing.Point(16, 128)
		Me.Label4.TabIndex = 17
		Me.Label4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.Enabled = True
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Label5.Text = "Monthly Payments"
		Me.Label5.ForeColor = System.Drawing.SystemColors.highlightText
		Me.Label5.Size = New System.Drawing.Size(105, 25)
		Me.Label5.Location = New System.Drawing.Point(8, 160)
		Me.Label5.TabIndex = 16
		Me.Label5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.Enabled = True
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Lblpayment.ForeColor = System.Drawing.SystemColors.highlightText
		Me.Lblpayment.Size = New System.Drawing.Size(121, 25)
		Me.Lblpayment.Location = New System.Drawing.Point(104, 160)
		Me.Lblpayment.TabIndex = 15
		Me.Lblpayment.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Lblpayment.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Lblpayment.BackColor = System.Drawing.Color.Transparent
		Me.Lblpayment.Enabled = True
		Me.Lblpayment.Cursor = System.Windows.Forms.Cursors.Default
		Me.Lblpayment.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Lblpayment.UseMnemonic = True
		Me.Lblpayment.Visible = True
		Me.Lblpayment.AutoSize = False
		Me.Lblpayment.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Lblpayment.Name = "Lblpayment"
		Me.Label8.Text = "Paid Amount"
		Me.Label8.ForeColor = System.Drawing.SystemColors.highlightText
		Me.Label8.Size = New System.Drawing.Size(81, 17)
		Me.Label8.Location = New System.Drawing.Point(16, 208)
		Me.Label8.TabIndex = 14
		Me.Label8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label8.BackColor = System.Drawing.Color.Transparent
		Me.Label8.Enabled = True
		Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.UseMnemonic = True
		Me.Label8.Visible = True
		Me.Label8.AutoSize = False
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.Name = "Label8"
		Me.lblpa.ForeColor = System.Drawing.SystemColors.highlightText
		Me.lblpa.Size = New System.Drawing.Size(81, 25)
		Me.lblpa.Location = New System.Drawing.Point(112, 200)
		Me.lblpa.TabIndex = 13
		Me.lblpa.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblpa.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblpa.BackColor = System.Drawing.Color.Transparent
		Me.lblpa.Enabled = True
		Me.lblpa.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblpa.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblpa.UseMnemonic = True
		Me.lblpa.Visible = True
		Me.lblpa.AutoSize = False
		Me.lblpa.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblpa.Name = "lblpa"
		Me.Label9.ForeColor = System.Drawing.SystemColors.highlightText
		Me.Label9.Size = New System.Drawing.Size(89, 17)
		Me.Label9.Location = New System.Drawing.Point(112, 104)
		Me.Label9.TabIndex = 12
		Me.Label9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label9.BackColor = System.Drawing.Color.Transparent
		Me.Label9.Enabled = True
		Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.UseMnemonic = True
		Me.Label9.Visible = True
		Me.Label9.AutoSize = False
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label9.Name = "Label9"
		Me.Frame3.BackColor = System.Drawing.Color.FromARGB(128, 0, 0)
		Me.Frame3.Text = "Customer Details"
		Me.Frame3.ForeColor = System.Drawing.SystemColors.highlightText
		Me.Frame3.Size = New System.Drawing.Size(289, 57)
		Me.Frame3.Location = New System.Drawing.Point(360, 80)
		Me.Frame3.TabIndex = 3
		Me.Frame3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame3.Enabled = True
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame3.Name = "Frame3"
		Me.cmb123.Size = New System.Drawing.Size(137, 21)
		Me.cmb123.Location = New System.Drawing.Point(112, 24)
		Me.cmb123.TabIndex = 4
		Me.cmb123.Text = "Select Customer"
		Me.cmb123.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmb123.BackColor = System.Drawing.SystemColors.Window
		Me.cmb123.CausesValidation = True
		Me.cmb123.Enabled = True
		Me.cmb123.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmb123.IntegralHeight = True
		Me.cmb123.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmb123.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmb123.Sorted = False
		Me.cmb123.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cmb123.TabStop = True
		Me.cmb123.Visible = True
		Me.cmb123.Name = "cmb123"
		Me.Label6.Text = "Customer Name"
		Me.Label6.ForeColor = System.Drawing.SystemColors.highlightText
		Me.Label6.Size = New System.Drawing.Size(81, 25)
		Me.Label6.Location = New System.Drawing.Point(8, 24)
		Me.Label6.TabIndex = 5
		Me.Label6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Enabled = True
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Frame4.BackColor = System.Drawing.Color.FromARGB(128, 0, 0)
		Me.Frame4.Text = "Loan on Bike "
		Me.Frame4.ForeColor = System.Drawing.SystemColors.highlightText
		Me.Frame4.Size = New System.Drawing.Size(217, 57)
		Me.Frame4.Location = New System.Drawing.Point(512, 168)
		Me.Frame4.TabIndex = 0
		Me.Frame4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame4.Enabled = True
		Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame4.Visible = True
		Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame4.Name = "Frame4"
		Me.cmbbike.Size = New System.Drawing.Size(105, 21)
		Me.cmbbike.Location = New System.Drawing.Point(72, 24)
		Me.cmbbike.TabIndex = 1
		Me.cmbbike.Text = "Combo1"
		Me.cmbbike.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbbike.BackColor = System.Drawing.SystemColors.Window
		Me.cmbbike.CausesValidation = True
		Me.cmbbike.Enabled = True
		Me.cmbbike.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbbike.IntegralHeight = True
		Me.cmbbike.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbbike.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbbike.Sorted = False
		Me.cmbbike.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cmbbike.TabStop = True
		Me.cmbbike.Visible = True
		Me.cmbbike.Name = "cmbbike"
		Me.Label7.Text = "Bike Name"
		Me.Label7.ForeColor = System.Drawing.SystemColors.highlightText
		Me.Label7.Size = New System.Drawing.Size(73, 17)
		Me.Label7.Location = New System.Drawing.Point(8, 24)
		Me.Label7.TabIndex = 2
		Me.Label7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label7.BackColor = System.Drawing.Color.Transparent
		Me.Label7.Enabled = True
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = False
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		Me.Image1.Size = New System.Drawing.Size(3840, 2160)
		Me.Image1.Location = New System.Drawing.Point(-800, -480)
		Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
		Me.Image1.Enabled = True
		Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.Image1.Visible = True
		Me.Image1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Image1.Name = "Image1"
		Me.Controls.Add(Frame1)
		Me.Controls.Add(Frame2)
		Me.Controls.Add(Frame3)
		Me.Controls.Add(Frame4)
		Me.Controls.Add(Image1)
		Me.Frame1.Controls.Add(cmbet)
		Me.Frame1.Controls.Add(Label1)
		Me.Frame2.Controls.Add(txtloan)
		Me.Frame2.Controls.Add(txtint)
		Me.Frame2.Controls.Add(txtyr)
		Me.Frame2.Controls.Add(Command1)
		Me.Frame2.Controls.Add(Command2)
		Me.Frame2.Controls.Add(Label10)
		Me.Frame2.Controls.Add(Label2)
		Me.Frame2.Controls.Add(Label3)
		Me.Frame2.Controls.Add(Label4)
		Me.Frame2.Controls.Add(Label5)
		Me.Frame2.Controls.Add(Lblpayment)
		Me.Frame2.Controls.Add(Label8)
		Me.Frame2.Controls.Add(lblpa)
		Me.Frame2.Controls.Add(Label9)
		Me.Frame3.Controls.Add(cmb123)
		Me.Frame3.Controls.Add(Label6)
		Me.Frame4.Controls.Add(cmbbike)
		Me.Frame4.Controls.Add(Label7)
		Me.Frame1.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.Frame3.ResumeLayout(False)
		Me.Frame4.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class