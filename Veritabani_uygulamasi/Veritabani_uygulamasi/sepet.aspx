<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sepet.aspx.cs" Inherits="Veritabani_uygulamasi.sepet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 42%;
            height: 102px;
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
                    <td colspan="2">
                        <asp:Table ID="Table1" runat="server" Width="803px">
                            <asp:TableRow runat="server">
                                <asp:TableCell runat="server">Resim</asp:TableCell>
                                <asp:TableCell runat="server">Ürünadı</asp:TableCell>
                                <asp:TableCell runat="server">Fiyat</asp:TableCell>
                                <asp:TableCell runat="server">Adet</asp:TableCell>
                                <asp:TableCell runat="server">Sil</asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:ImageButton ID="satin_al_btn" runat="server" ImageUrl="~/img/satin_al.jpg" OnClick="satin_al_btn_Click" />
                    </td>
                    <td class="auto-style2">
                        <asp:ImageButton ID="yenile_btn" runat="server" ImageUrl="~/img/sepeti_yenile.jpg" OnClick="yenile_btn_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2">
                        <asp:Label ID="Toplam_fiy_lbl" runat="server"></asp:Label>
                        <br />
                        <asp:Label ID="siparis_lbl" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
