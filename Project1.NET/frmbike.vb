Option Strict Off
Option Explicit On
Friend Class frmbike
	Inherits System.Windows.Forms.Form
	Dim ImageSorce As String
	
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		
		txtbname.Text = ""
		txtbdealer.Text = "MY WINGS HONDA"
		txtbprice.Text = ""
		cmb1.Text = "None"
		cmb2.Text = "None"
		pic1.Image = New System.Drawing.Bitmap(1, 1)
		
		Module1.numval(("select max(bikeid)+1 from bike"))
		txtbid.Text = CStr(nm)
		txtbdealer.Enabled = False
		
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Dim destPath As String
        If txtbid.Text <> "" And txtbname.Text <> "" And txtbdealer.Text <> "" And txtbprice.Text <> "" And cmb1.Text <> "" And cmb2.Text <> "" Then
            Module1.inupdel(("insert into bike  values ('" & txtbid.Text & "','" & txtbname.Text & "','" & txtbdealer.Text & "','" & txtbprice.Text & "','" & cmb1.Text & "','" & cmb2.Text & "','" & txtbid.Text & ".jpg" & "' )"))
            destPath = DataPath & txtbid.Text & ".jpg"
            FileCopy(ImageSorce, destPath)
            MsgBox("Data Saved")
            Module1.retdata(("select * from bike"))
        Else
            MsgBox("Insert all Details ", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
        End If
		
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		Me.Hide()
		MDIForm1.Show()
	End Sub
	
	Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
		End
	End Sub
	
	Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click
		CommonDialog1Open.ShowDialog()
		'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		CommonDialog1Open.Filter = "jpeg|*.jpg"
		str_Renamed = CommonDialog1Open.FileName
		ImageSorce = CommonDialog1Open.FileName
		pic1.Image = System.Drawing.Image.FromFile(str_Renamed)
	End Sub
	
	Private Sub frmbike_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Module1.getconnected()
		Module1.inupdel(("select * from bike"))
		ImageSorce = ""
	End Sub
	
	Private Sub Picture1_Click()
		
	End Sub
	
	Private Sub txtbname_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtbname.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii > 65 And KeyAscii <= 90 Or KeyAscii >= 97 And KeyAscii <= 122 Or KeyAscii = 32 Or KeyAscii = 8 Then
		Else
			lblo.Text = "enter charecter"
			KeyAscii = 0
			txtbname.Focus()
			lblo.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFF)
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
End Class