<!-- default file list -->
*Files to look at*:

* [XtraReport1.cs](./CS/WebSite/App_Code/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/WebSite/App_Code/XtraReport1.vb))
* **[Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))**
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to implement custom paging for a web report


<p>This example demonstrates how the ASPxPager control can be used to perform pagination for the ReportViewer control, displaying a multi-page report. At present, ASPxPager does not expose a client-side model (see <a href="https://www.devexpress.com/Support/Center/p/S18028">ASPxPager - publish ClientSide Events and client side API</a>). Also, unfortunately, it's impossible to change a page number in the ReportViewer via server code. You can only do this on the client side: <a href="http://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsWebScriptsASPxClientReportViewer_GotoPagetopic">ASPxClientReportViewer.GotoPage</a>. Due to these two peculiarities, it is necessary to perform at least two round-trips to the server (first when selecting a page in the ASPxPager, and second, when calling the ASPxClientReportViewer.GotoPage() method).</p>

<br/>


