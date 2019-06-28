namespace MjerenjeObracunTroskovaRada.FormeIzbornici
{
    partial class EvidencijaOdlaskaDolaska
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
            this.components = new System.ComponentModel.Container();
            this.btnPocetakSmjene = new System.Windows.Forms.Button();
            this.btnKrajRada = new System.Windows.Forms.Button();
            this.txtVrijemePocetka = new System.Windows.Forms.TextBox();
            this.txtVrijemeZavrsetka = new System.Windows.Forms.TextBox();
            this.txtTrajanjeSmjene = new System.Windows.Forms.TextBox();
            this.timerTrajanjeSmjene = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPocetakSmjene
            // 
            this.btnPocetakSmjene.Location = new System.Drawing.Point(12, 12);
            this.btnPocetakSmjene.Name = "btnPocetakSmjene";
            this.btnPocetakSmjene.Size = new System.Drawing.Size(155, 36);
            this.btnPocetakSmjene.TabIndex = 3;
            this.btnPocetakSmjene.Text = "Početak rada";
            this.btnPocetakSmjene.UseVisualStyleBackColor = true;
            this.btnPocetakSmjene.Click += new System.EventHandler(this.btnPocetakSmjene_Click);
            // 
            // btnKrajRada
            // 
            this.btnKrajRada.Enabled = false;
            this.btnKrajRada.Location = new System.Drawing.Point(378, 12);
            this.btnKrajRada.Name = "btnKrajRada";
            this.btnKrajRada.Size = new System.Drawing.Size(155, 36);
            this.btnKrajRada.TabIndex = 4;
            this.btnKrajRada.Text = "Kraj rada";
            this.btnKrajRada.UseVisualStyleBackColor = true;
            this.btnKrajRada.Click += new System.EventHandler(this.btnKrajRada_Click);
            // 
            // txtVrijemePocetka
            // 
            this.txtVrijemePocetka.Location = new System.Drawing.Point(12, 76);
            this.txtVrijemePocetka.Name = "txtVrijemePocetka";
            this.txtVrijemePocetka.ReadOnly = true;
            this.txtVrijemePocetka.Size = new System.Drawing.Size(155, 25);
            this.txtVrijemePocetka.TabIndex = 5;
            // 
            // txtVrijemeZavrsetka
            // 
            this.txtVrijemeZavrsetka.Location = new System.Drawing.Point(378, 76);
            this.txtVrijemeZavrsetka.Name = "txtVrijemeZavrsetka";
            this.txtVrijemeZavrsetka.ReadOnly = true;
            this.txtVrijemeZavrsetka.Size = new System.Drawing.Size(155, 25);
            this.txtVrijemeZavrsetka.TabIndex = 6;
            // 
            // txtTrajanjeSmjene
            // 
            this.txtTrajanjeSmjene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTrajanjeSmjene.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrajanjeSmjene.Location = new System.Drawing.Point(242, 76);
            this.txtTrajanjeSmjene.Name = "txtTrajanjeSmjene";
            this.txtTrajanjeSmjene.ReadOnly = true;
            this.txtTrajanjeSmjene.Size = new System.Drawing.Size(58, 25);
            this.txtTrajanjeSmjene.TabIndex = 7;
            // 
            // timerTrajanjeSmjene
            // 
            this.timerTrajanjeSmjene.Interval = 1000;
            this.timerTrajanjeSmjene.Tick += new System.EventHandler(this.timerTrajanjeSmjene_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Trajanje smjene";
            // 
            // EvidencijaOdlaskaDolaska
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTrajanjeSmjene);
            this.Controls.Add(this.txtVrijemeZavrsetka);
            this.Controls.Add(this.txtVrijemePocetka);
            this.Controls.Add(this.btnKrajRada);
            this.Controls.Add(this.btnPocetakSmjene);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EvidencijaOdlaskaDolaska";
            this.Text = "Evidencija dolaska / odlaska s posla";
            this.Load += new System.EventHandler(this.EvidencijaOdlaskaDolaska_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPocetakSmjene;
        private System.Windows.Forms.Button btnKrajRada;
        private System.Windows.Forms.TextBox txtVrijemePocetka;
        private System.Windows.Forms.TextBox txtVrijemeZavrsetka;
        private System.Windows.Forms.TextBox txtTrajanjeSmjene;
        private System.Windows.Forms.Timer timerTrajanjeSmjene;
        private System.Windows.Forms.Label label1;
    }
}