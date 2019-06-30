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
    public partial class FrmRacunovoda : Form
    {
        public Korisnik prijavljeniKorisnik { get; set; } = null;
        public DateTime vrijemePocetka { get; set; }
        public FrmRacunovoda(Korisnik k)
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
                EvidencijaRadnogVremena evidencijaBezZavrsnogVremena = UpravljanjePodacima.DohvatiEvidencijuRadnogVremena(prijavljeniKorisnik.OIB);

                if (evidencijaBezZavrsnogVremena != null)
                {
                    if (this.MdiChildren.Count() > 0)
                    {
                        foreach (var item in this.MdiChildren)
                        {
                            item.Close();
                        }
                    }
                    UpozorenjePrijeOdjave upozorenjePrijeOdjave = new UpozorenjePrijeOdjave(prijavljeniKorisnik, vrijemePocetka);
                    this.Hide();
                    upozorenjePrijeOdjave.ShowDialog();
                    this.Show();
                }
                else
                {
                    FrmLogin frmLogin = new FrmLogin();
                    this.Hide();
                    frmLogin.ShowDialog();
                    if (this.MdiChildren.Count() > 0)
                    {
                        foreach (var item in this.MdiChildren)
                        {
                            item.Close();
                        }
                    }
                    this.Close();
                }
            }
        }

        private void FrmRacunovoda_FormClosed(object sender, FormClosedEventArgs e)
        {
            EvidencijaRadnogVremena evidencijaBezZavrsnogVremena = UpravljanjePodacima.DohvatiEvidencijuRadnogVremena(prijavljeniKorisnik.OIB);
            if (evidencijaBezZavrsnogVremena != null)
            {
                UpozorenjeZbogNeevidentiranogKrajaSmjene upozorenjeZbogNeevidentiranogKrajaSmjene = new UpozorenjeZbogNeevidentiranogKrajaSmjene(prijavljeniKorisnik, vrijemePocetka);
                this.Hide();
                upozorenjeZbogNeevidentiranogKrajaSmjene.ShowDialog();
                if (this.MdiChildren.Count() > 0)
                {
                    foreach (var item in this.MdiChildren)
                    {
                        item.Close();
                    }
                }
                this.Close();
            }
            else
            {
                Application.Exit();
            }
        }

        private void FrmRacunovoda_Load(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                foreach (var item in this.MdiChildren)
                {
                    item.Close();
                }
            }
            FormeIzbornici.EvidencijaOdlaskaDolaska evidencijaOdlaskaDolaska = new FormeIzbornici.EvidencijaOdlaskaDolaska(prijavljeniKorisnik, "FrmRacunovoda");
            evidencijaOdlaskaDolaska.MdiParent = this;
            evidencijaOdlaskaDolaska.WindowState = FormWindowState.Maximized;
            evidencijaOdlaskaDolaska.Show();
        }

        private void obracunPlaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                foreach (var item in this.MdiChildren)
                {
                    item.Close();
                }
            }
            FormeIzbornici.ObracunPlaca obracunPlaca = new FormeIzbornici.ObracunPlaca();
            obracunPlaca.MdiParent = this;
            obracunPlaca.WindowState = FormWindowState.Maximized;
            obracunPlaca.Show();
        }

        private void evidencijaDolaskaOdlaskaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                foreach (var item in this.MdiChildren)
                {
                    item.Close();
                }
            }
            FormeIzbornici.EvidencijaOdlaskaDolaska evidencijaOdlaskaDolaska = new FormeIzbornici.EvidencijaOdlaskaDolaska(prijavljeniKorisnik, "FrmRacunovoda");
            evidencijaOdlaskaDolaska.MdiParent = this;
            evidencijaOdlaskaDolaska.WindowState = FormWindowState.Maximized;
            evidencijaOdlaskaDolaska.Show();
        }

        private void planiranjeGodisnjegOdmoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                foreach (var item in this.MdiChildren)
                {
                    item.Close();
                }
            }
            FormeIzbornici.PlaniranjeGodisnjegOdmora planiranjeGodisnjegOdmora = new FormeIzbornici.PlaniranjeGodisnjegOdmora(prijavljeniKorisnik);
            planiranjeGodisnjegOdmora.MdiParent = this;
            planiranjeGodisnjegOdmora.WindowState = FormWindowState.Maximized;
            planiranjeGodisnjegOdmora.Show();
        }

        private void pregledStanjaPrekovremenihSatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                foreach (var item in this.MdiChildren)
                {
                    item.Close();
                }
            }
            FormeIzbornici.PregledStanjaPrekovremenihSati pregledStanjaPrekovremenihSati = new FormeIzbornici.PregledStanjaPrekovremenihSati();
            pregledStanjaPrekovremenihSati.MdiParent = this;
            pregledStanjaPrekovremenihSati.WindowState = FormWindowState.Maximized;
            pregledStanjaPrekovremenihSati.Show();
        }
    }
}
