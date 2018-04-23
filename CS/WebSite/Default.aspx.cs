using System;
using DevExpress.XtraReports.UI;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        XtraReport report = new XtraReport1();

        report.CreateDocument();
        ASPxPager1.ItemCount = report.Pages.Count;
        DocumentViewer1.Report = report;
    }

    protected void ASPxPager1_PageIndexChanged(object sender, EventArgs e) {
        HiddenField1.Value = ASPxPager1.PageIndex.ToString();
    }
}
