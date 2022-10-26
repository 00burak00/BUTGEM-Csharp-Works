<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Siparis_raporum.aspx.cs" Inherits="Veritabani_uygulamasi.Siparis_raporum" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <CR:CrystalReportViewer ID="raporgosterici" runat="server" AutoDataBind="true"  />
    </form>
    <script src="js/bootstrap.bundle.js"></script>
</body>
</html>
