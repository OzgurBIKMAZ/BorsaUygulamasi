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
    public static class HelperBorsaKullaniciIslem
    {
        public static (bool, BorsaKullaniciIslem) CUD(BorsaKullaniciIslem bki, EntityState state)
        {
            using (BorsaEntities en = new BorsaEntities())
            {
                en.Entry(bki).State = state;
                if (en.SaveChanges() > 0)
                {
                    return (true, bki);
                }
                else
                {
                    return (false, null);
                }
            }
        }

        public static bool BakiyeEkle(int userID, double tutar, bool ekle)
        {
            BorsaKullaniciIslem bki = new BorsaKullaniciIslem()
            {
                KullaniciID = userID,
                BorsaID = 1,
                Miktar = tutar,
                CuzdanEkle = ekle,
                Tarih = DateTime.Now
            };

            using (BorsaEntities en = new BorsaEntities())
            {
                var a = en.BorsaKullaniciIslem.Add(bki);
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

        public static List<BorsaKullaniciIslemModel> getAllRecords()
        {
            List<BorsaKullaniciIslemModel> bkimList = new List<BorsaKullaniciIslemModel>();
            using (BorsaEntities en = new BorsaEntities())
            {
                var list = en.BorsaKullaniciIslem.ToList();
                foreach (var item in list)
                {
                    BorsaKullaniciIslemModel bkim = new BorsaKullaniciIslemModel();
                    bkim.KullaniciIslemID = item.KullaniciIslemID;
                    bkim.KullaniciID = item.KullaniciID;
                    bkim.BorsaID = item.BorsaID;
                    bkim.Miktar = item.Miktar;
                    bkim.CuzdanEkle = item.CuzdanEkle;
                    bkim.Tarih = item.Tarih;
                    bkim.isDeleted = item.isDeleted;
                    bkim.Borsa.Adi = item.Borsa.Adi;
                    bkim.Borsa.Tur = item.Borsa.Tur;
                    
                    bkimList.Add(bkim);
                }
                return bkimList;
            }
        }



        public static List<BorsaKullaniciIslemModel> getAllRecordsbyID(int kullaniciID)
        {
            List<BorsaKullaniciIslemModel> bkimList = new List<BorsaKullaniciIslemModel>();
            using (BorsaEntities en = new BorsaEntities())
            {
                var list = en.BorsaKullaniciIslem.Where(x =>x.KullaniciID== kullaniciID).ToList();
                foreach (var item in list)
                {
                    BorsaKullaniciIslemModel bkim = new BorsaKullaniciIslemModel();
                    bkim.KullaniciIslemID = item.KullaniciIslemID;
                    bkim.KullaniciID = item.KullaniciID;
                    bkim.BorsaID = item.BorsaID;
                    bkim.Miktar = item.Miktar;
                    bkim.CuzdanEkle = item.CuzdanEkle;
                    bkim.Tarih = item.Tarih;
                    bkim.Borsa.Adi = item.Borsa.Adi;
                    bkim.Borsa.Tur = item.Borsa.Tur;
                    bkim.isDeleted = item.isDeleted;

                    bkimList.Add(bkim);
                }
                return bkimList;
            }
        }

        public static List<BorsaKullaniciIslemModel> getRecordsbyBorsaID(int kullaniciID, int borsaID)
        {
            List<BorsaKullaniciIslemModel> bkimList = new List<BorsaKullaniciIslemModel>();
            using (BorsaEntities en = new BorsaEntities())
            {
                var list = en.BorsaKullaniciIslem.Where(x => x.KullaniciID == kullaniciID && x.BorsaID == borsaID).ToList();
                foreach (var item in list)
                {
                    BorsaKullaniciIslemModel bkim = new BorsaKullaniciIslemModel();
                    bkim.KullaniciIslemID = item.KullaniciIslemID;
                    bkim.KullaniciID = item.KullaniciID;
                    bkim.BorsaID = item.BorsaID;
                    bkim.Miktar = item.Miktar;
                    bkim.CuzdanEkle= item.CuzdanEkle;
                    bkim.Tarih = item.Tarih;
                    bkim.Borsa.Adi = item.Borsa.Adi;
                    bkim.Borsa.Tur = item.Borsa.Tur;
                    bkim.isDeleted = item.isDeleted;

                    bkimList.Add(bkim);
                }
                return bkimList;
            }
        }

        public static bool IslemDeleted(int kullaniciID, bool isdeleted)
        {
            using (BorsaEntities en = new BorsaEntities())
            {
                var user = getAllRecordsbyID(kullaniciID);

                foreach (var u in user)
                {
                    if (u != null)
                    {
                        en.Entry(u).State = EntityState.Modified;
                        u.isDeleted = isdeleted;
                    }
                }

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
    }
}
