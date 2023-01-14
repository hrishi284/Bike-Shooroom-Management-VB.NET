Option Strict Off
Option Explicit On
Friend Class frmscust
	Inherits System.Windows.Forms.Form
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		End
	End Sub
	
	
	
	Private Sub Command3_Click()
		
		Dim rn As String
		If MsgBox("Do You Want To Delete?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
			rn = InputBox("Enter Name to Delete")
			Module1.retdata(("select * from customer where custname = '" & rn & "'"))
			
			If Not rs1.EOF And Not rs1.BOF Then
				Module1.inupdel(("delete * from customer where custname = '" & rn & "'"))
				MsgBox("Record was Deleted ")
			Else
				MsgBox("Record not exist", MsgBoxStyle.Information)
			End If
		Else
			MsgBox("operation Cancelled")
		End If
		
	End Sub
	
	Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
		Me.Hide()
		MDIForm1.Show()
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