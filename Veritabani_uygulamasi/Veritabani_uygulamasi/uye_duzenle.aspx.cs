using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
namespace Veritabani_uygulamasi
{
    public partial class uye_duzenle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
            if (Page.IsPostBack == false)
            {
                bilgileri_yaz();
                ArrayList sehirler = new Sehirler_dao().tum_sehirleri_getir();
                int i = 1;
                foreach (Sehir sehir in sehirler)
                {
                    sehirlistesi.Items.Add(sehir.Sehiradi);
                    sehirlistesi.Items[i].Value = sehir.Plaka.ToString();
                    i++;
                }
                ArrayList meslekler = new Meslek_dao().tum_meslekleri_getir();
                int j = 1;
                foreach (Meslek meslek in meslekler)
                {
                    mesleklistesi.Items.Add(meslek.Meslekad);
                    mesleklistesi.Items[j].Value = meslek.Meslekid.ToString();
                    j++;
                }
            }
        }
        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (Radioerkek.Checked == false && Radiokadin.Checked == false)
                args.IsValid = false;
            else
                args.IsValid = true;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            dogtartxt.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid == true)
            {
                bool cinsiyet = false;//erkek
                if (Radiokadin.Checked == true) cinsiyet = true;

                int sayi = new Uyeler_dao().uye_guncelle(kuladitxt.Text, sifre1txt.Text,
                    adsoyadtxt.Text, Convert.ToDateTime(dogtartxt.Text), cinsiyet,
                    adrestxt.Text, Convert.ToInt32(sehirlistesi.SelectedValue),
                    emailtxt.Text, Convert.ToInt32(mesleklistesi.SelectedValue), ((Uye)Session["uyem"]).Uyeid);
                if (sayi > 0) 
                {
                    Response.Write("kayıt güncellendi");
                    Uye uyem = new Uyeler_dao().uye_giris_kontrol(kuladitxt.Text, sifre1txt.Text);
                    Session["uyem"] = uyem;
                }
                else if (sayi == -2)
                {
                    Response.Write("kayıt yapılamıyor aynı kullanıcı adı sistemde kayıtlı<br>");
                    Response.Write("Sizin için kullanıcı adı önerilermiz<br>");
                    Uyeler_dao.kullanici_adi_oner(kuladitxt.Text);
                    foreach (string oneri in Uyeler_dao.oneri_listesi)
                    {
                        Response.Write(oneri + "<br>");
                    }
                }
                else if (sayi == -1) Response.Write("kayıt yapılamıyor aynı email sistemde kayıtlı");
                else Response.Write("Bilinmeyen hata");
            }
        }
        public void bilgileri_yaz()
        {
            adsoyadtxt.Text = ((Uye)Session["uyem"]).Adsoyad;
            sifre1txt.Text = ((Uye)Session["uyem"]).Sifre;
            sifre2txt.Text = ((Uye)Session["uyem"]).Sifre;
            dogtartxt.Text = ((Uye)Session["uyem"]).Dogtar.ToShortDateString();
            adrestxt.Text = ((Uye)Session["uyem"]).Adres;
            kuladitxt.Text = ((Uye)Session["uyem"]).Kuladi;
            emailtxt.Text = ((Uye)Session["uyem"]).Email;
            if (((Uye)Session["uyem"]).Cinsiyet == true) Radiokadin.Checked = true;
            else Radioerkek.Checked = true;
            sehirlistesi.Items[0].Text = ((Uye)Session["uyem"]).Sehir.Sehiradi;
            sehirlistesi.Items[0].Value = ((Uye)Session["uyem"]).Sehir.Plaka.ToString();
            mesleklistesi.Items[0].Text = ((Uye)Session["uyem"]).Meslek.Meslekad;
            mesleklistesi.Items[0].Value = ((Uye)Session["uyem"]).Meslek.Meslekid.ToString();
        }
    }
}