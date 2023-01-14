<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmscust
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
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Command4 As System.Windows.Forms.Button
	Public WithEvents txtsch As System.Windows.Forms.TextBox
	Public WithEvents txtcid As System.Windows.Forms.TextBox
	Public WithEvents txtcName As System.Windows.Forms.TextBox
	Public WithEvents txtcAdd As System.Windows.Forms.TextBox
	Public WithEvents txtcNo As System.Windows.Forms.TextBox
	Public WithEvents txtcmail As System.Windows.Forms.TextBox
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
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmscust))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.pic1 = New System.Windows.Forms.PictureBox
		Me.Command1 = New System.Windows.Forms.Button
		Me.Command4 = New System.Windows.Forms.Button
		Me.txtsch = New System.Windows.Forms.TextBox
		Me.txtcid = New System.Windows.Forms.TextBox
		Me.txtcName = New System.Windows.Forms.TextBox
		Me.txtcAdd = New System.Windows.Forms.TextBox
		Me.txtcNo = New System.Windows.Forms.TextBox
		Me.txtcmail = New System.Windows.Forms.TextBox
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
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.ClientSize = New System.Drawing.Size(594, 418)
		Me.Location = New System.Drawing.Point(8, 30)
		Me.Icon = CType(resources.GetObject("frmscust.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmscust"
		Me.Frame1.BackColor = System.Drawing.Color.FromARGB(128, 128, 128)
		Me.Frame1.Text = "Custmer Seach"
		Me.Frame1.Size = New System.Drawing.Size(505, 473)
		Me.Frame1.Location = New System.Drawing.Point(24, 48)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.pic1.BackColor = System.Drawing.Color.White
		Me.pic1.Size = New System.Drawing.Size(193, 209)
		Me.pic1.Location = New System.Drawing.Point(296, 88)
		Me.pic1.TabIndex = 15
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
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "Cancel"
		Me.Command1.Size = New System.Drawing.Size(97, 41)
		Me.Command1.Location = New System.Drawing.Point(152, 416)
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
		Me.Command4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command4.Text = "Back"
		Me.Command4.Size = New System.Drawing.Size(97, 41)
		Me.Command4.Location = New System.Drawing.Point(32, 416)
		Me.Command4.TabIndex = 7
		Me.Command4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command4.BackColor = System.Drawing.SystemColors.Control
		Me.Command4.CausesValidation = True
		Me.Command4.Enabled = True
		Me.Command4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command4.TabStop = True
		Me.Command4.Name = "Command4"
		Me.txtsch.AutoSize = False
		Me.txtsch.Size = New System.Drawing.Size(201, 33)
		Me.txtsch.Location = New System.Drawing.Point(112, 40)
		Me.txtsch.TabIndex = 6
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
		Me.txtcid.AutoSize = False
		Me.txtcid.Size = New System.Drawing.Size(113, 27)
		Me.txtcid.Location = New System.Drawing.Point(112, 96)
		Me.txtcid.TabIndex = 5
		Me.txtcid.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtcid.AcceptsReturn = True
		Me.txtcid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtcid.BackColor = System.Drawing.SystemColors.Window
		Me.txtcid.CausesValidation = True
		Me.txtcid.Enabled = True
		Me.txtcid.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtcid.HideSelection = True
		Me.txtcid.ReadOnly = False
		Me.txtcid.Maxlength = 0
		Me.txtcid.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtcid.MultiLine = False
		Me.txtcid.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtcid.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtcid.TabStop = True
		Me.txtcid.Visible = True
		Me.txtcid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtcid.Name = "txtcid"
		Me.txtcName.AutoSize = False
		Me.txtcName.Size = New System.Drawing.Size(137, 25)
		Me.txtcName.Location = New System.Drawing.Point(112, 144)
		Me.txtcName.TabIndex = 4
		Me.txtcName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtcName.AcceptsReturn = True
		Me.txtcName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtcName.BackColor = System.Drawing.SystemColors.Window
		Me.txtcName.CausesValidation = True
		Me.txtcName.Enabled = True
		Me.txtcName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtcName.HideSelection = True
		Me.txtcName.ReadOnly = False
		Me.txtcName.Maxlength = 0
		Me.txtcName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtcName.MultiLine = False
		Me.txtcName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtcName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtcName.TabStop = True
		Me.txtcName.Visible = True
		Me.txtcName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtcName.Name = "txtcName"
		Me.txtcAdd.AutoSize = False
		Me.txtcAdd.Size = New System.Drawing.Size(177, 97)
		Me.txtcAdd.Location = New System.Drawing.Point(112, 184)
		Me.txtcAdd.TabIndex = 3
		Me.txtcAdd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtcAdd.AcceptsReturn = True
		Me.txtcAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtcAdd.BackColor = System.Drawing.SystemColors.Window
		Me.txtcAdd.CausesValidation = True
		Me.txtcAdd.Enabled = True
		Me.txtcAdd.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtcAdd.HideSelection = True
		Me.txtcAdd.ReadOnly = False
		Me.txtcAdd.Maxlength = 0
		Me.txtcAdd.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtcAdd.MultiLine = False
		Me.txtcAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtcAdd.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtcAdd.TabStop = True
		Me.txtcAdd.Visible = True
		Me.txtcAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtcAdd.Name = "txtcAdd"
		Me.txtcNo.AutoSize = False
		Me.txtcNo.Size = New System.Drawing.Size(113, 25)
		Me.txtcNo.Location = New System.Drawing.Point(112, 296)
		Me.txtcNo.TabIndex = 2
		Me.txtcNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtcNo.AcceptsReturn = True
		Me.txtcNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtcNo.BackColor = System.Drawing.SystemColors.Window
		Me.txtcNo.CausesValidation = True
		Me.txtcNo.Enabled = True
		Me.txtcNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtcNo.HideSelection = True
		Me.txtcNo.ReadOnly = False
		Me.txtcNo.Maxlength = 0
		Me.txtcNo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtcNo.MultiLine = False
		Me.txtcNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtcNo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtcNo.TabStop = True
		Me.txtcNo.Visible = True
		Me.txtcNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtcNo.Name = "txtcNo"
		Me.txtcmail.AutoSize = False
		Me.txtcmail.Size = New System.Drawing.Size(161, 33)
		Me.txtcmail.Location = New System.Drawing.Point(112, 344)
		Me.txtcmail.TabIndex = 1
		Me.txtcmail.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtcmail.AcceptsReturn = True
		Me.txtcmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtcmail.BackColor = System.Drawing.SystemColors.Window
		Me.txtcmail.CausesValidation = True
		Me.txtcmail.Enabled = True
		Me.txtcmail.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtcmail.HideSelection = True
		Me.txtcmail.ReadOnly = False
		Me.txtcmail.Maxlength = 0
		Me.txtcmail.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtcmail.MultiLine = False
		Me.txtcmail.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtcmail.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtcmail.TabStop = True
		Me.txtcmail.Visible = True
		Me.txtcmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtcmail.Name = "txtcmail"
		Me.Label1.Text = "Custmer Id"
		Me.Label1.Size = New System.Drawing.Size(73, 17)
		Me.Label1.Location = New System.Drawing.Point(16, 104)
		Me.Label1.TabIndex = 14
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Label2.Text = "Custmer Name"
		Me.Label2.Size = New System.Drawing.Size(73, 25)
		Me.Label2.Location = New System.Drawing.Point(8, 144)
		Me.Label2.TabIndex = 13
		Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label3.Text = "Custmer Adsress"
		Me.Label3.Size = New System.Drawing.Size(89, 25)
		Me.Label3.Location = New System.Drawing.Point(8, 192)
		Me.Label3.TabIndex = 12
		Me.Label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label4.Text = "Custmer Phone No"
		Me.Label4.Size = New System.Drawing.Size(81, 25)
		Me.Label4.Location = New System.Drawing.Point(8, 296)
		Me.Label4.TabIndex = 11
		Me.Label4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Label5.Text = "Email Adress"
		Me.Label5.Size = New System.Drawing.Size(81, 25)
		Me.Label5.Location = New System.Drawing.Point(8, 352)
		Me.Label5.TabIndex = 10
		Me.Label5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label6.Text = "Search by name"
		Me.Label6.Size = New System.Drawing.Size(73, 33)
		Me.Label6.Location = New System.Drawing.Point(16, 40)
		Me.Label6.TabIndex = 9
		Me.Label6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Enabled = True
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Image1.Size = New System.Drawing.Size(1376, 731)
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
		Me.Frame1.Controls.Add(pic1)
		Me.Frame1.Controls.Add(Command1)
		Me.Frame1.Controls.Add(Command4)
		Me.Frame1.Controls.Add(txtsch)
		Me.Frame1.Controls.Add(txtcid)
		Me.Frame1.Controls.Add(txtcName)
		Me.Frame1.Controls.Add(txtcAdd)
		Me.Frame1.Controls.Add(txtcNo)
		Me.Frame1.Controls.Add(txtcmail)
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