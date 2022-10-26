<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sayfa1.aspx.cs" Inherits="Response_nesnesi.sayfa1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Image ID="Image1" runat="server" Height="255px" ImageUrl="~/img/Koala.jpg" Width="261px" />
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
