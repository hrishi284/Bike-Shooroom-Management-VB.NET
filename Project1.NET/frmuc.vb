Option Strict Off
Option Explicit On
Friend Class frmuc
	Inherits System.Windows.Forms.Form
	Dim ImageSorce As String
	
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Module1.inupdel(("update customer set customer.custname = '" & txtcName.Text & "',customer.customeraddress = '" & txtcAdd.Text & "',customer.customerphone = '" & txtcNo.Text & "',customer.EmailId = '" & txtcmail.Text & "'where customer.customerid = '" & txtcid.Text & "'"))
		MsgBox("Details Updated ", MsgBoxStyle.Information)
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Me.Hide()
		MDIForm1.Show()
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		
		Module1.inupdel(("update customer set customer.photo='" & txtcid.Text & ".jpg" & "' where customer.customerid = '" & txtcid.Text & "'"))
		Dim destPath As String
		destPath = DPath & txtcid.Text & ".jpg"
		FileCopy(ImageSorce, destPath)
		MsgBox("Details Updated ", MsgBoxStyle.Information)
		
	End Sub
	
	Private Sub Command4_Click()
		Me.Hide()
		MDIForm1.Show()
	End Sub
	
	Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click
		CommonDialog1Open.ShowDialog()
		'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		CommonDialog1Open.Filter = "jpeg|*.jpg"
		str_Renamed = CommonDialog1Open.FileName
		ImageSorce = CommonDialog1Open.FileName
		pic1.Image = System.Drawing.Image.FromFile(str_Renamed)
	End Sub
	
	Private Sub txtsch_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtsch.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Module1.retdata(("select * from customer where custname like '%" & txtsch.Text & "%' "))
		
		If Not rs1.BOF Or Not rs1.EOF Then
			Call loaddata()
		Else
			txtcid.Text = ""
			txtcName.Text = ""
			txtcAdd.Text = ""
			txtcNo.Text = ""
			txtcmail.Text = ""
			pic1.Image = New System.Drawing.Bitmap(1, 1)
			MsgBox("No Data Found")
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub loaddata()
		On Error Resume Next
		txtcid.Text = rs1.Fields(0).Value
		txtcName.Text = rs1.Fields(1).Value
		txtcAdd.Text = rs1.Fields(2).Value
		txtcNo.Text = rs1.Fields(3).Value
		txtcmail.Text = rs1.Fields(4).Value
		pic1.Image = System.Drawing.Image.FromFile(DPath & rs1.Fields(6).Value)
	End Sub
End Class