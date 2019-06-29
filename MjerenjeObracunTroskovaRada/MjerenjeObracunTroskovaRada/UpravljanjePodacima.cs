using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace MjerenjeObracunTroskovaRada
{
    /// <summary>
    /// Statična klasa koja služi za rad s bazom podataka.
    /// </summary>
    public static class UpravljanjePodacima
    {
        private static string ConnectionString = "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=postgres";

        /// <summary>
        /// Klasa za autentifikaciju korisnika prilikom prijave u aplikaciju. 
        /// </summary>
        /// <param name="korIme">Korisničko ime koje je korisnik upisao u formu za prijavu.</param>
        /// <param name="zaporka">Lozinka koju je korisnik upisao u formu za prijavu.</param>
        /// <returns>1 ako su podaci za prijavu točni; 2 ako je krivo korisničko ime; 3 ako je kriva lozinka</returns>
        public static Korisnik AutentificirajKorisnika(string korIme, string zaporka)
        {
            using (var conn = new NpgsqlConnection(ConnectionString))
            {
                Korisnik autenticiraniKorinik = null;

                conn.Open();
                string sqlNaredba = "SELECT * FROM korisnik WHERE korisnicko_ime = '" + korIme + "' AND zaporka = '" + zaporka + "'";
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sqlNaredba, conn);
                NpgsqlDataReader reader = npgsqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Korisnik korisnik = new Korisnik(reader);
                    autenticiraniKorinik = korisnik;
                }
                reader.Close();
                conn.Close();

                return autenticiraniKorinik;
            }

        }

        public static void PozivanjePohranjeneProcedure(string nazivProcedure)
        {
            using (var conn = new NpgsqlConnection(ConnectionString))
            {
                conn.Open();
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(nazivProcedure, conn);
                npgsqlCommand.CommandType = CommandType.StoredProcedure;
                NpgsqlDataReader npgsqlDataReader = npgsqlCommand.ExecuteReader();
                conn.Close();
            }
        }

        public static void SpremanjeUBazu(string upit)
        {
            using (var conn = new NpgsqlConnection(ConnectionString))
            {
                conn.Open();
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(upit, conn);
                npgsqlCommand.ExecuteNonQuery();
                conn.Close();
            }
        }

        public static EvidencijaRadnogVremena DohvatiEvidencijuRadnogVremena(string oib)
        {
            using (var conn = new NpgsqlConnection(ConnectionString))
            {
                EvidencijaRadnogVremena evidencijaBezZavrsetkaSmjene = null;

                conn.Open();
                string sqlNaredba = "SELECT * FROM evidencija_radnog_vremena WHERE oib = '" + oib + "' AND kraj_smjene IS NOT DISTINCT FROM NULL";
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sqlNaredba, conn);
                NpgsqlDataReader reader = npgsqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    EvidencijaRadnogVremena evidencija  = new EvidencijaRadnogVremena(reader);
                    evidencijaBezZavrsetkaSmjene = evidencija;
                }
                reader.Close();
                conn.Close();

                return evidencijaBezZavrsetkaSmjene;
            }
        }

        public static List<Korisnik> DohvatiKorisnika()
        {
            using (var conn = new NpgsqlConnection(ConnectionString))
            {
                List<Korisnik> listaKorisnika = new List<Korisnik>();
                conn.Open();
                string sqlNaredba = "SELECT k.oib, k.korisnicko_ime, k.zaporka, k.ime, k.prezime, k.uloga FROM korisnik k LEFT JOIN zaposlenik z ON k.oib=z.oib WHERE z.oib IS NULL AND k.uloga <> 'administrator'";
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sqlNaredba, conn);
                NpgsqlDataReader reader = npgsqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Korisnik korisnik = new Korisnik(reader);
                    listaKorisnika.Add(korisnik);
                }
                reader.Close();
                conn.Close();

                return listaKorisnika;
            }
        }

        public static List<Zaposlenik> DohvatiZaposlenike()
        {
            using (var conn = new NpgsqlConnection(ConnectionString))
            {
                List<Zaposlenik> listaZaposlenika = new List<Zaposlenik>();
                conn.Open();
                string sqlNaredba = "SELECT * FROM zaposlenik";
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sqlNaredba, conn);
                NpgsqlDataReader reader = npgsqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Zaposlenik zaposlenik = new Zaposlenik(reader);
                    listaZaposlenika.Add(zaposlenik);
                }
                reader.Close();
                conn.Close();

                return listaZaposlenika;
            }
        }
    }
}
