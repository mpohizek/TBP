using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MjerenjeObracunTroskovaRada.FormeIzbornici
{
    public partial class UpravljanjeKorisnickimRacunima : Form
    {
        public UpravljanjeKorisnickimRacunima()
        {
            InitializeComponent();
        }

        private void OsvjeziPopisKorisnika()
        {
            List<Korisnik> listaKorisnika = new List<Korisnik>(UpravljanjePodacima.DohvatiKorisnike("SELECT * FROM korisnik"));
            dgvKorisnici.DataSource = listaKorisnika;
        }

        private void UpravljanjeKorisnickimRacunima_Load(object sender, EventArgs e)
        {
            OsvjeziPopisKorisnika();
        }

        private void btnNoviKorisnik_Click(object sender, EventArgs e)
        {
            FrmKorisnik frmKorisnik = new FrmKorisnik();
            frmKorisnik.ShowDialog();
            OsvjeziPopisKorisnika();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (dgvKorisnici.SelectedRows.Count > 0)
            {
                Korisnik odabraniKorisnik = dgvKorisnici.SelectedRows[0].DataBoundItem as Korisnik;
                FrmKorisnik frmKorisnik = new FrmKorisnik(odabraniKorisnik);
                frmKorisnik.ShowDialog();
                OsvjeziPopisKorisnika();
            }
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            if (dgvKorisnici.SelectedRows.Count > 0)
            {
                string zaPDF = "";
                Korisnik odabraniKorisnik = dgvKorisnici.SelectedRows[0].DataBoundItem as Korisnik;
                zaPDF = odabraniKorisnik.ToString();

                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                        try
                        {
                            PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                            doc.Open();
                            doc.Add(new Paragraph(zaPDF));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            doc.Close();
                        }
                    }
                }
            }

            
        }
    }
}
