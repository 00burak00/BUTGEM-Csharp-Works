using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_ders.Models;
namespace Mvc_ders.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Hakkimda()
        {
            return View();
        }

        public ActionResult viewbag_ornek()
        {
            List<int> sayilar = new List<int>();
            for (int i=0;i<=100;i++)
            {
                sayilar.Add(i);

            }
            ViewBag.sayilar = sayilar;
            return View();
        }

        public ActionResult link_ornek()
        {
            return View();
        }

        public ActionResult urungoster(int id)
        {
            List<string> anakartlar = new List<string>();
            anakartlar.Add("gigabyte,300 dolar");
            anakartlar.Add("msi ,250 dolar");
            List<String> ramlar = new List<string>()
            {
                "kingston 30 dolar","samsung 40 dolar"
            };

            if (id == 1) ViewBag.urunlerim = anakartlar;
            else ViewBag.urunlerim = ramlar;

            return View();
        }

        public ActionResult link_modelli()
        {
            return View();
        }

        public ActionResult urun_modelli_getir(int kate_id)
        {
            List<Urun> urunlerim = new List<Urun>();
            /* foreach (var gelenurun in new Urun_db().urunlerim)
             {
                 if (gelenurun.Kate_id ==kate_id)
                 {
                     urunlerim.Add(gelenurun);
                 }
             }*/
            urunlerim = new Urun_db().urunlerim.Where(x => x.Kate_id == kate_id).ToList();
            return View(urunlerim);
        }
    }
}