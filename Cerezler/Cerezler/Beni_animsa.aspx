<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Beni_animsa.aspx.cs" Inherits="Cerezler.Beni_animsa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Kullanıcı adı:<asp:TextBox ID="kuladi_txt" runat="server"></asp:TextBox>
            <br />
            Şifre:<asp:TextBox ID="sifre_txt" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="hatirla_cek" runat="server" Text="Beni Hatırla" />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Giriş" />
        </div>
    </form>
</body>
</html>
