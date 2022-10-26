<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Urun_islemleri.aspx.cs" Inherits="text_dosya_islemleri.Urun_islemleri" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 35%;
            height: 84px;
        }
        .auto-style2 {
            width: 222px;
        }
        .auto-style3 {
            width: 222px;
            height: 29px;
        }
        .auto-style4 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Ürün barkod:</td>
                    <td>
                        <asp:TextBox ID="barkod_txt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Ürün adı:</td>
                    <td>
                        <asp:TextBox ID="urun_aditxt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Fiyatı:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="fiyat_txt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Kategori</td>
                    <td>
                        <asp:DropDownList ID="kate_listesi" runat="server">
                            <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="kaydet" />
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Listele" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:ListBox ID="ListBox1" runat="server" Height="481px" Width="702px"></asp:ListBox>
    </form>
</body>
</html>
