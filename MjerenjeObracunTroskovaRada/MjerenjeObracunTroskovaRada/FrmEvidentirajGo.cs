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
    public partial class FrmEvidentirajGo : Form
    {
        public Korisnik PrijavljeniKorisnik { get; set; }
        public int BrojKoristenja { get; set; }
        public FrmEvidentirajGo(Korisnik k, int br)
        {
            InitializeComponent();
            PrijavljeniKorisnik = k;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                UpravljanjePodacima.SpremanjeUBazu("INSERT INTO koristenje_godisnjeg_odmora (oib, godina, redni_br_koristenja, pocetak, kraj) VALUES ('"+PrijavljeniKorisnik.OIB+"', '"+ Convert.ToInt32(DateTime.Now.Year) + "', '"+ BrojKoristenja+1 +"', '"+ datePickerPocetak.Value + "', '" + datePickerZavrsetak.Value + "')");
                MessageBox.Show("Odlazak na godišnji odmor je spremljen u bazu.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
