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
    public partial class AzuriranjePodatakaZaposlenika : Form
    {
        public List<Zaposlenik> listaZaposlenika{ get; set; }
        public AzuriranjePodatakaZaposlenika()
        {
            InitializeComponent();
            listaZaposlenika = new List<Zaposlenik>();
        }

        private void AzuriranjePodatakaZaposlenika_Load(object sender, EventArgs e)
        {
            listaZaposlenika = new List<Zaposlenik>(UpravljanjePodacima.DohvatiZaposlenike());
            comboBoxOIB.DataSource = listaZaposlenika;
            comboBoxOIB.DisplayMember = "oib";
            comboBoxOIB.ValueMember = "oib";
            string oib = comboBoxOIB.SelectedValue.ToString();
            foreach (var zaposlenik in listaZaposlenika)
            {
                if (zaposlenik.OIB == oib)
                {
                    txtRadnoMjesto.Text = zaposlenik.RadnoMjesto;
                    datePickerDatumZaposlenja.Value = zaposlenik.DatumZaposlenja;
                    txtBrutoRedovni.Text = zaposlenik.BrutoCijenaSatRedovni.ToString();
                    txtBrutoPrekovremeni.Text = zaposlenik.BrutoCijenaSatPrekovremeni.ToString();
                    txtBrojUzdrzavanihClanova.Text = zaposlenik.BrojUzdrzavanihClanova.ToString();
                    txtBrojDjece.Text = zaposlenik.BrojDjece.ToString();
                    txtIBAN.Text = zaposlenik.IBAN.ToString();
                }
            }
        }

        private void comboBoxOIB_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxOIB.SelectedItem != null)
            {
                string oib = comboBoxOIB.SelectedValue.ToString();
                foreach (var zaposlenik in listaZaposlenika)
                {
                    if (zaposlenik.OIB == oib)
                    {
                        txtRadnoMjesto.Text = zaposlenik.RadnoMjesto;
                        datePickerDatumZaposlenja.Value = zaposlenik.DatumZaposlenja;
                        txtBrutoRedovni.Text = zaposlenik.BrutoCijenaSatRedovni.ToString();
                        txtBrutoPrekovremeni.Text = zaposlenik.BrutoCijenaSatPrekovremeni.ToString();
                        txtBrojUzdrzavanihClanova.Text = zaposlenik.BrojUzdrzavanihClanova.ToString();
                        txtBrojDjece.Text = zaposlenik.BrojDjece.ToString();
                        txtIBAN.Text = zaposlenik.IBAN.ToString();
                    }
                }
            }
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
                                    UpravljanjePodacima.SpremanjeUBazu("UPDATE zaposlenik SET radno_mjesto = '"+ txtRadnoMjesto.Text +"', datum_zaposlenja = '"+ datePickerDatumZaposlenja.Value +"', bruto_cijena_sat_redovni = '"+ brutoRedovni +"', bruto_cijena_sat_prekovremeni = '"+ brutoPrekovremeni +"', broj_uzdrzavanih_clanova = '"+ brUzdrzavanih +"', broj_djece = '"+ brDjece +"', IBAN = '"+ txtIBAN.Text +"' WHERE oib = '"+comboBoxOIB.SelectedValue+"'");
                                    MessageBox.Show("Podaci o zaposleniku su ažurirani.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
