using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interface_2
{
    public class Tavuk : IYenilebilir
    {
        public string nasil_yenilir()
        {
            return "haşlanır,fırında olur,mangala gider";
        }
    }
}