Option Strict Off
Option Explicit On
Friend Class frmCust
	Inherits System.Windows.Forms.Form
	Dim ImageSorce As String
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		txtcid.Text = ""
		txtcName.Text = ""
		txtcAdd.Text = ""
		txtcNo.Text = ""
		Module1.numval(("select max(customerid)+1 from customer"))
		txtcid.Text = CStr(nm)
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Dim destPath As String
        If txtcid.Text <> "" And txtcName.Text <> "" And txtcAdd.Text <> "" And txtadhar.Text <> "" And txtcNo.Text <> "" And txtcmail.Text <> "" Then
            Module1.inupdel(("insert into customer values ('" & txtcid.Text & "','" & txtcName.Text & "','" & txtcAdd.Text & "','" & txtadhar.Text & "','" & txtcNo.Text & "','" & txtcmail.Text & "','" & txtcid.Text & ".jpg" & "'  )"))
            destPath = DPath & txtcid.Text & ".jpg"
            FileCopy(ImageSorce, destPath)
            MsgBox("Data Saved")
            Module1.retdata(("select * from customer"))
        Else
            MsgBox("Insert all Details ", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
        End If
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		End
	End Sub
	
	Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
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
	
	Private Sub frmCust_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Module1.getconnected()
		Module1.inupdel(("select * from customer"))
		ImageSorce = ""
	End Sub
	
	Private Sub txtcmail_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtcmail.Leave
		If InStr(2, Trim(txtcmail.Text), "@") Then
			Label.Text = "Vailid Email"
			Label.ForeColor = System.Drawing.ColorTranslator.FromOle(&H8000)
		Else
			Label.Text = "invalid email"
			Label.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFF)
		End If
	End Sub
	
	
	Private Sub txtcName_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtcName.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii > 65 And KeyAscii <= 90 Or KeyAscii >= 97 And KeyAscii <= 122 Or KeyAscii = 32 Or KeyAscii = 8 Then
		Else
			lblo.Text = "enter charecter"
			KeyAscii = 0
			txtcName.Focus()
			lblo.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFF)
		End If
		
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtcNo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtcNo.Leave
		If Len(txtcNo.Text) = 10 Then
			Labo.Text = "Valid No"
			Labo.ForeColor = System.Drawing.ColorTranslator.FromOle(&H8000)
		Else
			Labo.Text = "Invalid No"
			Labo.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFF)
		End If
	End Sub
End Class