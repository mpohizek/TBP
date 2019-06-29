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
    public partial class UnosNovihZaposlenika : Form
    {
        public UnosNovihZaposlenika()
        {
            InitializeComponent();
        }

        private void UnosNovihZaposlenika_Load(object sender, EventArgs e)
        {
            List<Korisnik> listaKorisnika = new List<Korisnik>(UpravljanjePodacima.DohvatiKorisnika());
            comboBoxOIB.DataSource = listaKorisnika;
            comboBoxOIB.DisplayMember = "oib";
            comboBoxOIB.ValueMember = "oib";
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (comboBoxOIB.SelectedItem != null && txtRadnoMjesto.Text.Length > 0 &&
                datePickerDatumZaposlenja.Text.Length > 0 && txtBrutoRedovni.Text.Length > 0 &&
                txtBrutoPrekovremeni.Text.Length > 0 && txtBrojUzdrzavanihClanova.Text.Length > 0 &&
                txtBrojDjece.Text.Length > 0 && txtIBAN.Text.Length > 0)
            {
                bool greska = false;
                if (decimal.TryParse(txtBrutoRedovni.Text, out decimal brutoRedovni))
                {
                    if (decimal.TryParse(txtBrutoPrekovremeni.Text, out decimal brutoPrekovremeni))
                    {
                        if (int.TryParse(txtBrojUzdrzavanihClanova.Text, out int brUzdrzavanih))
                        {
                            if (int.TryParse(txtBrojDjece.Text, out int brDjece))
                            {
                                if (txtIBAN.Text.Length == 21)
                                {
                                    UpravljanjePodacima.SpremanjeUBazu("INSERT INTO zaposlenik (oib, radno_mjesto, datum_zaposlenja, bruto_cijena_sat_redovni, bruto_cijena_sat_prekovremeni, broj_uzdrzavanih_clanova, broj_djece, IBAN) VALUES ('" + comboBoxOIB.SelectedValue + "', '" + txtRadnoMjesto.Text + "', '" + datePickerDatumZaposlenja.Value + "', '" + brutoRedovni + "', '" + brutoPrekovremeni + "', '" + brUzdrzavanih + "', '" + brDjece + "', '" + txtIBAN.Text + "')");
                                    MessageBox.Show("Zaposlenik je spremljen u bazu podataka.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    if (this.MdiParent.MdiChildren.Count() > 0)
                                    {
                                        foreach (var item in this.MdiParent.MdiChildren)
                                        {
                                            item.Close();
                                        }
                                    }
                                }
                                else MessageBox.Show("IBAN se sastoji od 21 znaka.", "Pogreška prilikom unosa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else greska = true;
                        }
                        else greska = true;
                    }
                    else greska = true;
                }
                else greska = true;

                if (greska) MessageBox.Show("Bruto cijene, broj uzdržavanih članova i broj djece su numerički podaci", "Pogreška prilikom unosa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Sva polja su obavezna!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void comboBoxOIB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtRadnoMjesto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void datePickerDatumZaposlenja_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtBrutoRedovni_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtBrutoPrekovremeni_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtBrojUzdrzavanihClanova_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtBrojDjece_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtIBAN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
