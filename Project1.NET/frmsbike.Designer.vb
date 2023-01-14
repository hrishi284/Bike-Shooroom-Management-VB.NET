<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmsbike
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
	Public WithEvents pic12 As System.Windows.Forms.PictureBox
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents txtbid As System.Windows.Forms.TextBox
	Public WithEvents txtbname As System.Windows.Forms.TextBox
	Public WithEvents txtbdealer As System.Windows.Forms.TextBox
	Public WithEvents txtbprice As System.Windows.Forms.TextBox
	Public WithEvents cmb1 As System.Windows.Forms.ComboBox
	Public WithEvents cmb2 As System.Windows.Forms.ComboBox
	Public WithEvents txtsrh As System.Windows.Forms.TextBox
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Image1 As System.Windows.Forms.PictureBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmsbike))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.pic12 = New System.Windows.Forms.PictureBox
		Me.Command2 = New System.Windows.Forms.Button
		Me.Command1 = New System.Windows.Forms.Button
		Me.txtbid = New System.Windows.Forms.TextBox
		Me.txtbname = New System.Windows.Forms.TextBox
		Me.txtbdealer = New System.Windows.Forms.TextBox
		Me.txtbprice = New System.Windows.Forms.TextBox
		Me.cmb1 = New System.Windows.Forms.ComboBox
		Me.cmb2 = New System.Windows.Forms.ComboBox
		Me.txtsrh = New System.Windows.Forms.TextBox
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Image1 = New System.Windows.Forms.PictureBox
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "Form2"
		Me.ClientSize = New System.Drawing.Size(1008, 555)
		Me.Location = New System.Drawing.Point(15, 37)
		Me.Icon = CType(resources.GetObject("frmsbike.Icon"), System.Drawing.Icon)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
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
		Me.Name = "frmsbike"
		Me.Frame1.BackColor = System.Drawing.Color.FromARGB(0, 64, 64)
		Me.Frame1.Text = "Bike Search "
		Me.Frame1.ForeColor = System.Drawing.Color.White
		Me.Frame1.Size = New System.Drawing.Size(521, 457)
		Me.Frame1.Location = New System.Drawing.Point(8, 40)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.Enabled = True
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.pic12.BackColor = System.Drawing.Color.White
		Me.pic12.Size = New System.Drawing.Size(289, 209)
		Me.pic12.Location = New System.Drawing.Point(224, 128)
		Me.pic12.TabIndex = 17
		Me.pic12.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.pic12.Dock = System.Windows.Forms.DockStyle.None
		Me.pic12.CausesValidation = True
		Me.pic12.Enabled = True
		Me.pic12.ForeColor = System.Drawing.SystemColors.ControlText
		Me.pic12.Cursor = System.Windows.Forms.Cursors.Default
		Me.pic12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.pic12.TabStop = True
		Me.pic12.Visible = True
		Me.pic12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.pic12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pic12.Name = "pic12"
		Me.Command2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command2.Text = "Cancel"
		Me.Command2.Size = New System.Drawing.Size(89, 41)
		Me.Command2.Location = New System.Drawing.Point(136, 384)
		Me.Command2.TabIndex = 9
		Me.Command2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command2.BackColor = System.Drawing.SystemColors.Control
		Me.Command2.CausesValidation = True
		Me.Command2.Enabled = True
		Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command2.TabStop = True
		Me.Command2.Name = "Command2"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "Back"
		Me.Command1.Size = New System.Drawing.Size(97, 41)
		Me.Command1.Location = New System.Drawing.Point(16, 384)
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
		Me.txtbid.AutoSize = False
		Me.txtbid.Size = New System.Drawing.Size(113, 19)
		Me.txtbid.Location = New System.Drawing.Point(88, 152)
		Me.txtbid.TabIndex = 7
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
		Me.txtbname.Location = New System.Drawing.Point(88, 184)
		Me.txtbname.TabIndex = 6
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
		Me.txtbdealer.Location = New System.Drawing.Point(88, 224)
		Me.txtbdealer.TabIndex = 5
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
		Me.txtbprice.Location = New System.Drawing.Point(88, 256)
		Me.txtbprice.TabIndex = 4
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
		Me.cmb1.Location = New System.Drawing.Point(88, 288)
		Me.cmb1.Items.AddRange(New Object(){"Black", "White ", "Grey", "Yellow", "Black Matte", "Blue", "Silver", "Brown", "Black & Red ", "Black & Yellow", "Green"})
		Me.cmb1.TabIndex = 3
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
		Me.cmb2.Location = New System.Drawing.Point(88, 328)
		Me.cmb2.Items.AddRange(New Object(){"Motorcycle", "Scooter"})
		Me.cmb2.TabIndex = 2
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
		Me.txtsrh.AutoSize = False
		Me.txtsrh.Size = New System.Drawing.Size(257, 41)
		Me.txtsrh.Location = New System.Drawing.Point(112, 48)
		Me.txtsrh.TabIndex = 1
		Me.txtsrh.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtsrh.AcceptsReturn = True
		Me.txtsrh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtsrh.BackColor = System.Drawing.SystemColors.Window
		Me.txtsrh.CausesValidation = True
		Me.txtsrh.Enabled = True
		Me.txtsrh.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtsrh.HideSelection = True
		Me.txtsrh.ReadOnly = False
		Me.txtsrh.Maxlength = 0
		Me.txtsrh.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtsrh.MultiLine = False
		Me.txtsrh.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtsrh.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtsrh.TabStop = True
		Me.txtsrh.Visible = True
		Me.txtsrh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtsrh.Name = "txtsrh"
		Me.Label7.Text = "Search from name"
		Me.Label7.ForeColor = System.Drawing.Color.White
		Me.Label7.Size = New System.Drawing.Size(97, 33)
		Me.Label7.Location = New System.Drawing.Point(8, 56)
		Me.Label7.TabIndex = 16
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
		Me.Label1.Text = "Bike id"
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Size = New System.Drawing.Size(57, 25)
		Me.Label1.Location = New System.Drawing.Point(8, 152)
		Me.Label1.TabIndex = 15
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
		Me.Label2.Location = New System.Drawing.Point(8, 184)
		Me.Label2.TabIndex = 14
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
		Me.Label3.Location = New System.Drawing.Point(8, 224)
		Me.Label3.TabIndex = 13
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
		Me.Label4.Location = New System.Drawing.Point(8, 256)
		Me.Label4.TabIndex = 12
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
		Me.Label5.Location = New System.Drawing.Point(8, 288)
		Me.Label5.TabIndex = 11
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
		Me.Label6.Location = New System.Drawing.Point(8, 328)
		Me.Label6.TabIndex = 10
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
		Me.Image1.Size = New System.Drawing.Size(1352, 800)
		Me.Image1.Location = New System.Drawing.Point(-24, 0)
		Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
		Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.Image1.Enabled = True
		Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Image1.Visible = True
		Me.Image1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Image1.Name = "Image1"
		Me.Controls.Add(Frame1)
		Me.Controls.Add(Image1)
		Me.Frame1.Controls.Add(pic12)
		Me.Frame1.Controls.Add(Command2)
		Me.Frame1.Controls.Add(Command1)
		Me.Frame1.Controls.Add(txtbid)
		Me.Frame1.Controls.Add(txtbname)
		Me.Frame1.Controls.Add(txtbdealer)
		Me.Frame1.Controls.Add(txtbprice)
		Me.Frame1.Controls.Add(cmb1)
		Me.Frame1.Controls.Add(cmb2)
		Me.Frame1.Controls.Add(txtsrh)
		Me.Frame1.Controls.Add(Label7)
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