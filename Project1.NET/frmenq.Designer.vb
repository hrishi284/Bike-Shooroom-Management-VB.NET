<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmenq
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
	Public WithEvents cmb1 As System.Windows.Forms.ComboBox
	Public WithEvents txtNo As System.Windows.Forms.TextBox
	Public WithEvents txtdt As System.Windows.Forms.TextBox
	Public WithEvents txtcname As System.Windows.Forms.TextBox
	Public WithEvents txtph As System.Windows.Forms.TextBox
	Public WithEvents txtadd As System.Windows.Forms.TextBox
	Public WithEvents txteid As System.Windows.Forms.TextBox
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command3 As System.Windows.Forms.Button
	Public WithEvents Command4 As System.Windows.Forms.Button
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Image1 As System.Windows.Forms.PictureBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmenq))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.cmb1 = New System.Windows.Forms.ComboBox
		Me.txtNo = New System.Windows.Forms.TextBox
		Me.txtdt = New System.Windows.Forms.TextBox
		Me.txtcname = New System.Windows.Forms.TextBox
		Me.txtph = New System.Windows.Forms.TextBox
		Me.txtadd = New System.Windows.Forms.TextBox
		Me.txteid = New System.Windows.Forms.TextBox
		Me.Command1 = New System.Windows.Forms.Button
		Me.Command2 = New System.Windows.Forms.Button
		Me.Command3 = New System.Windows.Forms.Button
		Me.Command4 = New System.Windows.Forms.Button
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Image1 = New System.Windows.Forms.PictureBox
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Form2"
		Me.ClientSize = New System.Drawing.Size(462, 286)
		Me.Location = New System.Drawing.Point(8, 30)
		Me.Icon = CType(resources.GetObject("frmenq.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmenq"
		Me.Frame1.BackColor = System.Drawing.Color.Black
		Me.Frame1.Text = "Enquiry Details"
		Me.Frame1.ForeColor = System.Drawing.SystemColors.InactiveBorder
		Me.Frame1.Size = New System.Drawing.Size(449, 529)
		Me.Frame1.Location = New System.Drawing.Point(0, 0)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.Enabled = True
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.cmb1.Size = New System.Drawing.Size(105, 21)
		Me.cmb1.Location = New System.Drawing.Point(160, 368)
		Me.cmb1.TabIndex = 11
		Me.cmb1.Text = "Select Bike"
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
		Me.txtNo.AutoSize = False
		Me.txtNo.Size = New System.Drawing.Size(153, 25)
		Me.txtNo.Location = New System.Drawing.Point(160, 56)
		Me.txtNo.TabIndex = 10
		Me.txtNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNo.AcceptsReturn = True
		Me.txtNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtNo.BackColor = System.Drawing.SystemColors.Window
		Me.txtNo.CausesValidation = True
		Me.txtNo.Enabled = True
		Me.txtNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtNo.HideSelection = True
		Me.txtNo.ReadOnly = False
		Me.txtNo.Maxlength = 0
		Me.txtNo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNo.MultiLine = False
		Me.txtNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtNo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNo.TabStop = True
		Me.txtNo.Visible = True
		Me.txtNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtNo.Name = "txtNo"
		Me.txtdt.AutoSize = False
		Me.txtdt.Size = New System.Drawing.Size(145, 25)
		Me.txtdt.Location = New System.Drawing.Point(160, 96)
		Me.txtdt.TabIndex = 9
		Me.txtdt.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtdt.AcceptsReturn = True
		Me.txtdt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtdt.BackColor = System.Drawing.SystemColors.Window
		Me.txtdt.CausesValidation = True
		Me.txtdt.Enabled = True
		Me.txtdt.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtdt.HideSelection = True
		Me.txtdt.ReadOnly = False
		Me.txtdt.Maxlength = 0
		Me.txtdt.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtdt.MultiLine = False
		Me.txtdt.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtdt.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtdt.TabStop = True
		Me.txtdt.Visible = True
		Me.txtdt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtdt.Name = "txtdt"
		Me.txtcname.AutoSize = False
		Me.txtcname.Size = New System.Drawing.Size(185, 19)
		Me.txtcname.Location = New System.Drawing.Point(160, 136)
		Me.txtcname.TabIndex = 8
		Me.txtcname.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtcname.AcceptsReturn = True
		Me.txtcname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtcname.BackColor = System.Drawing.SystemColors.Window
		Me.txtcname.CausesValidation = True
		Me.txtcname.Enabled = True
		Me.txtcname.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtcname.HideSelection = True
		Me.txtcname.ReadOnly = False
		Me.txtcname.Maxlength = 0
		Me.txtcname.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtcname.MultiLine = False
		Me.txtcname.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtcname.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtcname.TabStop = True
		Me.txtcname.Visible = True
		Me.txtcname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtcname.Name = "txtcname"
		Me.txtph.AutoSize = False
		Me.txtph.Size = New System.Drawing.Size(161, 25)
		Me.txtph.Location = New System.Drawing.Point(160, 176)
		Me.txtph.TabIndex = 7
		Me.txtph.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtph.AcceptsReturn = True
		Me.txtph.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtph.BackColor = System.Drawing.SystemColors.Window
		Me.txtph.CausesValidation = True
		Me.txtph.Enabled = True
		Me.txtph.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtph.HideSelection = True
		Me.txtph.ReadOnly = False
		Me.txtph.Maxlength = 0
		Me.txtph.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtph.MultiLine = False
		Me.txtph.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtph.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtph.TabStop = True
		Me.txtph.Visible = True
		Me.txtph.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtph.Name = "txtph"
		Me.txtadd.AutoSize = False
		Me.txtadd.Size = New System.Drawing.Size(201, 81)
		Me.txtadd.Location = New System.Drawing.Point(160, 216)
		Me.txtadd.TabIndex = 6
		Me.txtadd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtadd.AcceptsReturn = True
		Me.txtadd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtadd.BackColor = System.Drawing.SystemColors.Window
		Me.txtadd.CausesValidation = True
		Me.txtadd.Enabled = True
		Me.txtadd.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtadd.HideSelection = True
		Me.txtadd.ReadOnly = False
		Me.txtadd.Maxlength = 0
		Me.txtadd.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtadd.MultiLine = False
		Me.txtadd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtadd.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtadd.TabStop = True
		Me.txtadd.Visible = True
		Me.txtadd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtadd.Name = "txtadd"
		Me.txteid.AutoSize = False
		Me.txteid.Size = New System.Drawing.Size(169, 25)
		Me.txteid.Location = New System.Drawing.Point(160, 328)
		Me.txteid.TabIndex = 5
		Me.txteid.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txteid.AcceptsReturn = True
		Me.txteid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txteid.BackColor = System.Drawing.SystemColors.Window
		Me.txteid.CausesValidation = True
		Me.txteid.Enabled = True
		Me.txteid.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txteid.HideSelection = True
		Me.txteid.ReadOnly = False
		Me.txteid.Maxlength = 0
		Me.txteid.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txteid.MultiLine = False
		Me.txteid.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txteid.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txteid.TabStop = True
		Me.txteid.Visible = True
		Me.txteid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txteid.Name = "txteid"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "Add New"
		Me.Command1.Size = New System.Drawing.Size(105, 41)
		Me.Command1.Location = New System.Drawing.Point(8, 424)
		Me.Command1.TabIndex = 4
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
		Me.Command2.Size = New System.Drawing.Size(97, 41)
		Me.Command2.Location = New System.Drawing.Point(128, 424)
		Me.Command2.TabIndex = 3
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
		Me.Command3.Size = New System.Drawing.Size(89, 41)
		Me.Command3.Location = New System.Drawing.Point(240, 424)
		Me.Command3.TabIndex = 2
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
		Me.Command4.Text = "Cancel"
		Me.Command4.Size = New System.Drawing.Size(73, 41)
		Me.Command4.Location = New System.Drawing.Point(352, 424)
		Me.Command4.TabIndex = 1
		Me.Command4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command4.BackColor = System.Drawing.SystemColors.Control
		Me.Command4.CausesValidation = True
		Me.Command4.Enabled = True
		Me.Command4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command4.TabStop = True
		Me.Command4.Name = "Command4"
		Me.Label1.Text = "Enquiry No"
		Me.Label1.ForeColor = System.Drawing.SystemColors.highlightText
		Me.Label1.Size = New System.Drawing.Size(65, 25)
		Me.Label1.Location = New System.Drawing.Point(24, 56)
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
		Me.Label3.Text = "Enquiry Date"
		Me.Label3.ForeColor = System.Drawing.SystemColors.highlightText
		Me.Label3.Size = New System.Drawing.Size(65, 25)
		Me.Label3.Location = New System.Drawing.Point(24, 96)
		Me.Label3.TabIndex = 17
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
		Me.Label4.Text = "Customer Name"
		Me.Label4.ForeColor = System.Drawing.SystemColors.highlightText
		Me.Label4.Size = New System.Drawing.Size(89, 25)
		Me.Label4.Location = New System.Drawing.Point(16, 136)
		Me.Label4.TabIndex = 16
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
		Me.Label5.Text = "Custome rPhone"
		Me.Label5.ForeColor = System.Drawing.SystemColors.highlightText
		Me.Label5.Size = New System.Drawing.Size(89, 25)
		Me.Label5.Location = New System.Drawing.Point(16, 176)
		Me.Label5.TabIndex = 15
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
		Me.Label6.Text = "Customer Address"
		Me.Label6.ForeColor = System.Drawing.SystemColors.highlightText
		Me.Label6.Size = New System.Drawing.Size(97, 33)
		Me.Label6.Location = New System.Drawing.Point(16, 216)
		Me.Label6.TabIndex = 14
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
		Me.Label7.Text = "Email-ID"
		Me.Label7.ForeColor = System.Drawing.SystemColors.highlightText
		Me.Label7.Size = New System.Drawing.Size(105, 41)
		Me.Label7.Location = New System.Drawing.Point(16, 320)
		Me.Label7.TabIndex = 13
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
		Me.Label8.Text = "Bike Intersted "
		Me.Label8.ForeColor = System.Drawing.SystemColors.highlightText
		Me.Label8.Size = New System.Drawing.Size(89, 25)
		Me.Label8.Location = New System.Drawing.Point(16, 368)
		Me.Label8.TabIndex = 12
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
		Me.Label2.Text = "Enquiry No"
		Me.Label2.Size = New System.Drawing.Size(65, 25)
		Me.Label2.Location = New System.Drawing.Point(32, 104)
		Me.Label2.TabIndex = 19
		Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Image1.Size = New System.Drawing.Size(1920, 1080)
		Me.Image1.Location = New System.Drawing.Point(-168, -16)
		Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
		Me.Image1.Enabled = True
		Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.Image1.Visible = True
		Me.Image1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Image1.Name = "Image1"
		Me.Controls.Add(Frame1)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Image1)
		Me.Frame1.Controls.Add(cmb1)
		Me.Frame1.Controls.Add(txtNo)
		Me.Frame1.Controls.Add(txtdt)
		Me.Frame1.Controls.Add(txtcname)
		Me.Frame1.Controls.Add(txtph)
		Me.Frame1.Controls.Add(txtadd)
		Me.Frame1.Controls.Add(txteid)
		Me.Frame1.Controls.Add(Command1)
		Me.Frame1.Controls.Add(Command2)
		Me.Frame1.Controls.Add(Command3)
		Me.Frame1.Controls.Add(Command4)
		Me.Frame1.Controls.Add(Label1)
		Me.Frame1.Controls.Add(Label3)
		Me.Frame1.Controls.Add(Label4)
		Me.Frame1.Controls.Add(Label5)
		Me.Frame1.Controls.Add(Label6)
		Me.Frame1.Controls.Add(Label7)
		Me.Frame1.Controls.Add(Label8)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class