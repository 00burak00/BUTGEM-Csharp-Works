<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Anasayfa.aspx.cs" Inherits="Request_nesnesi.Anasayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ürünlerimiz<br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Urunlerimiz.aspx?urunid=1">Anakart</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Urunlerimiz.aspx?urunid=2">Ram</asp:HyperLink>
        </div>
        <p>
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Urunlerimiz.aspx?urunid=3">Hdd</asp:HyperLink>
        </p>
    </form>
</body>
</html>
