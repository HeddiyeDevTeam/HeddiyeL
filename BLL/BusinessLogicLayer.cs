using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using DataLinq;
namespace BLL
{
    public class BusinessLogicLayer
    {
        HeddiyeDataContext dt = new HeddiyeDataContext();
        public int UrunKontrol(string UrunAdi, string CinsiyetAdi, string HediyeAmaci, string YakinlikDerecesi, string YasAraligi, string BurcAdi,string link)
        {
            int UrunKontrol = 0;
          
            Urunler u = new Urunler();
            if (!string.IsNullOrEmpty(UrunAdi))
            {
                UrunKontrol = dt.SP_UrunEkle(UrunAdi, CinsiyetAdi, HediyeAmaci, YakinlikDerecesi, YasAraligi, BurcAdi,link);
            }

            else { UrunKontrol = -1; }

            return UrunKontrol;
        }


    }
}
