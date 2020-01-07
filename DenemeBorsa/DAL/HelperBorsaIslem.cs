using DenemeBorsa.Entity;
using DenemeBorsa.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeBorsa.DAL
{
    public static class HelperBorsaIslem
    {
        public static bool Add(BorsaIslem b)
        {
            using (BorsaEntities en = new BorsaEntities())
            {
                var deg = en.BorsaIslem.Add(b);
                if (en.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static List<BorsaIslemModel> getAllRecords()
        {
            List<BorsaIslemModel> bimList = new List<BorsaIslemModel>();
            using (BorsaEntities en = new BorsaEntities())
            {
                var list = en.BorsaIslem.OrderByDescending(x => x.Tarih).ToList();
                foreach (var bi in list)
                {
                    BorsaIslemModel bim = new BorsaIslemModel()
                    {
                        IslemID = bi.IslemID,
                        BorsaID = bi.BorsaID,
                        Alis = bi.Alis,
                        Satis = bi.Satis,
                        Degisim = bi.Degisim,
                        Tarih = bi.Tarih
                    };
                    bim.Borsa.Adi = bi.Borsa.Adi;
                    bim.Borsa.Tur = bi.Borsa.Tur;

                    bimList.Add(bim);
                }
                return bimList;
            }
        }

        public static List<BorsaIslemModel> getAllRecordsbyID(int borsaID)
        {
            List<BorsaIslemModel> bimList = new List<BorsaIslemModel>();
            using (BorsaEntities en = new BorsaEntities())
            {
                var list = en.BorsaIslem.Where(x => x.BorsaID == borsaID).OrderByDescending(t => t.Tarih).ToList();
                foreach (var bi in list)
                {
                    BorsaIslemModel bim = new BorsaIslemModel()
                    {
                        IslemID = bi.IslemID,
                        BorsaID = bi.BorsaID,
                        Alis = bi.Alis,
                        Satis = bi.Satis,
                        Degisim = bi.Degisim,
                        Tarih = bi.Tarih
                    };
                    bim.Borsa.Adi = bi.Borsa.Adi;
                    bim.Borsa.Tur = bi.Borsa.Tur;

                    bimList.Add(bim);
                }
                return bimList;
            }
        }
        
        public static BorsaIslemModel getLastRecord(int borsaID)
        {
            using (BorsaEntities en = new BorsaEntities())
            {
                var borsa = en.BorsaIslem.Where(x => x.BorsaID == borsaID).OrderByDescending(x => x.Tarih).FirstOrDefault();
                if (borsa != null)
                {
                    BorsaIslemModel don = new BorsaIslemModel()
                    {
                        IslemID = borsa.IslemID,
                        BorsaID = borsa.BorsaID,
                        Alis = borsa.Alis,
                        Satis = borsa.Satis,
                        Degisim = borsa.Degisim,
                        Tarih = borsa.Tarih
                    };
                    don.Borsa.Adi = borsa.Borsa.Adi;
                    don.Borsa.Tur = borsa.Borsa.Tur;
                    return don;
                }
                else
                {
                    return null;
                }
                

               
            }
        }

        
    }

}

