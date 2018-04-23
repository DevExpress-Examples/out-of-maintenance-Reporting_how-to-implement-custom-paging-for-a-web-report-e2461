using System;
using DevExpress.XtraReports.UI;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        XtraReport report = GetReport();

        report.CreateDocument();
        ASPxPager1.ItemCount = report.Pages.Count;
        ReportViewer1.Report = report;
    }

    protected void ASPxPager1_PageIndexChanged(object sender, EventArgs e)
    {
        HiddenField1.Value = ASPxPager1.PageIndex.ToString();
    }

    protected void ReportViewer1_Unload(object sender, EventArgs e)
    {
        ReportViewer1.Report = null;
    }

    protected XtraReport1 GetReport()
    {
        if ((XtraReport1)Session["report"] == null)
            Session["report"] = new XtraReport1();

        return (XtraReport1)Session["report"];
    }

}
