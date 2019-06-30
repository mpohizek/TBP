using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MjerenjeObracunTroskovaRada
{
    public class PoslovnaLogikaObracunaPlaca
    {
        public List<Zaposlenik> listaZaposlenika { get; set; }

        public List<ObracunskaLista> ObracunskeListe { get; set; }

        public PoslovnaLogikaObracunaPlaca()
        {
            listaZaposlenika = UpravljanjePodacima.DohvatiZaposlenike();
            ObracunskeListe = new List<ObracunskaLista>();
        }

        private void SpremanjePDFa()
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new Paragraph("OBRACUNSKE LISTE"));
                        foreach (ObracunskaLista o in ObracunskeListe)
                        {
                            doc.NewPage();
                            doc.Add(new Paragraph(o.ToString()));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }

        //glavna funkcija koja poziva druge funkcije iz ove klase
        public void ObracunavanjePlaca()
        {
            foreach (Zaposlenik z in listaZaposlenika)
            {
                ObracunskaLista obracunskaLista = new ObracunskaLista();
                obracunskaLista.Naziv = "OBRACUNSKA LISTA PLACE";
                obracunskaLista.ImePrezimeZaposlenika = DohvatiImePrezimeZaposlenika(z.OIB);
                obracunskaLista.OIB = z.OIB;
                obracunskaLista.IBAN = z.IBAN;
                obracunskaLista.Mjesec = DateTime.Now.Month - 1;
                obracunskaLista.Godina = DateTime.Now.Year;
                obracunskaLista.BrutoPlaca = DohvatiBrutoPlacu(z.OIB, obracunskaLista.Godina, obracunskaLista.Mjesec, z.BrutoCijenaSatRedovni, z.BrutoCijenaSatPrekovremeni);
                obracunskaLista.MIOUkupno = (decimal)0.2 * obracunskaLista.BrutoPlaca;
                obracunskaLista.MIOPrvi = (decimal)0.15 * obracunskaLista.BrutoPlaca;
                obracunskaLista.MIODrugi = (decimal)0.05 * obracunskaLista.BrutoPlaca;
                obracunskaLista.Dohodak = obracunskaLista.BrutoPlaca - obracunskaLista.MIOUkupno;
                obracunskaLista.OsnovniOsobniOdbitak = 3800;
                obracunskaLista.UzdrzavaniClanoviOsobniOdbitak = DohvatiOsobniOdbitakZaUzdrzavaneClanove(z.BrojUzdrzavanihClanova);
                obracunskaLista.DjecaOsobniOdbitak = DohvatiOsobniOdbitakZaDjecu(z.BrojDjece);
                obracunskaLista.OsobniOdbitakUkupno = obracunskaLista.OsnovniOsobniOdbitak + obracunskaLista.UzdrzavaniClanoviOsobniOdbitak + obracunskaLista.DjecaOsobniOdbitak;
                if (obracunskaLista.OsobniOdbitakUkupno >= obracunskaLista.Dohodak) obracunskaLista.OsnovicaZaPorezNaDohodak = 0;
                if (obracunskaLista.OsobniOdbitakUkupno < obracunskaLista.Dohodak) obracunskaLista.OsnovicaZaPorezNaDohodak = obracunskaLista.Dohodak - obracunskaLista.OsobniOdbitakUkupno;
                obracunskaLista.PrviPorezniRazred = DohvatiPrviPorezniRazred(obracunskaLista.OsnovicaZaPorezNaDohodak);
                obracunskaLista.DrugiPorezniRAzred = DohvatiDrugiPorezniRazred(obracunskaLista.OsnovicaZaPorezNaDohodak);
                obracunskaLista.PorezNaDohodakUkupno = obracunskaLista.PrviPorezniRazred + obracunskaLista.DrugiPorezniRAzred;
                obracunskaLista.NetoPlaca = obracunskaLista.Dohodak - obracunskaLista.PorezNaDohodakUkupno;
                obracunskaLista.DoprinosZaZdravstvenoOsiguranje = (decimal)0.165 * obracunskaLista.BrutoPlaca;
                ObracunskeListe.Add(obracunskaLista);
            }
            SpremanjePDFa();
        }

       

        private decimal DohvatiBrutoPlacu(string oIB, int godina, int mjesec, decimal brutoCijenaSatRedovni, decimal brutoCijenaSatPrekovremeni)
        {
            decimal brutoplaca = 0;
            List<EvidencijaRadnogVremena2> evidencijeRV = UpravljanjePodacima.DohvatiEvidencijeRadnogVremenaZaObracunPlace(oIB, godina, mjesec);
            if (evidencijeRV.Count == 0)
            {
                return 0;
            }
            else
            {
                foreach (EvidencijaRadnogVremena2 e in evidencijeRV)
                {
                    if (e.PocetakSmjene.Year==godina && e.PocetakSmjene.Month==mjesec)
                    {
                        TimeSpan duljinaSmjene = e.KrajSmjene - e.PocetakSmjene;
                        if (duljinaSmjene.Hours <= 8) brutoplaca += duljinaSmjene.Hours * brutoCijenaSatRedovni;
                        else brutoplaca += (duljinaSmjene.Hours - 8) * brutoCijenaSatPrekovremeni;
                    }
                }
                return brutoplaca;
            }
        }

        private decimal DohvatiPrviPorezniRazred(decimal osnovicaZaPorezNaDohodak)
        {
            if (osnovicaZaPorezNaDohodak <= 30000 && osnovicaZaPorezNaDohodak > 0)
            {
                return osnovicaZaPorezNaDohodak * (decimal)0.24;
            }
            else return 0;
        }
        private decimal DohvatiDrugiPorezniRazred(decimal osnovicaZaPorezNaDohodak)
        {
            if (osnovicaZaPorezNaDohodak > 30000)
            {
                return (osnovicaZaPorezNaDohodak - 30000) * (decimal)0.36;
            }
            else return 0;
        }

        private decimal DohvatiOsobniOdbitakZaDjecu(int brojDjece)
        {
            switch (brojDjece)
            {
                case 0: return 0;
                case 1: return 1750;
                case 2: return 1750 + 2500;
                case 3: return 1750 + 2500 + 3500;
                case 4: return 1750 + 2500 + 3500 + 4750;
                case 5: return 1750 + 2500 + 3500 + 4750 + 6250;
                case 6: return 1750 + 2500 + 3500 + 4750 + 6250 + 8000;
                case 7: return 1750 + 2500 + 3500 + 4750 + 6250 + 8000 + 10000;
                case 8: return 1750 + 2500 + 3500 + 4750 + 6250 + 8000 + 10000 + 12250;
                case 9: return 1750 + 2500 + 3500 + 4750 + 6250 + 8000 + 10000 + 12250 + 14750;
                default: return (decimal)(5.9 + 1.1*(brojDjece-9))*2500;
            }
        }

        private decimal DohvatiOsobniOdbitakZaUzdrzavaneClanove(int brojUzdrzavanihClanova)
        {
            if (brojUzdrzavanihClanova == 0)
            {
                return 0;
            }
            else return (decimal)(brojUzdrzavanihClanova * 0.7) * 2500;
        }

        private string DohvatiImePrezimeZaposlenika(string oIB)
        {
            string imePrezime = "";
            List<Korisnik> korisnici = UpravljanjePodacima.DohvatiKorisnike("SELECT * FROM korisnik");
            foreach (var item in korisnici)
            {
                if (item.OIB == oIB) imePrezime = item.Ime + " " + item.Prezime;
            }
            return imePrezime;
        }
    }
}
