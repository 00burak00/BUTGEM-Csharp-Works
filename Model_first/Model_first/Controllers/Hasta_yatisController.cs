using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model_first.Models;
namespace Model_first.Controllers
{
    public class Hasta_yatisController : Controller
    {
        Hastane_modelContainer db = new Hastane_modelContainer();
        // GET: Hasta_yatis
     public ActionResult yatis_raporu()
        {
            var hasta_yatislar = db.Hasta_yatis.ToList();
            return View(hasta_yatislar);
        }

    }
}