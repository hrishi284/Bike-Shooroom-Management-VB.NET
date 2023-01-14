Option Strict Off
Option Explicit On
Friend Class frmLogin
	Inherits System.Windows.Forms.Form
	'Private Sub cmdOK_Click()
	'If txtID.Text <> "" And txtPassword.Text <> "" Then
	
	'Module1.numval ("select count(*)from login where  ID ='" & txtID.Text & "' and password='" & txtPassword.Text & "'")
	
	'If module.nm = 1 Then
	'MsgBox ("login succesfully")
	'frmLogin.Hide
	'MDIForm1.Show
	'Unload Me
	
	'Else
	'MsgBox "invalid user", vbOKOnly + vbCritical, "error"
	'txtID.SetFocus
	'End If
	'Else
	'MsgBox "enter id and password"
	'End If
	'end sub
	
	
	Private Sub login()
		
		
		Module1.getconnected()
		Dim rs As New ADODB.Recordset
		rs.Open("select * from login where  username='" & txtUserName.Text & "'", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
		If rs.RecordCount < 1 Then
			MsgBox("username is invalid", MsgBoxStyle.OKOnly + MsgBoxStyle.Critical, "login")
			txtUserName.Focus()
			Exit Sub
		Else
			If txtPassword.Text = rs.Fields("Password").Value Then
				Me.Close()
				MsgBox("login succesfully")
				'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
                'Load(MDIForm1)
				frmAnimated.Show()
				Exit Sub
			Else
				MsgBox("password is invalid", MsgBoxStyle.OKOnly + MsgBoxStyle.Critical, "login")
				txtPassword.Focus()
				Exit Sub
			End If
		End If
		'UPGRADE_NOTE: Object rs may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rs = Nothing
	End Sub
	
	
	
	
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		End
	End Sub
	
	Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
		Dim txtid As Object
		If txtUserName.Text = " " Then
			MsgBox("userusername is empty")
			'UPGRADE_WARNING: Couldn't resolve default property of object txtid.SetFocus. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			txtid.SetFocus()
			Exit Sub
		ElseIf txtPassword.Text = "" Then 
			MsgBox("password is empty")
			txtPassword.Focus()
			Exit Sub
		Else
			Call login()
		End If
		
		
	End Sub
	
	
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Shell("explorer http://www.honda2wheelersindia.com/")
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Shell("explorer http://m.facebook.com/MY-WINGS-HONDA-96145746391186")
	End Sub
	
	Private Sub frmLogin_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Module1.getconnected()
		Dim rs As New ADODB.Recordset
		
	End Sub
	
	
	Private Sub Label1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Label1.Click
		Me.Hide()
		frmfpass.Show()
	End Sub
End Class