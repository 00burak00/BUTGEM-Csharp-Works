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
    
    public partial class Doktorlar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doktorlar()
        {
            this.Hasta_yatis = new HashSet<Hasta_yatis>();
        }
    
        public int Doktor_no { get; set; }
        public string Doktor_adi { get; set; }
        public int Dept_no { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hasta_yatis> Hasta_yatis { get; set; }
        public virtual Departmanlar Departmanlar { get; set; }
    }
}