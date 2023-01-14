<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class MDIForm1
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
	Public WithEvents Emp As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents cus As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents BikeD As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents Del As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents custmer As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents Employee As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents Bike As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents search As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents ubik As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents ucm As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents uem As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents frmupd As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents Enquiry As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents Quotation As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents emi As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents bill As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents brep As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents er As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents CR As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents rep As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents exit_Renamed As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MDIForm1))
		Me.IsMDIContainer = True
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.MainMenu1 = New System.Windows.Forms.MenuStrip
		Me.Del = New System.Windows.Forms.ToolStripMenuItem
		Me.Emp = New System.Windows.Forms.ToolStripMenuItem
		Me.cus = New System.Windows.Forms.ToolStripMenuItem
		Me.BikeD = New System.Windows.Forms.ToolStripMenuItem
		Me.search = New System.Windows.Forms.ToolStripMenuItem
		Me.custmer = New System.Windows.Forms.ToolStripMenuItem
		Me.Employee = New System.Windows.Forms.ToolStripMenuItem
		Me.Bike = New System.Windows.Forms.ToolStripMenuItem
		Me.frmupd = New System.Windows.Forms.ToolStripMenuItem
		Me.ubik = New System.Windows.Forms.ToolStripMenuItem
		Me.ucm = New System.Windows.Forms.ToolStripMenuItem
		Me.uem = New System.Windows.Forms.ToolStripMenuItem
		Me.Enquiry = New System.Windows.Forms.ToolStripMenuItem
		Me.Quotation = New System.Windows.Forms.ToolStripMenuItem
		Me.emi = New System.Windows.Forms.ToolStripMenuItem
		Me.bill = New System.Windows.Forms.ToolStripMenuItem
		Me.rep = New System.Windows.Forms.ToolStripMenuItem
		Me.brep = New System.Windows.Forms.ToolStripMenuItem
		Me.er = New System.Windows.Forms.ToolStripMenuItem
		Me.CR = New System.Windows.Forms.ToolStripMenuItem
		Me.exit_Renamed = New System.Windows.Forms.ToolStripMenuItem
		Me.MainMenu1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.Text = "MDIForm1"
		Me.ClientSize = New System.Drawing.Size(1008, 644)
		Me.Location = New System.Drawing.Point(15, 57)
		Me.Icon = CType(resources.GetObject("MDIForm1.Icon"), System.Drawing.Icon)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.Enabled = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Name = "MDIForm1"
		Me.Del.Name = "Del"
		Me.Del.Text = "Master Details "
		Me.Del.Checked = False
		Me.Del.Enabled = True
		Me.Del.Visible = True
		Me.Emp.Name = "Emp"
		Me.Emp.Text = "Employe Details"
		Me.Emp.ShortcutKeys = CType(System.Windows.Forms.Keys.Control or System.Windows.Forms.Keys.E, System.Windows.Forms.Keys)
		Me.Emp.Checked = False
		Me.Emp.Enabled = True
		Me.Emp.Visible = True
		Me.cus.Name = "cus"
		Me.cus.Text = "Custmer Details "
		Me.cus.ShortcutKeys = CType(System.Windows.Forms.Keys.Control or System.Windows.Forms.Keys.J, System.Windows.Forms.Keys)
		Me.cus.Checked = False
		Me.cus.Enabled = True
		Me.cus.Visible = True
		Me.BikeD.Name = "BikeD"
		Me.BikeD.Text = "Bike Details"
		Me.BikeD.ShortcutKeys = CType(System.Windows.Forms.Keys.Control or System.Windows.Forms.Keys.B, System.Windows.Forms.Keys)
		Me.BikeD.Checked = False
		Me.BikeD.Enabled = True
		Me.BikeD.Visible = True
		Me.search.Name = "search"
		Me.search.Text = "Search Master"
		Me.search.Checked = False
		Me.search.Enabled = True
		Me.search.Visible = True
		Me.custmer.Name = "custmer"
		Me.custmer.Text = "Custmer"
		Me.custmer.ShortcutKeys = CType(System.Windows.Forms.Keys.F1, System.Windows.Forms.Keys)
		Me.custmer.Checked = False
		Me.custmer.Enabled = True
		Me.custmer.Visible = True
		Me.Employee.Name = "Employee"
		Me.Employee.Text = "Employee"
		Me.Employee.ShortcutKeys = CType(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys)
		Me.Employee.Checked = False
		Me.Employee.Enabled = True
		Me.Employee.Visible = True
		Me.Bike.Name = "Bike"
		Me.Bike.Text = "Bike"
		Me.Bike.ShortcutKeys = CType(System.Windows.Forms.Keys.F3, System.Windows.Forms.Keys)
		Me.Bike.Checked = False
		Me.Bike.Enabled = True
		Me.Bike.Visible = True
		Me.frmupd.Name = "frmupd"
		Me.frmupd.Text = "Update Detais"
		Me.frmupd.Checked = False
		Me.frmupd.Enabled = True
		Me.frmupd.Visible = True
		Me.ubik.Name = "ubik"
		Me.ubik.Text = "Bike"
		Me.ubik.Checked = False
		Me.ubik.Enabled = True
		Me.ubik.Visible = True
		Me.ucm.Name = "ucm"
		Me.ucm.Text = "Custmer"
		Me.ucm.Checked = False
		Me.ucm.Enabled = True
		Me.ucm.Visible = True
		Me.uem.Name = "uem"
		Me.uem.Text = "Employee"
		Me.uem.Checked = False
		Me.uem.Enabled = True
		Me.uem.Visible = True
		Me.Enquiry.Name = "Enquiry"
		Me.Enquiry.Text = "Enquiry"
		Me.Enquiry.Checked = False
		Me.Enquiry.Enabled = True
		Me.Enquiry.Visible = True
		Me.Quotation.Name = "Quotation"
		Me.Quotation.Text = "Quotation"
		Me.Quotation.Checked = False
		Me.Quotation.Enabled = True
		Me.Quotation.Visible = True
		Me.emi.Name = "emi"
		Me.emi.Text = "EMI"
		Me.emi.Checked = False
		Me.emi.Enabled = True
		Me.emi.Visible = True
		Me.bill.Name = "bill"
		Me.bill.Text = "Billing"
		Me.bill.Checked = False
		Me.bill.Enabled = True
		Me.bill.Visible = True
		Me.rep.Name = "rep"
		Me.rep.Text = "Report"
		Me.rep.Checked = False
		Me.rep.Enabled = True
		Me.rep.Visible = True
		Me.brep.Name = "brep"
		Me.brep.Text = "Bike Report "
		Me.brep.Checked = False
		Me.brep.Enabled = True
		Me.brep.Visible = True
		Me.er.Name = "er"
		Me.er.Text = "Employe Report"
		Me.er.Checked = False
		Me.er.Enabled = True
		Me.er.Visible = True
		Me.CR.Name = "CR"
		Me.CR.Text = "Custmer Report"
		Me.CR.Checked = False
		Me.CR.Enabled = True
		Me.CR.Visible = True
		Me.exit_Renamed.Name = "exit"
		Me.exit_Renamed.Text = "Exit"
		Me.exit_Renamed.Checked = False
		Me.exit_Renamed.Enabled = True
		Me.exit_Renamed.Visible = True
		Me.Del.MergeAction = System.Windows.Forms.MergeAction.Remove
		Me.search.MergeAction = System.Windows.Forms.MergeAction.Remove
		Me.frmupd.MergeAction = System.Windows.Forms.MergeAction.Remove
		Me.Enquiry.MergeAction = System.Windows.Forms.MergeAction.Remove
		Me.Quotation.MergeAction = System.Windows.Forms.MergeAction.Remove
		Me.emi.MergeAction = System.Windows.Forms.MergeAction.Remove
		Me.bill.MergeAction = System.Windows.Forms.MergeAction.Remove
		Me.rep.MergeAction = System.Windows.Forms.MergeAction.Remove
		Me.exit_Renamed.MergeAction = System.Windows.Forms.MergeAction.Remove
		MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me.Del, Me.search, Me.frmupd, Me.Enquiry, Me.Quotation, Me.emi, Me.bill, Me.rep, Me.exit_Renamed})
		Del.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.Emp, Me.cus, Me.BikeD})
		search.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.custmer, Me.Employee, Me.Bike})
		frmupd.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.ubik, Me.ucm, Me.uem})
		rep.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.brep, Me.er, Me.CR})
		Me.Controls.Add(MainMenu1)
		Me.MainMenu1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class