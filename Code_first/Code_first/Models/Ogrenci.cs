using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Code_first.Models
{
    [Table("Ogrenciler")]
    public class Ogrenci
    {
        [Key]
        public int ogno { set; get; }
        [Required(ErrorMessage ="Ad Soyad Girilmesi zorunludur")]
        [StringLength(30,ErrorMessage ="Ad soyad en fazla 30 karakter olabilir")]
        public string ad_soyad { set; get; }
        [Index(IsUnique =true)]
        public long tc_kimlik { set; get; }
        //[Column(TypeName ="smalldatetime")]
        [DisplayFormat(ApplyFormatInEditMode =true,DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime dog_tar { set; get; }
        public string adres { set; get; }
      
        public virtual ICollection<Not> notlar { set; get; }
    }
}