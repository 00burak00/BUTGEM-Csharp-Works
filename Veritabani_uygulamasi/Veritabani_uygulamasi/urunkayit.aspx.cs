using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Collections;
namespace Veritabani_uygulamasi
{
    public partial class urunkayit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack ==false)
            {
                ArrayList kategoriler = new Kategoriler_dao().tum_kategori_getir();
                int i = 1;
                foreach (Kategori k in kategoriler)
                {
                    kategori_listem.Items.Add(k.Kateadi);
                    kategori_listem.Items[i].Value = k.Kateno.ToString();
                    i++;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           string resimadi= resimekle();
            if (resimadi !="")
            {
                Kategori k = new Kategori(Convert.ToInt32(kategori_listem.SelectedValue), kategori_listem.SelectedItem.Text);
                Urun urunum = new Urun()
                {
                    Urunadi = urunadi_txt.Text,
                    Fiyat = Convert.ToDouble(fiyat_txt.Text),
                    Aciklama = aciklama_txt.Text,
                    Resim = resimadi,
                   Kateno =k
                    
                };
                int sayi = new Urundao().urun_kaydet(urunum);
                if (sayi > 0) Label1.Text="Ürün kayıt edilmiştir";
            }
        }

        public String resimekle()
        {

            string resimadi = "";
            try
            {
                String uzanti = Path.GetExtension(FileUpload1.FileName);
                if (uzanti == ".jpg" || uzanti == ".png" || uzanti == ".gif")
                {
                    int son_urun_no = new Urundao().son_urun_id_getir();
                    son_urun_no += 1;
                    resimadi = son_urun_no + uzanti;

                    FileUpload1.SaveAs(Server.MapPath("urun_resimleri/") + resimadi);
                    Image1.ImageUrl = "urun_resimleri/" + resimadi;
                }
                else
                {
                    Label1.Text = "Resim Dosyası seçiniz";
                }
            }
            catch (Exception)
            {
                resimadi = "";
            }

            return resimadi;
        }
    }
}