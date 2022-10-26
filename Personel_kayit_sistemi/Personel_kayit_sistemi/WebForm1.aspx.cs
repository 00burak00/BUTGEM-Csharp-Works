using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;
namespace Personel_kayit_sistemi
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int per_sayisi = Convert.ToInt32(Interaction.InputBox("Personel sayisi gir", "", "", -1, -1));
            Personel[] personel_vt = new Personel[per_sayisi];
            int sayac = 0;
            for (int i=0;i<per_sayisi;i++)
            {
                Personel yeni_per = new Personel();
                yeni_per.Sgkno = Convert.ToInt32(Interaction.InputBox("sgkno gir", "", "", -1, -1));
                yeni_per.Ad_soyad= Interaction.InputBox("Personel adı gir", "", "", -1, -1);
                yeni_per.Kidem_yili= Convert.ToInt32(Interaction.InputBox("kidem yili gir", "", "", -1, -1));
                Adres adr = new Adres();
                adr.Ilce= Interaction.InputBox("ilçe gir", "", "", -1, -1);
                adr.Mahalle= Interaction.InputBox("mahalle gir", "", "", -1, -1);
                Bolum bol = new Bolum();
                bol.Bol_adi= Interaction.InputBox("bolum adı gir", "", "", -1, -1);
                yeni_per.Adres = adr;
                yeni_per.Bolum = bol;
                personel_vt[i] = yeni_per;
                int cvp = Convert.ToInt32(Interaction.MsgBox("Devam edecekmisiniz?", MsgBoxStyle.YesNo));
                if (cvp == 7)
                {
                    sayac = i + 1;
                    break;
                }
            }//for
            Array.Resize(ref personel_vt, sayac);

            byte secim = Convert.ToByte(Interaction.InputBox("1 - tüm personel 2 - sgkno ara 3 - enb enk maaş", "", "", -1, -1));
            switch (secim)
            {

                case 1:
                    foreach(Personel gelen_personel in personel_vt)
                    ListBox1.Items.Add(gelen_personel.personel_bilgisi());
                    break;
                case 2:
                    int aranan_sgk = Convert.ToByte(Interaction.InputBox("aranan sgk no gir", "", "", -1, -1));
                    foreach (Personel gelen_personel in personel_vt)
                    {
                        if (gelen_personel.Sgkno ==aranan_sgk)
                            ListBox1.Items.Add(gelen_personel.personel_bilgisi());
                    }
                    break;
                case 3:
                    Personel enb = personel_vt[0], enk = personel_vt[0];
                    foreach (Personel gelen_personel in personel_vt)
                    {
                        if (enb.Maas < gelen_personel.Maas) enb = gelen_personel;
                        if (enk.Maas > gelen_personel.Maas) enk = gelen_personel;
                    }
                    ListBox1.Items.Add("En büyük maaaşlı personel=" + enb.personel_bilgisi());
                    ListBox1.Items.Add("En küçük maaaşlı personel=" + enk.personel_bilgisi());
                    break;
            }
        }
    }
}