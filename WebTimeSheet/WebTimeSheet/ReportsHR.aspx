<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportsHR.aspx.cs" Inherits="WebTimeSheet.ReportsHR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ReportsHR</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    <h1>Reports</h1>
    </div>
        <asp:Button ID="btnAllTimeSheets" runat="server" Height="23px" OnClick="btnAllTimeSheets_Click" Text="All Time Sheets" Width="109px" />
        <br />
        <asp:ListBox ID="lbReports" runat="server" Height="365px" style="margin-top: 1px" Width="791px"></asp:ListBox>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
