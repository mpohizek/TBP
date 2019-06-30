namespace MjerenjeObracunTroskovaRada.FormeIzbornici
{
    partial class ObracunPlaca
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
            this.btnIzvrsiObracun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIzvrsiObracun
            // 
            this.btnIzvrsiObracun.Location = new System.Drawing.Point(13, 13);
            this.btnIzvrsiObracun.Name = "btnIzvrsiObracun";
            this.btnIzvrsiObracun.Size = new System.Drawing.Size(124, 94);
            this.btnIzvrsiObracun.TabIndex = 0;
            this.btnIzvrsiObracun.Text = "OBRAČUNAJ PLAĆU ZA PRETHODNI MJESEC";
            this.btnIzvrsiObracun.UseVisualStyleBackColor = true;
            this.btnIzvrsiObracun.Click += new System.EventHandler(this.btnIzvrsiObracun_Click);
            // 
            // ObracunPlaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.btnIzvrsiObracun);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ObracunPlaca";
            this.Text = "Obračun plaća";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIzvrsiObracun;
    }
}