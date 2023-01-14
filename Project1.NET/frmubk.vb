Option Strict Off
Option Explicit On
Friend Class frmubk
	Inherits System.Windows.Forms.Form
	
	Dim ImageSorce As String
	Private Sub Combo1_Click()
		txtbid.Enabled = False
		txtbname.Enabled = False
		txtbdealer.Enabled = False
		txtbprice.Enabled = False
		cmb1.Enabled = False
		cmb2.Enabled = False
		pic12.Enabled = False
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Me.Hide()
		MDIForm1.Show()
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Module1.inupdel(("update bike set bike.bname = '" & txtbname.Text & "', bike.bprice = '" & txtbprice.Text & "', bike.Dealername = '" & txtbdealer.Text & "' ,bike.BikeColor = '" & cmb1.Text & "',bike.BikeCatagory = '" & cmb2.Text & "' where bike.bikeid = '" & txtbid.Text & "'"))
		MsgBox("Details Updated ", MsgBoxStyle.Information)
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		Module1.inupdel(("update bike set bike.photo = '" & txtbid.Text & ".jpg" & "' where bike.bikeid = '" & txtbid.Text & "'"))
		Dim destPath As String
		destPath = DataPath & txtbid.Text & ".jpg"
		FileCopy(ImageSorce, destPath)
		MsgBox("Details Updated ", MsgBoxStyle.Information)
	End Sub
	
	Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click
		CommonDialog1Open.ShowDialog()
		'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		CommonDialog1Open.Filter = "jpeg|*.jpg"
		str_Renamed = CommonDialog1Open.FileName
		ImageSorce = CommonDialog1Open.FileName
		pic12.Image = System.Drawing.Image.FromFile(str_Renamed)
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
	Private Sub loaddata()
		On Error Resume Next
		txtbid.Text = rs1.Fields(0).Value
		txtbname.Text = rs1.Fields(1).Value
		txtbdealer.Text = rs1.Fields(3).Value
		txtbprice.Text = rs1.Fields(2).Value
		cmb1.Text = rs1.Fields(4).Value
		cmb2.Text = rs1.Fields(5).Value
		pic12.Image = System.Drawing.Image.FromFile(DataPath & rs1.Fields(6).Value)
		
	End Sub
End Class