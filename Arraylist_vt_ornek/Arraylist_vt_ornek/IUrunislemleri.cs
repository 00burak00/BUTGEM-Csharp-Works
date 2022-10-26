using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Arraylist_vt_ornek
{
    public interface IUrunislemleri
    {
        ArrayList urunlerigetir();
        void Urun_kaydet(Urun yeniurun);
        bool Urun_sil(int urunid);
        Urun urunbul(int urunid);
    }
}
