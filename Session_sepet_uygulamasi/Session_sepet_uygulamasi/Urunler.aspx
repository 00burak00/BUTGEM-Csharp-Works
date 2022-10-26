<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Urunler.aspx.cs" Inherits="Session_sepet_uygulamasi.Urunler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                <asp:ListItem Value="1">Anakart</asp:ListItem>
                <asp:ListItem Value="2">Ram</asp:ListItem>
                <asp:ListItem Value="3">Hdd</asp:ListItem>
            </asp:RadioButtonList>
        </div>
    </form>
</body>
</html>
