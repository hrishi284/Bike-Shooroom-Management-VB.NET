Option Strict Off
Option Explicit On
Friend Class frmAnimated
	Inherits System.Windows.Forms.Form
	Private Sub frmAnimated_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		WebBrowser1.Navigate(New System.URI(My.Application.Info.DirectoryPath & "\loading.gif"))
	End Sub
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		Me.Close()
		MDIForm1.Show()
		
		
		
	End Sub
End Class