Option Strict Off
Option Explicit On
Friend Class frmfpass
	Inherits System.Windows.Forms.Form
	Private Sub changepassbtn_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles changepassbtn.Click
		If txtnew.Text = txtconfirm.Text Then
			Module1.inupdel(("update login set login.password = '" & txtconfirm.Text & "'  where login.username = '" & txtfuser.Text & "'"))
			MsgBox("Password Changed Successfully", MsgBoxStyle.Information, "Password Change: Success")
			Me.Hide()
			frmLogin.Show()
		Else
			MsgBox("Password Does not matched,Please Enter Correct Details", MsgBoxStyle.Exclamation, "Change Password:Failed")
			txtnew.Text = ""
			txtconfirm.Text = ""
		End If
	End Sub
	
	Private Sub cmdcheak_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdcheak.Click
		rs.Open("select * from login where  username='" & txtfuser.Text & "'", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
		If rs.RecordCount < 1 Then
			lbl2.Text = "User id not found .....Sorry can't Reset password!!"
			txtfuser.Focus()
			lbl2.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFF)
		Else
			lbl2.Text = "User ID Found in the database"
			lbl2.ForeColor = System.Drawing.ColorTranslator.FromOle(&H8000)
			
		End If
		'UPGRADE_NOTE: Object rs may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rs = Nothing
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		rs.Open("select * from login where  dob='" & txtfdob.Text & "'", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
		If rs.RecordCount < 1 Then
			lbl3.Text = "Account not verified ,Can't reset the password"
			lbl2.Text = "Sorry .. Date of Birth Not Matched !! "
			lbl2.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			lbl3.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFF)
			
		Else
			
			lbl2.ForeColor = System.Drawing.ColorTranslator.FromOle(&H8000)
			lbl3.ForeColor = System.Drawing.ColorTranslator.FromOle(&H8000)
			lbl2.Text = "Congratulations !!"
			lbl3.Text = "Account is verified Now,Set your new Password"
			txtnew.Visible = True
			txtconfirm.Visible = True
			changepassbtn.Visible = True
			lblenp.Visible = True
			lblcp.Visible = True
		End If
		'UPGRADE_NOTE: Object rs may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rs = Nothing
	End Sub
	
	Private Sub frmfpass_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		txtnew.Visible = False
		txtconfirm.Visible = False
		changepassbtn.Visible = False
		lblenp.Visible = False
		lblcp.Visible = False
		
	End Sub
End Class