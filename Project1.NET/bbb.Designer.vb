<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmbill
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
	Public PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
	Public WithEvents Command4 As System.Windows.Forms.Button
	Public WithEvents print1 As System.Windows.Forms.Button
	Public WithEvents Command2 As System.Windows.Forms.Button
    Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents txtqut As System.Windows.Forms.TextBox
	Public WithEvents cmbbike As System.Windows.Forms.ComboBox
	Public WithEvents cmbcust As System.Windows.Forms.ComboBox
    Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents lblamt As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblname As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblprice As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblqty As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblsr As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmbill))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Command4 = New System.Windows.Forms.Button
        Me.print1 = New System.Windows.Forms.Button
        Me.Command2 = New System.Windows.Forms.Button
        Me.Command1 = New System.Windows.Forms.Button
        Me.txtqut = New System.Windows.Forms.TextBox
        Me.cmbbike = New System.Windows.Forms.ComboBox
        Me.cmbcust = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.lblamt = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.lblname = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.lblprice = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.lblqty = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.lblsr = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Text1 = New System.Windows.Forms.TextBox
        Me.Lbldate = New System.Windows.Forms.Label
        Me.lbltot = New System.Windows.Forms.Label
        Me.lblgst = New System.Windows.Forms.Label
        Me.lblta = New System.Windows.Forms.Label
        Me._lblamt_5 = New System.Windows.Forms.Label
        Me._lblamt_4 = New System.Windows.Forms.Label
        Me._lblamt_3 = New System.Windows.Forms.Label
        Me._lblamt_2 = New System.Windows.Forms.Label
        Me._lblamt_1 = New System.Windows.Forms.Label
        Me._lblamt_0 = New System.Windows.Forms.Label
        Me._lblqty_5 = New System.Windows.Forms.Label
        Me._lblqty_4 = New System.Windows.Forms.Label
        Me._lblqty_3 = New System.Windows.Forms.Label
        Me._lblqty_2 = New System.Windows.Forms.Label
        Me._lblqty_1 = New System.Windows.Forms.Label
        Me._lblqty_0 = New System.Windows.Forms.Label
        Me._lblprice_5 = New System.Windows.Forms.Label
        Me._lblprice_4 = New System.Windows.Forms.Label
        Me._lblprice_3 = New System.Windows.Forms.Label
        Me._lblprice_2 = New System.Windows.Forms.Label
        Me._lblprice_1 = New System.Windows.Forms.Label
        Me._lblprice_0 = New System.Windows.Forms.Label
        Me._lblname_5 = New System.Windows.Forms.Label
        Me._lblname_4 = New System.Windows.Forms.Label
        Me._lblname_3 = New System.Windows.Forms.Label
        Me._lblname_2 = New System.Windows.Forms.Label
        Me._lblname_1 = New System.Windows.Forms.Label
        Me._lblname_0 = New System.Windows.Forms.Label
        Me._lblsr_5 = New System.Windows.Forms.Label
        Me._lblsr_4 = New System.Windows.Forms.Label
        Me._lblsr_3 = New System.Windows.Forms.Label
        Me._lblsr_2 = New System.Windows.Forms.Label
        Me._lblsr_1 = New System.Windows.Forms.Label
        Me._lblsr_0 = New System.Windows.Forms.Label
        Me.lblmb = New System.Windows.Forms.Label
        Me.lbladd = New System.Windows.Forms.Label
        Me.lblnm = New System.Windows.Forms.Label
        CType(Me.lblamt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblprice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblqty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblsr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Command4
        '
        Me.Command4.BackColor = System.Drawing.SystemColors.Control
        Me.Command4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command4.Location = New System.Drawing.Point(768, 495)
        Me.Command4.Name = "Command4"
        Me.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command4.Size = New System.Drawing.Size(81, 41)
        Me.Command4.TabIndex = 69
        Me.Command4.Text = "Back"
        Me.Command4.UseVisualStyleBackColor = False
        '
        'print1
        '
        Me.print1.BackColor = System.Drawing.SystemColors.Control
        Me.print1.Cursor = System.Windows.Forms.Cursors.Default
        Me.print1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.print1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.print1.Location = New System.Drawing.Point(904, 464)
        Me.print1.Name = "print1"
        Me.print1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.print1.Size = New System.Drawing.Size(97, 49)
        Me.print1.TabIndex = 67
        Me.print1.Text = "Print "
        Me.print1.UseVisualStyleBackColor = False
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(896, 400)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(105, 49)
        Me.Command2.TabIndex = 66
        Me.Command2.Text = "Add Without Accessries"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(768, 431)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(105, 41)
        Me.Command1.TabIndex = 3
        Me.Command1.Text = "Add With Accessries"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'txtqut
        '
        Me.txtqut.AcceptsReturn = True
        Me.txtqut.BackColor = System.Drawing.SystemColors.Window
        Me.txtqut.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtqut.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqut.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtqut.Location = New System.Drawing.Point(888, 328)
        Me.txtqut.MaxLength = 0
        Me.txtqut.Name = "txtqut"
        Me.txtqut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtqut.Size = New System.Drawing.Size(89, 33)
        Me.txtqut.TabIndex = 2
        '
        'cmbbike
        '
        Me.cmbbike.BackColor = System.Drawing.SystemColors.Window
        Me.cmbbike.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbbike.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbike.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbbike.Location = New System.Drawing.Point(797, 260)
        Me.cmbbike.Name = "cmbbike"
        Me.cmbbike.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbbike.Size = New System.Drawing.Size(129, 22)
        Me.cmbbike.TabIndex = 1
        Me.cmbbike.Text = "Select Bile"
        '
        'cmbcust
        '
        Me.cmbcust.BackColor = System.Drawing.SystemColors.Window
        Me.cmbcust.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbcust.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcust.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbcust.Location = New System.Drawing.Point(797, 212)
        Me.cmbcust.Name = "cmbcust"
        Me.cmbcust.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbcust.Size = New System.Drawing.Size(129, 22)
        Me.cmbcust.TabIndex = 0
        Me.cmbcust.Text = "Select Custmer"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(786, 336)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(57, 25)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Quantity"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project1.My.Resources.Resources.b
        Me.PictureBox1.Location = New System.Drawing.Point(-7, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(755, 705)
        Me.PictureBox1.TabIndex = 70
        Me.PictureBox1.TabStop = False
        '
        'Text1
        '
        Me.Text1.AcceptsReturn = True
        Me.Text1.BackColor = System.Drawing.SystemColors.Window
        Me.Text1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.Location = New System.Drawing.Point(117, 192)
        Me.Text1.MaxLength = 0
        Me.Text1.Name = "Text1"
        Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1.Size = New System.Drawing.Size(81, 13)
        Me.Text1.TabIndex = 108
        '
        'Lbldate
        '
        Me.Lbldate.BackColor = System.Drawing.Color.Transparent
        Me.Lbldate.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lbldate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbldate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Lbldate.Location = New System.Drawing.Point(507, 176)
        Me.Lbldate.Name = "Lbldate"
        Me.Lbldate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lbldate.Size = New System.Drawing.Size(105, 33)
        Me.Lbldate.TabIndex = 107
        '
        'lbltot
        '
        Me.lbltot.BackColor = System.Drawing.SystemColors.Control
        Me.lbltot.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbltot.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltot.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbltot.Location = New System.Drawing.Point(615, 677)
        Me.lbltot.Name = "lbltot"
        Me.lbltot.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbltot.Size = New System.Drawing.Size(65, 17)
        Me.lbltot.TabIndex = 106
        Me.lbltot.Text = "Label11"
        '
        'lblgst
        '
        Me.lblgst.BackColor = System.Drawing.SystemColors.Control
        Me.lblgst.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblgst.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgst.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblgst.Location = New System.Drawing.Point(615, 647)
        Me.lblgst.Name = "lblgst"
        Me.lblgst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblgst.Size = New System.Drawing.Size(73, 17)
        Me.lblgst.TabIndex = 105
        Me.lblgst.Text = "Label11"
        '
        'lblta
        '
        Me.lblta.BackColor = System.Drawing.SystemColors.Control
        Me.lblta.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblta.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblta.Location = New System.Drawing.Point(631, 622)
        Me.lblta.Name = "lblta"
        Me.lblta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblta.Size = New System.Drawing.Size(57, 25)
        Me.lblta.TabIndex = 104
        Me.lblta.Text = "Label11"
        '
        '_lblamt_5
        '
        Me._lblamt_5.BackColor = System.Drawing.Color.Transparent
        Me._lblamt_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblamt_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblamt_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblamt_5.Location = New System.Drawing.Point(567, 519)
        Me._lblamt_5.Name = "_lblamt_5"
        Me._lblamt_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblamt_5.Size = New System.Drawing.Size(81, 17)
        Me._lblamt_5.TabIndex = 103
        '
        '_lblamt_4
        '
        Me._lblamt_4.BackColor = System.Drawing.Color.Transparent
        Me._lblamt_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblamt_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblamt_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblamt_4.Location = New System.Drawing.Point(567, 479)
        Me._lblamt_4.Name = "_lblamt_4"
        Me._lblamt_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblamt_4.Size = New System.Drawing.Size(89, 17)
        Me._lblamt_4.TabIndex = 102
        '
        '_lblamt_3
        '
        Me._lblamt_3.BackColor = System.Drawing.Color.Transparent
        Me._lblamt_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblamt_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblamt_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblamt_3.Location = New System.Drawing.Point(567, 439)
        Me._lblamt_3.Name = "_lblamt_3"
        Me._lblamt_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblamt_3.Size = New System.Drawing.Size(89, 17)
        Me._lblamt_3.TabIndex = 101
        '
        '_lblamt_2
        '
        Me._lblamt_2.BackColor = System.Drawing.Color.Transparent
        Me._lblamt_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblamt_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblamt_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblamt_2.Location = New System.Drawing.Point(615, 444)
        Me._lblamt_2.Name = "_lblamt_2"
        Me._lblamt_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblamt_2.Size = New System.Drawing.Size(97, 9)
        Me._lblamt_2.TabIndex = 100
        '
        '_lblamt_1
        '
        Me._lblamt_1.BackColor = System.Drawing.Color.Transparent
        Me._lblamt_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblamt_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblamt_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblamt_1.Location = New System.Drawing.Point(569, 404)
        Me._lblamt_1.Name = "_lblamt_1"
        Me._lblamt_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblamt_1.Size = New System.Drawing.Size(97, 9)
        Me._lblamt_1.TabIndex = 99
        '
        '_lblamt_0
        '
        Me._lblamt_0.BackColor = System.Drawing.Color.Transparent
        Me._lblamt_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblamt_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblamt_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblamt_0.Location = New System.Drawing.Point(585, 372)
        Me._lblamt_0.Name = "_lblamt_0"
        Me._lblamt_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblamt_0.Size = New System.Drawing.Size(81, 9)
        Me._lblamt_0.TabIndex = 98
        '
        '_lblqty_5
        '
        Me._lblqty_5.BackColor = System.Drawing.Color.Transparent
        Me._lblqty_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblqty_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblqty_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblqty_5.Location = New System.Drawing.Point(487, 519)
        Me._lblqty_5.Name = "_lblqty_5"
        Me._lblqty_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblqty_5.Size = New System.Drawing.Size(49, 17)
        Me._lblqty_5.TabIndex = 97
        '
        '_lblqty_4
        '
        Me._lblqty_4.BackColor = System.Drawing.Color.Transparent
        Me._lblqty_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblqty_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblqty_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblqty_4.Location = New System.Drawing.Point(487, 479)
        Me._lblqty_4.Name = "_lblqty_4"
        Me._lblqty_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblqty_4.Size = New System.Drawing.Size(49, 17)
        Me._lblqty_4.TabIndex = 96
        '
        '_lblqty_3
        '
        Me._lblqty_3.BackColor = System.Drawing.Color.Transparent
        Me._lblqty_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblqty_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblqty_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblqty_3.Location = New System.Drawing.Point(487, 439)
        Me._lblqty_3.Name = "_lblqty_3"
        Me._lblqty_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblqty_3.Size = New System.Drawing.Size(49, 17)
        Me._lblqty_3.TabIndex = 95
        '
        '_lblqty_2
        '
        Me._lblqty_2.BackColor = System.Drawing.Color.Transparent
        Me._lblqty_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblqty_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblqty_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblqty_2.Location = New System.Drawing.Point(535, 444)
        Me._lblqty_2.Name = "_lblqty_2"
        Me._lblqty_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblqty_2.Size = New System.Drawing.Size(49, 9)
        Me._lblqty_2.TabIndex = 94
        '
        '_lblqty_1
        '
        Me._lblqty_1.BackColor = System.Drawing.Color.Transparent
        Me._lblqty_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblqty_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblqty_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblqty_1.Location = New System.Drawing.Point(507, 404)
        Me._lblqty_1.Name = "_lblqty_1"
        Me._lblqty_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblqty_1.Size = New System.Drawing.Size(49, 9)
        Me._lblqty_1.TabIndex = 93
        '
        '_lblqty_0
        '
        Me._lblqty_0.BackColor = System.Drawing.Color.Transparent
        Me._lblqty_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblqty_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblqty_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblqty_0.Location = New System.Drawing.Point(507, 372)
        Me._lblqty_0.Name = "_lblqty_0"
        Me._lblqty_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblqty_0.Size = New System.Drawing.Size(49, 9)
        Me._lblqty_0.TabIndex = 92
        '
        '_lblprice_5
        '
        Me._lblprice_5.BackColor = System.Drawing.Color.Transparent
        Me._lblprice_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblprice_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblprice_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblprice_5.Location = New System.Drawing.Point(399, 519)
        Me._lblprice_5.Name = "_lblprice_5"
        Me._lblprice_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblprice_5.Size = New System.Drawing.Size(49, 17)
        Me._lblprice_5.TabIndex = 91
        '
        '_lblprice_4
        '
        Me._lblprice_4.BackColor = System.Drawing.Color.Transparent
        Me._lblprice_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblprice_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblprice_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblprice_4.Location = New System.Drawing.Point(399, 479)
        Me._lblprice_4.Name = "_lblprice_4"
        Me._lblprice_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblprice_4.Size = New System.Drawing.Size(49, 17)
        Me._lblprice_4.TabIndex = 90
        '
        '_lblprice_3
        '
        Me._lblprice_3.BackColor = System.Drawing.Color.Transparent
        Me._lblprice_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblprice_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblprice_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblprice_3.Location = New System.Drawing.Point(399, 439)
        Me._lblprice_3.Name = "_lblprice_3"
        Me._lblprice_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblprice_3.Size = New System.Drawing.Size(49, 17)
        Me._lblprice_3.TabIndex = 89
        '
        '_lblprice_2
        '
        Me._lblprice_2.BackColor = System.Drawing.Color.Transparent
        Me._lblprice_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblprice_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblprice_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblprice_2.Location = New System.Drawing.Point(447, 444)
        Me._lblprice_2.Name = "_lblprice_2"
        Me._lblprice_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblprice_2.Size = New System.Drawing.Size(49, 9)
        Me._lblprice_2.TabIndex = 88
        '
        '_lblprice_1
        '
        Me._lblprice_1.BackColor = System.Drawing.Color.Transparent
        Me._lblprice_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblprice_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblprice_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblprice_1.Location = New System.Drawing.Point(419, 412)
        Me._lblprice_1.Name = "_lblprice_1"
        Me._lblprice_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblprice_1.Size = New System.Drawing.Size(49, 9)
        Me._lblprice_1.TabIndex = 87
        '
        '_lblprice_0
        '
        Me._lblprice_0.BackColor = System.Drawing.Color.Transparent
        Me._lblprice_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblprice_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblprice_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblprice_0.Location = New System.Drawing.Point(419, 372)
        Me._lblprice_0.Name = "_lblprice_0"
        Me._lblprice_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblprice_0.Size = New System.Drawing.Size(49, 9)
        Me._lblprice_0.TabIndex = 86
        '
        '_lblname_5
        '
        Me._lblname_5.BackColor = System.Drawing.Color.Transparent
        Me._lblname_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblname_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblname_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblname_5.Location = New System.Drawing.Point(87, 511)
        Me._lblname_5.Name = "_lblname_5"
        Me._lblname_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblname_5.Size = New System.Drawing.Size(257, 25)
        Me._lblname_5.TabIndex = 85
        '
        '_lblname_4
        '
        Me._lblname_4.BackColor = System.Drawing.Color.Transparent
        Me._lblname_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblname_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblname_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblname_4.Location = New System.Drawing.Point(87, 471)
        Me._lblname_4.Name = "_lblname_4"
        Me._lblname_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblname_4.Size = New System.Drawing.Size(257, 25)
        Me._lblname_4.TabIndex = 84
        '
        '_lblname_3
        '
        Me._lblname_3.BackColor = System.Drawing.Color.Transparent
        Me._lblname_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblname_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblname_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblname_3.Location = New System.Drawing.Point(87, 431)
        Me._lblname_3.Name = "_lblname_3"
        Me._lblname_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblname_3.Size = New System.Drawing.Size(257, 25)
        Me._lblname_3.TabIndex = 83
        '
        '_lblname_2
        '
        Me._lblname_2.BackColor = System.Drawing.Color.Transparent
        Me._lblname_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblname_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblname_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblname_2.Location = New System.Drawing.Point(127, 452)
        Me._lblname_2.Name = "_lblname_2"
        Me._lblname_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblname_2.Size = New System.Drawing.Size(257, 17)
        Me._lblname_2.TabIndex = 82
        '
        '_lblname_1
        '
        Me._lblname_1.BackColor = System.Drawing.Color.Transparent
        Me._lblname_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblname_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblname_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblname_1.Location = New System.Drawing.Point(135, 412)
        Me._lblname_1.Name = "_lblname_1"
        Me._lblname_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblname_1.Size = New System.Drawing.Size(257, 17)
        Me._lblname_1.TabIndex = 81
        '
        '_lblname_0
        '
        Me._lblname_0.BackColor = System.Drawing.Color.Transparent
        Me._lblname_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblname_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblname_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblname_0.Location = New System.Drawing.Point(127, 372)
        Me._lblname_0.Name = "_lblname_0"
        Me._lblname_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblname_0.Size = New System.Drawing.Size(257, 17)
        Me._lblname_0.TabIndex = 80
        '
        '_lblsr_5
        '
        Me._lblsr_5.BackColor = System.Drawing.Color.Transparent
        Me._lblsr_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblsr_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblsr_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblsr_5.Location = New System.Drawing.Point(37, 511)
        Me._lblsr_5.Name = "_lblsr_5"
        Me._lblsr_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblsr_5.Size = New System.Drawing.Size(27, 25)
        Me._lblsr_5.TabIndex = 79
        '
        '_lblsr_4
        '
        Me._lblsr_4.BackColor = System.Drawing.Color.Transparent
        Me._lblsr_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblsr_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblsr_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblsr_4.Location = New System.Drawing.Point(37, 471)
        Me._lblsr_4.Name = "_lblsr_4"
        Me._lblsr_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblsr_4.Size = New System.Drawing.Size(27, 17)
        Me._lblsr_4.TabIndex = 78
        '
        '_lblsr_3
        '
        Me._lblsr_3.BackColor = System.Drawing.Color.Transparent
        Me._lblsr_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblsr_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblsr_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblsr_3.Location = New System.Drawing.Point(34, 431)
        Me._lblsr_3.Name = "_lblsr_3"
        Me._lblsr_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblsr_3.Size = New System.Drawing.Size(30, 17)
        Me._lblsr_3.TabIndex = 77
        '
        '_lblsr_2
        '
        Me._lblsr_2.BackColor = System.Drawing.Color.Transparent
        Me._lblsr_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblsr_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblsr_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblsr_2.Location = New System.Drawing.Point(79, 444)
        Me._lblsr_2.Name = "_lblsr_2"
        Me._lblsr_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblsr_2.Size = New System.Drawing.Size(33, 9)
        Me._lblsr_2.TabIndex = 76
        '
        '_lblsr_1
        '
        Me._lblsr_1.BackColor = System.Drawing.Color.Transparent
        Me._lblsr_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblsr_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblsr_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblsr_1.Location = New System.Drawing.Point(79, 412)
        Me._lblsr_1.Name = "_lblsr_1"
        Me._lblsr_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblsr_1.Size = New System.Drawing.Size(33, 9)
        Me._lblsr_1.TabIndex = 75
        '
        '_lblsr_0
        '
        Me._lblsr_0.BackColor = System.Drawing.Color.Transparent
        Me._lblsr_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblsr_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblsr_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblsr_0.Location = New System.Drawing.Point(79, 372)
        Me._lblsr_0.Name = "_lblsr_0"
        Me._lblsr_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblsr_0.Size = New System.Drawing.Size(33, 9)
        Me._lblsr_0.TabIndex = 74
        '
        'lblmb
        '
        Me.lblmb.BackColor = System.Drawing.Color.Transparent
        Me.lblmb.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblmb.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmb.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblmb.Location = New System.Drawing.Point(495, 209)
        Me.lblmb.Name = "lblmb"
        Me.lblmb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblmb.Size = New System.Drawing.Size(153, 25)
        Me.lblmb.TabIndex = 73
        '
        'lbladd
        '
        Me.lbladd.BackColor = System.Drawing.Color.Transparent
        Me.lbladd.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbladd.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbladd.Location = New System.Drawing.Point(141, 215)
        Me.lbladd.Name = "lbladd"
        Me.lbladd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbladd.Size = New System.Drawing.Size(241, 41)
        Me.lbladd.TabIndex = 72
        '
        'lblnm
        '
        Me.lblnm.BackColor = System.Drawing.Color.Transparent
        Me.lblnm.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblnm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblnm.Location = New System.Drawing.Point(151, 192)
        Me.lblnm.Name = "lblnm"
        Me.lblnm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblnm.Size = New System.Drawing.Size(169, 17)
        Me.lblnm.TabIndex = 71
        '
        'frmbill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(887, 746)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.Lbldate)
        Me.Controls.Add(Me.lbltot)
        Me.Controls.Add(Me.lblgst)
        Me.Controls.Add(Me.lblta)
        Me.Controls.Add(Me._lblamt_5)
        Me.Controls.Add(Me._lblamt_4)
        Me.Controls.Add(Me._lblamt_3)
        Me.Controls.Add(Me._lblamt_2)
        Me.Controls.Add(Me._lblamt_1)
        Me.Controls.Add(Me._lblamt_0)
        Me.Controls.Add(Me._lblqty_5)
        Me.Controls.Add(Me._lblqty_4)
        Me.Controls.Add(Me._lblqty_3)
        Me.Controls.Add(Me._lblqty_2)
        Me.Controls.Add(Me._lblqty_1)
        Me.Controls.Add(Me._lblqty_0)
        Me.Controls.Add(Me._lblprice_5)
        Me.Controls.Add(Me._lblprice_4)
        Me.Controls.Add(Me._lblprice_3)
        Me.Controls.Add(Me._lblprice_2)
        Me.Controls.Add(Me._lblprice_1)
        Me.Controls.Add(Me._lblprice_0)
        Me.Controls.Add(Me._lblname_5)
        Me.Controls.Add(Me._lblname_4)
        Me.Controls.Add(Me._lblname_3)
        Me.Controls.Add(Me._lblname_2)
        Me.Controls.Add(Me._lblname_1)
        Me.Controls.Add(Me._lblname_0)
        Me.Controls.Add(Me._lblsr_5)
        Me.Controls.Add(Me._lblsr_4)
        Me.Controls.Add(Me._lblsr_3)
        Me.Controls.Add(Me._lblsr_2)
        Me.Controls.Add(Me._lblsr_1)
        Me.Controls.Add(Me._lblsr_0)
        Me.Controls.Add(Me.lblmb)
        Me.Controls.Add(Me.lbladd)
        Me.Controls.Add(Me.lblnm)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Command4)
        Me.Controls.Add(Me.print1)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.txtqut)
        Me.Controls.Add(Me.cmbbike)
        Me.Controls.Add(Me.cmbcust)
        Me.Controls.Add(Me.Label14)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(8, 31)
        Me.Name = "frmbill"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.lblamt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblprice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblqty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblsr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents Text1 As System.Windows.Forms.TextBox
    Public WithEvents Lbldate As System.Windows.Forms.Label
    Public WithEvents lbltot As System.Windows.Forms.Label
    Public WithEvents lblgst As System.Windows.Forms.Label
    Public WithEvents lblta As System.Windows.Forms.Label
    Public WithEvents _lblamt_5 As System.Windows.Forms.Label
    Public WithEvents _lblamt_4 As System.Windows.Forms.Label
    Public WithEvents _lblamt_3 As System.Windows.Forms.Label
    Public WithEvents _lblamt_2 As System.Windows.Forms.Label
    Public WithEvents _lblamt_1 As System.Windows.Forms.Label
    Public WithEvents _lblamt_0 As System.Windows.Forms.Label
    Public WithEvents _lblqty_5 As System.Windows.Forms.Label
    Public WithEvents _lblqty_4 As System.Windows.Forms.Label
    Public WithEvents _lblqty_3 As System.Windows.Forms.Label
    Public WithEvents _lblqty_2 As System.Windows.Forms.Label
    Public WithEvents _lblqty_1 As System.Windows.Forms.Label
    Public WithEvents _lblqty_0 As System.Windows.Forms.Label
    Public WithEvents _lblprice_5 As System.Windows.Forms.Label
    Public WithEvents _lblprice_4 As System.Windows.Forms.Label
    Public WithEvents _lblprice_3 As System.Windows.Forms.Label
    Public WithEvents _lblprice_2 As System.Windows.Forms.Label
    Public WithEvents _lblprice_1 As System.Windows.Forms.Label
    Public WithEvents _lblprice_0 As System.Windows.Forms.Label
    Public WithEvents _lblname_5 As System.Windows.Forms.Label
    Public WithEvents _lblname_4 As System.Windows.Forms.Label
    Public WithEvents _lblname_3 As System.Windows.Forms.Label
    Public WithEvents _lblname_2 As System.Windows.Forms.Label
    Public WithEvents _lblname_1 As System.Windows.Forms.Label
    Public WithEvents _lblname_0 As System.Windows.Forms.Label
    Public WithEvents _lblsr_5 As System.Windows.Forms.Label
    Public WithEvents _lblsr_4 As System.Windows.Forms.Label
    Public WithEvents _lblsr_3 As System.Windows.Forms.Label
    Public WithEvents _lblsr_2 As System.Windows.Forms.Label
    Public WithEvents _lblsr_1 As System.Windows.Forms.Label
    Public WithEvents _lblsr_0 As System.Windows.Forms.Label
    Public WithEvents lblmb As System.Windows.Forms.Label
    Public WithEvents lbladd As System.Windows.Forms.Label
    Public WithEvents lblnm As System.Windows.Forms.Label
#End Region 
End Class