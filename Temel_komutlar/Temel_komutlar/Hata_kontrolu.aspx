<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hata_kontrolu.aspx.cs" Inherits="Temel_komutlar.Hata_kontrolu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="sayi1_txt" runat="server"></asp:TextBox>
            <asp:TextBox ID="islem_txt" runat="server" Width="49px"></asp:TextBox>
            <asp:TextBox ID="sayi2_txt" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <asp:Label ID="sonuc_lbl" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
