using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrossTabDemo1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            var report = new XtraReport1();
            var rd2 = new DevExpress.XtraReports.UI.ReportDesignTool(report);
            rd2.ShowDesigner();
        }
    }
}
