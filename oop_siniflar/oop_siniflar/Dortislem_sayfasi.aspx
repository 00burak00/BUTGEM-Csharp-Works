<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dortislem_sayfasi.aspx.cs" Inherits="oop_siniflar.Dortislem_sayfasi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="sayi1_txt" runat="server"></asp:TextBox>
            <asp:TextBox ID="sayi2_txt" runat="server"></asp:TextBox>
            <br />
            <asp:RadioButton ID="topla_radio" runat="server" AutoPostBack="True" GroupName="x" OnCheckedChanged="topla_radio_CheckedChanged" Text="topla" />
            <asp:RadioButton ID="cikar_radio" runat="server" AutoPostBack="True" GroupName="x" OnCheckedChanged="cikar_radio_CheckedChanged" Text="çıkar" />
            <asp:RadioButton ID="carp_radio" runat="server" AutoPostBack="True" GroupName="x" OnCheckedChanged="carp_radio_CheckedChanged" Text="çarp" />
            <asp:RadioButton ID="bol_radio" runat="server" AutoPostBack="True" GroupName="x" OnCheckedChanged="bol_radio_CheckedChanged" Text="Böl" />
        </div>
    </form>
</body>
</html>
