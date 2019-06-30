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
    public partial class PlaniranjeGodisnjegOdmora : Form
    {
        public Korisnik PrijavljeniKorisnik { get; set; }
        public PlaniranjeGodisnjegOdmora(Korisnik k)
        {
            InitializeComponent();
            PrijavljeniKorisnik = k;
        }
        private int OsvjeziBrojNeiskoristenihDanaGO()
        {
            object o = UpravljanjePodacima.DohvatiVrijednost("SELECT COALESCE(neiskoristeno_go_tekuce_god, 0) FROM zaposlenik WHERE oib = '" + PrijavljeniKorisnik.OIB + "'");
            if (o != null)
            {
                int brDana = Convert.ToInt32(o);
                return brDana;
            }
            return 0;
        }

        private void OsvjeziPopisKoristenjaGO()
        {
            List<KoristenjeGodisnjegOdmora> popis = UpravljanjePodacima.DohvatiKoristenjeGO("SELECT * FROM koristenje_godisnjeg_odmora WHERE oib= '"+ PrijavljeniKorisnik.OIB +"' AND godina = '"+ Convert.ToInt32(DateTime.Now.Year) +"'");
            dgvKoristenjeGO.DataSource = popis;
        }

        private void PlaniranjeGodisnjegOdmora_Load(object sender, EventArgs e)
        {
            object o = UpravljanjePodacima.DohvatiVrijednost("SELECT COALESCE(neiskoristeno_go_tekuce_god, 0) FROM zaposlenik WHERE oib = '" + PrijavljeniKorisnik.OIB + "' AND neiskoristeno_go_tekuce_god IS NULL");
            txtNeiskoristenoGO.Text = OsvjeziBrojNeiskoristenihDanaGO().ToString();
            if (o != null)
            {
                MessageBox.Show("Nemate pravo na GO zbog duljine staža", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (o == null && txtNeiskoristenoGO.Text == "0")
            {
                MessageBox.Show("Nemate neiskorištenih dana GO na raspolaganju.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (DateTime.Now.Month == 1)
                {
                    btnReset.Enabled = true;
                }
            }
            else if (o == null && txtNeiskoristenoGO.Text != "0")
            {
                OsvjeziPopisKoristenjaGO();
                btnEvidentiraj.Enabled = true;

                if (DateTime.Now.Month == 1)
                {
                    btnSljedecaGodina.Enabled = true;
                    btnNovčanaNaknada.Enabled = true;
                }
            }
        }

        private void btnEvidentiraj_Click(object sender, EventArgs e)
        {
            FrmEvidentirajGo frmEvidentirajGo = new FrmEvidentirajGo(PrijavljeniKorisnik, dgvKoristenjeGO.RowCount);
            frmEvidentirajGo.ShowDialog();
            txtNeiskoristenoGO.Text = OsvjeziBrojNeiskoristenihDanaGO().ToString();
            OsvjeziPopisKoristenjaGO();
        }

        private void btnSljedecaGodina_Click(object sender, EventArgs e)
        {
            UpravljanjePodacima.SpremanjeUBazu("UPDATE zaposlenik SET neiskoristeno_go_tekuce_god = '"+ OsvjeziBrojNeiskoristenihDanaGO() + 60 + "'  WHERE oib = '"+ PrijavljeniKorisnik.OIB +"'");
            txtNeiskoristenoGO.Text = OsvjeziBrojNeiskoristenihDanaGO().ToString();
        }

        private void btnNovcanaNaknada_Click(object sender, EventArgs e)
        {
            UpravljanjePodacima.SpremanjeUBazu("UPDATE zaposlenik SET neiskoristeno_go_tekuce_god = 0 WHERE oib = '" + PrijavljeniKorisnik.OIB + "'");
            txtNeiskoristenoGO.Text = OsvjeziBrojNeiskoristenihDanaGO().ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UpravljanjePodacima.SpremanjeUBazu("UPDATE zaposlenik SET neiskoristeno_go_tekuce_god = 60 WHERE oib = '" + PrijavljeniKorisnik.OIB + "'");
            txtNeiskoristenoGO.Text = OsvjeziBrojNeiskoristenihDanaGO().ToString();
        }
    }
}
