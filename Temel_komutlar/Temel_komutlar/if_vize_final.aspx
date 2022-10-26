<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="if_vize_final.aspx.cs" Inherits="Temel_komutlar.if_vize_final" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="vizelbl" runat="server" Text="Vize:"></asp:Label>
        <asp:TextBox ID="vizetxt" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="finallbl" runat="server" Text="Final:"></asp:Label>
        <asp:TextBox ID="finaltxt" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="butunlbl" runat="server" Text="Bütünleme:" Visible="False"></asp:Label>
        <asp:TextBox ID="butuntxt" runat="server" Visible="False"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Hesapla" />
        <asp:Label ID="sonuclbl" runat="server" ForeColor="Red"></asp:Label>
    
    </div>
    </form>
</body>
</html>

