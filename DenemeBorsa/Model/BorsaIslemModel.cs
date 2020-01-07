using DenemeBorsa.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeBorsa.Model
{
    public class BorsaIslemModel
    {
        public int IslemID { get; set; }
        public int BorsaID { get; set; }
        public double Alis { get; set; }
        public double Satis { get; set; }
        public double Degisim { get; set; }
        public System.DateTime Tarih { get; set; }

        public Borsa Borsa = new Borsa();
    }
}
