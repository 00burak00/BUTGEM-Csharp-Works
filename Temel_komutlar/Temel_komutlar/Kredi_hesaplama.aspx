<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kredi_hesaplama.aspx.cs" Inherits="Temel_komutlar.Kredi_hesaplama" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 27%;
            height: 96px;
        }
        .auto-style2 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style1">
                <tr>
                    <td>Kredi Tipi:</td>
                    <td>
                        <asp:DropDownList ID="tip_listesi" runat="server" AutoPostBack="True" OnSelectedIndexChanged="tip_listesi_SelectedIndexChanged">
                            <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                            <asp:ListItem Value="1">İhtiyaç</asp:ListItem>
                            <asp:ListItem Value="2">Taşıt</asp:ListItem>
                            <asp:ListItem Value="3">Konut</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Kredi Miktarı:</td>
                    <td>
                        <asp:TextBox ID="miktar_txt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Vade:</td>
                    <td>
                        <asp:DropDownList ID="vade_listesi" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2">
                        <asp:Label ID="faiz_lbl" runat="server"></asp:Label>
                        <br />
                        <asp:Label ID="aylik_lbl" runat="server"></asp:Label>
                        <br />
                        <asp:Label ID="toplam_lbl" runat="server"></asp:Label>
                        <br />
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Hesapla" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
