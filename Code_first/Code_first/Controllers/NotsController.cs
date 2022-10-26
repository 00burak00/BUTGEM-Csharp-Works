using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Code_first.Models;

namespace Code_first.Controllers
{
    public class NotsController : Controller
    {
        private Okul db = new Okul();

        // GET: Nots
        public ActionResult Index()
        {
            var notlar = db.notlar.Include(n => n.Ders).Include(n => n.ogrenci);
            return View(notlar.ToList());
        }

        // GET: Nots/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Not not = db.notlar.Find(id);
            if (not == null)
            {
                return HttpNotFound();
            }
            
            return View(not);
        }

        // GET: Nots/Create
        public ActionResult Create()
        {
            ViewBag.Ders_no = new SelectList(db.dersler, "Ders_no", "ders_adi");
            ViewBag.ogno = new SelectList(db.ogrenciler, "ogno", "ad_soyad");
            return View();
        }

        // POST: Nots/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,ogno,Ders_no,yaz1,yaz2")] Not not)
        {
            if (ModelState.IsValid)
            {
                db.notlar.Add(not);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Ders_no = new SelectList(db.dersler, "Ders_no", "ders_adi", not.Ders_no);
            ViewBag.ogno = new SelectList(db.ogrenciler, "ogno", "ad_soyad", not.ogno);
            return View(not);
        }

        // GET: Nots/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Not not = db.notlar.Find(id);
            if (not == null)
            {
                return HttpNotFound();
            }
            ViewBag.Ders_no = new SelectList(db.dersler, "Ders_no", "ders_adi", not.Ders_no);
            ViewBag.ogno = new SelectList(db.ogrenciler, "ogno", "ad_soyad", not.ogno);
            return View(not);
        }

        // POST: Nots/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,ogno,Ders_no,yaz1,yaz2")] Not not)
        {
            if (ModelState.IsValid)
            {
                db.Entry(not).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Ders_no = new SelectList(db.dersler, "Ders_no", "ders_adi", not.Ders_no);
            ViewBag.ogno = new SelectList(db.ogrenciler, "ogno", "ad_soyad", not.ogno);
            return View(not);
        }

        // GET: Nots/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Not not = db.notlar.Find(id);
            if (not == null)
            {
                return HttpNotFound();
            }
            return View(not);
        }

        // POST: Nots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Not not = db.notlar.Find(id);
            db.notlar.Remove(not);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult ogrenciye_gore_not_getir()
        {
            var notlar = db.notlar.Include(n => n.Ders).Include(n => n.ogrenci);
            ViewBag.ogno = new SelectList(db.ogrenciler, "ogno", "ad_soyad");
            return View(notlar);
        }

        [HttpPost]
        public ActionResult ogrenciye_gore_not_getir(int? ogno)
        {
            IEnumerable<Not> notlar;
            if (ogno == null)
                notlar = db.notlar.Include(n => n.Ders).Include(n => n.ogrenci);
            else
                notlar =db.notlar.Include(n => n.Ders).Include(n => n.ogrenci).Where(x => x.ogno == ogno);
            ViewBag.ogno = new SelectList(db.ogrenciler, "ogno", "ad_soyad");
            return View(notlar);
        }
        }
}
