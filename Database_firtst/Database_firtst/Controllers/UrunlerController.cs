using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Database_firtst.Models;
namespace Database_firtst.Controllers
{
    public class UrunlerController : Controller
    {
        Eticaret_vtEntities db = new Eticaret_vtEntities();

        // GET: Urunler
        public ActionResult urunleri_goster()
        {
            var urunlerim = db.urunler.ToList();
            return View(urunlerim);
        }
    }
}