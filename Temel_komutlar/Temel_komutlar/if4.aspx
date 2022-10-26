<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="if4.aspx.cs" Inherits="Temel_komutlar.if4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Sayi1:<asp:TextBox ID="sayi1_txt" runat="server" BackColor="Red" Font-Bold="True" ForeColor="#FFFF66"></asp:TextBox>
            <br />
            sayi2:<asp:TextBox ID="sayi2_txt" runat="server" BackColor="Red" Font-Bold="True" ForeColor="#FFFF66"></asp:TextBox>
            <br />
            <asp:RadioButton ID="topla_radio" runat="server" GroupName="islem" Text="Topla" />
            <asp:RadioButton ID="cikar_radio" runat="server" GroupName="islem" Text="Çıkar" />
            <asp:RadioButton ID="carp_radio" runat="server" GroupName="islem" Text="Çarp" />
            <asp:RadioButton ID="bol_radio" runat="server" GroupName="islem" Text="Böl" />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Hesapla" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="sonuc_lbl" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
