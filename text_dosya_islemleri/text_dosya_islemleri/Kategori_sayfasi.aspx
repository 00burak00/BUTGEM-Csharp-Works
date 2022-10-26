<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kategori_sayfasi.aspx.cs" Inherits="text_dosya_islemleri.Kategori_sayfasi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Kategori Adı:<asp:TextBox ID="kate_txt" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Kaydet" />
        </div>
    </form>
</body>
</html>
