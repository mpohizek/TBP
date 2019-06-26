﻿using System;
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
    public partial class FrmZaposlenik : Form
    {
        public Korisnik prijavljeniKorisnik { get; set; } = null;
        public FrmZaposlenik(Korisnik k)
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

        private void FrmZaposlenik_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmZaposlenik_Load(object sender, EventArgs e)
        {
            FormeIzbornici.EvidencijaOdlaskaDolaska evidencijaOdlaskaDolaska = new FormeIzbornici.EvidencijaOdlaskaDolaska();
            evidencijaOdlaskaDolaska.MdiParent = this;
            evidencijaOdlaskaDolaska.WindowState = FormWindowState.Maximized;
            evidencijaOdlaskaDolaska.Show();
        }

        private void evidencijaDolaskaOdlaskaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormeIzbornici.EvidencijaOdlaskaDolaska evidencijaOdlaskaDolaska = new FormeIzbornici.EvidencijaOdlaskaDolaska();
            evidencijaOdlaskaDolaska.MdiParent = this;
            evidencijaOdlaskaDolaska.WindowState = FormWindowState.Maximized;
            evidencijaOdlaskaDolaska.Show();
        }

        private void planiranjeGodisnjegOdmoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormeIzbornici.PlaniranjeGodisnjegOdmora planiranjeGodisnjegOdmora = new FormeIzbornici.PlaniranjeGodisnjegOdmora();
            planiranjeGodisnjegOdmora.MdiParent = this;
            planiranjeGodisnjegOdmora.WindowState = FormWindowState.Maximized;
            planiranjeGodisnjegOdmora.Show();
        }

        private void pregledStanjaPrekovremenihSatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormeIzbornici.PregledStanjaPrekovremenihSati pregledStanjaPrekovremenihSati = new FormeIzbornici.PregledStanjaPrekovremenihSati();
            pregledStanjaPrekovremenihSati.MdiParent = this;
            pregledStanjaPrekovremenihSati.WindowState = FormWindowState.Maximized;
            pregledStanjaPrekovremenihSati.Show();
        }
    }
}
