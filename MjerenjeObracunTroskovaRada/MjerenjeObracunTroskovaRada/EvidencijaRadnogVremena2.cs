using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MjerenjeObracunTroskovaRada
{
    public class EvidencijaRadnogVremena2
    {
        public string OIB { get; set; }
        public DateTime PocetakSmjene { get; set; }
        public DateTime KrajSmjene { get; set; }

        /// <summary>
        /// Konstruktor koji kreira EvidencijuRadnogVremena2 sa podacima iz DataReader objekta.
        /// </summary>
        /// <param name="dr">DataReader</param>
        public EvidencijaRadnogVremena2(Npgsql.NpgsqlDataReader dr)
        {
            if (dr != null)
            {
                OIB = dr["oib"].ToString();
                PocetakSmjene = Convert.ToDateTime(dr["pocetak_smjene"]);
                KrajSmjene = Convert.ToDateTime(dr["kraj_smjene"]);
            }
        }
    }
}
