namespace MagazaYonetim
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kullaniciAd = new System.Windows.Forms.Label();
            this.Sifre = new System.Windows.Forms.Label();
            this.KulAd = new System.Windows.Forms.TextBox();
            this.BoxSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kullaniciAd
            // 
            this.kullaniciAd.AutoSize = true;
            this.kullaniciAd.BackColor = System.Drawing.Color.Transparent;
            this.kullaniciAd.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullaniciAd.ForeColor = System.Drawing.Color.Goldenrod;
            this.kullaniciAd.Location = new System.Drawing.Point(61, 52);
            this.kullaniciAd.Name = "kullaniciAd";
            this.kullaniciAd.Size = new System.Drawing.Size(186, 32);
            this.kullaniciAd.TabIndex = 0;
            this.kullaniciAd.Text = "Kullanıcı Adı";
            this.kullaniciAd.Click += new System.EventHandler(this.kullaniciAd_Click);
            // 
            // Sifre
            // 
            this.Sifre.AutoSize = true;
            this.Sifre.BackColor = System.Drawing.Color.Transparent;
            this.Sifre.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sifre.ForeColor = System.Drawing.Color.Goldenrod;
            this.Sifre.Location = new System.Drawing.Point(114, 119);
            this.Sifre.Name = "Sifre";
            this.Sifre.Size = new System.Drawing.Size(77, 32);
            this.Sifre.TabIndex = 1;
            this.Sifre.Text = "Şifre";
            // 
            // KulAd
            // 
            this.KulAd.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KulAd.Location = new System.Drawing.Point(269, 53);
            this.KulAd.Name = "KulAd";
            this.KulAd.Size = new System.Drawing.Size(100, 31);
            this.KulAd.TabIndex = 2;
            // 
            // BoxSifre
            // 
            this.BoxSifre.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxSifre.Location = new System.Drawing.Point(269, 122);
            this.BoxSifre.Name = "BoxSifre";
            this.BoxSifre.Size = new System.Drawing.Size(100, 31);
            this.BoxSifre.TabIndex = 3;
            this.BoxSifre.UseSystemPasswordChar = true;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnGiris.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGiris.Font = new System.Drawing.Font("Book Antiqua", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiris.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnGiris.Location = new System.Drawing.Point(133, 249);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(169, 74);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(434, 344);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.BoxSifre);
            this.Controls.Add(this.KulAd);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.kullaniciAd);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kullaniciAd;
        private System.Windows.Forms.Label Sifre;
        private System.Windows.Forms.TextBox KulAd;
        private System.Windows.Forms.TextBox BoxSifre;
        private System.Windows.Forms.Button btnGiris;
    }
}

