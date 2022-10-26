<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hesapmakinasi.aspx.cs" Inherits="Temel_komutlar.Hesapmakinasi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Sayi1:<asp:TextBox ID="sayi1txt" runat="server"></asp:TextBox>
        </p>
        <p>
            Sayi2:<asp:TextBox ID="sayi2txt" runat="server"></asp:TextBox>
        </p>
        <div>
            <asp:Button ID="toplabtn" runat="server" OnClick="toplabtn_Click" Text="Topla" />
            <asp:Button ID="cikarbtn" runat="server" OnClick="cikarbtn_Click" Text="Çıkar" />
        </div>
    </form>
</body>
</html>
