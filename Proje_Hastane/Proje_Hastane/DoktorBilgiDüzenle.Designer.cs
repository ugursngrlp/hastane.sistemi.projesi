namespace Proje_Hastane
{
    partial class DoktorBilgiDüzenle
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
            this.TxTAd = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxTSıfre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBiilgiGüncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxTAd
            // 
            this.TxTAd.Location = new System.Drawing.Point(252, 121);
            this.TxTAd.Name = "TxTAd";
            this.TxTAd.Size = new System.Drawing.Size(294, 36);
            this.TxTAd.TabIndex = 34;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(251, 238);
            this.msktc.Mask = " ";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(294, 36);
            this.msktc.TabIndex = 33;
            this.msktc.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 28);
            this.label4.TabIndex = 32;
            this.label4.Text = "TC Kimlik No :";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(251, 179);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(294, 36);
            this.TxtSoyad.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 28);
            this.label3.TabIndex = 30;
            this.label3.Text = "Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 28);
            this.label2.TabIndex = 29;
            this.label2.Text = "Ad:";
            // 
            // TxTSıfre
            // 
            this.TxTSıfre.Location = new System.Drawing.Point(251, 359);
            this.TxTSıfre.Name = "TxTSıfre";
            this.TxTSıfre.Size = new System.Drawing.Size(294, 36);
            this.TxTSıfre.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 28);
            this.label6.TabIndex = 35;
            this.label6.Text = "Şifre :";
            // 
            // cmbbrans
            // 
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(252, 296);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(294, 36);
            this.cmbbrans.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 28);
            this.label1.TabIndex = 38;
            this.label1.Text = "Branş :";
            // 
            // BtnBiilgiGüncelle
            // 
            this.BtnBiilgiGüncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnBiilgiGüncelle.Location = new System.Drawing.Point(383, 501);
            this.BtnBiilgiGüncelle.Name = "BtnBiilgiGüncelle";
            this.BtnBiilgiGüncelle.Size = new System.Drawing.Size(161, 41);
            this.BtnBiilgiGüncelle.TabIndex = 39;
            this.BtnBiilgiGüncelle.Text = "Güncelle";
            this.BtnBiilgiGüncelle.UseVisualStyleBackColor = false;
            // 
            // DoktorBilgiDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(521, 507);
            this.Controls.Add(this.BtnBiilgiGüncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbbrans);
            this.Controls.Add(this.TxTSıfre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxTAd);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DoktorBilgiDüzenle";
            this.Text = "DoktorBilgiDüzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxTAd;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxTSıfre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbbrans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBiilgiGüncelle;
    }
}