<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="Session_sepet_uygulamasi.Giris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            Kullanıcı Adı:<asp:TextBox ID="kuladi_txt" runat="server"></asp:TextBox>
            <br />
            Şifre:<asp:TextBox ID="sifre_txt" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Giriş" style="height: 29px" />
        </div>
    </form>
</body>
</html>
