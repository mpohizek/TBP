namespace MjerenjeObracunTroskovaRada
{
    partial class FrmEvidentirajGo
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
            this.datePickerPocetak = new System.Windows.Forms.DateTimePicker();
            this.datePickerZavrsetak = new System.Windows.Forms.DateTimePicker();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Početni datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Završni datum:";
            // 
            // datePickerPocetak
            // 
            this.datePickerPocetak.Location = new System.Drawing.Point(120, 11);
            this.datePickerPocetak.Name = "datePickerPocetak";
            this.datePickerPocetak.Size = new System.Drawing.Size(200, 25);
            this.datePickerPocetak.TabIndex = 2;
            // 
            // datePickerZavrsetak
            // 
            this.datePickerZavrsetak.Location = new System.Drawing.Point(119, 46);
            this.datePickerZavrsetak.Name = "datePickerZavrsetak";
            this.datePickerZavrsetak.Size = new System.Drawing.Size(200, 25);
            this.datePickerZavrsetak.TabIndex = 3;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(106, 104);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(112, 49);
            this.btnSpremi.TabIndex = 4;
            this.btnSpremi.Text = "SPREMI";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // FrmEvidentirajGo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 183);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.datePickerZavrsetak);
            this.Controls.Add(this.datePickerPocetak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmEvidentirajGo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidentiranje godišnjeg odmora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datePickerPocetak;
        private System.Windows.Forms.DateTimePicker datePickerZavrsetak;
        private System.Windows.Forms.Button btnSpremi;
    }
}