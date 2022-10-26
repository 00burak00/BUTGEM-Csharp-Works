using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsol_uygulamasi
{
    class Oparatorler
    {
        static void Main(string[] args)
        {
            /*int s1;
            s1 = 5;
                
            s1 = s1 + 5;
            s1++;
            int s2=3;
            double x = 2;
            x = s2;

            s2 += 10;//s2=s2+10
            s2 -= 5;
            s2 *= 3;
            x = s1 + (s1 - s2) * 5;
            Console.WriteLine(s1);
            Console.ReadKey();*/
            int x = 8, y = 5, z = 10;
            bool sonuc;
            //sonuc = x < y;
            sonuc = (x <= z) || (y < x) && (y != 5);

            double sonuc2=0;
            // sonuc2 = Math.Pow(3, 3);
            //sonuc2= Math.Sqrt((x * y));
            
            Console.WriteLine(sonuc2);
            Console.ReadKey();

        }
        }
}
