namespace MjerenjeObracunTroskovaRada
{
    partial class FrmKorisnik
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.txtZaporka = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.comboBoxUloga = new System.Windows.Forms.ComboBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "OIB:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Korisničko ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zaporka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ime:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prezime:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Uloga:";
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(130, 6);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(308, 25);
            this.txtOIB.TabIndex = 6;
            // 
            // txtKorIme
            // 
            this.txtKorIme.Location = new System.Drawing.Point(130, 43);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(308, 25);
            this.txtKorIme.TabIndex = 7;
            // 
            // txtZaporka
            // 
            this.txtZaporka.Location = new System.Drawing.Point(130, 80);
            this.txtZaporka.Name = "txtZaporka";
            this.txtZaporka.Size = new System.Drawing.Size(308, 25);
            this.txtZaporka.TabIndex = 8;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(130, 117);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(308, 25);
            this.txtIme.TabIndex = 9;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(130, 154);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(308, 25);
            this.txtPrezime.TabIndex = 10;
            // 
            // comboBoxUloga
            // 
            this.comboBoxUloga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUloga.FormattingEnabled = true;
            this.comboBoxUloga.Location = new System.Drawing.Point(130, 191);
            this.comboBoxUloga.Name = "comboBoxUloga";
            this.comboBoxUloga.Size = new System.Drawing.Size(308, 25);
            this.comboBoxUloga.TabIndex = 11;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(192, 241);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(178, 44);
            this.btnSpremi.TabIndex = 12;
            this.btnSpremi.Text = "SPREMI";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // FrmKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.comboBoxUloga);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtZaporka);
            this.Controls.Add(this.txtKorIme);
            this.Controls.Add(this.txtOIB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmKorisnik";
            this.Text = "Korisnik";
            this.Load += new System.EventHandler(this.FrmKorisnik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.TextBox txtZaporka;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.ComboBox comboBoxUloga;
        private System.Windows.Forms.Button btnSpremi;
    }
}