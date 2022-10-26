<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="switch2.aspx.cs" Inherits="Temel_komutlar.switch2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Şehir Seçiniz:<asp:DropDownList ID="sehir_listesi" runat="server" AutoPostBack="True" OnSelectedIndexChanged="sehir_listesi_SelectedIndexChanged">
                <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                <asp:ListItem Value="16">Bursa</asp:ListItem>
                <asp:ListItem Value="6">Ankara</asp:ListItem>
                <asp:ListItem Value="34">İstanbul</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:ListBox ID="ilce_listesi" runat="server" AutoPostBack="True" Height="301px" OnSelectedIndexChanged="ilce_listesi_SelectedIndexChanged" Width="275px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
