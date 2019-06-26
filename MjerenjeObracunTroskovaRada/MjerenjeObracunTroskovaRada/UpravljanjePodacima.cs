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
    }
}
