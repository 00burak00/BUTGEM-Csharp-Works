using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_ders.Models
{
    public class Urun_db
    {
        public List<Urun> urunlerim;

        public Urun_db()
        {
            urunlerim = new List<Urun>
            {
             new Urun ()
             {
                 Urun_id =1,Urun_adi ="gigabyte",
                 Fiyat=600,Kate_id=1
             },
               new Urun ()
             {
                 Urun_id =2,Urun_adi ="msi",
                 Fiyat=400,Kate_id=1
             },
                 new Urun ()
             {
                 Urun_id =5,Urun_adi ="kinston",
                 Fiyat=40,Kate_id=2
             },
                new Urun ()
             {
                 Urun_id =9,Urun_adi ="oem",
                 Fiyat=30,Kate_id=2
             }
            };
               
        }
    }
}