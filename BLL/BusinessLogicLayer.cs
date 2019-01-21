using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using KullanicilarLinq;
namespace BLL
{
    public class BusinessLogicLayer
    {
        HeddiyeDataContext dt = new HeddiyeDataContext();
        public int UrunKontrol(string UrunAdi, string CinsiyetAdi, string HediyeAmaci, string YakinlikDerecesi, string YasAraligi, string BurcAdi,string link)
        {
            int UrunKontrol = 0;
            string denem = "";
            Urunler u = new Urunler();
            if (!string.IsNullOrEmpty(UrunAdi))
            {
                UrunKontrol = dt.SP_UrunEkle(UrunAdi, CinsiyetAdi, HediyeAmaci, YakinlikDerecesi, YasAraligi, BurcAdi,link);
            }



            return UrunKontrol;
        }


    }
}
