<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Arraylistler.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Öğrenci liste" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Sorted list" />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="359px" Width="447px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
