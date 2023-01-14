Option Strict Off
Option Explicit On
Module Module1
	Public rs2 As New ADODB.Recordset
	Public rs1 As New ADODB.Recordset
	Public rs As New ADODB.Recordset
	Public con As ADODB.Connection
	Public nm As Integer
	'UPGRADE_NOTE: str was upgraded to str_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public str_Renamed As String
	Public DataPath As String
	Public DPath As String
	Public DataP As String
	Public Sub getconnected()
		DataPath = "D:\BIke\"
		DPath = "D:\Custmer\"
		DataP = "D:\Employee\"
		con = New ADODB.Connection
		con.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\bike.mdb"
		con.Open()
		
	End Sub
	
	Public Sub retdata(ByVal q As String)
		If rs1.State = 1 Then
			rs1.Close()
		End If
		
		Call getconnected()
		rs1.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		rs1.Open(q, con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
		
	End Sub
	
	Public Sub inupdel(ByVal q As String)
		If rs.State = 1 Then
			rs.Close()
		End If
		Call getconnected()
		rs.Open(q, con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
		
		
	End Sub
	
	Public Sub numval(ByVal q As String)
		If rs.State = 1 Then
			rs.Close()
		End If
		rs.Open(q, con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
		If Not rs.EOF Or Not rs.BOF Then
			nm = rs.Fields(0).Value
		End If
	End Sub
	
	Public Sub dataret(ByVal q As String)
		If rs2.State = 1 Then
			rs2.Close()
		End If
		
		Call getconnected()
		rs2.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		rs2.Open(q, con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
		
	End Sub
End Module