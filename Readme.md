# How to create a custom control and register it in the EUD toolbox with a custom icon  


<p>This example illustrates how to create a custom control and register it in the End-User Report Designer toolbox with a custom icon. The control in the example is an <strong>XRLabel</strong> descendant. It implements a custom boolean <strong>CheckValue</strong> property.</p>
<p>If the property equals True, and the control text is not a number, the Control.ForeColor property is set to <strong>Red</strong>; otherwise, the ForeColor is set to <strong>DarkGreen</strong>. If the <strong>CheckValue</strong> property equals False, the ForeColor is set to <strong>Black</strong>. The default <strong>ForeColor</strong> property is hidden.<br><br>To register a control in the End-User Report Designer toolbox, the following attributes are used

* <strong>ToolboxBitmapAttribute</strong> (this attribute value is applied to an item in the Report Explorer);
* <strong>ToolboxBitmap24Attribute</strong> (this attribute value is applied to a toolbox item in the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument1763">standard report designer</a>);
* <strong>ToolboxBitmap32Attribute</strong> (this attribute value is applied to a toolbox item in the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument8546">ribbon report designer</a>).<br>In version 16.2 the <strong>ToolboxSvgImage</strong> is implemented to display the identical SVG image in all toolboxes and in the Report Explorer (see the <a href="https://www.devexpress.com/Support/Center/Question/Details/T452973">Support vector icons in the application GUI</a> thread for details).<br><br>To provide a custom action list in the control's smart tag, in the Visual Studio designer and in the End-User Report Designer, it necessary to override the <strong>XRTextControlDesigner</strong> (the base class for all controls) and <strong>XRComponentDesignerActionList</strong> classes. To utilize these classes with a custom control, the <strong>Designer</strong> and <strong>XRDesigner</strong> attributes are used.<br><br>The example also demonstrates how to change a default icon of the existing control. For example, to change an icon of the <strong>XRLabel</strong> control, use the following code in the <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUserDesignerXRDesignMdiController_DesignPanelLoadedtopic">DesignMdiController.DesignPanelLoaded</a> event handler:</p>
<br>


```cs
Stream stream = typeof(CustomLabel.MyCustomLabel).Assembly.GetManifestResourceStream("CustomLabel.label.svg");
SvgImage svg = SvgImage.FromStream(stream);
ts.AddToolBoxSvgImage(typeof(XRLabel), svg);
```


<br>


```vb
Dim stream As Stream = GetType(CustomLabel.MyCustomLabel).Assembly.GetManifestResourceStream("label.svg")
Dim svg As SvgImage = SvgImage.FromStream(stream)
ts.AddToolBoxSvgImage(GetType(XRLabel), svg)
```


<br><br>

<br/>


