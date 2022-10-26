<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="switch_3_doviz.aspx.cs" Inherits="Temel_komutlar.switch_3_doviz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 24px;
        }
        .auto-style2 {
            font-size: xx-large;
            text-align: center;
        }
        .auto-style3 {
            height: 24px;
            width: 689px;
            font-size: x-large;
        }
        .auto-style4 {
            width: 689px;
            font-size: x-large;
        }
        .auto-style5 {
            text-align: center;
        }
        .auto-style6 {
            width: 33%;
            height: 170px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style6">
                <tr>
                    <td class="auto-style2" colspan="2"><strong>Döviz Çevirici</strong></td>
                </tr>
                <tr>
                    <td class="auto-style3"><strong>Döviz Miktarı:</strong></td>
                    <td class="auto-style1">
                        <asp:TextBox ID="miktar_txt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"><strong>Döviz Tipi Seçiniz:</strong></td>
                    <td>
                        <asp:DropDownList ID="doviz_turu_listesi" runat="server" AutoPostBack="True" OnSelectedIndexChanged="doviz_turu_listesi_SelectedIndexChanged">
                            <asp:ListItem>Seçiniz</asp:ListItem>
                            <asp:ListItem>Dolar</asp:ListItem>
                            <asp:ListItem>Euro</asp:ListItem>
                            <asp:ListItem>Yen</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5" colspan="2">
                        <asp:Label ID="sonuc_lbl" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
