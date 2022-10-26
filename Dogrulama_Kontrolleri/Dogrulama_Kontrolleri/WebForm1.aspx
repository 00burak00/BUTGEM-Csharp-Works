<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Dogrulama_Kontrolleri.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ad Soyad Giriniz:<asp:TextBox ID="ad_soyad_txt" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ad_soyad_txt" ErrorMessage="Ad Soyad Boş geçilemez" Font-Bold="True" ForeColor="Red" ValidationGroup="kayit">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Şehir Seçiniz:<asp:DropDownList ID="sehir_listesi" runat="server">
                <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                <asp:ListItem Value="16">Bursa</asp:ListItem>
                <asp:ListItem Value="6">Ankara</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="sehir_listesi" ErrorMessage="Şehir seçmek zorunlu" Font-Bold="True" ForeColor="Red" InitialValue="0" ValidationGroup="kayit">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Yaşınızı giriniz:<asp:TextBox ID="yas_txt" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="yas_txt" ErrorMessage="Yaş boş olamaz" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" ValidationGroup="kayit">*</asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="yas_txt" ErrorMessage="Yaşınız 18 ile 50 arasında olmalı" Font-Bold="True" ForeColor="Red" MaximumValue="50" MinimumValue="18" Type="Integer" ValidationGroup="kayit">*</asp:RangeValidator>
            <br />
            <br />
            Şifre Giriniz:<asp:TextBox ID="sifre1_txt" runat="server" Width="165px"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="sifre2_txt" ControlToValidate="sifre1_txt" ErrorMessage="Şifreler uyuşmuyor" Font-Bold="True" ForeColor="Red" ValidationGroup="kayit">*</asp:CompareValidator>
            <br />
            Şifre tekrar :<asp:TextBox ID="sifre2_txt" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Şifremiz en az 8 karakter olmalı" Font-Bold="True" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate" ValidationGroup="kayit">*</asp:CustomValidator>
            <br />
            <br />
            Doğum tarihi Giriniz:<asp:TextBox ID="dogtar_txt" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="dogtar_txt" ErrorMessage="TARİH BOŞ OLAMAZ" Font-Bold="True" ForeColor="Red" ValidationGroup="kayit">*</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="dogtar_txt" ErrorMessage="Tarihsel değer girilmeli" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="takvim resmi" />
            <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" OnSelectionChanged="Calendar1_SelectionChanged" ShowGridLines="True" Visible="False" Width="220px">
                <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                <OtherMonthDayStyle ForeColor="#CC9966" />
                <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                <SelectorStyle BackColor="#FFCC66" />
                <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
            </asp:Calendar>
            <br />
            Email :<asp:TextBox ID="email_txt" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="email_txt" ErrorMessage="Doğru bir email formatı girin" Font-Bold="True" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Gönder" ValidationGroup="kayit" />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ShowSummary="False" ValidationGroup="kayit" Width="364px" />
        </div>
    </form>
</body>
</html>
