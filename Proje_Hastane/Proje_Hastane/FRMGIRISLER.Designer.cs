﻿namespace Proje_Hastane
{
    partial class FRMGIRISLER
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMGIRISLER));
            this.BtnHastaGirişi = new System.Windows.Forms.Button();
            this.BtnDoktorGirişi = new System.Windows.Forms.Button();
            this.BtnSekreterGirişi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnHastaGirişi
            // 
            this.BtnHastaGirişi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnHastaGirişi.BackgroundImage")));
            this.BtnHastaGirişi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHastaGirişi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHastaGirişi.Location = new System.Drawing.Point(56, 229);
            this.BtnHastaGirişi.Name = "BtnHastaGirişi";
            this.BtnHastaGirişi.Size = new System.Drawing.Size(191, 126);
            this.BtnHastaGirişi.TabIndex = 0;
            this.BtnHastaGirişi.UseVisualStyleBackColor = true;
            this.BtnHastaGirişi.Click += new System.EventHandler(this.BtnHastaGirişi_Click);
            // 
            // BtnDoktorGirişi
            // 
            this.BtnDoktorGirişi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDoktorGirişi.BackgroundImage")));
            this.BtnDoktorGirişi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDoktorGirişi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDoktorGirişi.Location = new System.Drawing.Point(307, 229);
            this.BtnDoktorGirişi.Name = "BtnDoktorGirişi";
            this.BtnDoktorGirişi.Size = new System.Drawing.Size(191, 126);
            this.BtnDoktorGirişi.TabIndex = 1;
            this.BtnDoktorGirişi.UseVisualStyleBackColor = true;
            this.BtnDoktorGirişi.Click += new System.EventHandler(this.BtnDoktorGirişi_Click);
            // 
            // BtnSekreterGirişi
            // 
            this.BtnSekreterGirişi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSekreterGirişi.BackgroundImage")));
            this.BtnSekreterGirişi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSekreterGirişi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSekreterGirişi.Location = new System.Drawing.Point(552, 229);
            this.BtnSekreterGirişi.Name = "BtnSekreterGirişi";
            this.BtnSekreterGirişi.Size = new System.Drawing.Size(191, 126);
            this.BtnSekreterGirişi.TabIndex = 2;
            this.BtnSekreterGirişi.UseVisualStyleBackColor = true;
            this.BtnSekreterGirişi.Click += new System.EventHandler(this.BtnSekreterGirişi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
           
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
           
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(620, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(552, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 52);
            this.label4.TabIndex = 7;
            this.label4.Text = "Medicana Hastanesi";
            // 
            // FRMGIRISLER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(791, 411);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSekreterGirişi);
            this.Controls.Add(this.BtnDoktorGirişi);
            this.Controls.Add(this.BtnHastaGirişi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRMGIRISLER";
            this.Text = "Medicana Hastanesi Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHastaGirişi;
        private System.Windows.Forms.Button BtnDoktorGirişi;
        private System.Windows.Forms.Button BtnSekreterGirişi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

