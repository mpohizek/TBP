namespace MjerenjeObracunTroskovaRada.FormeIzbornici
{
    partial class UpravljanjeKorisnickimRacunima
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.btnNoviKorisnik = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnIspisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToAddRows = false;
            this.dgvKorisnici.AllowUserToDeleteRows = false;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Location = new System.Drawing.Point(12, 12);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.ReadOnly = true;
            this.dgvKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisnici.Size = new System.Drawing.Size(713, 345);
            this.dgvKorisnici.TabIndex = 0;
            // 
            // btnNoviKorisnik
            // 
            this.btnNoviKorisnik.Location = new System.Drawing.Point(12, 363);
            this.btnNoviKorisnik.Name = "btnNoviKorisnik";
            this.btnNoviKorisnik.Size = new System.Drawing.Size(247, 39);
            this.btnNoviKorisnik.TabIndex = 1;
            this.btnNoviKorisnik.Text = "DODAJ NOVOG KORISNIKA";
            this.btnNoviKorisnik.UseVisualStyleBackColor = true;
            this.btnNoviKorisnik.Click += new System.EventHandler(this.btnNoviKorisnik_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(265, 363);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(247, 39);
            this.btnAzuriraj.TabIndex = 2;
            this.btnAzuriraj.Text = "AŽURIRAJ POSTOJEĆEG KORISNIKA";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnIspisi
            // 
            this.btnIspisi.ForeColor = System.Drawing.Color.DarkRed;
            this.btnIspisi.Location = new System.Drawing.Point(740, 12);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(76, 39);
            this.btnIspisi.TabIndex = 14;
            this.btnIspisi.Text = "ISPIŠI";
            this.btnIspisi.UseVisualStyleBackColor = true;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // UpravljanjeKorisnickimRacunima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 454);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnNoviKorisnik);
            this.Controls.Add(this.dgvKorisnici);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpravljanjeKorisnickimRacunima";
            this.Text = "Upravljanje korisničkim računima";
            this.Load += new System.EventHandler(this.UpravljanjeKorisnickimRacunima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.Button btnNoviKorisnik;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnIspisi;
    }
}