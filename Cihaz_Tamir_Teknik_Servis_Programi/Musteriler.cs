//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cihaz_Tamir_Teknik_Servis_Programi
{
    using System;
    using System.Collections.Generic;
    
    public partial class Musteriler
    {
        public int Musteri_Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telno { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }
        public Nullable<int> Cihaz_Id { get; set; }
        public string Imei { get; set; }
        public Nullable<int> Ariza_Id { get; set; }
        public Nullable<int> Parca_Id { get; set; }
        public Nullable<int> Tutar { get; set; }
        public Nullable<System.DateTime> Servis_Teslim { get; set; }
    
        public virtual Ariza Ariza { get; set; }
        public virtual Cihaz Cihaz { get; set; }
        public virtual Parca Parca { get; set; }
    }
}
