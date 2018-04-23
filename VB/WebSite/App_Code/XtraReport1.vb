Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

''' <summary>
''' Summary description for XtraReport1
''' </summary>
Public Class XtraReport1
	Inherits DevExpress.XtraReports.UI.XtraReport
	Private Detail As DevExpress.XtraReports.UI.DetailBand
	Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
	Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
	Private ReportHeader As ReportHeaderBand
	Private xrLabel1 As XRLabel
	Private xrLabel2 As XRLabel
	Private xrLabel3 As XRLabel
	Private xrPictureBox1 As XRPictureBox
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	Public Sub New()
		InitializeComponent()
		'
		' TODO: Add constructor logic here
		'
	End Sub

	''' <summary> 
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resourceFileName As String = "XtraReport1.resx"
		Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
		Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
		Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
		Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
		Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
		Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
		Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
		Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' Detail
		' 
		Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox1, Me.xrLabel3, Me.xrLabel2})
		Me.Detail.HeightF = 145F
		Me.Detail.Name = "Detail"
		Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' xrPictureBox1
		' 
		Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(442.7083F, 10.00001F)
		Me.xrPictureBox1.Name = "xrPictureBox1"
		Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(197.2917F, 79.99998F)
		' 
		' xrLabel3
		' 
		Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 67.00001F)
		Me.xrLabel3.Name = "xrLabel3"
		Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel3.SizeF = New System.Drawing.SizeF(398F, 23.00002F)
		Me.xrLabel3.Text = "xrLabel3"
		' 
		' xrLabel2
		' 
		Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
		Me.xrLabel2.Name = "xrLabel2"
		Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel2.SizeF = New System.Drawing.SizeF(271.875F, 23F)
		Me.xrLabel2.Text = "xrLabel2"
		' 
		' TopMargin
		' 
		Me.TopMargin.Name = "TopMargin"
		Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' BottomMargin
		' 
		Me.BottomMargin.Name = "BottomMargin"
		Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' ReportHeader
		' 
		Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
		Me.ReportHeader.HeightF = 64F
		Me.ReportHeader.Name = "ReportHeader"
		' 
		' xrLabel1
		' 
		Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 25F)
		Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(250F, 0F)
		Me.xrLabel1.Name = "xrLabel1"
		Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel1.SizeF = New System.Drawing.SizeF(158F, 42F)
		Me.xrLabel1.StylePriority.UseFont = False
		Me.xrLabel1.Text = "Categories"
		' 
		' XtraReport1
		' 
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
		Me.Version = "10.1"
'		Me.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.XtraReport1_BeforePrint);
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region

	Private Sub XtraReport1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
		Dim da As New DataSet1TableAdapters.CategoriesTableAdapter()
		Dim ds As New DataSet1()

		da.Fill(ds.Categories)

		DataSource = ds.Categories

		xrLabel2.Text = "[CategoryName]"
		xrLabel3.Text = "[Description]"
		xrPictureBox1.DataBindings.Add("Image", Nothing, "Picture")
	End Sub
End Class
