Option Strict Off
Option Explicit On
Friend Class MDIForm1
	Inherits System.Windows.Forms.Form
	Private Sub cust_Click()
		
	End Sub
	
	Public Sub Bike_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Bike.Click
		Me.Hide()
		frmsbike.Show()
	End Sub
	
	Public Sub BikeD_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BikeD.Click
		Me.Hide()
		frmbike.Show()
	End Sub
	
	Public Sub bill_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bill.Click
		Me.Hide()
		frmbill.Show()
		
	End Sub
	
	Public Sub brep_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles brep.Click
		Dim DataReport1 As Object
		Me.Hide()
		'UPGRADE_WARNING: Couldn't resolve default property of object DataReport1.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DataReport1.Show()
	End Sub
	
	Public Sub CR_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CR.Click
		Dim DataReport3 As Object
		Me.Hide()
		'UPGRADE_WARNING: Couldn't resolve default property of object DataReport3.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DataReport3.Show()
	End Sub
	
	Public Sub Cus_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cus.Click
		Me.Hide()
		frmCust.Show()
	End Sub
	
	Public Sub custmer_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles custmer.Click
		Me.Hide()
		frmscust.Show()
	End Sub
	
	Public Sub emi_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles emi.Click
		Me.Hide()
		frmEmi.Show()
	End Sub
	
	Public Sub Emp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Emp.Click
		Me.Hide()
		frmEmp.Show()
	End Sub
	
	Public Sub Employee_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Employee.Click
		Me.Hide()
		frmsEmp.Show()
	End Sub
	
	Public Sub Enquiry_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Enquiry.Click
		Me.Hide()
		frmenq.Show()
	End Sub
	
	Public Sub er_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles er.Click
		Dim DataReport2 As Object
		Me.Hide()
		'UPGRADE_WARNING: Couldn't resolve default property of object DataReport2.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DataReport2.Show()
		
	End Sub
	
	Public Sub exit_Renamed_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles exit_Renamed.Click
		End
	End Sub
	
	Public Sub Quotation_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Quotation.Click
		Me.Hide()
		frmquo.Show()
	End Sub
	
	
	Public Sub ubik_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ubik.Click
		Me.Hide()
		frmubk.Show()
	End Sub
	
	Public Sub ucm_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ucm.Click
		Me.Hide()
		frmuc.Show()
		
	End Sub
	
	Public Sub uem_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles uem.Click
		Me.Hide()
		frmuep.Show()
		
	End Sub
End Class