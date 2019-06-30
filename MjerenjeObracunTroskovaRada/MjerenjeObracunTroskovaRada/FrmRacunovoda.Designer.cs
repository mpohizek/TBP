namespace MjerenjeObracunTroskovaRada
{
    partial class FrmRacunovoda
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
            this.txtImeKorisnika = new System.Windows.Forms.TextBox();
            this.uiActionOdjava = new System.Windows.Forms.ComboBox();
            this.izbornikRacunovoda = new System.Windows.Forms.MenuStrip();
            this.evidencijaOdlaskaDolaskaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planiranjeGodisnjegOdmoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obračunPlaćeToolStriMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izbornikRacunovoda.SuspendLayout();
            this.SuspendLayout();
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
            // izbornikRacunovoda
            // 
            this.izbornikRacunovoda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evidencijaOdlaskaDolaskaToolStripMenuItem,
            this.planiranjeGodisnjegOdmoraToolStripMenuItem,
            this.obračunPlaćeToolStriMenuItem});
            this.izbornikRacunovoda.Location = new System.Drawing.Point(0, 0);
            this.izbornikRacunovoda.Name = "izbornikRacunovoda";
            this.izbornikRacunovoda.Size = new System.Drawing.Size(933, 24);
            this.izbornikRacunovoda.TabIndex = 7;
            this.izbornikRacunovoda.Text = "menuStrip1";
            // 
            // evidencijaOdlaskaDolaskaToolStripMenuItem
            // 
            this.evidencijaOdlaskaDolaskaToolStripMenuItem.Name = "evidencijaOdlaskaDolaskaToolStripMenuItem";
            this.evidencijaOdlaskaDolaskaToolStripMenuItem.Size = new System.Drawing.Size(166, 20);
            this.evidencijaOdlaskaDolaskaToolStripMenuItem.Text = "Evidencija dolaska / odlaska";
            this.evidencijaOdlaskaDolaskaToolStripMenuItem.Click += new System.EventHandler(this.evidencijaDolaskaOdlaskaToolStripMenuItem_Click);
            // 
            // planiranjeGodisnjegOdmoraToolStripMenuItem
            // 
            this.planiranjeGodisnjegOdmoraToolStripMenuItem.Name = "planiranjeGodisnjegOdmoraToolStripMenuItem";
            this.planiranjeGodisnjegOdmoraToolStripMenuItem.Size = new System.Drawing.Size(171, 20);
            this.planiranjeGodisnjegOdmoraToolStripMenuItem.Text = "Planiranje godišnjeg odmora";
            this.planiranjeGodisnjegOdmoraToolStripMenuItem.Click += new System.EventHandler(this.planiranjeGodisnjegOdmoraToolStripMenuItem_Click);
            // 
            // obračunPlaćeToolStriMenuItem
            // 
            this.obračunPlaćeToolStriMenuItem.Name = "obračunPlaćeToolStriMenuItem";
            this.obračunPlaćeToolStriMenuItem.Size = new System.Drawing.Size(96, 20);
            this.obračunPlaćeToolStriMenuItem.Text = "Obračun plaće";
            this.obračunPlaćeToolStriMenuItem.Click += new System.EventHandler(this.obracunPlaceToolStripMenuItem_Click);
            // 
            // FrmRacunovoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.txtImeKorisnika);
            this.Controls.Add(this.uiActionOdjava);
            this.Controls.Add(this.izbornikRacunovoda);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.izbornikRacunovoda;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmRacunovoda";
            this.Text = "RAČUNOVODSTVO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRacunovoda_FormClosed);
            this.Load += new System.EventHandler(this.FrmRacunovoda_Load);
            this.izbornikRacunovoda.ResumeLayout(false);
            this.izbornikRacunovoda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImeKorisnika;
        private System.Windows.Forms.ComboBox uiActionOdjava;
        private System.Windows.Forms.MenuStrip izbornikRacunovoda;
        private System.Windows.Forms.ToolStripMenuItem evidencijaOdlaskaDolaskaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planiranjeGodisnjegOdmoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obračunPlaćeToolStriMenuItem;
    }
}