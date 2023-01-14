<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmfpass
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
	Public WithEvents changepassbtn As System.Windows.Forms.Button
	Public WithEvents txtconfirm As System.Windows.Forms.TextBox
	Public WithEvents txtnew As System.Windows.Forms.TextBox
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents txtfdob As System.Windows.Forms.TextBox
	Public WithEvents txtfuser As System.Windows.Forms.TextBox
	Public WithEvents cmdcheak As System.Windows.Forms.Button
	Public WithEvents lblcp As System.Windows.Forms.Label
	Public WithEvents lblenp As System.Windows.Forms.Label
	Public WithEvents lbl3 As System.Windows.Forms.Label
	Public WithEvents lbl2 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Image1 As System.Windows.Forms.PictureBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmfpass))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.changepassbtn = New System.Windows.Forms.Button
		Me.txtconfirm = New System.Windows.Forms.TextBox
		Me.txtnew = New System.Windows.Forms.TextBox
		Me.Command1 = New System.Windows.Forms.Button
		Me.txtfdob = New System.Windows.Forms.TextBox
		Me.txtfuser = New System.Windows.Forms.TextBox
		Me.cmdcheak = New System.Windows.Forms.Button
		Me.lblcp = New System.Windows.Forms.Label
		Me.lblenp = New System.Windows.Forms.Label
		Me.lbl3 = New System.Windows.Forms.Label
		Me.lbl2 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Image1 = New System.Windows.Forms.PictureBox
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "Form2"
		Me.ClientSize = New System.Drawing.Size(912, 586)
		Me.Location = New System.Drawing.Point(8, 30)
		Me.Icon = CType(resources.GetObject("frmfpass.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmfpass"
		Me.Frame1.BackColor = System.Drawing.Color.FromARGB(64, 64, 64)
		Me.Frame1.Text = "Forgot Password"
		Me.Frame1.Size = New System.Drawing.Size(513, 521)
		Me.Frame1.Location = New System.Drawing.Point(8, 24)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.changepassbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.changepassbtn.Text = "Change Password"
		Me.changepassbtn.Size = New System.Drawing.Size(161, 73)
		Me.changepassbtn.Location = New System.Drawing.Point(144, 424)
		Me.changepassbtn.TabIndex = 7
		Me.changepassbtn.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.changepassbtn.BackColor = System.Drawing.SystemColors.Control
		Me.changepassbtn.CausesValidation = True
		Me.changepassbtn.Enabled = True
		Me.changepassbtn.ForeColor = System.Drawing.SystemColors.ControlText
		Me.changepassbtn.Cursor = System.Windows.Forms.Cursors.Default
		Me.changepassbtn.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.changepassbtn.TabStop = True
		Me.changepassbtn.Name = "changepassbtn"
		Me.txtconfirm.AutoSize = False
		Me.txtconfirm.Size = New System.Drawing.Size(257, 73)
		Me.txtconfirm.Location = New System.Drawing.Point(128, 336)
		Me.txtconfirm.TabIndex = 6
		Me.txtconfirm.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtconfirm.AcceptsReturn = True
		Me.txtconfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtconfirm.BackColor = System.Drawing.SystemColors.Window
		Me.txtconfirm.CausesValidation = True
		Me.txtconfirm.Enabled = True
		Me.txtconfirm.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtconfirm.HideSelection = True
		Me.txtconfirm.ReadOnly = False
		Me.txtconfirm.Maxlength = 0
		Me.txtconfirm.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtconfirm.MultiLine = False
		Me.txtconfirm.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtconfirm.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtconfirm.TabStop = True
		Me.txtconfirm.Visible = True
		Me.txtconfirm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtconfirm.Name = "txtconfirm"
		Me.txtnew.AutoSize = False
		Me.txtnew.Size = New System.Drawing.Size(241, 41)
		Me.txtnew.Location = New System.Drawing.Point(128, 272)
		Me.txtnew.TabIndex = 5
		Me.txtnew.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtnew.AcceptsReturn = True
		Me.txtnew.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtnew.BackColor = System.Drawing.SystemColors.Window
		Me.txtnew.CausesValidation = True
		Me.txtnew.Enabled = True
		Me.txtnew.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtnew.HideSelection = True
		Me.txtnew.ReadOnly = False
		Me.txtnew.Maxlength = 0
		Me.txtnew.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtnew.MultiLine = False
		Me.txtnew.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtnew.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtnew.TabStop = True
		Me.txtnew.Visible = True
		Me.txtnew.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtnew.Name = "txtnew"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "Verify"
		Me.Command1.Size = New System.Drawing.Size(97, 41)
		Me.Command1.Location = New System.Drawing.Point(384, 112)
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
		Me.txtfdob.AutoSize = False
		Me.txtfdob.Size = New System.Drawing.Size(217, 33)
		Me.txtfdob.Location = New System.Drawing.Point(128, 120)
		Me.txtfdob.TabIndex = 3
		Me.txtfdob.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtfdob.AcceptsReturn = True
		Me.txtfdob.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtfdob.BackColor = System.Drawing.SystemColors.Window
		Me.txtfdob.CausesValidation = True
		Me.txtfdob.Enabled = True
		Me.txtfdob.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtfdob.HideSelection = True
		Me.txtfdob.ReadOnly = False
		Me.txtfdob.Maxlength = 0
		Me.txtfdob.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtfdob.MultiLine = False
		Me.txtfdob.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtfdob.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtfdob.TabStop = True
		Me.txtfdob.Visible = True
		Me.txtfdob.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtfdob.Name = "txtfdob"
		Me.txtfuser.AutoSize = False
		Me.txtfuser.Size = New System.Drawing.Size(217, 33)
		Me.txtfuser.Location = New System.Drawing.Point(128, 32)
		Me.txtfuser.TabIndex = 2
		Me.txtfuser.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtfuser.AcceptsReturn = True
		Me.txtfuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtfuser.BackColor = System.Drawing.SystemColors.Window
		Me.txtfuser.CausesValidation = True
		Me.txtfuser.Enabled = True
		Me.txtfuser.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtfuser.HideSelection = True
		Me.txtfuser.ReadOnly = False
		Me.txtfuser.Maxlength = 0
		Me.txtfuser.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtfuser.MultiLine = False
		Me.txtfuser.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtfuser.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtfuser.TabStop = True
		Me.txtfuser.Visible = True
		Me.txtfuser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtfuser.Name = "txtfuser"
		Me.cmdcheak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdcheak.Text = "Cheak"
		Me.cmdcheak.Size = New System.Drawing.Size(97, 41)
		Me.cmdcheak.Location = New System.Drawing.Point(384, 32)
		Me.cmdcheak.TabIndex = 1
		Me.cmdcheak.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdcheak.BackColor = System.Drawing.SystemColors.Control
		Me.cmdcheak.CausesValidation = True
		Me.cmdcheak.Enabled = True
		Me.cmdcheak.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdcheak.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdcheak.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdcheak.TabStop = True
		Me.cmdcheak.Name = "cmdcheak"
		Me.lblcp.Text = "Confirm Password "
		Me.lblcp.ForeColor = System.Drawing.SystemColors.highlightText
		Me.lblcp.Size = New System.Drawing.Size(105, 41)
		Me.lblcp.Location = New System.Drawing.Point(8, 352)
		Me.lblcp.TabIndex = 13
		Me.lblcp.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblcp.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblcp.BackColor = System.Drawing.Color.Transparent
		Me.lblcp.Enabled = True
		Me.lblcp.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblcp.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblcp.UseMnemonic = True
		Me.lblcp.Visible = True
		Me.lblcp.AutoSize = False
		Me.lblcp.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblcp.Name = "lblcp"
		Me.lblenp.Text = "Enter New Password"
		Me.lblenp.ForeColor = System.Drawing.SystemColors.highlightText
		Me.lblenp.Size = New System.Drawing.Size(105, 25)
		Me.lblenp.Location = New System.Drawing.Point(8, 280)
		Me.lblenp.TabIndex = 12
		Me.lblenp.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblenp.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblenp.BackColor = System.Drawing.Color.Transparent
		Me.lblenp.Enabled = True
		Me.lblenp.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblenp.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblenp.UseMnemonic = True
		Me.lblenp.Visible = True
		Me.lblenp.AutoSize = False
		Me.lblenp.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblenp.Name = "lblenp"
		Me.lbl3.ForeColor = System.Drawing.SystemColors.highlightText
		Me.lbl3.Size = New System.Drawing.Size(257, 33)
		Me.lbl3.Location = New System.Drawing.Point(104, 176)
		Me.lbl3.TabIndex = 11
		Me.lbl3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbl3.BackColor = System.Drawing.Color.Transparent
		Me.lbl3.Enabled = True
		Me.lbl3.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbl3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbl3.UseMnemonic = True
		Me.lbl3.Visible = True
		Me.lbl3.AutoSize = False
		Me.lbl3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbl3.Name = "lbl3"
		Me.lbl2.ForeColor = System.Drawing.SystemColors.highlightText
		Me.lbl2.Size = New System.Drawing.Size(209, 25)
		Me.lbl2.Location = New System.Drawing.Point(128, 80)
		Me.lbl2.TabIndex = 10
		Me.lbl2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbl2.BackColor = System.Drawing.Color.Transparent
		Me.lbl2.Enabled = True
		Me.lbl2.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbl2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbl2.UseMnemonic = True
		Me.lbl2.Visible = True
		Me.lbl2.AutoSize = False
		Me.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbl2.Name = "lbl2"
		Me.Label2.Text = "Date of Birth"
		Me.Label2.ForeColor = System.Drawing.SystemColors.highlightText
		Me.Label2.Size = New System.Drawing.Size(97, 41)
		Me.Label2.Location = New System.Drawing.Point(8, 120)
		Me.Label2.TabIndex = 9
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
		Me.Label1.Text = "User Name"
		Me.Label1.ForeColor = System.Drawing.SystemColors.highlightText
		Me.Label1.Size = New System.Drawing.Size(81, 41)
		Me.Label1.Location = New System.Drawing.Point(8, 32)
		Me.Label1.TabIndex = 8
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
		Me.Image1.Size = New System.Drawing.Size(1920, 1080)
		Me.Image1.Location = New System.Drawing.Point(0, 0)
		Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
		Me.Image1.Enabled = True
		Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.Image1.Visible = True
		Me.Image1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Image1.Name = "Image1"
		Me.Controls.Add(Frame1)
		Me.Controls.Add(Image1)
		Me.Frame1.Controls.Add(changepassbtn)
		Me.Frame1.Controls.Add(txtconfirm)
		Me.Frame1.Controls.Add(txtnew)
		Me.Frame1.Controls.Add(Command1)
		Me.Frame1.Controls.Add(txtfdob)
		Me.Frame1.Controls.Add(txtfuser)
		Me.Frame1.Controls.Add(cmdcheak)
		Me.Frame1.Controls.Add(lblcp)
		Me.Frame1.Controls.Add(lblenp)
		Me.Frame1.Controls.Add(lbl3)
		Me.Frame1.Controls.Add(lbl2)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Label1)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class