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
        }
    }
}
