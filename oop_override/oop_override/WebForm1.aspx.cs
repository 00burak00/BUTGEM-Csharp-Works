using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace oop_override
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Kedi cat = new Kedi();
            Response.Write(cat.sescikar());
            Kopek dog = new Kopek();
            Response.Write(dog.sescikar());
            Hayvan h1 = new Kopek();
            Response.Write(h1.sescikar());
          
        
        }
    }
}