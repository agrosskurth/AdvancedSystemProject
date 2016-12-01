<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebTimeSheet.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            font-size: x-large;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1" style="text-align: center">
    
        <h1>Welcome
            <asp:Label ID="lblFName" runat="server"></asp:Label>
            <asp:Label ID="lblLName" runat="server"></asp:Label>
        </h1>
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1">
        </asp:TreeView>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    <div class="auto-style1" style="text-align: right">
    
        <br />
            <asp:Button ID="btnLogout0" runat="server" OnClick="btnLogout_Click" Text="Logout"/>
        </div>
            <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
    </form>
</body>
</html>
