<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmbike
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
	Public WithEvents pic1 As System.Windows.Forms.PictureBox
	Public WithEvents txtbid As System.Windows.Forms.TextBox
	Public WithEvents txtbname As System.Windows.Forms.TextBox
	Public WithEvents txtbdealer As System.Windows.Forms.TextBox
	Public WithEvents txtbprice As System.Windows.Forms.TextBox
	Public WithEvents cmb1 As System.Windows.Forms.ComboBox
	Public WithEvents cmb2 As System.Windows.Forms.ComboBox
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command3 As System.Windows.Forms.Button
	Public WithEvents Command4 As System.Windows.Forms.Button
	Public WithEvents Command5 As System.Windows.Forms.Button
	Public CommonDialog1Open As System.Windows.Forms.OpenFileDialog
	Public WithEvents lblo As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Image2 As System.Windows.Forms.PictureBox
	Public WithEvents Image1 As System.Windows.Forms.PictureBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmbike))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.pic1 = New System.Windows.Forms.PictureBox
		Me.txtbid = New System.Windows.Forms.TextBox
		Me.txtbname = New System.Windows.Forms.TextBox
		Me.txtbdealer = New System.Windows.Forms.TextBox
		Me.txtbprice = New System.Windows.Forms.TextBox
		Me.cmb1 = New System.Windows.Forms.ComboBox
		Me.cmb2 = New System.Windows.Forms.ComboBox
		Me.Command1 = New System.Windows.Forms.Button
		Me.Command2 = New System.Windows.Forms.Button
		Me.Command3 = New System.Windows.Forms.Button
		Me.Command4 = New System.Windows.Forms.Button
		Me.Command5 = New System.Windows.Forms.Button
		Me.CommonDialog1Open = New System.Windows.Forms.OpenFileDialog
		Me.lblo = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Image2 = New System.Windows.Forms.PictureBox
		Me.Image1 = New System.Windows.Forms.PictureBox
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Form2"
		Me.ClientSize = New System.Drawing.Size(683, 434)
		Me.Location = New System.Drawing.Point(8, 30)
		Me.Icon = CType(resources.GetObject("frmbike.Icon"), System.Drawing.Icon)
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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
		Me.Name = "frmbike"
		Me.Frame1.BackColor = System.Drawing.Color.Black
		Me.Frame1.Text = "Bike Details"
		Me.Frame1.ForeColor = System.Drawing.Color.White
		Me.Frame1.Size = New System.Drawing.Size(441, 457)
		Me.Frame1.Location = New System.Drawing.Point(16, 8)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.Enabled = True
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.pic1.BackColor = System.Drawing.Color.Black
		Me.pic1.Size = New System.Drawing.Size(193, 209)
		Me.pic1.Location = New System.Drawing.Point(240, 24)
		Me.pic1.TabIndex = 12
		Me.pic1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.pic1.Dock = System.Windows.Forms.DockStyle.None
		Me.pic1.CausesValidation = True
		Me.pic1.Enabled = True
		Me.pic1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.pic1.Cursor = System.Windows.Forms.Cursors.Default
		Me.pic1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.pic1.TabStop = True
		Me.pic1.Visible = True
		Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.pic1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pic1.Name = "pic1"
		Me.txtbid.AutoSize = False
		Me.txtbid.Size = New System.Drawing.Size(113, 19)
		Me.txtbid.Location = New System.Drawing.Point(88, 32)
		Me.txtbid.TabIndex = 11
		Me.txtbid.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtbid.AcceptsReturn = True
		Me.txtbid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtbid.BackColor = System.Drawing.SystemColors.Window
		Me.txtbid.CausesValidation = True
		Me.txtbid.Enabled = True
		Me.txtbid.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtbid.HideSelection = True
		Me.txtbid.ReadOnly = False
		Me.txtbid.Maxlength = 0
		Me.txtbid.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtbid.MultiLine = False
		Me.txtbid.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtbid.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtbid.TabStop = True
		Me.txtbid.Visible = True
		Me.txtbid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtbid.Name = "txtbid"
		Me.txtbname.AutoSize = False
		Me.txtbname.Size = New System.Drawing.Size(137, 25)
		Me.txtbname.Location = New System.Drawing.Point(88, 64)
		Me.txtbname.TabIndex = 10
		Me.txtbname.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtbname.AcceptsReturn = True
		Me.txtbname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtbname.BackColor = System.Drawing.SystemColors.Window
		Me.txtbname.CausesValidation = True
		Me.txtbname.Enabled = True
		Me.txtbname.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtbname.HideSelection = True
		Me.txtbname.ReadOnly = False
		Me.txtbname.Maxlength = 0
		Me.txtbname.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtbname.MultiLine = False
		Me.txtbname.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtbname.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtbname.TabStop = True
		Me.txtbname.Visible = True
		Me.txtbname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtbname.Name = "txtbname"
		Me.txtbdealer.AutoSize = False
		Me.txtbdealer.Size = New System.Drawing.Size(137, 25)
		Me.txtbdealer.Location = New System.Drawing.Point(96, 120)
		Me.txtbdealer.TabIndex = 9
		Me.txtbdealer.Text = "MY WINGS HONDA"
		Me.txtbdealer.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtbdealer.AcceptsReturn = True
		Me.txtbdealer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtbdealer.BackColor = System.Drawing.SystemColors.Window
		Me.txtbdealer.CausesValidation = True
		Me.txtbdealer.Enabled = True
		Me.txtbdealer.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtbdealer.HideSelection = True
		Me.txtbdealer.ReadOnly = False
		Me.txtbdealer.Maxlength = 0
		Me.txtbdealer.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtbdealer.MultiLine = False
		Me.txtbdealer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtbdealer.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtbdealer.TabStop = True
		Me.txtbdealer.Visible = True
		Me.txtbdealer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtbdealer.Name = "txtbdealer"
		Me.txtbprice.AutoSize = False
		Me.txtbprice.Size = New System.Drawing.Size(97, 19)
		Me.txtbprice.Location = New System.Drawing.Point(96, 160)
		Me.txtbprice.TabIndex = 8
		Me.txtbprice.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtbprice.AcceptsReturn = True
		Me.txtbprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtbprice.BackColor = System.Drawing.SystemColors.Window
		Me.txtbprice.CausesValidation = True
		Me.txtbprice.Enabled = True
		Me.txtbprice.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtbprice.HideSelection = True
		Me.txtbprice.ReadOnly = False
		Me.txtbprice.Maxlength = 0
		Me.txtbprice.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtbprice.MultiLine = False
		Me.txtbprice.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtbprice.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtbprice.TabStop = True
		Me.txtbprice.Visible = True
		Me.txtbprice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtbprice.Name = "txtbprice"
		Me.cmb1.Size = New System.Drawing.Size(105, 21)
		Me.cmb1.Location = New System.Drawing.Point(96, 192)
		Me.cmb1.Items.AddRange(New Object(){"Black", "White ", "Grey", "Yellow", "Black Matte", "Blue", "Silver", "Brown", "Black & Red ", "Black & Yellow", "Green"})
		Me.cmb1.TabIndex = 7
		Me.cmb1.Text = "None"
		Me.cmb1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmb1.BackColor = System.Drawing.SystemColors.Window
		Me.cmb1.CausesValidation = True
		Me.cmb1.Enabled = True
		Me.cmb1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmb1.IntegralHeight = True
		Me.cmb1.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmb1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmb1.Sorted = False
		Me.cmb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cmb1.TabStop = True
		Me.cmb1.Visible = True
		Me.cmb1.Name = "cmb1"
		Me.cmb2.Size = New System.Drawing.Size(97, 21)
		Me.cmb2.Location = New System.Drawing.Point(88, 232)
		Me.cmb2.Items.AddRange(New Object(){"Motorcycle", "Scooter"})
		Me.cmb2.TabIndex = 6
		Me.cmb2.Text = "None"
		Me.cmb2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmb2.BackColor = System.Drawing.SystemColors.Window
		Me.cmb2.CausesValidation = True
		Me.cmb2.Enabled = True
		Me.cmb2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmb2.IntegralHeight = True
		Me.cmb2.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmb2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmb2.Sorted = False
		Me.cmb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cmb2.TabStop = True
		Me.cmb2.Visible = True
		Me.cmb2.Name = "cmb2"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "Add New"
		Me.Command1.Size = New System.Drawing.Size(105, 49)
		Me.Command1.Location = New System.Drawing.Point(8, 336)
		Me.Command1.TabIndex = 5
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
		Me.Command2.Size = New System.Drawing.Size(97, 49)
		Me.Command2.Location = New System.Drawing.Point(128, 336)
		Me.Command2.TabIndex = 4
		Me.Command2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command2.BackColor = System.Drawing.SystemColors.Control
		Me.Command2.CausesValidation = True
		Me.Command2.Enabled = True
		Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command2.TabStop = True
		Me.Command2.Name = "Command2"
		Me.Command3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command3.Text = "Back"
		Me.Command3.Size = New System.Drawing.Size(89, 49)
		Me.Command3.Location = New System.Drawing.Point(240, 336)
		Me.Command3.TabIndex = 3
		Me.Command3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command3.BackColor = System.Drawing.SystemColors.Control
		Me.Command3.CausesValidation = True
		Me.Command3.Enabled = True
		Me.Command3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command3.TabStop = True
		Me.Command3.Name = "Command3"
		Me.Command4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command4.Text = "Cancel "
		Me.Command4.Size = New System.Drawing.Size(81, 49)
		Me.Command4.Location = New System.Drawing.Point(344, 336)
		Me.Command4.TabIndex = 2
		Me.Command4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command4.BackColor = System.Drawing.SystemColors.Control
		Me.Command4.CausesValidation = True
		Me.Command4.Enabled = True
		Me.Command4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command4.TabStop = True
		Me.Command4.Name = "Command4"
		Me.Command5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command5.Text = "Upload"
		Me.Command5.Size = New System.Drawing.Size(121, 41)
		Me.Command5.Location = New System.Drawing.Point(272, 280)
		Me.Command5.TabIndex = 1
		Me.Command5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command5.BackColor = System.Drawing.SystemColors.Control
		Me.Command5.CausesValidation = True
		Me.Command5.Enabled = True
		Me.Command5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command5.TabStop = True
		Me.Command5.Name = "Command5"
		Me.lblo.Size = New System.Drawing.Size(105, 25)
		Me.lblo.Location = New System.Drawing.Point(104, 96)
		Me.lblo.TabIndex = 19
		Me.lblo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblo.BackColor = System.Drawing.Color.Transparent
		Me.lblo.Enabled = True
		Me.lblo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblo.UseMnemonic = True
		Me.lblo.Visible = True
		Me.lblo.AutoSize = False
		Me.lblo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblo.Name = "lblo"
		Me.Label1.Text = "Bike id"
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Size = New System.Drawing.Size(57, 25)
		Me.Label1.Location = New System.Drawing.Point(8, 40)
		Me.Label1.TabIndex = 18
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
		Me.Label2.Text = "Bike Name"
		Me.Label2.ForeColor = System.Drawing.Color.White
		Me.Label2.Size = New System.Drawing.Size(65, 25)
		Me.Label2.Location = New System.Drawing.Point(8, 64)
		Me.Label2.TabIndex = 17
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
		Me.Label3.Text = "Dealer Name"
		Me.Label3.ForeColor = System.Drawing.Color.White
		Me.Label3.Size = New System.Drawing.Size(73, 17)
		Me.Label3.Location = New System.Drawing.Point(8, 120)
		Me.Label3.TabIndex = 16
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
		Me.Label4.Text = "Price"
		Me.Label4.ForeColor = System.Drawing.Color.White
		Me.Label4.Size = New System.Drawing.Size(57, 17)
		Me.Label4.Location = New System.Drawing.Point(16, 160)
		Me.Label4.TabIndex = 15
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
		Me.Label5.Text = "Color"
		Me.Label5.ForeColor = System.Drawing.Color.White
		Me.Label5.Size = New System.Drawing.Size(73, 25)
		Me.Label5.Location = New System.Drawing.Point(16, 200)
		Me.Label5.TabIndex = 14
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
		Me.Label6.Text = "Catagory "
		Me.Label6.ForeColor = System.Drawing.Color.White
		Me.Label6.Size = New System.Drawing.Size(65, 25)
		Me.Label6.Location = New System.Drawing.Point(16, 232)
		Me.Label6.TabIndex = 13
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
		Me.Image2.Size = New System.Drawing.Size(1352, 808)
		Me.Image2.Location = New System.Drawing.Point(0, 0)
		Me.Image2.Image = CType(resources.GetObject("Image2.Image"), System.Drawing.Image)
		Me.Image2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.Image2.Enabled = True
		Me.Image2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Image2.Visible = True
		Me.Image2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Image2.Name = "Image2"
		Me.Image1.Size = New System.Drawing.Size(3840, 2160)
		Me.Image1.Location = New System.Drawing.Point(-696, -848)
		Me.Image1.Enabled = True
		Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.Image1.Visible = True
		Me.Image1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Image1.Name = "Image1"
		Me.Controls.Add(Frame1)
		Me.Controls.Add(Image2)
		Me.Controls.Add(Image1)
		Me.Frame1.Controls.Add(pic1)
		Me.Frame1.Controls.Add(txtbid)
		Me.Frame1.Controls.Add(txtbname)
		Me.Frame1.Controls.Add(txtbdealer)
		Me.Frame1.Controls.Add(txtbprice)
		Me.Frame1.Controls.Add(cmb1)
		Me.Frame1.Controls.Add(cmb2)
		Me.Frame1.Controls.Add(Command1)
		Me.Frame1.Controls.Add(Command2)
		Me.Frame1.Controls.Add(Command3)
		Me.Frame1.Controls.Add(Command4)
		Me.Frame1.Controls.Add(Command5)
		Me.Frame1.Controls.Add(lblo)
		Me.Frame1.Controls.Add(Label1)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Label3)
		Me.Frame1.Controls.Add(Label4)
		Me.Frame1.Controls.Add(Label5)
		Me.Frame1.Controls.Add(Label6)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class