<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kategori_islemleri.aspx.cs" Inherits="Veritabani_uygulamasi.Kategori_islemleri" %>
<%@ Import Namespace="Veritabani_uygulamasi" %>
<!DOCTYPE html><html xmlns="http://www.w3.org/1999/xhtml"><head runat="server"><title></title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 28%;
        }
    </style>
</head>
    <body><form id="form1" runat="server">
        <div>
            Kategori Adı:<asp:TextBox ID="kateadi_txt" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Kaydet" CssClass="btn-danger" />
        
        
            <br />
            <table class="auto-style1">
                <tr>
                    <td>Kategori adı</td>
                    <td>Sil</td>
                    <td>Değiştir</td>
                </tr>
                <%ArrayList kategori_listesi = new Kategoriler_dao().tum_kategori_getir();
                    foreach (Kategori gelen_kat in kategori_listesi)
                    {
                    %>

                <tr>
                    <td><%=gelen_kat.Kateadi %></td>
                    <td><a href="kategori_sil.aspx?kateno=<%=gelen_kat.Kateno %>" class="btn btn-danger">Sil</a></td>
                    <td><a href="kategori_duzenle.aspx?kateno=<%=gelen_kat.Kateno %>">Değiştir</a></td>
                </tr>
                <%} %>
            </table>
        
        
            <br />
        
        
        </div>
    </form>
    <p>
&nbsp;</p>
</body>
<script src="js/bootstrap.bundle.js"></script>
</html>
