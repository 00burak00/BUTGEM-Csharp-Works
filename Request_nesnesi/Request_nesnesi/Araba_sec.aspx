<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Araba_sec.aspx.cs" Inherits="Request_nesnesi.Araba_sec" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Araba Markasi Seçin:<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                <asp:ListItem Value="1">Alfa</asp:ListItem>
                <asp:ListItem Value="2">Reno</asp:ListItem>
                <asp:ListItem Value="3">Fiat</asp:ListItem>
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
