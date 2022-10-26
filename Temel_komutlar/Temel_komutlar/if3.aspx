<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="if3.aspx.cs" Inherits="Temel_komutlar.if3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Not girin:<asp:TextBox ID="not_txt" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="hesapla" />
        </div>
    </form>
</body>
</html>
