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
    /// <summary>
    /// Forma za prijavu u aplikaciju.
    /// </summary>
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private int AutorizirajKorisnika (Korisnik autenticiraniKorisnik)
        {
            if (autenticiraniKorisnik!=null)
            {
                switch (autenticiraniKorisnik.Uloga)
                {
                    case "administrator": return 1;
                    case "racunovoda": return 2;
                    case "zaposlenikOdjelaULJP": return 3;
                    case "zaposlenik": return 4;
                    default:
                        break;
                }
            }
            return 0; //pogreška prilikom prijave 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UpravljanjePodacima.PozivanjePohranjeneProcedure("public.provjeriti_pravo_na_godisnji");

            string korisnickoIme = txtKorisnickoIme.Text;
            string lozinka = txtLozinka.Text;
            Korisnik prijavljeniKorisnik = UpravljanjePodacima.AutentificirajKorisnika(korisnickoIme, lozinka);

            if (prijavljeniKorisnik!=null)
            {
                int autorizacija;

                autorizacija = this.AutorizirajKorisnika(prijavljeniKorisnik);

                switch (autorizacija)
                {
                    case 1:
                        {
                            FrmAdministrator frmAdministrator = new FrmAdministrator(prijavljeniKorisnik);
                            this.Hide();
                            frmAdministrator.ShowDialog();
                            break;
                        }
                    case 2:
                        {
                            FrmRacunovoda frmRacunovoda = new FrmRacunovoda(prijavljeniKorisnik);
                            this.Hide();
                            frmRacunovoda.ShowDialog();
                            break;
                        }
                    case 3:
                        {
                            FrmZaposlenikOdjelaULJP frmZaposlenikOdjelaULJP = new FrmZaposlenikOdjelaULJP(prijavljeniKorisnik);
                            this.Hide();
                            frmZaposlenikOdjelaULJP.ShowDialog();
                            break;
                        }
                    case 4:
                        {
                            FrmZaposlenik frmZaposlenik = new FrmZaposlenik(prijavljeniKorisnik);
                            this.Hide();
                            frmZaposlenik.ShowDialog();
                            break;
                        }
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Netočni podaci za prijavu!", "Pogreška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKorisnickoIme.Clear();
                txtLozinka.Clear();
            }
            
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
