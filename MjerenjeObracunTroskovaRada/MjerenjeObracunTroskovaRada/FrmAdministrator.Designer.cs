namespace MjerenjeObracunTroskovaRada
{
    partial class FrmAdministrator
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
            this.izbornikAdministrator = new System.Windows.Forms.MenuStrip();
            this.upravljanjeKorisnickimRacunimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiActionOdjava = new System.Windows.Forms.ComboBox();
            this.txtImeKorisnika = new System.Windows.Forms.TextBox();
            this.izbornikAdministrator.SuspendLayout();
            this.SuspendLayout();
            // 
            // izbornikAdministrator
            // 
            this.izbornikAdministrator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upravljanjeKorisnickimRacunimaToolStripMenuItem});
            this.izbornikAdministrator.Location = new System.Drawing.Point(0, 0);
            this.izbornikAdministrator.Name = "izbornikAdministrator";
            this.izbornikAdministrator.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.izbornikAdministrator.Size = new System.Drawing.Size(933, 24);
            this.izbornikAdministrator.TabIndex = 1;
            this.izbornikAdministrator.Text = "menuStrip1";
            // 
            // upravljanjeKorisnickimRacunimaToolStripMenuItem
            // 
            this.upravljanjeKorisnickimRacunimaToolStripMenuItem.Name = "upravljanjeKorisnickimRacunimaToolStripMenuItem";
            this.upravljanjeKorisnickimRacunimaToolStripMenuItem.Size = new System.Drawing.Size(195, 20);
            this.upravljanjeKorisnickimRacunimaToolStripMenuItem.Text = "Upravljanje korisničkim računima";
            this.upravljanjeKorisnickimRacunimaToolStripMenuItem.Click += new System.EventHandler(this.upravljanjeKorisnickimRacunimaToolStripMenuItem_Click);
            // 
            // uiActionOdjava
            // 
            this.uiActionOdjava.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionOdjava.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiActionOdjava.FormattingEnabled = true;
            this.uiActionOdjava.Location = new System.Drawing.Point(772, 0);
            this.uiActionOdjava.Name = "uiActionOdjava";
            this.uiActionOdjava.Size = new System.Drawing.Size(161, 25);
            this.uiActionOdjava.TabIndex = 2;
            this.uiActionOdjava.SelectedValueChanged += new System.EventHandler(this.uiActionOdjava_SelectedValueChanged);
            // 
            // txtImeKorisnika
            // 
            this.txtImeKorisnika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImeKorisnika.Location = new System.Drawing.Point(772, 0);
            this.txtImeKorisnika.Name = "txtImeKorisnika";
            this.txtImeKorisnika.ReadOnly = true;
            this.txtImeKorisnika.Size = new System.Drawing.Size(143, 25);
            this.txtImeKorisnika.TabIndex = 4;
            // 
            // FrmAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.txtImeKorisnika);
            this.Controls.Add(this.uiActionOdjava);
            this.Controls.Add(this.izbornikAdministrator);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.izbornikAdministrator;
            this.Name = "FrmAdministrator";
            this.Text = "ADMINISTRATOR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAdministrator_FormClosed);
            this.Load += new System.EventHandler(this.FrmAdministrator_Load);
            this.izbornikAdministrator.ResumeLayout(false);
            this.izbornikAdministrator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip izbornikAdministrator;
        private System.Windows.Forms.ComboBox uiActionOdjava;
        private System.Windows.Forms.TextBox txtImeKorisnika;
        private System.Windows.Forms.ToolStripMenuItem upravljanjeKorisnickimRacunimaToolStripMenuItem;
    }
}