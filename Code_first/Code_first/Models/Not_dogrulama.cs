using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Code_first.Models
{
    public class Not_dogrulama:ValidationAttribute
    {
       
        public override bool IsValid(object value)
        {
            bool sonuc = false;
            if (Convert.ToInt32(value) >= 0 && Convert.ToInt32(value) <= 100) sonuc = true;
            return sonuc;
        }
    }
}