using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using XtraFormsTest;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;

namespace XtraReportTest
{
    public partial class MainXtraForm : DevExpress.XtraEditors.XtraForm
    {
        
        public MainXtraForm()
        {
            InitializeComponent();

        }
        private List<Data> CreateData()
        {
            List<Data> data = new List<Data>();

            Data item1 = new Data();
            item1.Date = DateTime.Now;
            item1.Id = 0;
            item1.Name = "First";
            data.Add(item1);

            Data item2 = new Data();
            item2.Date = DateTime.Now;
            item2.Id = 1;
            item2.Name = "Second";
            data.Add(item2);

            Data item3 = new Data();
            item3.Date = DateTime.Now;
            item3.Id = 2;
            item3.Name = "Third";
            data.Add(item3);

            return data;
        }

        private void btnFirstReport_Click(object sender, EventArgs e)
        {
            XtraReportFirst report = new XtraReportFirst();
            report.CreateDocument();
            DocumentViewer doc = documentViewer;
            doc.DocumentSource = report; 
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }

        private void btnSecondReport_Click(object sender, EventArgs e)
        {
            XtraReportSecond report = new XtraReportSecond();
            report.DataSource = CreateData();
            report.CreateDocument();
            DocumentViewer doc = documentViewer;
            doc.DocumentSource = report; 
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();

        }
    }
}