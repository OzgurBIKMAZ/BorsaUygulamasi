//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DenemeBorsa.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class BorsaKullaniciIslem
    {
        public int KullaniciIslemID { get; set; }
        public int KullaniciID { get; set; }
        public int BorsaID { get; set; }
        public double Miktar { get; set; }
        public bool CuzdanEkle { get; set; }
        public System.DateTime Tarih { get; set; }
        public bool isDeleted { get; set; }
    
        public virtual Borsa Borsa { get; set; }
        public virtual BorsaKullanici BorsaKullanici { get; set; }
    }
}