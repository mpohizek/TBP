using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MjerenjeObracunTroskovaRada
{
    public class ObracunskaLista
    {
        public string ImePrezimeZaposlenika { get; set; }
        public string OIB { get; set; }
        public string IBAN { get; set; }
        public string Naziv { get; set; }
        public int Mjesec { get; set; }
        public int Godina { get; set; }
        public decimal BrutoPlaca { get; set; }
        public decimal MIOUkupno { get; set; }
        public decimal MIOPrvi { get; set; }
        public decimal MIODrugi { get; set; }
        public decimal Dohodak { get; set; }
        public decimal OsobniOdbitakUkupno { get; set; }
        public decimal OsnovniOsobniOdbitak { get; set; }
        public decimal UzdrzavaniClanoviOsobniOdbitak { get; set; }
        public decimal DjecaOsobniOdbitak { get; set; }
        public decimal OsnovicaZaPorezNaDohodak { get; set; }
        public decimal PorezNaDohodakUkupno { get; set; }
        public decimal PrviPorezniRazred { get; set; }
        public decimal DrugiPorezniRAzred { get; set; }
        public decimal NetoPlaca { get; set; }
        public decimal DoprinosZaZdravstvenoOsiguranje { get; set; }

        public override string ToString()
        {
            return "Zaposlenik: " + ImePrezimeZaposlenika + Environment.NewLine +
                "OIB: " + OIB + Environment.NewLine +
                "IBAN: " + IBAN + Environment.NewLine +
                "\t\t" + Naziv + Environment.NewLine +
                "\t\t za " + Mjesec + ", " + Godina + Environment.NewLine +
                "1) Bruto plaća: " + Math.Round(BrutoPlaca, 2) + Environment.NewLine +
                "2) Doprinosi za mirovinsko osiguranje (20%): " + Math.Round(MIOUkupno, 2) + Environment.NewLine +
                "\t MIO Prvi stup (15%): " + Math.Round(MIOPrvi, 2) + Environment.NewLine +
                "\t MIO Drugi stup (5%): " + Math.Round(MIODrugi, 2) + Environment.NewLine +
                "3) Dohodak (1-2): " + Math.Round(Dohodak, 2) + Environment.NewLine +
                "4) Osobni odbitci djelatnika ukupno: " + Math.Round(OsobniOdbitakUkupno, 2) + Environment.NewLine +
                "\t Osnovni osobni odbitak: " + +Math.Round(OsnovniOsobniOdbitak, 2) + Environment.NewLine +
                "\t Uzdrzavani clanovi uže obitelji: " + Math.Round(UzdrzavaniClanoviOsobniOdbitak, 2) + Environment.NewLine +
                "\t Osobni odbitak za djecu: " + Math.Round(DjecaOsobniOdbitak, 2) + Environment.NewLine +
                "5) Osnovica za porez na dohodak: " + Math.Round(OsnovicaZaPorezNaDohodak, 2) + Environment.NewLine +
                "\t Prvi porezni razred (dohodak do 30.000,00 kn) 24%: " + Math.Round(PrviPorezniRazred, 2) + Environment.NewLine +
                "\t Drugi porezni razred (dohodak od 30.000,00 kn) 36%: " + Math.Round(DrugiPorezniRAzred, 2) + Environment.NewLine +
                "6) Neto plaća (za isplatu): " + Math.Round(NetoPlaca, 2) + Environment.NewLine +
                "7) Doprinos za zdravstveno osiguranje (16,5%): " + Math.Round(DoprinosZaZdravstvenoOsiguranje, 2) + Environment.NewLine;
        }
    }
}
