using CustomLabel;
using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace T461136 {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
            radioGroup1.SelectedIndex = 0;
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();
            ReportDesignTool tool = new ReportDesignTool(report);
           
            tool.DesignForm.DesignMdiController.DesignPanelLoaded += DesignMdiController_DesignPanelLoaded;
            tool.ShowDesigner();
        }

        private void simpleButton2_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();
            ReportDesignTool tool = new ReportDesignTool(report);
            tool.DesignRibbonForm.DesignMdiController.DesignPanelLoaded += DesignMdiController_DesignPanelLoaded;
            tool.ShowRibbonDesigner();
        }

        void DesignMdiController_DesignPanelLoaded(object sender, DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs e) {
            XRToolboxService ts = (XRToolboxService)e.DesignerHost.GetService(typeof(IToolboxService));
            ts.AddToolboxItem(new ToolboxItem(typeof(MyCustomLabel)), "Standard Controls");

            // change icon of the XRLabel control
            if(radioGroup1.SelectedIndex == 1) {
                Stream stream = typeof(CustomLabel.MyCustomLabel).Assembly.GetManifestResourceStream("CustomLabel.StandardLabel.svg");
                SvgImage svg = SvgImage.FromStream(stream);
                ts.AddToolBoxSvgImage(typeof(XRLabel), svg);
            } else {
                Stream stream = typeof(CustomLabel.MyCustomLabel).Assembly.GetManifestResourceStream("CustomLabel.StandardLabel16.bmp");
                Image img = Image.FromStream(stream);
                ts.AddToolBoxImage(typeof(XRLabel), ImageSize.Size16, img);
                stream = typeof(CustomLabel.MyCustomLabel).Assembly.GetManifestResourceStream("CustomLabel.StandardLabel24.bmp");
                img = Image.FromStream(stream);
                ts.AddToolBoxImage(typeof(XRLabel), ImageSize.Size24, img);
                stream = typeof(CustomLabel.MyCustomLabel).Assembly.GetManifestResourceStream("CustomLabel.StandardLabel32.bmp");
                img = Image.FromStream(stream);
                ts.AddToolBoxImage(typeof(XRLabel), ImageSize.Size32, img);
            }
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e) {
            if(radioGroup1.SelectedIndex == 1)
                WindowsFormsSettings.AllowDefaultSvgImages = DevExpress.Utils.DefaultBoolean.True;
            else
                WindowsFormsSettings.AllowDefaultSvgImages = DevExpress.Utils.DefaultBoolean.False;
        }
    }
}
