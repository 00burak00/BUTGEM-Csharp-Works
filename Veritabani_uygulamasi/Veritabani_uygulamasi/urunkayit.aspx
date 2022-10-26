<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="urunkayit.aspx.cs" Inherits="Veritabani_uygulamasi.urunkayit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 702px;
        }
        .auto-style2 {
            width: 40%;
            height: 435px;
        }
        .auto-style3 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style2">
                <tr>
                    <td class="auto-style1">Ürün Adı:</td>
                    <td>
                        <asp:TextBox ID="urunadi_txt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Fiyatı</td>
                    <td>
                        <asp:TextBox ID="fiyat_txt" runat="server" Width="112px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Katogorisi:</td>
                    <td>
                        <asp:DropDownList ID="kategori_listem" runat="server">
                            <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Açıklama.</td>
                    <td>
                        <asp:TextBox ID="aciklama_txt" runat="server" Height="181px" TextMode="MultiLine" Width="555px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Resim Seçin:</td>
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server" Width="398px" />
                        <br />
                        <asp:Image ID="Image1" runat="server" Height="167px" Width="172px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Kaydet" Width="536px" />
                        <br />
                        <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
