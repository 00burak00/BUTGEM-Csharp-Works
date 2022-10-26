using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eticaret_mvc.Models
{
    public class Sepet
    {
        private List<Sepetlik> _sepetim = new List<Sepetlik>();
        public List<Sepetlik> Sepetim
        { get => _sepetim; }

        public void Sepete_ekle(urunler urun,int adet)
        {
          var sepetteki_urun=_sepetim.FirstOrDefault(x => x.urun.urunid == urun.urunid);
            if (sepetteki_urun == null)
            {
                _sepetim.Add(new Sepetlik { urun = urun, adet = 1 });
            }
            else if (adet == 0) sepetteki_urun.adet += 1;//linkle ekleniyor
            else sepetteki_urun.adet = adet;//sepet adet formdan gelen
        }

        public void Sepetten_sil(urunler urun)
        {
            _sepetim.RemoveAll(x => x.urun.urunid == urun.urunid);
        }

        public double sepet_toplami()
        {
           return(_sepetim.Sum(x => x.urun.fiyat * x.adet));
        }

        public void sepeti_temizle()
        {
            _sepetim.Clear();
        }
    }
}