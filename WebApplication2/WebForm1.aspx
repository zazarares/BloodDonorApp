<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            z-index: 1;
            left: 430px;
            top: 219px;
            position: absolute;
            width: 188px;
        }
        #Text2 {
            z-index: 1;
            left: 431px;
            top: 286px;
            position: absolute;
            width: 186px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server" BackImageUrl="https://c8.alamy.com/comp/J90EDD/background-blood-donor-day-style-collection-J90EDD.jpg" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 864px; width: 1599px">
            &nbsp;
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 432px; top: 193px; position: absolute" Text="Username:"></asp:Label>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 433px; top: 257px; position: absolute" Text="Password:"></asp:Label>
            <asp:Button ID="Button1" runat="server" BackColor="White" OnClick="Button1_Click" style="z-index: 1; left: 492px; top: 339px; position: absolute; width: 70px;" Text="Login" />
            <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 433px; top: 286px; position: absolute; width: 184px" TextMode="Password"></asp:TextBox>
            <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 431px; top: 223px; position: absolute; width: 185px"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" style="z-index: 1; left: 470px; top: 392px; position: absolute" Text="Create Account" />
        </asp:Panel>
    </form>
</body>
</html>
