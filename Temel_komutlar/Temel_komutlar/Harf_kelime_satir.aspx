<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Harf_kelime_satir.aspx.cs" Inherits="Temel_komutlar.Harf_kelime_satir" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        <asp:TextBox ID="TextBox1" runat="server" Height="99px" TextMode="MultiLine" Width="299px"></asp:TextBox>
    </form>
</body>
</html>
