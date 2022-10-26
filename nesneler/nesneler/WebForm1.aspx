<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="nesneler.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem>Kitap okuma</asp:ListItem>
                <asp:ListItem>yüzme</asp:ListItem>
                <asp:ListItem>golf</asp:ListItem>
                <asp:ListItem>at binme</asp:ListItem>
                <asp:ListItem>tenis</asp:ListItem>
            </asp:CheckBoxList>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Seçili hobiler" />
            <br />
        </div>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem>gs</asp:ListItem>
            <asp:ListItem>bjk</asp:ListItem>
            <asp:ListItem>bursa spor</asp:ListItem>
            <asp:ListItem>giresun spor</asp:ListItem>
            <asp:ListItem>ts</asp:ListItem>
            <asp:ListItem>fb</asp:ListItem>
        </asp:RadioButtonList>
        <asp:ImageMap ID="ImageMap1" runat="server" Height="600px" ImageUrl="~/img/Penguins.jpg" Width="800px">
            <asp:CircleHotSpot AlternateText="google git" NavigateUrl="www.google.com" Radius="50" X="200" Y="100" />
        </asp:ImageMap>
    </form>
</body>
</html>
