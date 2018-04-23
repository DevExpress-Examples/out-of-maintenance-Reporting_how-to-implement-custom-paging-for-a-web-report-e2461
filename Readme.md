# How to implement custom paging for a web report


<p>This example demonstrates how the ASPxPager control can be used to perform pagination for the ReportViewer control, displaying a multi-page report. At present, ASPxPager does not expose a client-side model (see <a href="https://www.devexpress.com/Support/Center/p/S18028">ASPxPager - publish ClientSide Events and client side API</a>). Also, unfortunately, it's impossible to change a page number in the ReportViewer via server code. You can only do this on the client side: <a href="http://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsWebScriptsASPxClientReportViewer_GotoPagetopic">ASPxClientReportViewer.GotoPage</a>. Due to these two peculiarities, it is necessary to perform at least two round-trips to the server (first when selecting a page in the ASPxPager, and second, when calling the ASPxClientReportViewer.GotoPage() method).</p>


<h3>Description</h3>

Starting with v2013 vol 2, you can use a single&nbsp;<a href="http://documentation.devexpress.com/#XtraReports/clsDevExpressXtraReportsWebASPxDocumentViewertopic"><u>ASPxDocumentViewer</u></a>&nbsp;control to display a report on your webpage.

<br/>


