using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsol_uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            //bu bizim ilk örneğimiz olacak
            /*
             * açıklamalar
             * 
             * 
             */

            /* Console.WriteLine("merhaba dünya");
             Console.ReadKey();*/
            /*int sayi1 = 25;
            string ad_soyad;
 
            Console.WriteLine(sayi1);
            ad_soyad = "ismail";
            Console.WriteLine(ad_soyad);
            Console.ReadKey();*/
            Console.WriteLine("1. sayıyı giriniz");
            int sayi1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz");
            int sayi2;
            sayi2 = Convert.ToInt32(Console.ReadLine());
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sayıların toplamı=" + toplam);
            Console.ReadKey();
        } //main bitişi
    }//class
}
