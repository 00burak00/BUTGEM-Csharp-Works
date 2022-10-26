using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model_first.Models;
namespace Model_first.Controllers
{
    public class HastalarController : Controller
    {
        Hastane_modelContainer db = new Hastane_modelContainer();
        // GET: Hastalar
        public ActionResult Create()
        {
        
            return View();
        }
        [HttpPost]
        public ActionResult Create(Hastalar hasta)
        {
            db.Hastalar.Add(hasta);
            db.SaveChanges();
            return View();
        }

    }
}