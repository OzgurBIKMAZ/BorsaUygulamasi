using DenemeBorsa.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeBorsa.DAL
{
    public static class HelperBorsaKullanici
    {
        public static (bool, BorsaKullanici) CUD (BorsaKullanici b, EntityState state)
        {
            using (BorsaEntities en = new BorsaEntities())
            {
                en.Entry(b).State = state;
                if (en.SaveChanges() > 0)
                {
                    return (true, b);
                }
                else
                {
                    return (false, null);
                }
            }
        }

        public static BorsaKullanici getRecordbyID(int kullaniciID)
        {
            using (BorsaEntities en = new BorsaEntities())
            {
                var kul = en.BorsaKullanici.Where(x => x.KullaniciID == kullaniciID).FirstOrDefault();
                return kul;
            }
        }

        public static int getIDfromUser(string kullaniciAdi)
        {
            using (BorsaEntities en = new BorsaEntities())
            {
                var kul = en.BorsaKullanici.Where(x => x.KullaniciAdi == kullaniciAdi).FirstOrDefault();
                return kul.KullaniciID;
            }
        }

        public static List<BorsaKullanici> getAllRecords()
        {
            using (BorsaEntities en = new BorsaEntities())
            {
                var list = en.BorsaKullanici.ToList();
                return list;
            }
        }

        public static bool UserDeleted(int kullaniciID, bool isdeleted)
        {
            using (BorsaEntities en = new BorsaEntities())
            {
                var user = getRecordbyID(kullaniciID);
                
                if (user != null)
                {
                    en.Entry(user).State = EntityState.Modified;
                    user.isDeleted = isdeleted;

                    if (en.SaveChanges() > 0)
                    {
                        return true;
                    }
                }
                return false;
            }

        }

        public static bool checkUserName(string kullaniciAdi)
        {
            using (BorsaEntities en = new BorsaEntities())
            {
                var list = getAllRecords();
                foreach (var u in list)
                {
                    if (u.KullaniciAdi.Equals(kullaniciAdi))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public static (bool, int, bool) checkUserLogin(string ad, string pass)
        {
            using (BorsaEntities en = new BorsaEntities())
            {
                var kayit = en.BorsaKullanici.Where(x => x.KullaniciAdi.Equals(ad) && x.Sifre.Equals(pass)).FirstOrDefault();
                if (kayit != null)
                {

                    return (true, kayit.KullaniciID, kayit.isDeleted);
                }
                else
                {
                    return (false, -1, false);
                }
            }
        }

        public static bool ChangePassword(BorsaKullanici b, string pass)
        {
            using (BorsaEntities en = new BorsaEntities())
            {
                en.Entry(b).State = EntityState.Modified;
                b.Sifre = pass;
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

        public static bool IletisimBilgileriGuncelle(BorsaKullanici b, string tel, string mail, string adres)
        {
            using (BorsaEntities en = new BorsaEntities())
            {
                en.Entry(b).State = EntityState.Modified;
                b.Telefon = tel;
                b.Email = mail;
                b.Adres = adres;
                if (en.SaveChanges()>0)
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
