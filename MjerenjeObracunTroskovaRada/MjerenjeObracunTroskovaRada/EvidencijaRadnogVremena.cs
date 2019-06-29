using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MjerenjeObracunTroskovaRada
{
    /// <summary>
    /// Entitetna klasa.
    /// </summary>
    public class EvidencijaRadnogVremena
    {
        public string OIB { get; set; }
        public DateTime PocetakSmjene { get; set; }

        /// <summary>
        /// Konstruktor koji kreira EvidencijuRadnogVremena sa podacima iz DataReader objekta.
        /// </summary>
        /// <param name="dr">DataReader</param>
        public EvidencijaRadnogVremena(Npgsql.NpgsqlDataReader dr)
        {
            if (dr != null)
            {
                OIB = dr["oib"].ToString();
                PocetakSmjene = Convert.ToDateTime(dr["pocetak_smjene"]);
            }
        }
    }
}
