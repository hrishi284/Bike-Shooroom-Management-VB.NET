Option Strict Off
Option Explicit On
Friend Class frmquo
	Inherits System.Windows.Forms.Form
	'UPGRADE_WARNING: Event cmb1.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmb1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Module1.retdata(("select bprice from bike where bname ='" & cmb1.Text & "'"))
        If Not rs1.EOF Or Not rs1.BOF Then
            lblsprice.Text = rs1.Fields(0).Value
        End If
        Module1.retdata(("select insurance from qotation  "))
        If Not rs1.EOF Or Not rs1.BOF Then
            lblin.Text = rs1.Fields(0).Value
        End If
        Module1.retdata(("select tax from qotation  "))
        If Not rs1.EOF Or Not rs1.BOF Then
            lblrto.Text = rs1.Fields(0).Value
        End If
        Module1.retdata(("select scard from qotation  "))
        If Not rs1.EOF Or Not rs1.BOF Then
            lblsmc.Text = rs1.Fields(0).Value
        End If
        Module1.retdata(("select standf from qotation  "))
        If Not rs1.EOF Or Not rs1.BOF Then
            lblhpa.Text = rs1.Fields(0).Value
        End If
        Module1.retdata(("select access from qotation  "))
        If Not rs1.EOF Or Not rs1.BOF Then
            lblacc.Text = rs1.Fields(0).Value
        End If
        lbltot.Text = CStr(Val(lblsprice.Text) + Val(lblin.Text) + Val(lblrto.Text) + Val(lblsmc.Text) + Val(lblhpa.Text) + Val(lblacc.Text))

    End Sub
	
    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        lblacce.Enabled = True
        lblacc.Enabled = True

    End Sub
	
    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        lblacce.Enabled = False
        lblacc.Enabled = False

    End Sub
	
    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Me.Hide()
        MDIForm1.Show()
    End Sub
	
    Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        End
    End Sub
	
	Private Sub frmquo_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Label17.Text = CStr(Today)
		Module1.retdata(("select * from bike"))
		While Not rs1.EOF
			cmb1.Items.Add((rs1.Fields(1).Value))
			rs1.MoveNext()
		End While
		Module1.retdata(("select * from bike"))
		While Not rs1.EOF
			cmb2.Items.Add((rs1.Fields(4).Value))
			rs1.MoveNext()
		End While
	End Sub
	
	
	
    Private Sub print1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        print1.Visible = False
        'UPGRADE_ISSUE: Form method frmquo.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub
End Class