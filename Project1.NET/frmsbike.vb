Option Strict Off
Option Explicit On
Friend Class frmsbike
	Inherits System.Windows.Forms.Form
	
	
	
	
	
	
	
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Me.Hide()
		MDIForm1.Show()
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		End
	End Sub
	
	
	
	Private Sub loaddata()
		On Error Resume Next
		txtbid.Text = rs1.Fields(0).Value
		txtbname.Text = rs1.Fields(1).Value
		txtbdealer.Text = rs1.Fields(2).Value
		txtbprice.Text = rs1.Fields(3).Value
		cmb1.Text = rs1.Fields(4).Value
		cmb2.Text = rs1.Fields(5).Value
		pic12.Image = System.Drawing.Image.FromFile(DataPath & rs1.Fields(6).Value)
	End Sub
	
	
	
	
	
	
	Private Sub Command3_Click()
		Dim rss As String
		If MsgBox("Do You Want To Delete?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
			rss = InputBox("Enter Name to Delete")
			Module1.retdata(("select * from bike where bname= '" & rss & "'"))
			If Not rs1.EOF And Not rs1.BOF Then
				Module1.inupdel(("Delete * from bike where bname='" & rss & "'"))
				MsgBox("Record was Deleted ")
			Else
				MsgBox("Record not exist", MsgBoxStyle.Information)
			End If
		Else
			MsgBox("operation Cancelled")
		End If
	End Sub
	
	Private Sub txtsrh_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtsrh.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Module1.retdata(("select * from bike where bname like '%" & txtsrh.Text & "%' "))
		If Not rs1.BOF Or Not rs1.EOF Then
			Call loaddata()
		Else
			txtbid.Text = ""
			txtbname.Text = ""
			txtbdealer.Text = "MY WINGS HONDA"
			txtbprice.Text = ""
			cmb1.Text = "None"
			cmb2.Text = "None"
			pic12.Image = New System.Drawing.Bitmap(1, 1)
			MsgBox("No Data Found")
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
End Class