<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="switch_1.aspx.cs" Inherits="Temel_komutlar.switch_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Not Değeri:</div>
        <asp:TextBox ID="not_txt" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="hesapla" />
    </form>
</body>
</html>
