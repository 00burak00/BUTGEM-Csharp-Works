using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eticaret_mvc.Models;
namespace Eticaret_mvc.Controllers
{
    public class SepetController : Controller
    {
        Eticaret_vtEntities db = new Eticaret_vtEntities();

        public Sepet Sepeti_getir()
        {
            var sepetimiz =(Sepet)Session["sepet"];

            if (sepetimiz==null)
            {
                sepetimiz = new Sepet();
                Session["sepet"] = sepetimiz;
            }
            return sepetimiz;
        }

        // GET: Sepet
        public ActionResult Sepeti_goster()
        {
            return View(Sepeti_getir());
        }

        public ActionResult sepete_Ekle(int? urun_id,int? adet)
        {
          var _adet=  adet ?? 0;//linkle gelirsek adet gelmiyor null
          var urun=  db.urunler.FirstOrDefault(x => x.urunid == urun_id);
            if (urun!=null )
            {
                Sepeti_getir().Sepete_ekle(urun, _adet);
            }
            return RedirectToAction("Sepeti_goster");
        }
        public ActionResult sepetten_sil(int? urunid)
        {
            var silinecek_urun = db.urunler.FirstOrDefault(x => x.urunid == urunid);
            if (silinecek_urun!=null)
            {
                Sepeti_getir().Sepetten_sil(silinecek_urun);
            }
            return RedirectToAction("sepeti_goster");
        }
    }
}