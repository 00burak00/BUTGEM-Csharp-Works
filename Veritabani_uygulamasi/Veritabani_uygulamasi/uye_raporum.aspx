<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="uye_raporum.aspx.cs" Inherits="Veritabani_uygulamasi.uye_raporum" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <CR:CrystalReportViewer ID="rapor_gosterici" runat="server" AutoDataBind="true" />
        </div>
    </form>
</body>
</html>
