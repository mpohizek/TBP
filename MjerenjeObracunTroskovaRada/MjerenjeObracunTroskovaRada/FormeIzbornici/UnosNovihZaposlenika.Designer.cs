namespace MjerenjeObracunTroskovaRada.FormeIzbornici
{
    partial class UnosNovihZaposlenika
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
            this.comboBoxOIB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRadnoMjesto = new System.Windows.Forms.TextBox();
            this.datePickerDatumZaposlenja = new System.Windows.Forms.DateTimePicker();
            this.txtBrutoRedovni = new System.Windows.Forms.TextBox();
            this.txtBrutoPrekovremeni = new System.Windows.Forms.TextBox();
            this.txtBrojUzdrzavanihClanova = new System.Windows.Forms.TextBox();
            this.txtBrojDjece = new System.Windows.Forms.TextBox();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "OIB:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxOIB
            // 
            this.comboBoxOIB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOIB.FormattingEnabled = true;
            this.comboBoxOIB.Location = new System.Drawing.Point(217, 6);
            this.comboBoxOIB.Name = "comboBoxOIB";
            this.comboBoxOIB.Size = new System.Drawing.Size(199, 25);
            this.comboBoxOIB.TabIndex = 1;
            this.comboBoxOIB.SelectedIndexChanged += new System.EventHandler(this.comboBoxOIB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Radno mjesto:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Datum zaposlenja:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bruto cijena (redovni sat):";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bruto cijena (prekovremeni sat):";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Broj uzdržavanih članova:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Broj djece:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "IBAN:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtRadnoMjesto
            // 
            this.txtRadnoMjesto.Location = new System.Drawing.Point(217, 43);
            this.txtRadnoMjesto.Name = "txtRadnoMjesto";
            this.txtRadnoMjesto.Size = new System.Drawing.Size(319, 25);
            this.txtRadnoMjesto.TabIndex = 9;
            this.txtRadnoMjesto.TextChanged += new System.EventHandler(this.txtRadnoMjesto_TextChanged);
            // 
            // datePickerDatumZaposlenja
            // 
            this.datePickerDatumZaposlenja.Location = new System.Drawing.Point(217, 87);
            this.datePickerDatumZaposlenja.Name = "datePickerDatumZaposlenja";
            this.datePickerDatumZaposlenja.Size = new System.Drawing.Size(200, 25);
            this.datePickerDatumZaposlenja.TabIndex = 10;
            this.datePickerDatumZaposlenja.ValueChanged += new System.EventHandler(this.datePickerDatumZaposlenja_ValueChanged);
            // 
            // txtBrutoRedovni
            // 
            this.txtBrutoRedovni.Location = new System.Drawing.Point(217, 137);
            this.txtBrutoRedovni.Name = "txtBrutoRedovni";
            this.txtBrutoRedovni.Size = new System.Drawing.Size(200, 25);
            this.txtBrutoRedovni.TabIndex = 11;
            this.txtBrutoRedovni.TextChanged += new System.EventHandler(this.txtBrutoRedovni_TextChanged);
            // 
            // txtBrutoPrekovremeni
            // 
            this.txtBrutoPrekovremeni.Location = new System.Drawing.Point(217, 191);
            this.txtBrutoPrekovremeni.Name = "txtBrutoPrekovremeni";
            this.txtBrutoPrekovremeni.Size = new System.Drawing.Size(200, 25);
            this.txtBrutoPrekovremeni.TabIndex = 12;
            this.txtBrutoPrekovremeni.TextChanged += new System.EventHandler(this.txtBrutoPrekovremeni_TextChanged);
            // 
            // txtBrojUzdrzavanihClanova
            // 
            this.txtBrojUzdrzavanihClanova.Location = new System.Drawing.Point(217, 243);
            this.txtBrojUzdrzavanihClanova.Name = "txtBrojUzdrzavanihClanova";
            this.txtBrojUzdrzavanihClanova.Size = new System.Drawing.Size(200, 25);
            this.txtBrojUzdrzavanihClanova.TabIndex = 13;
            this.txtBrojUzdrzavanihClanova.TextChanged += new System.EventHandler(this.txtBrojUzdrzavanihClanova_TextChanged);
            // 
            // txtBrojDjece
            // 
            this.txtBrojDjece.Location = new System.Drawing.Point(217, 290);
            this.txtBrojDjece.Name = "txtBrojDjece";
            this.txtBrojDjece.Size = new System.Drawing.Size(200, 25);
            this.txtBrojDjece.TabIndex = 14;
            this.txtBrojDjece.TextChanged += new System.EventHandler(this.txtBrojDjece_TextChanged);
            // 
            // txtIBAN
            // 
            this.txtIBAN.Location = new System.Drawing.Point(217, 336);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(200, 25);
            this.txtIBAN.TabIndex = 15;
            this.txtIBAN.TextChanged += new System.EventHandler(this.txtIBAN_TextChanged);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(217, 386);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(200, 42);
            this.btnSpremi.TabIndex = 16;
            this.btnSpremi.Text = "SPREMI";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // UnosNovihZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtIBAN);
            this.Controls.Add(this.txtBrojDjece);
            this.Controls.Add(this.txtBrojUzdrzavanihClanova);
            this.Controls.Add(this.txtBrutoPrekovremeni);
            this.Controls.Add(this.txtBrutoRedovni);
            this.Controls.Add(this.datePickerDatumZaposlenja);
            this.Controls.Add(this.txtRadnoMjesto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxOIB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UnosNovihZaposlenika";
            this.Text = "Unos novih zaposlenika";
            this.Load += new System.EventHandler(this.UnosNovihZaposlenika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOIB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRadnoMjesto;
        private System.Windows.Forms.DateTimePicker datePickerDatumZaposlenja;
        private System.Windows.Forms.TextBox txtBrutoRedovni;
        private System.Windows.Forms.TextBox txtBrutoPrekovremeni;
        private System.Windows.Forms.TextBox txtBrojUzdrzavanihClanova;
        private System.Windows.Forms.TextBox txtBrojDjece;
        private System.Windows.Forms.TextBox txtIBAN;
        private System.Windows.Forms.Button btnSpremi;
    }
}