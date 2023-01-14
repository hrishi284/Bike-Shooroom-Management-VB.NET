Option Strict Off
Option Explicit On
Friend Class frmEmi
	Inherits System.Windows.Forms.Form
	Dim N As Short
	'UPGRADE_NOTE: rate was upgraded to rate_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Dim amt, payment As Object
	Dim rate_Renamed As Double
	
	
	
	'UPGRADE_WARNING: Event cmbbike.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbbike_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbbike.SelectedIndexChanged
		Module1.retdata(("select bprice from bike where bname ='" & cmbbike.Text & "'"))
		If Not rs1.EOF Or Not rs1.BOF Then
			txtloan.Text = rs1.Fields(0).Value
			
		End If
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object amt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		amt = Val(txtloan.Text)
		rate_Renamed = Val(txtloan.Text) * (Val(txtint.Text) / 100)
		
		Label9.Text = CStr(rate_Renamed)
		N = Val(txtyr.Text) * 12
		'UPGRADE_WARNING: Couldn't resolve default property of object payment. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		payment = (rate_Renamed / N)
		'UPGRADE_WARNING: Couldn't resolve default property of object payment. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Lblpayment.Text = VB6.Format(payment, "###0")
		lblpa.Text = CStr(rate_Renamed + Val(txtloan.Text))
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Dim txtia As Object
		
		'UPGRADE_WARNING: Couldn't resolve default property of object txtia.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If cmbet.Text <> "" And cmb123.Text <> "" And cmbbike.Text <> "" And txtloan.Text <> "" And txtint.Text <> "" And txtia.Text <> "" And txtyr.Text <> "" And Lblpayment.Text <> "" And lblpa.Text <> "" Then
			'UPGRADE_WARNING: Couldn't resolve default property of object txtia.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Module1.inupdel(("insert into emi  values ('" & cmbet.Text & "','" & cmb123.Text & "','" & cmbbike.Text & "','" & txtloan.Text & "','" & txtint.Text & "','" & txtia.Text & "','" & txtyr.Text & "' ,'" & Lblpayment.Text & "','" & lblpa.Text & "')"))
			MsgBox("Data Saved")
		Else
			MsgBox("Insert all Details ", MsgBoxStyle.OKOnly + MsgBoxStyle.Critical)
		End If
	End Sub
	
	Private Sub frmEmi_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Module1.retdata(("select * from customer"))
		While Not rs1.EOF
			cmb123.Items.Add((rs1.Fields(1).Value))
			rs1.MoveNext()
		End While
		Module1.retdata(("select * from bike"))
		While Not rs1.EOF
			cmbbike.Items.Add((rs1.Fields(1).Value))
			rs1.MoveNext()
		End While
		
	End Sub
End Class