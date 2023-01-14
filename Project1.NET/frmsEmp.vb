Option Strict Off
Option Explicit On
Friend Class frmsEmp
	Inherits System.Windows.Forms.Form
	Private Sub Command2_Click()
		Dim rn As String
		If MsgBox("Do You Want To Delete?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
			rn = InputBox("Enter Name to Delete")
			Module1.retdata(("select * from employee where empname = '" & rn & "'"))
			
			If Not rs1.EOF And Not rs1.BOF Then
				Module1.inupdel(("delete * from employee where empname = '" & rn & "'"))
				MsgBox("Record was Deleted ")
			Else
				MsgBox("Record not exist", MsgBoxStyle.Information)
			End If
		Else
			MsgBox("operation Cancelled")
		End If
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		End
	End Sub
	
	Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
		Me.Hide()
		MDIForm1.Show()
	End Sub
	
	Private Sub txtsch_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtsch.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Module1.retdata(("select * from employee where empname like '%" & txtsch.Text & "%' "))
		
		If Not rs1.BOF Or Not rs1.EOF Then
			Call loaddata()
		Else
			txtid.Text = ""
			txtname.Text = ""
			txtadd.Text = ""
			txtno.Text = ""
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
		txtid.Text = rs1.Fields(0).Value
		txtname.Text = rs1.Fields(1).Value
		txtadd.Text = rs1.Fields(2).Value
		txtno.Text = rs1.Fields(3).Value
		pic1.Image = System.Drawing.Image.FromFile(DataP & rs1.Fields(4).Value)
	End Sub
End Class