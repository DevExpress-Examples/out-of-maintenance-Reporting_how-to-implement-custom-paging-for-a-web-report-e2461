<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.XtraReports.v9.3.Web, Version=9.3.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dxr" %>
<%@ Register Assembly="DevExpress.Web.v9.3, Version=9.3.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPager" TagPrefix="dxp" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="1px" style="width:100%;">
            <tr>
                <td align="center" style="background-color:yellow;">
                    <dxp:ASPxPager ID="ASPxPager1" runat="server" ItemCount="5" ItemsPerPage="1" 
                        OnPageIndexChanged="ASPxPager1_PageIndexChanged" 
                        CurrentPageNumberFormat="Page {0}" ShowSeparators="True">
                        <LastPageButton Visible="True">
                        </LastPageButton>
                        <SummaryStyle Font-Bold="True" Font-Italic="False" Font-Size="Large">
                        </SummaryStyle>
                        <FirstPageButton Visible="True">
                        </FirstPageButton>
                        <Summary AllPagesText="Pages: {0} - {1} ({1} pages)" 
                            Text="Page {0} of {1} ({1} pages)" />
                    </dxp:ASPxPager>
                </td>
            </tr>
            <tr>
                <td align="center">
                    <dxr:ReportViewer ID="ReportViewer1" runat="server" ClientInstanceName="reportViewer"
                        OnUnload="ReportViewer1_Unload">
                        <ClientSideEvents PageLoad="function(s, e) {
    if(e.PageCount === 0) {
        return;
    }
    var hiddenField = document.getElementById('HiddenField1');
    var pageIndex = parseInt(hiddenField.value);

    if (!isNaN(pageIndex))
        reportViewer.GotoPage(pageIndex);
    
    hiddenField.value = '';
}" />
                    </dxr:ReportViewer>
                </td>
            </tr>
        </table>
        <asp:HiddenField ID="HiddenField1" runat="server" />
    </div>
    </form>
</body>
</html>
