using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_ders.Models;
namespace Mvc_ders.Controllers
{
    public class UrunlerController : Controller
    {
        // GET: Urunler
        public ActionResult urunislemleri()
        {
           List<Urun> urunlerim= new Urun_db().urunlerim;
            return View(urunlerim);
        }
        [HttpPost]
        public ActionResult urunislemleri(Urun urunum,string islem)
        {
            List<Urun> urunlerim;
            List<Urun> arama_listesi=null;
            if (Session["urunlerim"] != null) urunlerim = (List<Urun>) Session["urunlerim"];
                else urunlerim = new Urun_db().urunlerim;

            if (islem.Equals("Kaydet"))
            {
                urunlerim.Add(urunum);
            }
            else if (islem.Equals("Sil"))
            {
              Urun silinecek_urun= urunlerim.Where(x => x.Urun_id == urunum.Urun_id).First();
                urunlerim.Remove(silinecek_urun);
            }
            else if (islem.Equals("Ara"))
            {
                arama_listesi = urunlerim.Where(x => x.Urun_id == urunum.Urun_id).ToList();
            }
            else if (islem.Equals("Güncelle"))
            {
               int yer_index= urunlerim.FindIndex(x => x.Urun_id == urunum.Urun_id);
                urunlerim[yer_index] = urunum;
            }

            Session["urunlerim"] = urunlerim;
            if (islem.Equals("Ara")) return View(arama_listesi);
           else return View(urunlerim);
        }
       
      
    }
}