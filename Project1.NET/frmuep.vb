Option Strict Off
Option Explicit On
Friend Class frmuep
	Inherits System.Windows.Forms.Form
	Dim ImageSorce As String
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Me.Hide()
		MDIForm1.Show()
		
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		Module1.inupdel(("update employee set employee.photo='" & txtid.Text & ".jpg" & "' where employee.empid = '" & txtid.Text & "'"))
		Dim destPath As String
		destPath = DataP & txtid.Text & ".jpg"
		FileCopy(ImageSorce, destPath)
		MsgBox("Details Updated ", MsgBoxStyle.Information)
	End Sub
	
	
	
	
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Module1.inupdel(("update employee set employee.empname = '" & txtname.Text & "',employee.empAdress = '" & txtadd.Text & "',employee.empNo = '" & txtno.Text & "'  where employee.empid = '" & txtid.Text & "'"))
		MsgBox("Details Updated ", MsgBoxStyle.Information)
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
		ImageSorce = CommonDialog1Open.FileName
		pic1.Image = System.Drawing.Image.FromFile(DataP & rs1.Fields(4).Value)
	End Sub
End Class