using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oop_siniflar
{
    public class Hesaplama
    {
        public int toplama(int x,int y)
        {
            
            return x + y;
        }

        public int coklu_toplama(int[] sayilar)
        {
            int t = 0;
            foreach(int x in sayilar)
            {
                t += x;
            }
            return t;
        }
    }
}