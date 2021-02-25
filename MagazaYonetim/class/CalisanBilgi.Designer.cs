namespace MagazaYonetim
{
    partial class CalisanBilgi
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
            this.tabAdres = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lboxAdres = new System.Windows.Forms.ListBox();
            this.adresyazdir = new System.Windows.Forms.Button();
            this.tabAdres.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdres
            // 
            this.tabAdres.Controls.Add(this.tabPage1);
            this.tabAdres.Controls.Add(this.tabPage2);
            this.tabAdres.Controls.Add(this.tabPage3);
            this.tabAdres.Controls.Add(this.tabPage4);
            this.tabAdres.Location = new System.Drawing.Point(13, 0);
            this.tabAdres.Name = "tabAdres";
            this.tabAdres.SelectedIndex = 0;
            this.tabAdres.Size = new System.Drawing.Size(1360, 654);
            this.tabAdres.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.adresyazdir);
            this.tabPage1.Controls.Add(this.lboxAdres);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1352, 628);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Çalışan Adres";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1352, 628);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "İzin Günleri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1352, 628);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Çalışan Şirket İçi Bilgi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1352, 628);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lboxAdres
            // 
            this.lboxAdres.FormattingEnabled = true;
            this.lboxAdres.Location = new System.Drawing.Point(28, 62);
            this.lboxAdres.Name = "lboxAdres";
            this.lboxAdres.Size = new System.Drawing.Size(1288, 472);
            this.lboxAdres.TabIndex = 0;
            // 
            // adresyazdir
            // 
            this.adresyazdir.Location = new System.Drawing.Point(516, 560);
            this.adresyazdir.Name = "adresyazdir";
            this.adresyazdir.Size = new System.Drawing.Size(293, 23);
            this.adresyazdir.TabIndex = 1;
            this.adresyazdir.Text = "Adres Bİlgilerini Getir";
            this.adresyazdir.UseVisualStyleBackColor = true;
            this.adresyazdir.Click += new System.EventHandler(this.adresyazdir_Click);
            // 
            // CalisanBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 657);
            this.Controls.Add(this.tabAdres);
            this.Name = "CalisanBilgi";
            this.Text = "CalisanBilgi";
            this.Load += new System.EventHandler(this.CalisanBilgi_Load);
            this.tabAdres.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdres;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button adresyazdir;
        private System.Windows.Forms.ListBox lboxAdres;
    }
}