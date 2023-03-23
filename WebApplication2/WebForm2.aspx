<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 384px; top: 100px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 384px; top: 160px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 387px; top: 219px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 387px; top: 277px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 386px; top: 65px; position: absolute" Text="Username"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 385px; top: 133px; position: absolute" Text="Firstname"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 385px; top: 194px; position: absolute" Text="Last name"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 387px; top: 253px; position: absolute" Text="Password"></asp:Label>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 440px; top: 499px; position: absolute" Text="Create Account" />
        <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 394px; top: 409px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox7" runat="server" style="z-index: 1; left: 399px; top: 461px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 396px; top: 376px; position: absolute" Text="BloodType"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 401px; top: 438px; position: absolute" Text="Zona"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 389px; top: 345px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 451px; top: 536px; position: absolute"></asp:Label>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 393px; top: 316px; position: absolute" Text="CNP"></asp:Label>
    </form>
</body>
</html>
