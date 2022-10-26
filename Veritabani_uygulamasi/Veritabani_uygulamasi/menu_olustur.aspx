<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu_olustur.aspx.cs" Inherits="Veritabani_uygulamasi.menu_olustur" %>
<%@ import Namespace=Veritabani_uygulamasi %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
       
        <div>
            <nav class="navbar navbar-expand-lg navbar-brand bg-light">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">Kapatıyoruz.Com</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarNavDropdown">
      <ul class="navbar-nav">
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="default.aspx">Ana Sayfa</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="uye_kayit.aspx">Üye ol</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="iletisim.html">iletisim</a>
        </li>
        <li class="nav-item dropdown">
          <a class="nav-link dropdown-toggle" href="#" id="navbarDropdownMenuLink" role="button" data-bs-toggle="dropdown" aria-expanded="false">
            Kategoriler
          </a>
          <ul class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
               <%
               ArrayList kategorilistesi = new Kategoriler_dao().tum_kategori_getir();
               foreach (Kategori gelen_kategori in kategorilistesi)
               {
               %>
              
              <li><a class="dropdown-item" href="urunler.aspx?kateno=<%=gelen_kategori.Kateno %>">
                  <%Response.Write(gelen_kategori.Kateadi); %></a></li>
             <%} %>
          </ul>
        </li>
      </ul>
    </div>
  </div>
</nav>

        </div>
    </form>
</body>
<script src="js/bootstrap.bundle.js"></script>
</html>
