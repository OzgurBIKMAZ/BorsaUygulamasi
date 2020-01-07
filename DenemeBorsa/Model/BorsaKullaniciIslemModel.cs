using DenemeBorsa.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeBorsa.Model
{
    public class BorsaKullaniciIslemModel
    {
        public int KullaniciIslemID { get; set; }
        public int KullaniciID { get; set; }
        public int BorsaID { get; set; }
        public double Miktar { get; set; }
        public System.DateTime Tarih { get; set; }
        public bool CuzdanEkle { get; set; }
        public bool isDeleted { get; set; }

        public Borsa Borsa = new Borsa();
    }
}
