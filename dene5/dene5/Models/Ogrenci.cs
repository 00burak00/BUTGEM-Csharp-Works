using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace dene5.Models
{
    [Table("Ogrenciler")]
    public class Ogrenci
    {
        [Key]
        public int ogno { set; get; }
        [Required(ErrorMessage = "Ad soyad gereklidir")]
        [StringLength(30, ErrorMessage = "En Fazla 30 karakter")]
        public String ad_soyad { set; get; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:dd/mm/yyyy}")]
        public DateTime dogtar { set; get; }
        [Index (IsUnique =true)]
        public long tckimlik { set; get; }
        public String Adres { set; get; }
    }
}