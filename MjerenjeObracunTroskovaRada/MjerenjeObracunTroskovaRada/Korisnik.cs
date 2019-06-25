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
        /// Obični konstruktor.
        /// </summary>
        /// <param name="oib">Unosi zaposlenik odjela ULJP prilikom zapošljavanja novog zaposlenika.</param>
        /// <param name="korIme">Unosi zaposlenik odjela ULJP prilikom zapošljavanja novog zaposlenika.</param>
        /// <param name="zaporka">Unosi zaposlenik odjela ULJP prilikom zapošljavanja novog zaposlenika.</param>
        /// <param name="ime">Unosi zaposlenik odjela ULJP prilikom zapošljavanja novog zaposlenika.</param>
        /// <param name="prezime">Unosi zaposlenik odjela ULJP prilikom zapošljavanja novog zaposlenika.</param>
        /// <param name="uloga">Unosi zaposlenik odjela ULJP prilikom zapošljavanja novog zaposlenika.</param>
        public Korisnik(string oib, string korIme, string zaporka, string ime, string prezime, string uloga)
        {
            OIB = oib;
            KorisnickoIme = korIme;
            Zaporka = zaporka;
            Ime = ime;
            Prezime = prezime;
            Uloga = uloga;
        }

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
    }


}
