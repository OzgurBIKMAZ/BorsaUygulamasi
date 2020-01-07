using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeBorsa.DAL
{
    public class Enums
    {
        public enum BorsaTur
        {
            Bakiye,
            Döviz,
            Altın,
            Hisse
        }

        public enum UserTur
        {
            Admin,
            NormalKullanıcı,
            Broker,
            Şirket
        }
    }
}
