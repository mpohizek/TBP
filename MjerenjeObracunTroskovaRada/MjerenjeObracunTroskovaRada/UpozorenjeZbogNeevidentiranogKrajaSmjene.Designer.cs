namespace MjerenjeObracunTroskovaRada
{
    partial class UpozorenjeZbogNeevidentiranogKrajaSmjene
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpozorenjeZbogNeevidentiranogKrajaSmjene));
            this.label1 = new System.Windows.Forms.Label();
            this.btnEvidentiratiKraj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Niste evidentirali kraj smjene. Što želite učiniti?";
            // 
            // btnEvidentiratiKraj
            // 
            this.btnEvidentiratiKraj.Location = new System.Drawing.Point(112, 31);
            this.btnEvidentiratiKraj.Name = "btnEvidentiratiKraj";
            this.btnEvidentiratiKraj.Size = new System.Drawing.Size(183, 51);
            this.btnEvidentiratiKraj.TabIndex = 1;
            this.btnEvidentiratiKraj.Text = "Evidentirati kraj smjene sad";
            this.btnEvidentiratiKraj.UseVisualStyleBackColor = true;
            this.btnEvidentiratiKraj.Click += new System.EventHandler(this.btnEvidentiratiKraj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(112, 106);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(183, 51);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obrisati evidenciju početka smjene";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(112, 176);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(183, 51);
            this.btnZatvori.TabIndex = 4;
            this.btnZatvori.Text = "Zatvoriti aplikaciju";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // UpozorenjeZbogNeevidentiranogKrajaSmjene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 244);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnEvidentiratiKraj);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpozorenjeZbogNeevidentiranogKrajaSmjene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upozorenje";
            this.Load += new System.EventHandler(this.UpozorenjeZbogNeevidentiranogKrajaSmjene_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEvidentiratiKraj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnZatvori;
    }
}