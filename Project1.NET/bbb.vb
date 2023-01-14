Option Strict Off
Option Explicit On
Friend Class frmbill
	Inherits System.Windows.Forms.Form
	Dim i As Short
	'UPGRADE_WARNING: Event cmbcust.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbcust_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbcust.SelectedIndexChanged
		Module1.retdata(("select customerphone from customer where custname ='" & cmbcust.Text & "'"))
		If Not rs1.EOF Or Not rs1.BOF Then
			lblnm.Text = cmbcust.Text
			lblmb.Text = rs1.Fields(0).Value
			
		End If
		Module1.retdata(("select customeraddress from customer where custname ='" & cmbcust.Text & "'"))
		If Not rs1.EOF Or Not rs1.BOF Then
			lbladd.Text = rs1.Fields(0).Value
		End If
		
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		If cmbbike.Text <> "Select Bil" And txtqut.Text <> "" Then
			Module1.numval(("select bprice from bike where bname='" & cmbbike.Text & "'"))
			
			For i = 0 To 5 Step 1
				If lblsr(i).Text = "" Then
					lblsr(i).Text = CStr(i + 1)
					lblname(i).Text = cmbbike.Text
					lblprice(i).Text = CStr(nm)
					lblqty(i).Text = txtqut.Text
					lblamt(i).Text = CStr(CDbl(lblprice(i).Text) + Val(lblno.Text) + Val(lblin.Text) + Val(lbltax.Text) + Val(lblsc.Text) + Val(lblstd.Text) * CDbl(lblqty(i).Text))
					Exit For
				End If
			Next 
			lblta.Text = CStr(Val(lblamt(0).Text) + Val(lblamt(1).Text) + Val(lblamt(2).Text) + Val(lblamt(3).Text) + Val(lblamt(4).Text) + Val(lblamt(5).Text))
			lblgst.Text = CStr(Val(lblta.Text) * 2 / 100)
			lbltot.Text = CStr(Val(lblta.Text) + Val(lblgst.Text))
		Else
			MsgBox("select Bike and enter Quntity")
			
		End If
		
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		If cmbbike.Text <> "Select Bil" And txtqut.Text <> "" Then
			Module1.numval(("select bprice from bike where bname='" & cmbbike.Text & "'"))
			
			For i = 0 To 5 Step 1
				If lblsr(i).Text = "" Then
					lblsr(i).Text = CStr(i + 1)
					lblname(i).Text = cmbbike.Text
					lblprice(i).Text = CStr(nm)
					lblqty(i).Text = txtqut.Text
					lblamt(i).Text = CStr(CDbl(lblprice(i).Text) + Val(lblnin.Text) + Val(lblntax.Text) + Val(lblnsc.Text) + Val(lblhypo.Text) * CDbl(lblqty(i).Text))
					Exit For
				End If
			Next 
			lblta.Text = CStr(Val(lblamt(0).Text) + Val(lblamt(1).Text) + Val(lblamt(2).Text) + Val(lblamt(3).Text) + Val(lblamt(4).Text) + Val(lblamt(5).Text))
			lblgst.Text = CStr(Val(lblta.Text) * 2 / 100)
			lbltot.Text = CStr(Val(lblta.Text) + Val(lblgst.Text))
		Else
			MsgBox("select Bike and enter Quntity")
			
		End If
	End Sub
	
	Private Sub Command3_Click()
		'If Text1.Text <> "" And lblnm.Caption <> "" And Lbldate.Caption <> "" And lblname.Item.Caption <> "" And lblqty.Item.Caption <> "" And lblamt.Item.Caption <> "" And lblta.Caption <> "" And lblgst.Caption <> "" And lbltot.Caption <> "" Then
		'Module1.inupdel ("insert into bill  values ('" & Text1.Text & "','" & lblnm.Caption & "','" & Lbldate.Caption & "','" & lblname.Count.Caption & "','" & lblqty.Count.Caption & "','" & lblamt.Count.Caption & "','" & lblta.Caption & "','" & lblgst.Caption & "','" & lbltot.Caption & "' )")
		'MsgBox " Data save "
		
	End Sub
	
	Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
		Me.Hide()
		MDIForm1.Show()
	End Sub
	
	Private Sub frmbill_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		'Module1.numval ("select max(bilno)+1 from bil")
		'Text1.Text = nm
		Module1.retdata(("select * from bike"))
		While Not rs1.EOF
			cmbbike.Items.Add((rs1.Fields(1).Value))
			rs1.MoveNext()
		End While
		Module1.retdata(("select * from customer"))
		While Not rs1.EOF
			cmbcust.Items.Add((rs1.Fields(1).Value))
			rs1.MoveNext()
		End While
		Module1.getconnected()
		Module1.retdata(("select * from customer"))
		Module1.retdata(("select * from qotation"))
		lblno.Text = rs1.Fields(1).Value
		lblin.Text = rs1.Fields(2).Value
		lbltax.Text = rs1.Fields(3).Value
		lblsc.Text = rs1.Fields(4).Value
		lblstd.Text = rs1.Fields(5).Value
		Module1.retdata(("select * from qotationwtioutaccessries"))
		lblnin.Text = rs1.Fields(1).Value
		lblntax.Text = rs1.Fields(2).Value
		lblnsc.Text = rs1.Fields(3).Value
		lblhypo.Text = rs1.Fields(4).Value
		Lbldate.Text = CStr(Today)
		'Module1.numval ("select max(blno)+1 from bill")
		'Text1.Text = nm
		'Module1.retdata ("select blno from bill )
		
	End Sub
	
	
	
	
	
	Private Sub print1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles print1.Click
		print1.Visible = False
		PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.CompatibleModeClientAreaOnly)
		print1.Visible = True
	End Sub

    Private Sub Text1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text1.TextChanged

    End Sub
End Class