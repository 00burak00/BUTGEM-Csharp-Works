using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;
using System.Web.UI.WebControls;

namespace Veritabani_uygulamasi
{
    public partial class Siparis_raporum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new Siparis_dao().siparis_raporu();
          
                foreach (DataRow satir in ds.Tables["siparis_tablosu"].Rows)
                {
                try
                {
                    byte[] rapor_resmi;
                    rapor_resmi = File.ReadAllBytes(Server.MapPath("urun_resimleri/") + satir["resim"]);
                    satir["rapor_resmi"] = rapor_resmi;
                }
                catch (FileNotFoundException) { }

                }
          

            ReportDocument raporum = new ReportDocument();
            raporum.Load(Server.MapPath("siparis_raporu.rpt"));
            raporum.SetDataSource(ds);
            raporgosterici.ReportSource = raporum;
        }
    }
}