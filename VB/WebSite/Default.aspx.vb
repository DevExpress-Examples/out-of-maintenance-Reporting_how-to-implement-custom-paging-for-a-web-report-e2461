Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.UI

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim report As XtraReport = New XtraReport1()

		report.CreateDocument()
		ASPxPager1.ItemCount = report.Pages.Count
		DocumentViewer1.Report = report
	End Sub

	Protected Sub ASPxPager1_PageIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		HiddenField1.Value = ASPxPager1.PageIndex.ToString()
	End Sub
End Class
