<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Dosya_klasor_komutlari.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="486px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="641px"></asp:ListBox>
            <asp:Image ID="Image1" runat="server" Height="233px" Width="294px" />
        </div>
    </form>
</body>
</html>
