using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;
namespace Veritabani_uygulamasi
{
    public partial class uye_raporum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new Uyeler_dao().uye_raporla();
            ReportDocument raporum = new ReportDocument();
            raporum.Load(Server.MapPath("uyeler.rpt"));
            raporum.SetDataSource(ds);
            rapor_gosterici.ReportSource = raporum;

    
        }
    }
}