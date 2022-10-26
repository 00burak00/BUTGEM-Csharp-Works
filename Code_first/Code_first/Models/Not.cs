using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Code_first.Models
{
    public class Not
    {
        public int id { set; get; }
        public int ogno { set; get; }
        public byte Ders_no { set; get; }
        [Range(0,100,ErrorMessage ="0 ile 100 arasında değer girin")]
        public byte yaz1 { set; get; }
        [Not_dogrulama(ErrorMessage = "0 ile 100 arasında değer girin")]
        public byte? yaz2 { set; get; }
        public Ogrenci ogrenci { set; get; }
        public Ders Ders { get; set; }
    }
}