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
    public partial class ObracunPlaca : Form
    {
        public ObracunPlaca()
        {
            InitializeComponent();
        }

        private void btnIzvrsiObracun_Click(object sender, EventArgs e)
        {
            PoslovnaLogikaObracunaPlaca poslovnaLogikaObracunaPlaca = new PoslovnaLogikaObracunaPlaca();
            poslovnaLogikaObracunaPlaca.ObracunavanjePlaca();
        }
    }
}
