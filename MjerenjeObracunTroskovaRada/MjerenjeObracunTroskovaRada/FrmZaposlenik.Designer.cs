namespace MjerenjeObracunTroskovaRada
{
    partial class FrmZaposlenik
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
            this.izbornikZaposlenik = new System.Windows.Forms.MenuStrip();
            this.evidencijaDolaskaOdlaskaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planiranjeGodisnjegOdmoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledStanjaPrekovremenihSatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtImeKorisnika = new System.Windows.Forms.TextBox();
            this.uiActionOdjava = new System.Windows.Forms.ComboBox();
            this.izbornikZaposlenik.SuspendLayout();
            this.SuspendLayout();
            // 
            // izbornikZaposlenik
            // 
            this.izbornikZaposlenik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evidencijaDolaskaOdlaskaToolStripMenuItem,
            this.planiranjeGodisnjegOdmoraToolStripMenuItem,
            this.pregledStanjaPrekovremenihSatiToolStripMenuItem});
            this.izbornikZaposlenik.Location = new System.Drawing.Point(0, 0);
            this.izbornikZaposlenik.Name = "izbornikZaposlenik";
            this.izbornikZaposlenik.Size = new System.Drawing.Size(933, 24);
            this.izbornikZaposlenik.TabIndex = 1;
            this.izbornikZaposlenik.Text = "menuStrip1";
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
            // pregledStanjaPrekovremenihSatiToolStripMenuItem
            // 
            this.pregledStanjaPrekovremenihSatiToolStripMenuItem.Name = "pregledStanjaPrekovremenihSatiToolStripMenuItem";
            this.pregledStanjaPrekovremenihSatiToolStripMenuItem.Size = new System.Drawing.Size(197, 20);
            this.pregledStanjaPrekovremenihSatiToolStripMenuItem.Text = "Pregled stanja prekovremenih sati";
            this.pregledStanjaPrekovremenihSatiToolStripMenuItem.Click += new System.EventHandler(this.pregledStanjaPrekovremenihSatiToolStripMenuItem_Click);
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
            // FrmZaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.txtImeKorisnika);
            this.Controls.Add(this.uiActionOdjava);
            this.Controls.Add(this.izbornikZaposlenik);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.izbornikZaposlenik;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmZaposlenik";
            this.Text = "ZAPOSLENICI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmZaposlenik_FormClosed);
            this.Load += new System.EventHandler(this.FrmZaposlenik_Load);
            this.izbornikZaposlenik.ResumeLayout(false);
            this.izbornikZaposlenik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip izbornikZaposlenik;
        private System.Windows.Forms.TextBox txtImeKorisnika;
        private System.Windows.Forms.ComboBox uiActionOdjava;
        private System.Windows.Forms.ToolStripMenuItem evidencijaDolaskaOdlaskaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planiranjeGodisnjegOdmoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledStanjaPrekovremenihSatiToolStripMenuItem;
    }
}