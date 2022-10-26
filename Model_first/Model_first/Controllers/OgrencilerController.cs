using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model_first.Models;
namespace Model_first.Controllers
{
    public class OgrencilerController : Controller
    {
        Model1Container db = new Model1Container();

        // GET: Ogrenciler
       public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Ogrenciler ogrenciler)
        {
            db.Ogrenciler.Add(ogrenciler);
            db.SaveChanges();
            return View();
        }
    }
}