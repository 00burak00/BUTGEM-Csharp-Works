using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eticaret_mvc.Models;
namespace Eticaret_mvc.Controllers
{
    public class HomeController : Controller
    {
        Eticaret_vtEntities db = new Eticaret_vtEntities();

        public ActionResult Index()
        {
            ViewBag.Title = "Ana Sayfa";
            return View();
        }

        public ActionResult kategori_doldur()
        {
            return PartialView(db.kategoriler.ToList());
        }
      
        public ActionResult login_giris(uyeler uyem)
        {
            Session["kulkontrol"] = null;
            var uye = db.uyeler.FirstOrDefault(x => x.kuladi == uyem.kuladi && x.sifre == uyem.sifre);
           
            if(uye==null)
            Session["kulkontrol"] = "Yanlış kullanıcı adı veya Şifre";
            else
            Session["uyem"] = uye;
            return RedirectToAction("index");
        }

        public ActionResult guv_cikis()
        {
            Session.RemoveAll();
            Session.Abandon();
            return RedirectToAction("index");
        }
    }
}