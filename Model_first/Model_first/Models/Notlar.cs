//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model_first.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Notlar
    {
        public int Id { get; set; }
        public byte yaz1 { get; set; }
        public byte yaz2 { get; set; }
        public int ogno { get; set; }
        public int Ders_no { get; set; }
    
        public virtual Ogrenciler Ogrenciler { get; set; }
        public virtual Dersler Dersler { get; set; }
    }
}
