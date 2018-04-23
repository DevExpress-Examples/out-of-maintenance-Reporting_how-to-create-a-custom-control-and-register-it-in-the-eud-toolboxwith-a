Imports CustomLabel
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner.Native
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Design
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace T461136
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
			radioGroup1.SelectedIndex = 0
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim report As New XtraReport1()
			Dim tool As New ReportDesignTool(report)
            AddHandler tool.DesignForm.DesignMdiController.DesignPanelLoaded, AddressOf DesignMdiController_DesignPanelLoaded
			tool.ShowDesigner()
		End Sub

		Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
			Dim report As New XtraReport1()
			Dim tool As New ReportDesignTool(report)
			AddHandler tool.DesignRibbonForm.DesignMdiController.DesignPanelLoaded, AddressOf DesignMdiController_DesignPanelLoaded
			tool.ShowRibbonDesigner()
		End Sub

		Private Sub DesignMdiController_DesignPanelLoaded(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs)
			Dim ts As XRToolboxService = DirectCast(e.DesignerHost.GetService(GetType(IToolboxService)), XRToolboxService)
			ts.AddToolboxItem(New ToolboxItem(GetType(MyCustomLabel)), "Standard Controls")

			' change icon of the XRLabel control
			If radioGroup1.SelectedIndex = 1 Then
                Dim stream As Stream = GetType(CustomLabel.MyCustomLabel).Assembly.GetManifestResourceStream("StandardLabel.svg")
				Dim svg As SvgImage = SvgImage.FromStream(stream)
				ts.AddToolBoxSvgImage(GetType(XRLabel), svg)
			Else
                Dim stream As Stream = GetType(CustomLabel.MyCustomLabel).Assembly.GetManifestResourceStream("CustomLabel.StandardLabel16.bmp")
                Dim img As Image = Image.FromStream(stream)
                ts.AddToolBoxImage(GetType(XRLabel), ImageSize.Size16, img)
                stream = GetType(CustomLabel.MyCustomLabel).Assembly.GetManifestResourceStream("CustomLabel.StandardLabel24.bmp")
                img = Image.FromStream(stream)
                ts.AddToolBoxImage(GetType(XRLabel), ImageSize.Size24, img)
                stream = GetType(CustomLabel.MyCustomLabel).Assembly.GetManifestResourceStream("CustomLabel.StandardLabel32.bmp")
                img = Image.FromStream(stream)
                ts.AddToolBoxImage(GetType(XRLabel), ImageSize.Size32, img)
			End If
		End Sub

		Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioGroup1.SelectedIndexChanged
			If radioGroup1.SelectedIndex = 1 Then
				WindowsFormsSettings.AllowDefaultSvgImages = DevExpress.Utils.DefaultBoolean.True
			Else
				WindowsFormsSettings.AllowDefaultSvgImages = DevExpress.Utils.DefaultBoolean.False
			End If
		End Sub
	End Class
End Namespace
