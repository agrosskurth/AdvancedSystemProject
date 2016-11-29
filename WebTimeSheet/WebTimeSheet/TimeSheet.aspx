<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TimeSheet.aspx.cs" Inherits="WebTimeSheet.TimeSheet1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1 style="text-align: center">Time Sheet Entry</h1>
        <p style="text-align: center"></p>
        <p style="text-align: center">
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList3" runat="server">
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList4" runat="server">
            </asp:DropDownList>
        </p>
        <p style="text-align: center">&nbsp;</p>
        <p style="text-align: center">&nbsp;</p>
        <p style="text-align: center">&nbsp;</p>
        <p style="text-align: center">&nbsp;</p>
        <p style="text-align: center">&nbsp;</p>
        <p style="text-align: center">&nbsp;</p>
    </div>
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
    </form>
</body>
</html>
