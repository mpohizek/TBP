using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MjerenjeObracunTroskovaRada.FormeIzbornici
{
    public partial class EvidencijaOdlaskaDolaska : Form
    {
        public Korisnik prijavljeniKorisnik { get; set; }
        public DateTime vrijemePocetka { get; set; }
        public string tipRoditelja { get; set; }
        public EvidencijaOdlaskaDolaska(Korisnik k, string t)
        {
            InitializeComponent();
            prijavljeniKorisnik = k;
            tipRoditelja = t;
        }

        private void btnPocetakSmjene_Click(object sender, EventArgs e)
        {
            UpravljanjePodacima.SpremanjeUBazu("INSERT INTO evidencija_radnog_vremena (oib, pocetak_smjene) VALUES ('" + prijavljeniKorisnik.OIB + "', '" + DateTime.Now + "')");
            btnPocetakSmjene.Enabled = false;
            vrijemePocetka = DateTime.Now;
            txtVrijemePocetka.Text = vrijemePocetka.ToString();
            btnKrajRada.Enabled = true;
            timerTrajanjeSmjene.Start();

            ProsljedivanjeVremenaMdiParentu();
        }

        private void ProsljedivanjeVremenaMdiParentu()
        {
            switch (tipRoditelja)
            {
                case "FrmRacunovoda":
                    {
                        ((FrmRacunovoda)MdiParent).vrijemePocetka = vrijemePocetka;
                        break;
                    }
                case "FrmZaposlenik":
                    {
                        ((FrmZaposlenik)MdiParent).vrijemePocetka = vrijemePocetka;
                        break;
                    }
                case "FrmZaposlenikOdjelaULJP":
                    {
                        ((FrmZaposlenikOdjelaULJP)MdiParent).vrijemePocetka = vrijemePocetka;
                        break;
                    }
            }
        }

        private void timerTrajanjeSmjene_Tick(object sender, EventArgs e)
        {
            TimeSpan trajanje = DateTime.Now - vrijemePocetka;
            string[] trajanjeSplit = trajanje.ToString().Split('.');
            txtTrajanjeSmjene.Text = trajanjeSplit[0];
        }

        private void btnKrajRada_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Potvrđujete li evidentiranje kraja smjene", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                UpravljanjePodacima.SpremanjeUBazu("UPDATE evidencija_radnog_vremena SET kraj_smjene = '" + DateTime.Now + "' WHERE oib = '" + prijavljeniKorisnik.OIB + "' AND pocetak_smjene = '" + vrijemePocetka + "'");
                timerTrajanjeSmjene.Stop();
                txtVrijemeZavrsetka.Text = DateTime.Now.ToString();
                btnPocetakSmjene.Enabled = true;
                btnKrajRada.Enabled = false;
            }
        }

        private void EvidencijaOdlaskaDolaska_Load(object sender, EventArgs e)
        {
            EvidencijaRadnogVremena evidencijaBezZavrsnogVremena;
            evidencijaBezZavrsnogVremena = UpravljanjePodacima.DohvatiEvidencijuRadnogVremena(prijavljeniKorisnik.OIB);
            if (evidencijaBezZavrsnogVremena != null)
            {
                btnPocetakSmjene.Enabled = false;
                btnKrajRada.Enabled = true;
                vrijemePocetka = evidencijaBezZavrsnogVremena.PocetakSmjene;
                timerTrajanjeSmjene.Start();
                txtVrijemePocetka.Text= vrijemePocetka.ToString();
            }

            ProsljedivanjeVremenaMdiParentu();
        }
    }
}
