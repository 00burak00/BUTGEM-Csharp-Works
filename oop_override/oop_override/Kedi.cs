using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oop_override
{
    public class Kedi:Hayvan 
    {
        public override string sescikar()
        {
            return "miyav miyav";
        }
    }
}