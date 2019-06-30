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
    public class Korisnik
    {
        public string OIB { get; set; }
        public string KorisnickoIme { get; set; }
        public string Zaporka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Uloga { get; set; }

        /// <summary>
        /// Konstruktor koji kreira Zaposlenika sa podacima iz DataReader objekta.
        /// </summary>
        /// <param name="dr">DataReader</param>
        public Korisnik(Npgsql.NpgsqlDataReader dr)
        {
            if (dr != null)
            {
                OIB = dr["oib"].ToString();
                KorisnickoIme = dr["korisnicko_ime"].ToString();
                Zaporka = dr["zaporka"].ToString();
                Ime = dr["ime"].ToString();
                Prezime = dr["prezime"].ToString();
                Uloga = dr["uloga"].ToString();
            }
        }
        public override string ToString()
        {
            return "OIB: " + this.OIB + Environment.NewLine + "Korisničko ime: " + this.KorisnickoIme + Environment.NewLine + "Zaporka: " + this.Zaporka + Environment.NewLine + "Ime: " + this.Ime + Environment.NewLine + "Prezime: " + this.Prezime + Environment.NewLine + "Uloga: " + this.Uloga;
        }
    }


}
