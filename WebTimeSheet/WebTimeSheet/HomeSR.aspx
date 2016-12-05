<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebTimeSheet.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
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
        </div>
        <p>
            <asp:Button ID="btnHome" runat="server" Text="Home" />
&nbsp;<asp:Button ID="btnTimeSheet" runat="server" Text="TimeSheet" Width="86px" />
&nbsp;<asp:Button ID="btnReports" runat="server" OnClick="btnReports_Click" Text="Reports" />
&nbsp;<asp:Button ID="btnReportsHR" runat="server" OnClick="btnReportsHR_Click" Text="Reports(HR)" Width="82px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 21px; top: 52px; position: absolute; height: 22px" Text="(Supervisor)"></asp:Label>
        </p>
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
    </form>
</body>
</html>
