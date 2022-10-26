using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Request_nesnesi
{
    public partial class Araba_model : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] alfalar = { "147", "mito", "gulietta", "stello" };
            string[] renolar= { "megane", "clio", "captur", "talisman" };
            string[] fiatlar= { "egea", "doblo", "doğan slx", "tempra" };
            byte id = Convert.ToByte( Request.QueryString["id"]);
            switch (id)
            {
                case 1:
                    listeyaz(alfalar);
                    break;
                case 2:
                    listeyaz(renolar);
                    break;
                case 3:
                    listeyaz(fiatlar);
                    break;
            }//switch
        }//click
        void listeyaz(string[] marka)
        {
            foreach (string x in marka)
            {
                ListBox1.Items.Add(x);
            }
        }
    }
}