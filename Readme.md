<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128601334/13.2.10%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2461)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [XtraReport1.cs](./CS/WebSite/App_Code/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/WebSite/App_Code/XtraReport1.vb))
* **[Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))**
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to implement custom paging for a web report
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e2461/)**
<!-- run online end -->


<p>This example demonstrates how the ASPxPager control can be used to perform pagination for the ReportViewer control, displaying a multi-page report. At present, ASPxPager does not expose a client-side model (see <a href="https://www.devexpress.com/Support/Center/p/S18028">ASPxPager - publish ClientSide Events and client side API</a>). Also, unfortunately, it's impossible to change a page number in the ReportViewer via server code. You can only do this on the client side: <a href="http://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsWebScriptsASPxClientReportViewer_GotoPagetopic">ASPxClientReportViewer.GotoPage</a>. Due to these two peculiarities, it is necessary to perform at least two round-trips to the server (first when selecting a page in the ASPxPager, and second, when calling the ASPxClientReportViewer.GotoPage() method).</p>


<h3>Description</h3>

<p>Starting with v2013 vol 2, you can use a single <a href="http://documentation.devexpress.com/#XtraReports/clsDevExpressXtraReportsWebASPxDocumentViewertopic"><u>ASPxDocumentViewer</u></a> control to display a report on your webpage.</p>

<br/>


