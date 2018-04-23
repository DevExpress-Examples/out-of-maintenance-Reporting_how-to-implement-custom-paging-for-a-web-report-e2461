Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.UI

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim report As XtraReport = GetReport()

		report.CreateDocument()
		ASPxPager1.ItemCount = report.Pages.Count
		ReportViewer1.Report = report
	End Sub

	Protected Sub ASPxPager1_PageIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		HiddenField1.Value = ASPxPager1.PageIndex.ToString()
	End Sub

	Protected Sub ReportViewer1_Unload(ByVal sender As Object, ByVal e As EventArgs)
		ReportViewer1.Report = Nothing
	End Sub

	Protected Function GetReport() As XtraReport1
		If CType(Session("report"), XtraReport1) Is Nothing Then
			Session("report") = New XtraReport1()
		End If

		Return CType(Session("report"), XtraReport1)
	End Function

End Class
