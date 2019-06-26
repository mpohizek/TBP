namespace MjerenjeObracunTroskovaRada
{
    partial class FrmZaposlenikOdjelaULJP
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
            this.izbornikULJP = new System.Windows.Forms.MenuStrip();
            this.evidencijaDolaskaOdlaskaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planiranjeGodisnjegOdmoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNovihZaposlenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNovihZaposlenikaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.azuriranjePodatakaOZaposlenicimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtImeKorisnika = new System.Windows.Forms.TextBox();
            this.uiActionOdjava = new System.Windows.Forms.ComboBox();
            this.izbornikULJP.SuspendLayout();
            this.SuspendLayout();
            // 
            // izbornikULJP
            // 
            this.izbornikULJP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evidencijaDolaskaOdlaskaToolStripMenuItem,
            this.planiranjeGodisnjegOdmoraToolStripMenuItem,
            this.pregledToolStripMenuItem,
            this.unosNovihZaposlenikaToolStripMenuItem});
            this.izbornikULJP.Location = new System.Drawing.Point(0, 0);
            this.izbornikULJP.Name = "izbornikULJP";
            this.izbornikULJP.Size = new System.Drawing.Size(933, 24);
            this.izbornikULJP.TabIndex = 1;
            this.izbornikULJP.Text = "menuStrip1";
            // 
            // evidencijaDolaskaOdlaskaToolStripMenuItem
            // 
            this.evidencijaDolaskaOdlaskaToolStripMenuItem.Name = "evidencijaDolaskaOdlaskaToolStripMenuItem";
            this.evidencijaDolaskaOdlaskaToolStripMenuItem.Size = new System.Drawing.Size(166, 20);
            this.evidencijaDolaskaOdlaskaToolStripMenuItem.Text = "Evidencija dolaska / odlaska";
            this.evidencijaDolaskaOdlaskaToolStripMenuItem.Click += new System.EventHandler(this.evidencijaDolaskaOdlaskaToolStripMenuItem_Click);
            // 
            // planiranjeGodisnjegOdmoraToolStripMenuItem
            // 
            this.planiranjeGodisnjegOdmoraToolStripMenuItem.Name = "planiranjeGodisnjegOdmoraToolStripMenuItem";
            this.planiranjeGodisnjegOdmoraToolStripMenuItem.Size = new System.Drawing.Size(171, 20);
            this.planiranjeGodisnjegOdmoraToolStripMenuItem.Text = "Planiranje godišnjeg odmora";
            this.planiranjeGodisnjegOdmoraToolStripMenuItem.Click += new System.EventHandler(this.planiranjeGodisnjegOdmoraToolStripMenuItem_Click);
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(197, 20);
            this.pregledToolStripMenuItem.Text = "Pregled stanja prekovremenih sati";
            this.pregledToolStripMenuItem.Click += new System.EventHandler(this.pregledToolStripMenuItem_Click);
            // 
            // unosNovihZaposlenikaToolStripMenuItem
            // 
            this.unosNovihZaposlenikaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNovihZaposlenikaToolStripMenuItem1,
            this.azuriranjePodatakaOZaposlenicimaToolStripMenuItem});
            this.unosNovihZaposlenikaToolStripMenuItem.Name = "unosNovihZaposlenikaToolStripMenuItem";
            this.unosNovihZaposlenikaToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.unosNovihZaposlenikaToolStripMenuItem.Text = "Zaposlenici";
            // 
            // unosNovihZaposlenikaToolStripMenuItem1
            // 
            this.unosNovihZaposlenikaToolStripMenuItem1.Name = "unosNovihZaposlenikaToolStripMenuItem1";
            this.unosNovihZaposlenikaToolStripMenuItem1.Size = new System.Drawing.Size(267, 22);
            this.unosNovihZaposlenikaToolStripMenuItem1.Text = "Unos novih zaposlenika";
            this.unosNovihZaposlenikaToolStripMenuItem1.Click += new System.EventHandler(this.unosNovihZaposlenikaToolStripMenuItem1_Click);
            // 
            // azuriranjePodatakaOZaposlenicimaToolStripMenuItem
            // 
            this.azuriranjePodatakaOZaposlenicimaToolStripMenuItem.Name = "azuriranjePodatakaOZaposlenicimaToolStripMenuItem";
            this.azuriranjePodatakaOZaposlenicimaToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.azuriranjePodatakaOZaposlenicimaToolStripMenuItem.Text = "Ažuriranje podataka o zaposlenicima";
            this.azuriranjePodatakaOZaposlenicimaToolStripMenuItem.Click += new System.EventHandler(this.azuriranjePodatakaOZaposlenicimaToolStripMenuItem_Click);
            // 
            // txtImeKorisnika
            // 
            this.txtImeKorisnika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImeKorisnika.Location = new System.Drawing.Point(772, 0);
            this.txtImeKorisnika.Name = "txtImeKorisnika";
            this.txtImeKorisnika.ReadOnly = true;
            this.txtImeKorisnika.Size = new System.Drawing.Size(143, 25);
            this.txtImeKorisnika.TabIndex = 6;
            // 
            // uiActionOdjava
            // 
            this.uiActionOdjava.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionOdjava.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiActionOdjava.FormattingEnabled = true;
            this.uiActionOdjava.Location = new System.Drawing.Point(772, 0);
            this.uiActionOdjava.Name = "uiActionOdjava";
            this.uiActionOdjava.Size = new System.Drawing.Size(161, 25);
            this.uiActionOdjava.TabIndex = 5;
            this.uiActionOdjava.SelectedValueChanged += new System.EventHandler(this.uiActionOdjava_SelectedValueChanged);
            // 
            // FrmZaposlenikOdjelaULJP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.txtImeKorisnika);
            this.Controls.Add(this.uiActionOdjava);
            this.Controls.Add(this.izbornikULJP);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.izbornikULJP;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmZaposlenikOdjelaULJP";
            this.Text = "UPRAVLJANJE LJUDSKIM POTENCIJALIMA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmZaposlenikOdjelaULJP_FormClosed);
            this.Load += new System.EventHandler(this.FrmZaposlenikOdjelaULJP_Load);
            this.izbornikULJP.ResumeLayout(false);
            this.izbornikULJP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip izbornikULJP;
        private System.Windows.Forms.TextBox txtImeKorisnika;
        private System.Windows.Forms.ComboBox uiActionOdjava;
        private System.Windows.Forms.ToolStripMenuItem evidencijaDolaskaOdlaskaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planiranjeGodisnjegOdmoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNovihZaposlenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNovihZaposlenikaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem azuriranjePodatakaOZaposlenicimaToolStripMenuItem;
    }
}