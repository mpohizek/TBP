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
    public partial class UpozorenjePrijeOdjave : Form
    {
        public Korisnik prijavljeniKorisnik { get; set; }
        public DateTime vrijemePocetka { get; set; }
        public UpozorenjePrijeOdjave(Korisnik k, DateTime v)
        {
            InitializeComponent();
            prijavljeniKorisnik = k;
            vrijemePocetka = v;
        }

        private void UpozorenjePrijeOdjave_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnEvidentiratiKraj_Click(object sender, EventArgs e)
        {
            UpravljanjePodacima.SpremanjeUBazu("UPDATE evidencija_radnog_vremena SET kraj_smjene = '" + DateTime.Now + "' WHERE oib = '" + prijavljeniKorisnik.OIB + "' AND pocetak_smjene = '" + vrijemePocetka + "'");
            this.Hide();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpravljanjePodacima.SpremanjeUBazu("DELETE FROM evidencija_radnog_vremena WHERE oib='" + prijavljeniKorisnik.OIB + "' AND kraj_smjene IS NOT DISTINCT FROM NULL");
        }

        private void btnOdjavi_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
