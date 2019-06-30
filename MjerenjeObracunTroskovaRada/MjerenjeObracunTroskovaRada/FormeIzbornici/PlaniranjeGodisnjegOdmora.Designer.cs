namespace MjerenjeObracunTroskovaRada.FormeIzbornici
{
    partial class PlaniranjeGodisnjegOdmora
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
            this.txtNeiskoristenoGO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvKoristenjeGO = new System.Windows.Forms.DataGridView();
            this.btnEvidentiraj = new System.Windows.Forms.Button();
            this.btnSljedecaGodina = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNovčanaNaknada = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKoristenjeGO)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Neiskorišteno GO ove godine:";
            // 
            // txtNeiskoristenoGO
            // 
            this.txtNeiskoristenoGO.Location = new System.Drawing.Point(210, 6);
            this.txtNeiskoristenoGO.Name = "txtNeiskoristenoGO";
            this.txtNeiskoristenoGO.ReadOnly = true;
            this.txtNeiskoristenoGO.Size = new System.Drawing.Size(100, 25);
            this.txtNeiskoristenoGO.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Korištenje godišnjeg odmora u tekućoj godini:";
            // 
            // dgvKoristenjeGO
            // 
            this.dgvKoristenjeGO.AllowUserToAddRows = false;
            this.dgvKoristenjeGO.AllowUserToDeleteRows = false;
            this.dgvKoristenjeGO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKoristenjeGO.Location = new System.Drawing.Point(20, 95);
            this.dgvKoristenjeGO.Name = "dgvKoristenjeGO";
            this.dgvKoristenjeGO.ReadOnly = true;
            this.dgvKoristenjeGO.Size = new System.Drawing.Size(647, 174);
            this.dgvKoristenjeGO.TabIndex = 3;
            // 
            // btnEvidentiraj
            // 
            this.btnEvidentiraj.Enabled = false;
            this.btnEvidentiraj.Location = new System.Drawing.Point(673, 95);
            this.btnEvidentiraj.Name = "btnEvidentiraj";
            this.btnEvidentiraj.Size = new System.Drawing.Size(184, 44);
            this.btnEvidentiraj.TabIndex = 4;
            this.btnEvidentiraj.Text = "Evidentiraj godišnji odmor";
            this.btnEvidentiraj.UseVisualStyleBackColor = true;
            this.btnEvidentiraj.Click += new System.EventHandler(this.btnEvidentiraj_Click);
            // 
            // btnSljedecaGodina
            // 
            this.btnSljedecaGodina.Enabled = false;
            this.btnSljedecaGodina.Location = new System.Drawing.Point(20, 412);
            this.btnSljedecaGodina.Name = "btnSljedecaGodina";
            this.btnSljedecaGodina.Size = new System.Drawing.Size(344, 35);
            this.btnSljedecaGodina.TabIndex = 5;
            this.btnSljedecaGodina.Text = "Prijenos neiskorištenog iz prošle godine u ovu";
            this.btnSljedecaGodina.UseVisualStyleBackColor = true;
            this.btnSljedecaGodina.Click += new System.EventHandler(this.btnSljedecaGodina_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ova evidencija je dostupna u siječnju:";
            // 
            // btnNovčanaNaknada
            // 
            this.btnNovčanaNaknada.Enabled = false;
            this.btnNovčanaNaknada.Location = new System.Drawing.Point(20, 453);
            this.btnNovčanaNaknada.Name = "btnNovčanaNaknada";
            this.btnNovčanaNaknada.Size = new System.Drawing.Size(344, 35);
            this.btnNovčanaNaknada.TabIndex = 7;
            this.btnNovčanaNaknada.Text = "Traženje novčane naknade za neiskorišteni dio GO";
            this.btnNovčanaNaknada.UseVisualStyleBackColor = true;
            this.btnNovčanaNaknada.Click += new System.EventHandler(this.btnNovcanaNaknada_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(20, 371);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(344, 35);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Postavljanje broja neiskorištenih dana GO na 60";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // PlaniranjeGodisnjegOdmora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNovčanaNaknada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSljedecaGodina);
            this.Controls.Add(this.btnEvidentiraj);
            this.Controls.Add(this.dgvKoristenjeGO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNeiskoristenoGO);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PlaniranjeGodisnjegOdmora";
            this.Text = "Traženje novčane naknade za neiskorišteni GO";
            this.Load += new System.EventHandler(this.PlaniranjeGodisnjegOdmora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKoristenjeGO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNeiskoristenoGO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvKoristenjeGO;
        private System.Windows.Forms.Button btnEvidentiraj;
        private System.Windows.Forms.Button btnSljedecaGodina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNovčanaNaknada;
        private System.Windows.Forms.Button btnReset;
    }
}