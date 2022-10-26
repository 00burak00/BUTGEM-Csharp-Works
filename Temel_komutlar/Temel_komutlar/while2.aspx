<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="while2.aspx.cs" Inherits="Temel_komutlar.while2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Kelime Giriniz:<asp:TextBox ID="kelime_txt" runat="server"></asp:TextBox>
            <br />
            Kaç kez:<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
