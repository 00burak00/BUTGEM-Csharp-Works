<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Urun_sayfasi.aspx.cs" Inherits="oop_siniflar.Urun_sayfasi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Giriş" />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="447px" Width="478px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
