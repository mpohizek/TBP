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

        public static List<EvidencijaRadnogVremena2> DohvatiEvidencijeRadnogVremenaZaObracunPlace(string oib, int godina, int mjesec)
        {
            using (var conn = new NpgsqlConnection(ConnectionString))
            {
                List<EvidencijaRadnogVremena2> lista = new List<EvidencijaRadnogVremena2>();

                conn.Open();
                string sqlNaredba = "SELECT * FROM evidencija_radnog_vremena WHERE oib = '" + oib + "'";
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sqlNaredba, conn);
                NpgsqlDataReader reader = npgsqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    EvidencijaRadnogVremena2 evidencija = new EvidencijaRadnogVremena2(reader);
                    lista.Add(evidencija);
                }
                reader.Close();
                conn.Close();

                return lista;
            }
        }

        public static List<Korisnik> DohvatiKorisnike(string sql)
        {
            using (var conn = new NpgsqlConnection(ConnectionString))
            {
                List<Korisnik> listaKorisnika = new List<Korisnik>();
                conn.Open();
                string sqlNaredba = sql;
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

        public static object DohvatiVrijednost(string sql)
        {
            using (var conn = new NpgsqlConnection(ConnectionString))
            {
                conn.Open();
                string sqlNaredba = sql;
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sqlNaredba, conn);
                object vrijednost = npgsqlCommand.ExecuteScalar();

                conn.Close();

                return vrijednost;
            }
        }

        public static List<KoristenjeGodisnjegOdmora> DohvatiKoristenjeGO(string sql)
        {
            using (var conn = new NpgsqlConnection(ConnectionString))
            {
                List<KoristenjeGodisnjegOdmora> listaKoristenjaGO = new List<KoristenjeGodisnjegOdmora>();
                conn.Open();
                string sqlNaredba = sql;
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sqlNaredba, conn);
                NpgsqlDataReader reader = npgsqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    KoristenjeGodisnjegOdmora k = new KoristenjeGodisnjegOdmora(reader);
                    listaKoristenjaGO.Add(k);
                }
                reader.Close();
                conn.Close();

                return listaKoristenjaGO;
            }
        }
    }
}
