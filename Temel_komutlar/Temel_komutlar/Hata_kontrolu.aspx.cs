using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Temel_komutlar
{
    public partial class Hata_kontrolu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int s1 = Convert.ToInt32(sayi1_txt.Text);
                int s2 = Convert.ToInt32(sayi2_txt.Text);
                String islem = islem_txt.Text;
                int sonuc = 0;
                switch (islem)
                {
                    case "+":
                        sonuc = s1 + s2;
                        break;
                    case "-":
                        sonuc = s1 - s2;
                        break;
                    case "*":
                        sonuc = s1 * s2;
                        break;
                    case "/":
                        sonuc = s1 / s2;
                        break;
                    default:
                        throw new InvalidOperationException();
                        break;
                            
                }//switch
                sonuc_lbl.Text = sonuc.ToString();
            }//try
            
            catch (Exception hata)
            {
                if(hata is FormatException) sonuc_lbl.Text = "sayı kutularına sadece rakam giriniz";
                else if(hata is DivideByZeroException) sonuc_lbl.Text = "sıfıra bölme hatası";
                else if(hata is OverflowException ) sonuc_lbl.Text = "çok büyük sayı girildi";
                else if (hata is InvalidOperationException) sonuc_lbl.Text = "geçersiz bir işlem";
                else sonuc_lbl.Text = "bİLİNMEYEN HATA ..yazılımcıyı ara";
            }
            finally
            {
                //en son hata oluşsa dahi  çalışmasını istediğimiz komutlar buraya
            }
           /* catch (FormatException)
            {
                sonuc_lbl.Text = "sayı kutularına sadece rakam giriniz";
            }
            catch (DivideByZeroException)
            {
                sonuc_lbl.Text = "sıfıra bölme hatası";
            }
            catch (OverflowException)
            {
                sonuc_lbl.Text = "çok büyük sayı girildi";
            }
            catch (InvalidOperationException)
            {
                sonuc_lbl.Text = "geçersiz bir işlem";
            }
            catch (Exception)
            {
                sonuc_lbl.Text = "bİLİNMEYEN HATA ..yazılımcıyı ara";
            }*/

        }
    }
}