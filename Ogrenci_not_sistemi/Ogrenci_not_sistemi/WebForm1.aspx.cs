using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;
namespace Ogrenci_not_sistemi
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int mevcud = Convert.ToInt32(Interaction.InputBox("kaç öğrenci girilecek", "", "", -1, -1));
            Ogrenci[] ogrenci_listem = new Ogrenci[mevcud];
            int s = 0;
            for (int i=0;i<=mevcud;i++)
            {
                Ogrenci ogr = new Ogrenci();
                ogr.Ogno = Convert.ToInt32(Interaction.InputBox("öğrenci no", "", "", -1, -1));
                ogr.Ad_soyad = Interaction.InputBox("adres", "", "", -1, -1);
                ogr.Not1=Convert.ToInt32(Interaction.InputBox("not1", "", "", -1, -1));
                ogr.Not2 = Convert.ToInt32(Interaction.InputBox("not 2", "", "", -1, -1));
                ogrenci_listem[i] = ogr;
                s++;
                byte cvp = Convert.ToByte(Interaction.MsgBox("devam edecekmisiniz?", MsgBoxStyle.YesNo));
                if (cvp == 7) break;
                 
            }

            Array.Resize(ref ogrenci_listem, s);
            foreach (Ogrenci gelen_ogr in ogrenci_listem)
            {
              
                ListBox1.Items.Add(gelen_ogr.ogrenci_bilgisi());
            }
        
            int ogno_aranan= Convert.ToInt32(Interaction.InputBox("Aranan no", "", "", -1, -1));
            foreach (Ogrenci gelen_ogr in ogrenci_listem)
            {      
                    if (gelen_ogr.Ogno == ogno_aranan)
                    {
                        ListBox2.Items.Add(gelen_ogr.ogrenci_bilgisi());
                        break;
                    } 
            }
        }
    }
}