using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MjerenjeObracunTroskovaRada
{
    public class Zaposlenik
    {
        public string OIB { get; set; }
        public string RadnoMjesto { get; set; }
        public DateTime DatumZaposlenja { get; set; }
        public decimal BrutoCijenaSatRedovni { get; set; }
        public decimal BrutoCijenaSatPrekovremeni { get; set; }
        public int BrojUzdrzavanihClanova { get; set; }
        public int BrojDjece { get; set; }
        public string IBAN { get; set; }

        public Zaposlenik(Npgsql.NpgsqlDataReader dr)
        {
            if (dr != null)
            {
                OIB = dr["oib"].ToString();
                RadnoMjesto = dr["radno_mjesto"].ToString();
                DatumZaposlenja = Convert.ToDateTime(dr["datum_zaposlenja"]);
                BrutoCijenaSatRedovni = Convert.ToDecimal(dr["bruto_cijena_sat_redovni"]);
                BrutoCijenaSatPrekovremeni = Convert.ToDecimal(dr["bruto_cijena_sat_prekovremeni"]);
                BrojUzdrzavanihClanova = Convert.ToInt32(dr["broj_uzdrzavanih_clanova"]);
                BrojDjece = Convert.ToInt32(dr["broj_djece"]);
                IBAN = dr["IBAN"].ToString();
            }
        }
    }
}
