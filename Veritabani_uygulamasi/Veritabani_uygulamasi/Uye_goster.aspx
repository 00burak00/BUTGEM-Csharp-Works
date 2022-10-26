<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Uye_goster.aspx.cs" Inherits="Veritabani_uygulamasi.Uye_goster" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Şehir:<asp:DropDownList ID="sehir_listesi" runat="server" AutoPostBack="True" OnSelectedIndexChanged="sehir_listesi_SelectedIndexChanged" CssClass="btn-warning">
                <asp:ListItem Value="0">Seçiniz</asp:ListItem>
            </asp:DropDownList>
            Email:<asp:TextBox ID="email_txt" runat="server" AutoPostBack="True" OnTextChanged="email_txt_TextChanged"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Tümü" CssClass="btn-outline-success active" />
            <br />
            <asp:Table ID="Table1" runat="server" Width="1357px" CssClass="table-warning">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">Üye no</asp:TableCell>
                    <asp:TableCell runat="server">Ad Soyad</asp:TableCell>
                    <asp:TableCell runat="server">Kullanıcı adı</asp:TableCell>
                    <asp:TableCell runat="server">Email</asp:TableCell>
                    <asp:TableCell runat="server">Doğum Tarihi</asp:TableCell>
                    <asp:TableCell runat="server">Şehir</asp:TableCell>
                    <asp:TableCell runat="server">Meslek</asp:TableCell>
                    <asp:TableCell runat="server">Sil</asp:TableCell>
                    <asp:TableCell runat="server">Değiştir</asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
   
</html>
