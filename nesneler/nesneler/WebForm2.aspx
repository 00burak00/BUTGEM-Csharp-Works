<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="nesneler.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="View1" runat="server">
                    <asp:Button ID="Button1" runat="server" Text="Button" />
                    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                    <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <asp:Image ID="Image1" runat="server" Height="220px" ImageUrl="~/img/Penguins.jpg" Width="505px" />
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                    <asp:Button ID="Button2" runat="server" Text="Button" />
                </asp:View>
                <asp:View ID="View3" runat="server">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                    </asp:DropDownList>
                    <asp:Button ID="Button3" runat="server" Text="Button" />
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </asp:View>
            </asp:MultiView>
        </div>
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="adım1" />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="adım2" />
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="adım3" />
    </form>
</body>
</html>
