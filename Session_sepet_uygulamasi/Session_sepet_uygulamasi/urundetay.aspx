<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="urundetay.aspx.cs" Inherits="Session_sepet_uygulamasi.urundetay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 52%;
            height: 475px;
        }
        .auto-style3 {
            height: 327px;
            text-align: center;
        }
        .auto-style4 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style2">
                <tr>
                    <td class="auto-style3">
                        <asp:Image ID="Image1" runat="server" Height="250px" Width="250px" />
                    </td>
                    <td class="auto-style3">
                        <asp:Image ID="Image2" runat="server" Height="250px" Width="250px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="ad_lbl1" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:Label ID="ad_lbl2" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="fiy_lbl1" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:Label ID="fiy_lbl2" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="67px" ImageUrl="~/img/indir.jpg" OnClick="ImageButton1_Click" Width="76px" />
                    </td>
                    <td class="auto-style4">
                        <asp:ImageButton ID="ImageButton2" runat="server" Height="63px" ImageUrl="~/img/indir.jpg" OnClick="ImageButton2_Click" Width="64px" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Urunler.aspx">Geri dön</asp:HyperLink>
    </form>
</body>
</html>
