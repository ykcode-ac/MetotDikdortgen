namespace MetotDikdortgen
{
    partial class Form1
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
            this.txtKisaKenar = new System.Windows.Forms.TextBox();
            this.txtUzunKenar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblAlan = new System.Windows.Forms.Label();
            this.lblCevre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kısa Kenar";
            // 
            // txtKisaKenar
            // 
            this.txtKisaKenar.Location = new System.Drawing.Point(146, 27);
            this.txtKisaKenar.Name = "txtKisaKenar";
            this.txtKisaKenar.Size = new System.Drawing.Size(100, 26);
            this.txtKisaKenar.TabIndex = 1;
            // 
            // txtUzunKenar
            // 
            this.txtUzunKenar.Location = new System.Drawing.Point(146, 59);
            this.txtUzunKenar.Name = "txtUzunKenar";
            this.txtUzunKenar.Size = new System.Drawing.Size(100, 26);
            this.txtUzunKenar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Uzun Kenar";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(146, 100);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 35);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblAlan
            // 
            this.lblAlan.AutoSize = true;
            this.lblAlan.Location = new System.Drawing.Point(142, 162);
            this.lblAlan.Name = "lblAlan";
            this.lblAlan.Size = new System.Drawing.Size(45, 20);
            this.lblAlan.TabIndex = 5;
            this.lblAlan.Text = "Alan:";
            // 
            // lblCevre
            // 
            this.lblCevre.AutoSize = true;
            this.lblCevre.Location = new System.Drawing.Point(142, 194);
            this.lblCevre.Name = "lblCevre";
            this.lblCevre.Size = new System.Drawing.Size(54, 20);
            this.lblCevre.TabIndex = 6;
            this.lblCevre.Text = "Çevre:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(564, 257);
            this.Controls.Add(this.lblCevre);
            this.Controls.Add(this.lblAlan);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtUzunKenar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKisaKenar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "yazilimkodlama.com";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKisaKenar;
        private System.Windows.Forms.TextBox txtUzunKenar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblAlan;
        private System.Windows.Forms.Label lblCevre;
    }
}

