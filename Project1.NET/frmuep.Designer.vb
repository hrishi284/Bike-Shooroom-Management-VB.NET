<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmuep
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
	Public WithEvents Command5 As System.Windows.Forms.Button
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents txtid As System.Windows.Forms.TextBox
	Public WithEvents txtname As System.Windows.Forms.TextBox
	Public WithEvents txtadd As System.Windows.Forms.TextBox
	Public WithEvents txtno As System.Windows.Forms.TextBox
	Public WithEvents txtsch As System.Windows.Forms.TextBox
	Public WithEvents pic1 As System.Windows.Forms.PictureBox
	Public WithEvents Command3 As System.Windows.Forms.Button
	Public CommonDialog1Open As System.Windows.Forms.OpenFileDialog
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Image1 As System.Windows.Forms.PictureBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmuep))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.Command5 = New System.Windows.Forms.Button
		Me.Command2 = New System.Windows.Forms.Button
		Me.Command1 = New System.Windows.Forms.Button
		Me.txtid = New System.Windows.Forms.TextBox
		Me.txtname = New System.Windows.Forms.TextBox
		Me.txtadd = New System.Windows.Forms.TextBox
		Me.txtno = New System.Windows.Forms.TextBox
		Me.txtsch = New System.Windows.Forms.TextBox
		Me.pic1 = New System.Windows.Forms.PictureBox
		Me.Command3 = New System.Windows.Forms.Button
		Me.CommonDialog1Open = New System.Windows.Forms.OpenFileDialog
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Image1 = New System.Windows.Forms.PictureBox
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Form3"
		Me.ClientSize = New System.Drawing.Size(616, 489)
		Me.Location = New System.Drawing.Point(331, 56)
		Me.Icon = CType(resources.GetObject("frmuep.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmuep"
		Me.Frame1.BackColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.Text = "Update"
		Me.Frame1.ForeColor = System.Drawing.SystemColors.InactiveBorder
		Me.Frame1.Size = New System.Drawing.Size(553, 561)
		Me.Frame1.Location = New System.Drawing.Point(24, 32)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.Enabled = True
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.Command5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command5.Text = "Upload"
		Me.Command5.Size = New System.Drawing.Size(89, 49)
		Me.Command5.Location = New System.Drawing.Point(384, 368)
		Me.Command5.TabIndex = 10
		Me.Command5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command5.BackColor = System.Drawing.SystemColors.Control
		Me.Command5.CausesValidation = True
		Me.Command5.Enabled = True
		Me.Command5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command5.TabStop = True
		Me.Command5.Name = "Command5"
		Me.Command2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command2.Text = "UPDATE"
		Me.Command2.Size = New System.Drawing.Size(153, 41)
		Me.Command2.Location = New System.Drawing.Point(88, 432)
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
		Me.Command1.Size = New System.Drawing.Size(97, 49)
		Me.Command1.Location = New System.Drawing.Point(264, 432)
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
		Me.txtid.AutoSize = False
		Me.txtid.Size = New System.Drawing.Size(137, 19)
		Me.txtid.Location = New System.Drawing.Point(160, 152)
		Me.txtid.TabIndex = 7
		Me.txtid.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtid.AcceptsReturn = True
		Me.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtid.BackColor = System.Drawing.SystemColors.Window
		Me.txtid.CausesValidation = True
		Me.txtid.Enabled = True
		Me.txtid.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtid.HideSelection = True
		Me.txtid.ReadOnly = False
		Me.txtid.Maxlength = 0
		Me.txtid.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtid.MultiLine = False
		Me.txtid.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtid.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtid.TabStop = True
		Me.txtid.Visible = True
		Me.txtid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtid.Name = "txtid"
		Me.txtname.AutoSize = False
		Me.txtname.Size = New System.Drawing.Size(137, 25)
		Me.txtname.Location = New System.Drawing.Point(160, 192)
		Me.txtname.TabIndex = 6
		Me.txtname.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtname.AcceptsReturn = True
		Me.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtname.BackColor = System.Drawing.SystemColors.Window
		Me.txtname.CausesValidation = True
		Me.txtname.Enabled = True
		Me.txtname.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtname.HideSelection = True
		Me.txtname.ReadOnly = False
		Me.txtname.Maxlength = 0
		Me.txtname.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtname.MultiLine = False
		Me.txtname.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtname.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtname.TabStop = True
		Me.txtname.Visible = True
		Me.txtname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtname.Name = "txtname"
		Me.txtadd.AutoSize = False
		Me.txtadd.Size = New System.Drawing.Size(161, 65)
		Me.txtadd.Location = New System.Drawing.Point(160, 240)
		Me.txtadd.TabIndex = 5
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
		Me.txtno.AutoSize = False
		Me.txtno.Size = New System.Drawing.Size(137, 25)
		Me.txtno.Location = New System.Drawing.Point(160, 360)
		Me.txtno.TabIndex = 4
		Me.txtno.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtno.AcceptsReturn = True
		Me.txtno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtno.BackColor = System.Drawing.SystemColors.Window
		Me.txtno.CausesValidation = True
		Me.txtno.Enabled = True
		Me.txtno.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtno.HideSelection = True
		Me.txtno.ReadOnly = False
		Me.txtno.Maxlength = 0
		Me.txtno.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtno.MultiLine = False
		Me.txtno.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtno.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtno.TabStop = True
		Me.txtno.Visible = True
		Me.txtno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtno.Name = "txtno"
		Me.txtsch.AutoSize = False
		Me.txtsch.Size = New System.Drawing.Size(265, 33)
		Me.txtsch.Location = New System.Drawing.Point(160, 72)
		Me.txtsch.TabIndex = 3
		Me.txtsch.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtsch.AcceptsReturn = True
		Me.txtsch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtsch.BackColor = System.Drawing.SystemColors.Window
		Me.txtsch.CausesValidation = True
		Me.txtsch.Enabled = True
		Me.txtsch.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtsch.HideSelection = True
		Me.txtsch.ReadOnly = False
		Me.txtsch.Maxlength = 0
		Me.txtsch.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtsch.MultiLine = False
		Me.txtsch.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtsch.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtsch.TabStop = True
		Me.txtsch.Visible = True
		Me.txtsch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtsch.Name = "txtsch"
		Me.pic1.BackColor = System.Drawing.Color.White
		Me.pic1.Size = New System.Drawing.Size(193, 209)
		Me.pic1.Location = New System.Drawing.Point(336, 128)
		Me.pic1.TabIndex = 2
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
		Me.Command3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command3.Text = "Update Photo"
		Me.Command3.Size = New System.Drawing.Size(153, 41)
		Me.Command3.Location = New System.Drawing.Point(88, 488)
		Me.Command3.TabIndex = 1
		Me.Command3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command3.BackColor = System.Drawing.SystemColors.Control
		Me.Command3.CausesValidation = True
		Me.Command3.Enabled = True
		Me.Command3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command3.TabStop = True
		Me.Command3.Name = "Command3"
		Me.Label1.BackColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Text = "Employee ID "
		Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveBorder
		Me.Label1.Size = New System.Drawing.Size(65, 17)
		Me.Label1.Location = New System.Drawing.Point(48, 152)
		Me.Label1.TabIndex = 15
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.Enabled = True
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Label2.BackColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Text = "Employee Name "
		Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveBorder
		Me.Label2.Size = New System.Drawing.Size(81, 25)
		Me.Label2.Location = New System.Drawing.Point(40, 192)
		Me.Label2.TabIndex = 14
		Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.Enabled = True
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label3.BackColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Text = "Employee Address"
		Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveBorder
		Me.Label3.Size = New System.Drawing.Size(89, 17)
		Me.Label3.Location = New System.Drawing.Point(32, 248)
		Me.Label3.TabIndex = 13
		Me.Label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.Enabled = True
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label4.BackColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Text = "Employee Contact No"
		Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveBorder
		Me.Label4.Size = New System.Drawing.Size(65, 25)
		Me.Label4.Location = New System.Drawing.Point(56, 368)
		Me.Label4.TabIndex = 12
		Me.Label4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.Enabled = True
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Label6.BackColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Text = "Search by name"
		Me.Label6.ForeColor = System.Drawing.SystemColors.InactiveBorder
		Me.Label6.Size = New System.Drawing.Size(97, 33)
		Me.Label6.Location = New System.Drawing.Point(48, 72)
		Me.Label6.TabIndex = 11
		Me.Label6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.Enabled = True
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Image1.Size = New System.Drawing.Size(1920, 1200)
		Me.Image1.Location = New System.Drawing.Point(-16, -152)
		Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
		Me.Image1.Enabled = True
		Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.Image1.Visible = True
		Me.Image1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Image1.Name = "Image1"
		Me.Controls.Add(Frame1)
		Me.Controls.Add(Image1)
		Me.Frame1.Controls.Add(Command5)
		Me.Frame1.Controls.Add(Command2)
		Me.Frame1.Controls.Add(Command1)
		Me.Frame1.Controls.Add(txtid)
		Me.Frame1.Controls.Add(txtname)
		Me.Frame1.Controls.Add(txtadd)
		Me.Frame1.Controls.Add(txtno)
		Me.Frame1.Controls.Add(txtsch)
		Me.Frame1.Controls.Add(pic1)
		Me.Frame1.Controls.Add(Command3)
		Me.Frame1.Controls.Add(Label1)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Label3)
		Me.Frame1.Controls.Add(Label4)
		Me.Frame1.Controls.Add(Label6)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class