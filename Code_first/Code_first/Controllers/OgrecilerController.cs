using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Code_first.Models;
namespace Code_first.Controllers
{
    public class OgrecilerController : Controller
    {
        Okul db = new Okul();
        // GET: Ogreciler
        public ActionResult tum_ogrenciler()
        {
            var ogrencilerim = db.ogrenciler.ToList();
            return View(ogrencilerim);
        }

        [HttpPost]
        public ActionResult tum_ogrenciler(IEnumerable<int> idler)
        {
            db.ogrenciler.Where(x =>idler.Contains(x.ogno)).ToList().ForEach(n => db.ogrenciler.Remove(n));
            db.SaveChanges();
            var ogrencilerim = db.ogrenciler.ToList();
            return View(ogrencilerim);
      
        }
        public ActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Create(Ogrenci ogrenci)
        {
            if (ModelState.IsValid == true)
            {
                try
                {
                    db.ogrenciler.Add(ogrenci);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    ViewBag.tc_hatasi = "Aynı Tc kimlikten var";
                }
            }

            return View();
        }

        public ActionResult ogrenci_sil(int id)
        {
           var ogrenci= db.ogrenciler.Find(id);
            db.ogrenciler.Remove(ogrenci);
            db.SaveChanges();
            return RedirectToAction("tum_ogrenciler");
        }

        public ActionResult Edit(int id)
        {
            var ogrenci = db.ogrenciler.Find(id);
            return View(ogrenci);
        }
        [HttpPost]
        public ActionResult Edit(Ogrenci ogrenci)
        {
            if (ModelState.IsValid == true)
            {
                try
                {
                    db.Entry(ogrenci).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("tum_ogrenciler");
                }
                catch
                {
                    ViewBag.tc_hatasi = "Aynı tc kimlik nurmalı ogrenci var";
                }
            }
            return View();
        }
    }
}