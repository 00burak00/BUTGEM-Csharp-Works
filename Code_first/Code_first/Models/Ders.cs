using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Code_first.Models
{
    [Table("Dersler")]
    public class Ders
    {
        [Key]
        public byte Ders_no { set; get; }
        [Required(ErrorMessage ="Ders adı girilmesi zorunlu")]
        public string ders_adi { set; get; }
        public virtual ICollection<Not> notlar { set; get; }
    }
}