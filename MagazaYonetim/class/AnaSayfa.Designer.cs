namespace MagazaYonetim
{
    partial class AnaSayfa
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
            this.MrkBilgibtn = new System.Windows.Forms.Button();
            this.ClsnBilgibtn = new System.Windows.Forms.Button();
            this.StokBilgibtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MrkBilgibtn
            // 
            this.MrkBilgibtn.Location = new System.Drawing.Point(109, 116);
            this.MrkBilgibtn.Name = "MrkBilgibtn";
            this.MrkBilgibtn.Size = new System.Drawing.Size(197, 87);
            this.MrkBilgibtn.TabIndex = 0;
            this.MrkBilgibtn.Text = "Market/Tedarikçi Bilgi";
            this.MrkBilgibtn.UseVisualStyleBackColor = true;
            this.MrkBilgibtn.Click += new System.EventHandler(this.MrkBilgibtn_Click);
            // 
            // ClsnBilgibtn
            // 
            this.ClsnBilgibtn.Location = new System.Drawing.Point(477, 121);
            this.ClsnBilgibtn.Name = "ClsnBilgibtn";
            this.ClsnBilgibtn.Size = new System.Drawing.Size(154, 82);
            this.ClsnBilgibtn.TabIndex = 1;
            this.ClsnBilgibtn.Text = "Çalışan Bilgisi";
            this.ClsnBilgibtn.UseVisualStyleBackColor = true;
            this.ClsnBilgibtn.Click += new System.EventHandler(this.ClsnBilgibtn_Click);
            // 
            // StokBilgibtn
            // 
            this.StokBilgibtn.Location = new System.Drawing.Point(316, 280);
            this.StokBilgibtn.Name = "StokBilgibtn";
            this.StokBilgibtn.Size = new System.Drawing.Size(155, 75);
            this.StokBilgibtn.TabIndex = 2;
            this.StokBilgibtn.Text = "Stok Bilgisi";
            this.StokBilgibtn.UseVisualStyleBackColor = true;
            this.StokBilgibtn.Click += new System.EventHandler(this.StokBilgibtn_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StokBilgibtn);
            this.Controls.Add(this.ClsnBilgibtn);
            this.Controls.Add(this.MrkBilgibtn);
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MrkBilgibtn;
        private System.Windows.Forms.Button ClsnBilgibtn;
        private System.Windows.Forms.Button StokBilgibtn;
    }
}