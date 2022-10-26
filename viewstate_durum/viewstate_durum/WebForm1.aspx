<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" EnableViewState="false" Inherits="viewstate_durum.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="0">Seçiniz</asp:ListItem>
            <asp:ListItem Value="16">Bursa</asp:ListItem>
            <asp:ListItem Value="6">Ankara</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="264px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="447px" EnableViewState="False"></asp:ListBox>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="uyeid" DataSourceID="SqlDataSource1" EnableViewState="False" Height="156px" Width="734px">
            <Columns>
                <asp:BoundField DataField="uyeid" HeaderText="uyeid" InsertVisible="False" ReadOnly="True" SortExpression="uyeid" />
                <asp:BoundField DataField="kuladi" HeaderText="kuladi" SortExpression="kuladi" />
                <asp:BoundField DataField="sifre" HeaderText="sifre" SortExpression="sifre" />
                <asp:BoundField DataField="adsoyad" HeaderText="adsoyad" SortExpression="adsoyad" />
                <asp:BoundField DataField="dogtar" HeaderText="dogtar" SortExpression="dogtar" />
                <asp:CheckBoxField DataField="cinsiyet" HeaderText="cinsiyet" SortExpression="cinsiyet" />
                <asp:BoundField DataField="adres" HeaderText="adres" SortExpression="adres" />
                <asp:BoundField DataField="plaka" HeaderText="plaka" SortExpression="plaka" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                <asp:BoundField DataField="meslekid" HeaderText="meslekid" SortExpression="meslekid" />
                <asp:CheckBoxField DataField="onay" HeaderText="onay" SortExpression="onay" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [uyeler]"></asp:SqlDataSource>
    </form>
</body>
</html>
