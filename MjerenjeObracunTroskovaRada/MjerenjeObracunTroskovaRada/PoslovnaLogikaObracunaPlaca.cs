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
                        doc.Add(new Paragraph("OBRAČUNSKE LISTE"));
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
                obracunskaLista.Naziv = "OBRAČUNSKA LISTA PLAĆE";
                obracunskaLista.ImePrezimeZaposlenika = DohvatiImePrezimeZaposlenika(z.OIB);
                obracunskaLista.OIB = z.OIB;
                obracunskaLista.IBAN = z.IBAN;
                obracunskaLista.Mjesec = DateTime.Now.Month - 1;
                obracunskaLista.BrutoPlaca = DohvatiBrutoPlacu(z.OIB, obracunskaLista.Godina, obracunskaLista.Mjesec, z.BrutoCijenaSatRedovni, z.BrutoCijenaSatPrekovremeni);
                obracunskaLista.MIOUkupno = (decimal)0.2 * obracunskaLista.BrutoPlaca;
                obracunskaLista.MIOPrvi = (decimal)0.15 * obracunskaLista.BrutoPlaca;
                obracunskaLista.MIODrugi = (decimal)0.05 * obracunskaLista.BrutoPlaca;
                obracunskaLista.Dohodak = obracunskaLista.BrutoPlaca - obracunskaLista.MIOUkupno;
                obracunskaLista.OsnovniOsobniOdbitak = 3800;
                obracunskaLista.UzdrzavaniClanoviOsobniOdbitak = DohvatiOsobniOdbitakZaUzdrzavaneClanove(z.BrojUzdrzavanihClanova);
                obracunskaLista.DjecaOsobniOdbitak = DohvatiOsobniOdbitakZaDjecu(z.BrojDjece);
                obracunskaLista.OsobniOdbitakUkupno = obracunskaLista.OsobniOdbitakUkupno + obracunskaLista.UzdrzavaniClanoviOsobniOdbitak + obracunskaLista.DjecaOsobniOdbitak;
                obracunskaLista.OsnovicaZaPorezNaDohodak = obracunskaLista.Dohodak - obracunskaLista.OsobniOdbitakUkupno;
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
                    TimeSpan duljinaSmjene = e.KrajSmjene - e.PocetakSmjene;
                    if (duljinaSmjene.Hours <= 8) brutoplaca += duljinaSmjene.Hours * brutoCijenaSatRedovni;
                    else brutoplaca += (duljinaSmjene.Hours - 8) * brutoCijenaSatPrekovremeni;
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
                case 0:
                    {
                        return 0;
                    }
                case 
            }
        }

        private decimal DohvatiOsobniOdbitakZaUzdrzavaneClanove(int brojUzdrzavanihClanova)
        {
            throw new NotImplementedException();
        }

        private string DohvatiImePrezimeZaposlenika(string oIB)
        {
            throw new NotImplementedException();
        }
    }
}
