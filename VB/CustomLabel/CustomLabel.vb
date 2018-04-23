Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraReports
Imports DevExpress.Utils.Design
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Localization
Imports DevExpress.XtraReports.Design
Imports System.ComponentModel.Design

Namespace CustomLabel
    <
    ToolboxItem(True),
    ToolboxBitmap(GetType(CustomLabel.MyCustomLabel), "CustomLabel16.bmp"),
    ToolboxBitmap24("CustomLabel.CustomLabel24.bmp, CustomLabel"),
    ToolboxBitmap32("CustomLabel.CustomLabel32.bmp, CustomLabel"),
    ToolboxSvgImage("CustomLabel.svg, CustomLabel"),
    Designer("CustomLabel.MyCustomLabelDesigner"),
    XRDesigner("CustomLabel.MyCustomLabelDesigner")>
    Public Class MyCustomLabel
        Inherits XRLabel

        Private _checkValue As Boolean
        <DefaultValue(True)>
        Public Overridable Property CheckValue() As Boolean
            Get
                Return _checkValue
            End Get
            Set(ByVal value As Boolean)
                If _checkValue <> value Then
                    _checkValue = value
                    OnPropertiesChanged()
                End If
            End Set
        End Property

        <Browsable(False), EditorBrowsable(EditorBrowsableState.Never), Bindable(False)>
        Public Overrides Property ForeColor() As Color
            Get
                Return MyBase.ForeColor
            End Get
            Set(ByVal value As Color)
                MyBase.ForeColor = value
            End Set
        End Property

        Public Overrides Property Text() As String
            Get
                Return MyBase.Text
            End Get
            Set(ByVal value As String)
                MyBase.Text = value
                OnPropertiesChanged()
            End Set
        End Property

        Public Sub New()
            Me.Font = New Font("Calibri", 12, FontStyle.Bold)
            Me.CheckValue = True
        End Sub

        Private Sub OnPropertiesChanged()
            Dim result As Integer
            If _checkValue Then
                ForeColor = If(Integer.TryParse(Text, result), Color.DarkGreen, Color.Red)
            Else
                ForeColor = Color.Black
            End If
        End Sub
    End Class

	Public Class MyCustomLabelDesigner
		Inherits XRTextControlDesigner

		Protected Overrides Sub RegisterActionLists(ByVal list As System.ComponentModel.Design.DesignerActionListCollection)
			MyBase.RegisterActionLists(list)
			list.Add(New MyCustomLabelActionList(Me))
		End Sub
	End Class

	Public Class MyCustomLabelActionList
		Inherits XRComponentDesignerActionList

		Public Sub New(ByVal componentDesigner As XRComponentDesigner)
			MyBase.New(componentDesigner)
		End Sub

		Protected Overrides Sub FillActionItemCollection(ByVal actionItems As DesignerActionItemCollection)
			MyBase.FillActionItemCollection(actionItems)
			AddPropertyItem(actionItems, "CheckValue", "CheckValue")
		End Sub

		Public Property CheckValue() As Boolean
			Get
				Return DirectCast(Me.Component, MyCustomLabel).CheckValue
			End Get
			Set(ByVal value As Boolean)
				Me.SetPropertyValue("CheckValue", value)
			End Set
		End Property
	End Class
End Namespace
