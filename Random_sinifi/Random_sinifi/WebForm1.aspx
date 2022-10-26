<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Random_sinifi.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="60px" Width="60px" />
            <asp:Image ID="Image2" runat="server" Height="60px" Width="60px" />
            <asp:Image ID="Image3" runat="server" Height="60px" Width="60px" />
            <asp:Image ID="Image4" runat="server" Height="60px" Width="60px" />
            <br />
            <br />
            Güvenlik kodu Girin:<asp:TextBox ID="guv_kod_txt" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 29px" Text="Button" />
        </div>
    </form>
</body>
</html>
