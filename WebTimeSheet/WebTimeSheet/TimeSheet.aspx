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
            <asp:Label ID="lblDate" runat="server"></asp:Label>
&nbsp;
            <asp:DropDownList ID="ddlHoursIn" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Hours</asp:ListItem>
                <asp:ListItem Text="12 AM" Value="0"></asp:ListItem>
                <asp:ListItem>1 AM</asp:ListItem>
                <asp:ListItem>2 AM</asp:ListItem>
                <asp:ListItem>3 AM</asp:ListItem>
                <asp:ListItem>4 AM</asp:ListItem>
                <asp:ListItem>5 AM</asp:ListItem>
                <asp:ListItem>6 AM</asp:ListItem>
                <asp:ListItem>7 AM</asp:ListItem>
                <asp:ListItem>8 AM</asp:ListItem>
                <asp:ListItem>9 AM</asp:ListItem>
                <asp:ListItem>10 AM</asp:ListItem>
                <asp:ListItem>11 AM</asp:ListItem>
                <asp:ListItem>12 PM</asp:ListItem>
                <asp:ListItem>1 PM</asp:ListItem>
                <asp:ListItem>2 PM</asp:ListItem>
                <asp:ListItem>3 PM</asp:ListItem>
                <asp:ListItem>4 PM</asp:ListItem>
                <asp:ListItem>5 PM</asp:ListItem>
                <asp:ListItem>6 PM</asp:ListItem>
                <asp:ListItem>7 PM</asp:ListItem>
                <asp:ListItem>8 PM</asp:ListItem>
                <asp:ListItem>9 PM</asp:ListItem>
                <asp:ListItem>10 PM</asp:ListItem>
                <asp:ListItem>11 PM</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="ddlMinutesIn" runat="server">
                <asp:ListItem>Minutes</asp:ListItem>
                <asp:ListItem Value="0">00</asp:ListItem>
                <asp:ListItem>01</asp:ListItem>
                <asp:ListItem>02</asp:ListItem>
                <asp:ListItem>03</asp:ListItem>
                <asp:ListItem>04</asp:ListItem>
                <asp:ListItem>05</asp:ListItem>
                <asp:ListItem>06</asp:ListItem>
                <asp:ListItem>07</asp:ListItem>
                <asp:ListItem>08</asp:ListItem>
                <asp:ListItem>09</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem Value="11"></asp:ListItem>
                <asp:ListItem Value="12"></asp:ListItem>
                <asp:ListItem>13</asp:ListItem>
                <asp:ListItem Value="14"></asp:ListItem>
                <asp:ListItem>15</asp:ListItem>
                <asp:ListItem Value="16"></asp:ListItem>
                <asp:ListItem>17</asp:ListItem>
                <asp:ListItem>18</asp:ListItem>
                <asp:ListItem>19</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>21</asp:ListItem>
                <asp:ListItem>22</asp:ListItem>
                <asp:ListItem>23</asp:ListItem>
                <asp:ListItem Value="24"></asp:ListItem>
                <asp:ListItem>25</asp:ListItem>
                <asp:ListItem>26</asp:ListItem>
                <asp:ListItem Value="27"></asp:ListItem>
                <asp:ListItem>28</asp:ListItem>
                <asp:ListItem Value="29"></asp:ListItem>
                <asp:ListItem Value="30"></asp:ListItem>
                <asp:ListItem Value="31"></asp:ListItem>
                <asp:ListItem Value="32"></asp:ListItem>
                <asp:ListItem>33</asp:ListItem>
                <asp:ListItem>34</asp:ListItem>
                <asp:ListItem>35</asp:ListItem>
                <asp:ListItem>36</asp:ListItem>
                <asp:ListItem>37</asp:ListItem>
                <asp:ListItem Value="38"></asp:ListItem>
                <asp:ListItem>39</asp:ListItem>
                <asp:ListItem>40</asp:ListItem>
                <asp:ListItem>41</asp:ListItem>
                <asp:ListItem>42</asp:ListItem>
                <asp:ListItem>43</asp:ListItem>
                <asp:ListItem>44</asp:ListItem>
                <asp:ListItem>45</asp:ListItem>
                <asp:ListItem>46</asp:ListItem>
                <asp:ListItem Value="47"></asp:ListItem>
                <asp:ListItem Value="48"></asp:ListItem>
                <asp:ListItem Value="49"></asp:ListItem>
                <asp:ListItem Value="50"></asp:ListItem>
                <asp:ListItem Value="51"></asp:ListItem>
                <asp:ListItem Value="52"></asp:ListItem>
                <asp:ListItem Value="53"></asp:ListItem>
                <asp:ListItem Value="54"></asp:ListItem>
                <asp:ListItem Value="55"></asp:ListItem>
                <asp:ListItem Value="56"></asp:ListItem>
                <asp:ListItem Value="57"></asp:ListItem>
                <asp:ListItem Value="58"></asp:ListItem>
                <asp:ListItem Value="59"></asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        </p>
        <p style="text-align: center">
            <asp:Label ID="lblDate0" runat="server"></asp:Label>
            <asp:DropDownList ID="ddlHoursOut" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Hours</asp:ListItem>
                <asp:ListItem Text="12 AM" Value="0"></asp:ListItem>
                <asp:ListItem>1 AM</asp:ListItem>
                <asp:ListItem>2 AM</asp:ListItem>
                <asp:ListItem>3 AM</asp:ListItem>
                <asp:ListItem>4 AM</asp:ListItem>
                <asp:ListItem>5 AM</asp:ListItem>
                <asp:ListItem>6 AM</asp:ListItem>
                <asp:ListItem>7 AM</asp:ListItem>
                <asp:ListItem>8 AM</asp:ListItem>
                <asp:ListItem>9 AM</asp:ListItem>
                <asp:ListItem>10 AM</asp:ListItem>
                <asp:ListItem>11 AM</asp:ListItem>
                <asp:ListItem>12 PM</asp:ListItem>
                <asp:ListItem>1 PM</asp:ListItem>
                <asp:ListItem>2 PM</asp:ListItem>
                <asp:ListItem>3 PM</asp:ListItem>
                <asp:ListItem>4 PM</asp:ListItem>
                <asp:ListItem>5 PM</asp:ListItem>
                <asp:ListItem>6 PM</asp:ListItem>
                <asp:ListItem>7 PM</asp:ListItem>
                <asp:ListItem>8 PM</asp:ListItem>
                <asp:ListItem>9 PM</asp:ListItem>
                <asp:ListItem>10 PM</asp:ListItem>
                <asp:ListItem>11 PM</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="ddlMinutesOut" runat="server">
                <asp:ListItem>Minutes</asp:ListItem>
                <asp:ListItem Value="0">00</asp:ListItem>
                <asp:ListItem>01</asp:ListItem>
                <asp:ListItem>02</asp:ListItem>
                <asp:ListItem>03</asp:ListItem>
                <asp:ListItem>04</asp:ListItem>
                <asp:ListItem>05</asp:ListItem>
                <asp:ListItem>06</asp:ListItem>
                <asp:ListItem>07</asp:ListItem>
                <asp:ListItem>08</asp:ListItem>
                <asp:ListItem>09</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem Value="11"></asp:ListItem>
                <asp:ListItem Value="12"></asp:ListItem>
                <asp:ListItem>13</asp:ListItem>
                <asp:ListItem Value="14"></asp:ListItem>
                <asp:ListItem>15</asp:ListItem>
                <asp:ListItem Value="16"></asp:ListItem>
                <asp:ListItem>17</asp:ListItem>
                <asp:ListItem>18</asp:ListItem>
                <asp:ListItem>19</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>21</asp:ListItem>
                <asp:ListItem>22</asp:ListItem>
                <asp:ListItem>23</asp:ListItem>
                <asp:ListItem Value="24"></asp:ListItem>
                <asp:ListItem>25</asp:ListItem>
                <asp:ListItem>26</asp:ListItem>
                <asp:ListItem Value="27"></asp:ListItem>
                <asp:ListItem>28</asp:ListItem>
                <asp:ListItem Value="29"></asp:ListItem>
                <asp:ListItem Value="30"></asp:ListItem>
                <asp:ListItem Value="31"></asp:ListItem>
                <asp:ListItem Value="32"></asp:ListItem>
                <asp:ListItem>33</asp:ListItem>
                <asp:ListItem>34</asp:ListItem>
                <asp:ListItem>35</asp:ListItem>
                <asp:ListItem>36</asp:ListItem>
                <asp:ListItem>37</asp:ListItem>
                <asp:ListItem Value="38"></asp:ListItem>
                <asp:ListItem>39</asp:ListItem>
                <asp:ListItem>40</asp:ListItem>
                <asp:ListItem>41</asp:ListItem>
                <asp:ListItem>42</asp:ListItem>
                <asp:ListItem>43</asp:ListItem>
                <asp:ListItem>44</asp:ListItem>
                <asp:ListItem>45</asp:ListItem>
                <asp:ListItem>46</asp:ListItem>
                <asp:ListItem Value="47"></asp:ListItem>
                <asp:ListItem Value="48"></asp:ListItem>
                <asp:ListItem Value="49"></asp:ListItem>
                <asp:ListItem Value="50"></asp:ListItem>
                <asp:ListItem Value="51"></asp:ListItem>
                <asp:ListItem Value="52"></asp:ListItem>
                <asp:ListItem Value="53"></asp:ListItem>
                <asp:ListItem Value="54"></asp:ListItem>
                <asp:ListItem Value="55"></asp:ListItem>
                <asp:ListItem Value="56"></asp:ListItem>
                <asp:ListItem Value="57"></asp:ListItem>
                <asp:ListItem Value="58"></asp:ListItem>
                <asp:ListItem Value="59"></asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="ddlReason" runat="server">
                <asp:ListItem>Random</asp:ListItem>
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
