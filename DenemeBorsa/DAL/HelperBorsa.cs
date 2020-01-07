using DenemeBorsa.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeBorsa.DAL
{
    public static class HelperBorsa
    {
        public static (bool, Borsa) CUD(Borsa borsa, EntityState state)
        {
            using (BorsaEntities en = new BorsaEntities())
            {
                en.Entry(borsa).State = state;
                if (en.SaveChanges() > 0)
                {
                    return (true, borsa);
                }
                else
                {
                    return (false, null);
                }
            }

        }
        public static List<Borsa> getAllRecords(bool durum)
        {
            using (BorsaEntities en = new BorsaEntities())
            {
                var list = en.Borsa.Where(x => x.BorsaID != 1 && x.isDeleted==durum).ToList();
                return list;
            }
        }

        public static Borsa getRecordbyID(int borsaID)
        {
            using (BorsaEntities en = new BorsaEntities())
            {
                var borsa = en.Borsa.Where(x => x.BorsaID == borsaID).FirstOrDefault();
                return borsa;
            }

        }

        public static List<Borsa> gelAllRecordsbyTur(int turID)
        {
            using (BorsaEntities en = new BorsaEntities())
            {
                var list = en.Borsa.Where(x => x.Tur == turID && x.isDeleted == false).ToList();
                return list;
            }
        }

        public static bool BorsaDeleted(int borsaID, bool isdeleted)
        {
            using (BorsaEntities en = new BorsaEntities())
            {
                var borsa = getRecordbyID(borsaID);
                en.Entry(borsa).State = EntityState.Modified;
                borsa.isDeleted = isdeleted;

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

        public static bool checkName(string name)
        {
            using (BorsaEntities en = new BorsaEntities())
            {
                var list = getAllRecords(false);
                foreach (var c in list)
                {
                    if (c.Adi.ToLower().Equals(name.ToLower()))
                    {
                        return true;
                    }
                }
                return false;
            }
        }


    }
}
