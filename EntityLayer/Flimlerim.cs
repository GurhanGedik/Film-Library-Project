//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Flimlerim
    {
        public int FlimID { get; set; }
        public string FlimAdi { get; set; }
        public string FlimTuru { get; set; }
        public string Yonetmen { get; set; }
        public string Senarist { get; set; }
        public string ImdbPuani { get; set; }
        public Nullable<System.DateTime> FlimTarihi { get; set; }
        public string Oyuncular { get; set; }
        public string Konusu { get; set; }
        public string ResimUrl { get; set; }
        public override string ToString()
        {
            return this.FlimAdi;
        }
    }
}
