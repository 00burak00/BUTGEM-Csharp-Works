<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Ziyaretci.Master" CodeBehind="uye_kayit.aspx.cs" Inherits="Veritabani_uygulamasi.uye_kayit" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
             <table class="auto-style1">
                <tr>
                    <td class="text-start">Kullanıcı Adı:</td>
                    <td class="text-start">
                        <asp:TextBox ID="kuladitxt" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style10">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="kuladitxt" ErrorMessage="Kulllanici Adı Boş olamaz" Font-Bold="True" ForeColor="Red" ValidationGroup="kayit">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="text-start">Şifre:</td>
                    <td class="text-start">
                        <asp:TextBox ID="sifre1txt" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style11">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="sifre1txt" ErrorMessage="Şifre Boş olamaz" Font-Bold="True" ForeColor="Red" ValidationGroup="kayit">*</asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="sifre2txt" ControlToValidate="sifre1txt" ErrorMessage="Şifreler Aynı Değil" Font-Bold="True" ForeColor="Red" ValidationGroup="kayit">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="text-start">Şifre Tekar:</td>
                    <td class="text-start">
                        <asp:TextBox ID="sifre2txt" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style14"></td>
                </tr>
                <tr>
                    <td class="text-start">Ad Soyad:</td>
                    <td class="text-start">
                        <asp:TextBox ID="adsoyadtxt" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style10">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="adsoyadtxt" ErrorMessage="Ad Soyad Boş Geçilemez" Font-Bold="True" ForeColor="Red" ValidationGroup="kayit">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="text-start">Doğum Tarihi:</td>
                    <td class="text-start">
                        <asp:TextBox ID="dogtartxt" runat="server"></asp:TextBox>
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="25px" ImageUrl="~/img/th259JIQAI.jpg" OnClick="ImageButton1_Click" Width="38px" />
                        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Visible="False" Width="200px" OnSelectionChanged="Calendar1_SelectionChanged">
                            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                            <NextPrevStyle VerticalAlign="Bottom" />
                            <OtherMonthDayStyle ForeColor="#808080" />
                            <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                            <SelectorStyle BackColor="#CCCCCC" />
                            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                            <WeekendDayStyle BackColor="#FFFFCC" />
                        </asp:Calendar>
                    </td>
                    <td class="auto-style19">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="dogtartxt" ErrorMessage="Doğum Tarihi Gerekli" Font-Bold="True" ForeColor="Red" ValidationGroup="kayit">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                   <tr>
                    <td class="text-start">Cinsiyet:</td>
                    <td class="text-start">
                        <asp:RadioButton ID="Radiokadin" runat="server" GroupName="cins" Text="Kadın" />
                        <asp:RadioButton ID="Radioerkek" runat="server" GroupName="cins" Text="Erkek" />
                       </td>
                    <td class="auto-style22">
                        <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Cinsiyet Seçmelisiniz" Font-Bold="True" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate" ValidationGroup="kayit">*</asp:CustomValidator>
                       </td>
                </tr>
                   <tr>
                    <td class="text-start">Adres:</td>
                    <td class="text-start">
                        <asp:TextBox ID="adrestxt" runat="server" Height="80px" TextMode="MultiLine" Width="290px"></asp:TextBox>
                       </td>
                    <td class="auto-style19">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="adrestxt" ErrorMessage="Adres Boş olamaz" Font-Bold="True" ForeColor="Red" ValidationGroup="kayit">*</asp:RequiredFieldValidator>
                       </td>
                </tr>
                   <tr>
                    <td class="text-start">Şehir:</td>
                    <td class="text-start">
                        <asp:DropDownList ID="sehirlistesi" runat="server">
                            <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                        </asp:DropDownList>
                       </td>
                    <td class="auto-style10">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="sehirlistesi" ErrorMessage="Şehir Seçilmeli" Font-Bold="True" ForeColor="Red" InitialValue="0" ValidationGroup="kayit">*</asp:RequiredFieldValidator>
                       </td>
                </tr>
                   <tr>
                    <td class="text-start">Email:</td>
                    <td class="text-start">
                        <asp:TextBox ID="emailtxt" runat="server"></asp:TextBox>
                       </td>
                    <td class="auto-style25">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="emailtxt" ErrorMessage="Email zorunlu" Font-Bold="True" ForeColor="Red" ValidationGroup="kayit">*</asp:RequiredFieldValidator>
                       </td>
                </tr>
                   <tr>
                    <td class="text-start">Meslek:</td>
                    <td class="text-start">
                        <asp:DropDownList ID="mesleklistesi" runat="server">
                            <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                        </asp:DropDownList>
                       </td>
                    <td class="auto-style32">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="mesleklistesi" ErrorMessage="Meslek Zorunlu" ForeColor="Red" InitialValue="0" ValidationGroup="kayit">*</asp:RequiredFieldValidator>
                       </td>
                </tr>
                   <tr>
                    <td colspan="3"><center>
                        <asp:Button ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click" ValidationGroup="kayit" CssClass ="form-control btn-success" Width="205px" />
                       </td></center>
                </tr>
                   <tr>
                    <td colspan="3">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="SingleParagraph" ValidationGroup="kayit" />
                       </td>
                </tr>
            </table>




        </div>
    </asp:Content>