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
&nbsp;<asp:Button ID="btnTimeSheet" runat="server" Text="TimeSheet" Width="86px" OnClick="btnTimeSheet_Click" />
        </p>
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
    </form>
</body>
</html>
