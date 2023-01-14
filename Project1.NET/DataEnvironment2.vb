Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.Compatibility

Module DataEnvironment_DataEnvironment2_Module
	Friend DataEnvironment2 As DataEnvironment_DataEnvironment2 = New DataEnvironment_DataEnvironment2()
End Module

Friend Class DataEnvironment_DataEnvironment2
	Inherits VB6.BaseDataEnvironment
	Public WithEvents Connection1 As ADODB.Connection
	Public WithEvents rsCommand1 As ADODB.Recordset
	Private m_Command1 As ADODB.Command
	Public Sub New()
		MyBase.New()
		Dim par As ADODB.Parameter
		
		
		Connection1 = New ADODB.Connection()
		Connection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\bike.mdb;Persist Security Info=False;"
		m_Connections.Add(Connection1, "Connection1")
		m_Command1 = New ADODB.Command()
		rsCommand1 = New ADODB.Recordset()
		m_Command1.Name = "Command1"
		m_Command1.CommandText = "`employee`"
		m_Command1.CommandType = ADODB.CommandTypeEnum.adCmdTable
		rsCommand1.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		rsCommand1.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		rsCommand1.LockType = ADODB.LockTypeEnum.adLockReadOnly
		rsCommand1.Source = m_Command1
		m_Commands.Add(m_Command1, "Command1")
		m_Recordsets.Add(rsCommand1, "Command1")
	End Sub
	Public Sub Command1()
		If Connection1.State = ADODB.ObjectStateEnum.adStateClosed Then
			Connection1.Open()
		End If
		If rsCommand1.State = ADODB.ObjectStateEnum.adStateOpen Then
			rsCommand1.Close()
		End If
		m_Command1.ActiveConnection = Connection1
		rsCommand1.Open()
	End Sub
End Class