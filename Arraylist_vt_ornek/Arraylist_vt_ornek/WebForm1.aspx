<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Arraylist_vt_ornek.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Urun no:<asp:TextBox ID="urun_no_txt" runat="server"></asp:TextBox>
            <br />
            Ürün Adı:<asp:TextBox ID="urun_adi_txt" runat="server"></asp:TextBox>
            <br />
            Fiyatı:<asp:TextBox ID="urun_fiyat_txt" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Kaydet" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="sil" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="bul" />
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="327px" Width="898px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
