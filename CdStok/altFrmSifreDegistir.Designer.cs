namespace CdStok
{
    partial class altFrmSifreDegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(altFrmSifreDegistir));
            this.lblReYeniSifre = new System.Windows.Forms.Label();
            this.txtReYeniSifre = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblYeniSifre = new System.Windows.Forms.Label();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblReYeniSifre
            // 
            this.lblReYeniSifre.AutoSize = true;
            this.lblReYeniSifre.Location = new System.Drawing.Point(12, 61);
            this.lblReYeniSifre.Name = "lblReYeniSifre";
            this.lblReYeniSifre.Size = new System.Drawing.Size(71, 13);
            this.lblReYeniSifre.TabIndex = 19;
            this.lblReYeniSifre.Text = "Yeni Şifre (T):";
            // 
            // txtReYeniSifre
            // 
            this.txtReYeniSifre.Location = new System.Drawing.Point(85, 58);
            this.txtReYeniSifre.MaxLength = 16;
            this.txtReYeniSifre.Name = "txtReYeniSifre";
            this.txtReYeniSifre.PasswordChar = '*';
            this.txtReYeniSifre.Size = new System.Drawing.Size(128, 20);
            this.txtReYeniSifre.TabIndex = 15;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(12, 84);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(201, 23);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(12, 9);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(54, 13);
            this.lblSifre.TabIndex = 18;
            this.lblSifre.Text = "Eski Şifre:";
            // 
            // lblYeniSifre
            // 
            this.lblYeniSifre.AutoSize = true;
            this.lblYeniSifre.Location = new System.Drawing.Point(12, 35);
            this.lblYeniSifre.Name = "lblYeniSifre";
            this.lblYeniSifre.Size = new System.Drawing.Size(55, 13);
            this.lblYeniSifre.TabIndex = 17;
            this.lblYeniSifre.Text = "Yeni Şifre:";
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(85, 32);
            this.txtYeniSifre.MaxLength = 16;
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.PasswordChar = '*';
            this.txtYeniSifre.Size = new System.Drawing.Size(128, 20);
            this.txtYeniSifre.TabIndex = 14;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(85, 6);
            this.txtSifre.MaxLength = 16;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(128, 20);
            this.txtSifre.TabIndex = 13;
            // 
            // altFrmSifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 116);
            this.Controls.Add(this.lblReYeniSifre);
            this.Controls.Add(this.txtReYeniSifre);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblYeniSifre);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.txtSifre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "altFrmSifreDegistir";
            this.Text = "Şifre Değiştir";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.altFrmSifreDegistir_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReYeniSifre;
        private System.Windows.Forms.TextBox txtReYeniSifre;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblYeniSifre;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.TextBox txtSifre;
    }
}