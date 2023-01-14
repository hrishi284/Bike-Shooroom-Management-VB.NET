<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmEmp
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
	Public WithEvents Frame2 As System.Windows.Forms.Panel
	Public WithEvents pic1 As System.Windows.Forms.PictureBox
	Public WithEvents Command5 As System.Windows.Forms.Button
	Public WithEvents Command4 As System.Windows.Forms.Button
	Public WithEvents Command3 As System.Windows.Forms.Button
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents txteNo As System.Windows.Forms.TextBox
	Public WithEvents txteadd As System.Windows.Forms.TextBox
	Public WithEvents txtename As System.Windows.Forms.TextBox
	Public WithEvents txteid As System.Windows.Forms.TextBox
	Public CommonDialog1Open As System.Windows.Forms.OpenFileDialog
	Public WithEvents Labo As System.Windows.Forms.Label
	Public WithEvents lblo As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Image1 As System.Windows.Forms.PictureBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEmp))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame2 = New System.Windows.Forms.Panel
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.pic1 = New System.Windows.Forms.PictureBox
		Me.Command5 = New System.Windows.Forms.Button
		Me.Command4 = New System.Windows.Forms.Button
		Me.Command3 = New System.Windows.Forms.Button
		Me.Command2 = New System.Windows.Forms.Button
		Me.Command1 = New System.Windows.Forms.Button
		Me.txteNo = New System.Windows.Forms.TextBox
		Me.txteadd = New System.Windows.Forms.TextBox
		Me.txtename = New System.Windows.Forms.TextBox
		Me.txteid = New System.Windows.Forms.TextBox
		Me.CommonDialog1Open = New System.Windows.Forms.OpenFileDialog
		Me.Labo = New System.Windows.Forms.Label
		Me.lblo = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Image1 = New System.Windows.Forms.PictureBox
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = " "
		Me.ClientSize = New System.Drawing.Size(633, 482)
		Me.Location = New System.Drawing.Point(8, 30)
		Me.Icon = CType(resources.GetObject("frmEmp.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmEmp"
		Me.Frame2.BackColor = System.Drawing.Color.Black
		Me.Frame2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Frame2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Frame2.Size = New System.Drawing.Size(17, 17)
		Me.Frame2.Location = New System.Drawing.Point(832, 288)
		Me.Frame2.TabIndex = 14
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.Enabled = True
		Me.Frame2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Name = "Frame2"
		Me.Frame1.BackColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.Text = "Employee Details"
		Me.Frame1.ForeColor = System.Drawing.Color.White
		Me.Frame1.Size = New System.Drawing.Size(465, 433)
		Me.Frame1.Location = New System.Drawing.Point(16, 48)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.Enabled = True
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.pic1.BackColor = System.Drawing.Color.White
		Me.pic1.Size = New System.Drawing.Size(193, 209)
		Me.pic1.Location = New System.Drawing.Point(264, 40)
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
		Me.Command5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command5.Text = "Upload"
		Me.Command5.Size = New System.Drawing.Size(89, 49)
		Me.Command5.Location = New System.Drawing.Point(336, 280)
		Me.Command5.TabIndex = 9
		Me.Command5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command5.BackColor = System.Drawing.SystemColors.Control
		Me.Command5.CausesValidation = True
		Me.Command5.Enabled = True
		Me.Command5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command5.TabStop = True
		Me.Command5.Name = "Command5"
		Me.Command4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command4.Text = "Back"
		Me.Command4.Size = New System.Drawing.Size(89, 33)
		Me.Command4.Location = New System.Drawing.Point(216, 352)
		Me.Command4.TabIndex = 8
		Me.Command4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command4.BackColor = System.Drawing.SystemColors.Control
		Me.Command4.CausesValidation = True
		Me.Command4.Enabled = True
		Me.Command4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command4.TabStop = True
		Me.Command4.Name = "Command4"
		Me.Command3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command3.Text = "Cancel"
		Me.Command3.Size = New System.Drawing.Size(89, 33)
		Me.Command3.Location = New System.Drawing.Point(328, 352)
		Me.Command3.TabIndex = 7
		Me.Command3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command3.BackColor = System.Drawing.SystemColors.Control
		Me.Command3.CausesValidation = True
		Me.Command3.Enabled = True
		Me.Command3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command3.TabStop = True
		Me.Command3.Name = "Command3"
		Me.Command2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command2.Text = "Save "
		Me.Command2.Size = New System.Drawing.Size(89, 33)
		Me.Command2.Location = New System.Drawing.Point(112, 352)
		Me.Command2.TabIndex = 6
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
		Me.Command1.Text = "ADD NEW"
		Me.Command1.Size = New System.Drawing.Size(81, 33)
		Me.Command1.Location = New System.Drawing.Point(16, 352)
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
		Me.txteNo.AutoSize = False
		Me.txteNo.Size = New System.Drawing.Size(137, 25)
		Me.txteNo.Location = New System.Drawing.Point(112, 240)
		Me.txteNo.TabIndex = 4
		Me.txteNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txteNo.AcceptsReturn = True
		Me.txteNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txteNo.BackColor = System.Drawing.SystemColors.Window
		Me.txteNo.CausesValidation = True
		Me.txteNo.Enabled = True
		Me.txteNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txteNo.HideSelection = True
		Me.txteNo.ReadOnly = False
		Me.txteNo.Maxlength = 0
		Me.txteNo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txteNo.MultiLine = False
		Me.txteNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txteNo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txteNo.TabStop = True
		Me.txteNo.Visible = True
		Me.txteNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txteNo.Name = "txteNo"
		Me.txteadd.AutoSize = False
		Me.txteadd.Size = New System.Drawing.Size(137, 65)
		Me.txteadd.Location = New System.Drawing.Point(112, 160)
		Me.txteadd.TabIndex = 3
		Me.txteadd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txteadd.AcceptsReturn = True
		Me.txteadd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txteadd.BackColor = System.Drawing.SystemColors.Window
		Me.txteadd.CausesValidation = True
		Me.txteadd.Enabled = True
		Me.txteadd.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txteadd.HideSelection = True
		Me.txteadd.ReadOnly = False
		Me.txteadd.Maxlength = 0
		Me.txteadd.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txteadd.MultiLine = False
		Me.txteadd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txteadd.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txteadd.TabStop = True
		Me.txteadd.Visible = True
		Me.txteadd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txteadd.Name = "txteadd"
		Me.txtename.AutoSize = False
		Me.txtename.Size = New System.Drawing.Size(137, 25)
		Me.txtename.Location = New System.Drawing.Point(112, 80)
		Me.txtename.TabIndex = 2
		Me.txtename.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtename.AcceptsReturn = True
		Me.txtename.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtename.BackColor = System.Drawing.SystemColors.Window
		Me.txtename.CausesValidation = True
		Me.txtename.Enabled = True
		Me.txtename.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtename.HideSelection = True
		Me.txtename.ReadOnly = False
		Me.txtename.Maxlength = 0
		Me.txtename.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtename.MultiLine = False
		Me.txtename.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtename.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtename.TabStop = True
		Me.txtename.Visible = True
		Me.txtename.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtename.Name = "txtename"
		Me.txteid.AutoSize = False
		Me.txteid.Size = New System.Drawing.Size(137, 19)
		Me.txteid.Location = New System.Drawing.Point(112, 32)
		Me.txteid.TabIndex = 1
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
		Me.Labo.Size = New System.Drawing.Size(129, 33)
		Me.Labo.Location = New System.Drawing.Point(112, 272)
		Me.Labo.TabIndex = 17
		Me.Labo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Labo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Labo.BackColor = System.Drawing.Color.Transparent
		Me.Labo.Enabled = True
		Me.Labo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Labo.Cursor = System.Windows.Forms.Cursors.Default
		Me.Labo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Labo.UseMnemonic = True
		Me.Labo.Visible = True
		Me.Labo.AutoSize = False
		Me.Labo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Labo.Name = "Labo"
		Me.lblo.Size = New System.Drawing.Size(129, 25)
		Me.lblo.Location = New System.Drawing.Point(112, 112)
		Me.lblo.TabIndex = 16
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
		Me.Label4.Text = "Employee Contact No"
		Me.Label4.ForeColor = System.Drawing.Color.White
		Me.Label4.Size = New System.Drawing.Size(65, 25)
		Me.Label4.Location = New System.Drawing.Point(24, 224)
		Me.Label4.TabIndex = 13
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
		Me.Label3.Text = "Employee Address"
		Me.Label3.ForeColor = System.Drawing.Color.White
		Me.Label3.Size = New System.Drawing.Size(89, 17)
		Me.Label3.Location = New System.Drawing.Point(16, 152)
		Me.Label3.TabIndex = 12
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
		Me.Label2.Text = "Employee Name "
		Me.Label2.ForeColor = System.Drawing.Color.White
		Me.Label2.Size = New System.Drawing.Size(81, 25)
		Me.Label2.Location = New System.Drawing.Point(16, 72)
		Me.Label2.TabIndex = 11
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
		Me.Label1.Text = "Employee ID "
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Size = New System.Drawing.Size(65, 17)
		Me.Label1.Location = New System.Drawing.Point(24, 32)
		Me.Label1.TabIndex = 10
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
		Me.Image1.Size = New System.Drawing.Size(1352, 800)
		Me.Image1.Location = New System.Drawing.Point(0, 0)
		Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
		Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.Image1.Enabled = True
		Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Image1.Visible = True
		Me.Image1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Image1.Name = "Image1"
		Me.Controls.Add(Frame2)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(Image1)
		Me.Frame1.Controls.Add(pic1)
		Me.Frame1.Controls.Add(Command5)
		Me.Frame1.Controls.Add(Command4)
		Me.Frame1.Controls.Add(Command3)
		Me.Frame1.Controls.Add(Command2)
		Me.Frame1.Controls.Add(Command1)
		Me.Frame1.Controls.Add(txteNo)
		Me.Frame1.Controls.Add(txteadd)
		Me.Frame1.Controls.Add(txtename)
		Me.Frame1.Controls.Add(txteid)
		Me.Frame1.Controls.Add(Labo)
		Me.Frame1.Controls.Add(lblo)
		Me.Frame1.Controls.Add(Label4)
		Me.Frame1.Controls.Add(Label3)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Label1)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class