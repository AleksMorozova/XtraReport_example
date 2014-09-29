using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraEditors;

namespace XtraFormsTest
{
    public partial class XtraReport3 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport3()
        {
            InitializeComponent();
        }

        private void XtraReport3_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            DataSetCity dataSet = new DataSetCity();

            DataSetCityTableAdapters.CityTableAdapter adapter =
                new DataSetCityTableAdapters.CityTableAdapter();
            adapter.Fill(dataSet.City);

            foreach (ParameterInfo info in e.ParametersInformation)
            {
                if (info.Parameter.Name == "parameterCity")
                {
                    LookUpEdit lookUpEdit = new LookUpEdit();
                    lookUpEdit.Properties.DataSource = dataSet.City;
                    lookUpEdit.Properties.DisplayMember = "name";
                    lookUpEdit.Properties.ValueMember = "name";
                    lookUpEdit.Properties.Columns.Add(new
                        LookUpColumnInfo("name", 0, "name"));
                    info.Editor = lookUpEdit;
                }
            }
        }

    }
}
