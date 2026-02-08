namespace CdStok
{
    partial class frmKullaniciKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciKayit));
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblKadi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKadi = new System.Windows.Forms.TextBox();
            this.txtReSifre = new System.Windows.Forms.TextBox();
            this.lblReSifre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(12, 84);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(198, 23);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblKadi
            // 
            this.lblKadi.AutoSize = true;
            this.lblKadi.Location = new System.Drawing.Point(12, 9);
            this.lblKadi.Name = "lblKadi";
            this.lblKadi.Size = new System.Drawing.Size(67, 13);
            this.lblKadi.TabIndex = 9;
            this.lblKadi.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(12, 35);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(31, 13);
            this.lblSifre.TabIndex = 8;
            this.lblSifre.Text = "Şifre:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(85, 32);
            this.txtSifre.MaxLength = 16;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(128, 20);
            this.txtSifre.TabIndex = 1;
            // 
            // txtKadi
            // 
            this.txtKadi.Location = new System.Drawing.Point(85, 6);
            this.txtKadi.MaxLength = 16;
            this.txtKadi.Name = "txtKadi";
            this.txtKadi.Size = new System.Drawing.Size(128, 20);
            this.txtKadi.TabIndex = 0;
            // 
            // txtReSifre
            // 
            this.txtReSifre.Location = new System.Drawing.Point(85, 58);
            this.txtReSifre.MaxLength = 16;
            this.txtReSifre.Name = "txtReSifre";
            this.txtReSifre.PasswordChar = '*';
            this.txtReSifre.Size = new System.Drawing.Size(128, 20);
            this.txtReSifre.TabIndex = 2;
            // 
            // lblReSifre
            // 
            this.lblReSifre.AutoSize = true;
            this.lblReSifre.Location = new System.Drawing.Point(12, 61);
            this.lblReSifre.Name = "lblReSifre";
            this.lblReSifre.Size = new System.Drawing.Size(65, 13);
            this.lblReSifre.TabIndex = 12;
            this.lblReSifre.Text = "Tekrar Şifre:";
            // 
            // frmKullaniciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 118);
            this.Controls.Add(this.lblReSifre);
            this.Controls.Add(this.txtReSifre);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblKadi);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKadi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKullaniciKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Kullanıcı Kaydı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblKadi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKadi;
        private System.Windows.Forms.TextBox txtReSifre;
        private System.Windows.Forms.Label lblReSifre;
    }
}