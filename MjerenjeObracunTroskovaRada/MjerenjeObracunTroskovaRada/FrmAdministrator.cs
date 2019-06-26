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
    public partial class FrmAdministrator : Form
    {
        public Korisnik prijavljeniKorisnik { get; set; } = null;
        public FrmAdministrator(Korisnik k)
        {
            InitializeComponent();
            prijavljeniKorisnik = k;
            uiActionOdjava.Items.Add("Odjava");
            txtImeKorisnika.Text = k.Ime + " " + k.Prezime;
        }

        private void uiActionOdjava_SelectedValueChanged(object sender, EventArgs e)
        {
            if (uiActionOdjava.SelectedItem != null)
            {
                FrmLogin frmLogin = new FrmLogin();
                this.Hide();
                frmLogin.ShowDialog();
            }
        }

        private void FrmAdministrator_Load(object sender, EventArgs e)
        {
            FormeIzbornici.UpravljanjeKorisnickimRacunima upravljanjeKorisnickimRacunima = new FormeIzbornici.UpravljanjeKorisnickimRacunima();
            upravljanjeKorisnickimRacunima.MdiParent = this;
            upravljanjeKorisnickimRacunima.WindowState = FormWindowState.Maximized;
            upravljanjeKorisnickimRacunima.Show();
        }

        private void upravljanjeKorisnickimRacunimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormeIzbornici.UpravljanjeKorisnickimRacunima upravljanjeKorisnickimRacunima = new FormeIzbornici.UpravljanjeKorisnickimRacunima();
            upravljanjeKorisnickimRacunima.MdiParent = this;
            upravljanjeKorisnickimRacunima.WindowState = FormWindowState.Maximized;
            upravljanjeKorisnickimRacunima.Show();
        }

        private void FrmAdministrator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
