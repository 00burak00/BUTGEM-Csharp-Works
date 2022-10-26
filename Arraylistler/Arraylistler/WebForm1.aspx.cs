using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using Microsoft.VisualBasic;
namespace Arraylistler
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             ArrayList isimler = new ArrayList();
             isimler.Add("kamil");
             isimler.Add("osman");
             isimler.Add("ayşe");
             isimler.Add("fatma");
             //Response.Write(isimler[3]);
             foreach (String gelen in isimler)
             {
                 Response.Write(gelen);
             }

            int x=isimler.Count;//eleman sayısı
            isimler.Clear();//siler
            isimler.IndexOf("yunus");//-1 döndürür yoksa,varsa earraylist içerisindeki yeri index no
            isimler.Remove("kamil");//sadece o elemanı siler
            isimler.RemoveAt(2);//2 index nolu yani ayşe silinir
            isimler.Sort();//sıralar 



           /* ArrayList listem = new ArrayList();
            listem.Add("tuncay");
            listem.Add(25);
            listem.Add(true);
            Insan i1 = new Insan();
            i1.adi = "ismail";
            i1.boy = 180;
            listem.Add(i1);
            foreach (object gelen in listem)
            {

            }*/

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ArrayList ogrenci_listem = new ArrayList();
            while (true)
            {
                Ogrenci yeni_ogr = new Ogrenci()
                {
                    Ogno = Convert.ToInt32(Interaction.InputBox("no gir", "", "", -1, -1)),
                    Ad_soyad = Interaction.InputBox("ad soyad gir", "", "", -1, -1),
                };
                ogrenci_listem.Add(yeni_ogr);
                MsgBoxResult x = Interaction.MsgBox("Devam edecekmisiniz?", MsgBoxStyle.YesNo);
                if (x == MsgBoxResult.No) break;
            }//while
            foreach (Ogrenci gelen_ogr in ogrenci_listem )
            {
                ListBox1.Items.Add(gelen_ogr.ToString());
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SortedList ogrenci_listem = new SortedList();
            while (true)
            {
                Ogrenci yeni_ogr = new Ogrenci()
                {
                    Ogno = Convert.ToInt32(Interaction.InputBox("no gir", "", "", -1, -1)),
                    Ad_soyad = Interaction.InputBox("ad soyad gir", "", "", -1, -1),
                };
                ogrenci_listem.Add(yeni_ogr.Ogno, yeni_ogr);
                MsgBoxResult x = Interaction.MsgBox("Devam edecekmisiniz?", MsgBoxStyle.YesNo);
                if (x == MsgBoxResult.No) break;

            }//while

            foreach (DictionaryEntry gelen in ogrenci_listem)
            {
                ListBox1.Items.Add(((int)gelen.Key).ToString() + ((Ogrenci)gelen.Value).ToString());
            }

            }
    }
}