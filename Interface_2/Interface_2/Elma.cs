using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interface_2
{
    public class Elma : IYenilebilir, ISuyucikarilabilir

    {
        public virtual string nasil_suyu_cikarilir()
        {
            return "makinaya koy düğmeye bas";
        }

        public string nasil_yenilir()
        {
            return "eline al ısır ye";
        }
    }
}