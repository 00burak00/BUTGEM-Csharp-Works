using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_ders.Models
{
    public class Urun
    {
        private int urun_id;
        private string  urun_adi;
        private double fiyat;
        private int kate_id;

        public int Urun_id { get => urun_id; set => urun_id = value; }
        public string Urun_adi { get => urun_adi; set => urun_adi = value; }
        public double Fiyat { get => fiyat; set => fiyat = value; }
        public int Kate_id { get => kate_id; set => kate_id = value; }
    }
}