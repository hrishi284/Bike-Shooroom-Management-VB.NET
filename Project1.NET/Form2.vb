Option Strict Off
Option Explicit On
Friend Class frmEmp
	Inherits System.Windows.Forms.Form
	Dim ImageSorce As String
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		
		txtename.Text = ""
		txteadd.Text = ""
		txteNo.Text = ""
		Module1.numval(("select max(empid)+1 from Employee"))
		
		txteid.Text = CStr(nm)
		
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Dim destPath As String
        If txteid.Text <> "" And txtename.Text <> "" And txteadd.Text <> "" And txteNo.Text <> "" Then
            Module1.inupdel(("insert into employee values('" & txteid.Text & "','" & txtename.Text & "','" & txteadd.Text & "','" & txteNo.Text & "','" & txteid.Text & ".jpg" & "' )"))
            destPath = DPath & txteid.Text & ".jpg"
            FileCopy(ImageSorce, destPath)
            MsgBox("Data Saved")
            Module1.retdata(("select * from employee"))
        Else
            MsgBox("Isert all value", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
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
	
	Private Sub frmEmp_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Module1.getconnected()
		Module1.inupdel(("select * from employee"))
		
		ImageSorce = ""
		
	End Sub
	
	
	
	Private Sub txtename_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtename.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii > 65 And KeyAscii <= 90 Or KeyAscii >= 97 And KeyAscii <= 122 Or KeyAscii = 32 Or KeyAscii = 8 Then
		Else
			lblo.Text = "enter charecter"
			KeyAscii = 0
			txtename.Focus()
			lblo.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFF)
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txteNo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txteNo.Leave
		If Len(txteNo.Text) = 10 Then
			Labo.Text = "Valid No"
			Labo.ForeColor = System.Drawing.ColorTranslator.FromOle(&H8000)
		Else
			Labo.Text = "Invalid No"
			Labo.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFF)
		End If
	End Sub
End Class