//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eticaret_mvc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class altkategoriler
    {
        public short altkateno { get; set; }
        public string altkateadi { get; set; }
        public byte anakateno { get; set; }
    
        public virtual kategoriler kategoriler { get; set; }
    }
}
