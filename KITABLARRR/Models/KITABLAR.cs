//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KITABLARRR.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KITABLAR
    {
        public int ID { get; set; }
        public string KITAB_AD { get; set; }
        public string KITAB_YAZAR { get; set; }
        public Nullable<int> KITAB_SEHIFE { get; set; }
        public Nullable<decimal> KITAB_QIYMET { get; set; }
        public Nullable<System.DateTime> KITAB_TARIX { get; set; }
        public string KITAB_CAPEV { get; set; }
    }
}
