using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MjerenjeObracunTroskovaRada
{
    public class KoristenjeGodisnjegOdmora
    {
        public string OIB { get; set; }
        public int Godina { get; set; }
        public int RedniBrojKoristenja { get; set; }
        public DateTime Pocetak { get; set; }
        public DateTime Kraj { get; set; }

        public KoristenjeGodisnjegOdmora(string oib, int g, int rbr, DateTime pocetak, DateTime kraj)
        {
            OIB = oib;
            Godina = g;
            RedniBrojKoristenja = rbr;
            Pocetak = pocetak;
            Kraj = kraj;
        }

        public KoristenjeGodisnjegOdmora(Npgsql.NpgsqlDataReader dr)
        {
            if (dr != null)
            {
                OIB = dr["oib"].ToString();
                Godina = Convert.ToInt32(dr["godina"]);
                RedniBrojKoristenja = Convert.ToInt32(dr["redni_br_koristenja"]);
                Pocetak = Convert.ToDateTime(dr["pocetak"]);
                Kraj = Convert.ToDateTime(dr["kraj"]);
            }
        }
    }
}
