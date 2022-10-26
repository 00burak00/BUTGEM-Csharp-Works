<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="nesneler.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="oluştur" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="oku" />
        </div>
        <asp:Table ID="Table1" runat="server" Height="26px" Width="360px">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server" BorderColor="Red" BorderStyle="Solid">Ad soyad</asp:TableCell>
                <asp:TableCell runat="server" BorderColor="Red" BorderStyle="Solid" BorderWidth="1px">Doğum tarihi</asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="oluştur" />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="oku" />
    </form>
</body>
</html>
