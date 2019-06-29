using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MjerenjeObracunTroskovaRada
{
    public partial class UpozorenjeZbogNeevidentiranogKrajaSmjene : Form
    {
        public Korisnik prijavljeniKorisnik { get; set; }
        public DateTime vrijemePocetka { get; set; }

        public UpozorenjeZbogNeevidentiranogKrajaSmjene(Korisnik k, DateTime v)
        {
            InitializeComponent();
            prijavljeniKorisnik = k;
            vrijemePocetka = v;
        }

        private void UpozorenjeZbogNeevidentiranogKrajaSmjene_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnEvidentiratiKraj_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpravljanjePodacima.SpremanjeUBazu("UPDATE evidencija_radnog_vremena SET kraj_smjene = '" + DateTime.Now + "' WHERE oib = '" + prijavljeniKorisnik.OIB + "' AND pocetak_smjene = '" + vrijemePocetka + "'");
            this.Close();
            Application.Exit();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpravljanjePodacima.SpremanjeUBazu("DELETE FROM evidencija_radnog_vremena WHERE oib='" + prijavljeniKorisnik.OIB +"' AND kraj_smjene IS NOT DISTINCT FROM NULL");
            this.Close();
            Application.Exit();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Application.Exit();
        }
    }
    }
