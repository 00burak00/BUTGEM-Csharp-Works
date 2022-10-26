using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eticaret_mvc.Models;
using System.IO;
using PagedList;
namespace Eticaret_mvc.Controllers
{
    public class UrunlerController : Controller
    {
        Eticaret_vtEntities db = new Eticaret_vtEntities();


        public ActionResult urun_goster(int id,int? sayfano)
        {
            var _sayfano = sayfano ?? 1;
     var urunlerim = db.urunler.Where(x => x.kateno == id).ToList().ToPagedList(_sayfano,3);
            return View(urunlerim);
        }


        // GET: Urunler
        public ActionResult Urun_kaydet()
        {
            ViewBag.kateno = new SelectList (db.kategoriler,"kateno","kateadi" );
            return View();
        }

        [HttpPost]
        public ActionResult Urun_kaydet(urunler urunum,HttpPostedFileBase file)
        {
            try
            {
                string file_name = "null.jpg";
             
                if (file.ContentLength>0)
                {
                    file_name = Path.GetFileName(file.FileName);
                    string yol = Path.Combine(Server.MapPath("~/urun_resimleri") , file_name);
                    file.SaveAs(yol);
                }
                urunum.resim = file_name;
                db.urunler.Add(urunum);
                db.SaveChanges();
                ViewBag.mesaj = "Resim yüklendi.Vt ye kayıt yapıldı";
           }
           catch(Exception)
            {
                ViewBag.mesaj = "sorun var.Tekrar deneyin";
            }

            ViewBag.kateno = new SelectList(db.kategoriler, "kateno", "kateadi");
            return View();
        }
    }
}