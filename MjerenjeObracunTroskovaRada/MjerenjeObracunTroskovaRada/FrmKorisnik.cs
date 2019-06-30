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
    public partial class FrmKorisnik : Form
    {
        public Korisnik OdabraniKorisnik { get; set; }
        public FrmKorisnik()
        {
            InitializeComponent();
        }
        public FrmKorisnik(Korisnik k)
        {
            InitializeComponent();
            OdabraniKorisnik = k;
        }

        private void FrmKorisnik_Load(object sender, EventArgs e)
        {
            comboBoxUloga.Items.Add("administrator");
            comboBoxUloga.Items.Add("racunovoda");
            comboBoxUloga.Items.Add("zaposlenikOdjelaULJP");
            comboBoxUloga.Items.Add("zaposlenik");
            if (OdabraniKorisnik != null)
            {
                txtOIB.Text = OdabraniKorisnik.OIB;
                txtKorIme.Text = OdabraniKorisnik.KorisnickoIme;
                txtZaporka.Text = OdabraniKorisnik.Zaporka;
                txtIme.Text = OdabraniKorisnik.Ime;
                txtPrezime.Text = OdabraniKorisnik.Prezime;
                txtOIB.ReadOnly = true;
                switch (OdabraniKorisnik.Uloga)
                {
                    case "administrator":
                        {
                            comboBoxUloga.SelectedIndex = 0;
                            comboBoxUloga.SelectedValue = "administrator";
                            break;
                        }
                    case "racunovoda":
                        {
                            comboBoxUloga.SelectedIndex = 1;
                            comboBoxUloga.SelectedValue = "racunovoda";
                            break;
                        }
                    case "zaposlenikOdjelaULJP":
                        {
                            comboBoxUloga.SelectedIndex = 2;
                            comboBoxUloga.SelectedValue = "zaposlenikOdjelaULJP";
                            break;
                        }
                    case "zaposlenik":
                        {
                            comboBoxUloga.SelectedIndex = 3;
                            comboBoxUloga.SelectedValue = "zaposlenik";
                            break;
                        }
                }
                
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (OdabraniKorisnik == null)
            {
                if (txtOIB.Text.Length > 0 && txtKorIme.Text.Length > 0 &&
                    txtZaporka.Text.Length > 0 && txtIme.Text.Length > 0 &&
                    txtPrezime.Text.Length > 0 && comboBoxUloga.SelectedItem != null)
                {
                    if (txtOIB.Text.Length == 11)
                    {
                        try
                        {
                            UpravljanjePodacima.SpremanjeUBazu("INSERT INTO korisnik (oib, korisnicko_ime, zaporka, ime, prezime, uloga) VALUES ('" + txtOIB.Text + "', '" + txtKorIme.Text + "', '" + txtZaporka.Text + "', '" + txtIme.Text + "', '" + txtPrezime.Text + "', '" + comboBoxUloga.GetItemText(this.comboBoxUloga.SelectedItem) + "')");
                            MessageBox.Show("Korisnik je spremljen u bazu podataka.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (Exception ex)
                        { 
                        MessageBox.Show(ex.Message, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                }
                    else MessageBox.Show("OIB ima 11 znamenki!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Sva polja su obavezna!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else //Ažuriranje postojećeg korisnika
            {
                if (txtOIB.Text.Length > 0 && txtKorIme.Text.Length > 0 &&
                    txtZaporka.Text.Length > 0 && txtIme.Text.Length > 0 &&
                    txtPrezime.Text.Length > 0 && comboBoxUloga.SelectedItem != null)
                {
                    if (txtOIB.Text.Length == 11)
                    {
                        UpravljanjePodacima.SpremanjeUBazu("UPDATE korisnik SET korisnicko_ime = '" + txtKorIme.Text + "', zaporka = '" + txtZaporka.Text + "', ime = '" + txtIme.Text + "', prezime = '" + txtPrezime.Text + "', uloga = '"+ comboBoxUloga.GetItemText(this.comboBoxUloga.SelectedItem) +"' WHERE oib='"+ OdabraniKorisnik.OIB +"'");
                        MessageBox.Show("Podaci o korisniku su ažurirani.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else MessageBox.Show("OIB ima 11 znamenki!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Sva polja su obavezna!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
