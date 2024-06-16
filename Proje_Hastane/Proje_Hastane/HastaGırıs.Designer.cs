namespace Proje_Hastane
{
    partial class HastaGırıs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaGırıs));
            this.label1 = new System.Windows.Forms.Label();
            this.LNKUYEOL = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.TXTSFR = new System.Windows.Forms.TextBox();
            this.BtnGırısYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş Paneli ";
            // 
            // LNKUYEOL
            // 
            this.LNKUYEOL.AutoSize = true;
            this.LNKUYEOL.Location = new System.Drawing.Point(531, 288);
            this.LNKUYEOL.Name = "LNKUYEOL";
            this.LNKUYEOL.Size = new System.Drawing.Size(75, 28);
            this.LNKUYEOL.TabIndex = 1;
            this.LNKUYEOL.TabStop = true;
            this.LNKUYEOL.Text = "Üye Ol";
            this.LNKUYEOL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LNKUYEOL_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "TC Kimlik No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Şifre :";
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(231, 239);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(294, 36);
            this.mskTC.TabIndex = 4;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // TXTSFR
            // 
            this.TXTSFR.Location = new System.Drawing.Point(231, 285);
            this.TXTSFR.Name = "TXTSFR";
            this.TXTSFR.Size = new System.Drawing.Size(294, 36);
            this.TXTSFR.TabIndex = 5;
            // 
            // BtnGırısYap
            // 
            this.BtnGırısYap.Location = new System.Drawing.Point(340, 327);
            this.BtnGırısYap.Name = "BtnGırısYap";
            this.BtnGırısYap.Size = new System.Drawing.Size(183, 54);
            this.BtnGırısYap.TabIndex = 6;
            this.BtnGırısYap.Text = " Giriş Yap";
            this.BtnGırısYap.UseVisualStyleBackColor = true;
            this.BtnGırısYap.Click += new System.EventHandler(this.BtnGırısYap_Click);
            // 
            // HastaGırıs
            // 
            this.AcceptButton = this.BtnGırısYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(679, 437);
            this.Controls.Add(this.BtnGırısYap);
            this.Controls.Add(this.TXTSFR);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LNKUYEOL);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "HastaGırıs";
            this.Text = "Hasta Girişi";
            this.Load += new System.EventHandler(this.HastaGırıs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LNKUYEOL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.TextBox TXTSFR;
        private System.Windows.Forms.Button BtnGırısYap;
    }
}