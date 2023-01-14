<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAnimated
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
	Public WithEvents Picture1 As System.Windows.Forms.Panel
	Public WithEvents WindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAnimated))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Timer1 = New System.Windows.Forms.Timer(components)
		Me.Picture1 = New System.Windows.Forms.Panel
		Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
		Me.WindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer
		Me.Label1 = New System.Windows.Forms.Label
		Me.Picture1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.WindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BackColor = System.Drawing.Color.FromARGB(0, 128, 0)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Text = "Form1"
		Me.ClientSize = New System.Drawing.Size(233, 299)
		Me.Location = New System.Drawing.Point(0, 0)
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.BackgroundImage = CType(resources.GetObject("frmAnimated.BackgroundImage"), System.Drawing.Image)
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmAnimated"
		Me.Timer1.Interval = 3000
		Me.Timer1.Enabled = True
		Me.Picture1.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.Picture1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Picture1.Size = New System.Drawing.Size(201, 187)
		Me.Picture1.Location = New System.Drawing.Point(11, 47)
		Me.Picture1.TabIndex = 0
		Me.Picture1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Picture1.Dock = System.Windows.Forms.DockStyle.None
		Me.Picture1.CausesValidation = True
		Me.Picture1.Enabled = True
		Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Picture1.TabStop = True
		Me.Picture1.Visible = True
		Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Picture1.Name = "Picture1"
		Me.WebBrowser1.Size = New System.Drawing.Size(313, 321)
		Me.WebBrowser1.Location = New System.Drawing.Point(-10, -40)
		Me.WebBrowser1.TabIndex = 1
		Me.WebBrowser1.AllowWebBrowserDrop = True
		Me.WebBrowser1.Name = "WebBrowser1"
		WindowsMediaPlayer1.OcxState = CType(resources.GetObject("WindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.WindowsMediaPlayer1.Size = New System.Drawing.Size(25, 9)
		Me.WindowsMediaPlayer1.Location = New System.Drawing.Point(72, 256)
		Me.WindowsMediaPlayer1.TabIndex = 3
		Me.WindowsMediaPlayer1.Visible = False
		Me.WindowsMediaPlayer1.Name = "WindowsMediaPlayer1"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Text = "Please wait while your request is processing"
		Me.Label1.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.FromARGB(224, 224, 224)
		Me.Label1.Size = New System.Drawing.Size(233, 49)
		Me.Label1.Location = New System.Drawing.Point(0, 0)
		Me.Label1.TabIndex = 2
		Me.Label1.Enabled = True
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Controls.Add(Picture1)
		Me.Controls.Add(WindowsMediaPlayer1)
		Me.Controls.Add(Label1)
		Me.Picture1.Controls.Add(WebBrowser1)
		CType(Me.WindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Picture1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class