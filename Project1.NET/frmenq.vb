Option Strict Off
Option Explicit On
Friend Class frmenq
	Inherits System.Windows.Forms.Form
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		txtno.Text = ""
		txtdt.Text = ""
		txtcName.Text = ""
		txtph.Text = ""
		txtadd.Text = ""
		txteid.Text = ""
		cmb1.Text = "Select bike"
	End Sub
	
	
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		If txtno.Text <> "" And txtdt.Text <> "" And txtcName.Text <> "" And txtph.Text <> "" And txtadd.Text <> "" And txteid.Text <> "" And cmb1.Text <> "" Then
			Module1.inupdel(("insert into enquiry values ('" & txtno.Text & "','" & txtdt.Text & "','" & txtcName.Text & "','" & txtph.Text & "','" & txtadd.Text & "','" & txteid.Text & "','" & cmb1.Text & "' )"))
			MsgBox("Data Saved")
			Module1.retdata(("select * from enquiry"))
		Else
			MsgBox("Insert all Details ", MsgBoxStyle.OKOnly + MsgBoxStyle.Critical)
		End If
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		Me.Hide()
		MDIForm1.Show()
	End Sub
	
	Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
		End
	End Sub
	
	Private Sub frmenq_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Module1.retdata(("select * from bike"))
		While Not rs1.EOF
			cmb1.Items.Add((rs1.Fields(1).Value))
			rs1.MoveNext()
		End While
		Module1.getconnected()
		Module1.inupdel(("select * from enquiry "))
		
	End Sub
End Class