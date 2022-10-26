using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_ders.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string txtAd,string txtSoyad)
        {
            ViewBag.deger = txtAd + "--->" + txtSoyad;
            return View();
        }

        public ActionResult dort_islem()
        {
            return View();
        }

        [HttpPost]

        public ActionResult dort_islem(int sayi1,int sayi2,int islem)
        {
            double sonuc = 0;
            switch (islem)
            {
                case 1:
                    sonuc = sayi1 + sayi2;
                    break;   
                case 2:
                    sonuc = sayi1 - sayi2;
                    break; 
                case 3:
                    sonuc = sayi1 * sayi2;
                    break; 
                case 4:
                    sonuc = sayi1 * sayi2;
                    break;
            }
            ViewBag.sonuc = sonuc;
            return View();
        }

        public ActionResult deneme()
        {
            List<SelectListItem> degerler = new List<SelectListItem>();
            degerler.Add(new SelectListItem()
            {
                Text="bursa",Value ="16"
            });
            degerler.Add(new SelectListItem()
            {
                Text = "ankara",
                Value = "6"
            });

            ViewBag.degerler = degerler;
            return View();
        }

        public ActionResult kitle_endex()
        {
            doldur();
            return View();
        }

        [HttpPost]
        public ActionResult kitle_endex(int kilo,double boy)
        {
            string sonuc;
            var kitle = kilo / (boy * boy);
            if (kitle >= 0 && kitle <= 19) sonuc = "zayıf";
            else if (kitle >= 20 && kitle <= 25) sonuc = "normal";
            else if (kitle >= 26 && kitle <= 30) sonuc = "kilolu";
            else sonuc = "obez";
            ViewBag.sonuc = sonuc;
            doldur();
            return View();

        }

        void doldur()
        {
            List<SelectListItem> kilolar = new List<SelectListItem>();
            for (int i = 10; i <= 200; i++)
            {
                SelectListItem kilo = new SelectListItem()
                {
                    Text = i.ToString(),
                    Value = i.ToString()

                };
                kilolar.Add(kilo);
            }
            ViewBag.kilo = kilolar;
        }

    }
}