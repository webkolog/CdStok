namespace CdStok
{
    partial class altFrmYerDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(altFrmYerDuzenle));
            this.Grp = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtYerAdi = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grp
            // 
            this.Grp.Controls.Add(this.btnGuncelle);
            this.Grp.Controls.Add(this.btnSil);
            this.Grp.Controls.Add(this.txtYerAdi);
            this.Grp.Location = new System.Drawing.Point(12, 12);
            this.Grp.Name = "Grp";
            this.Grp.Size = new System.Drawing.Size(184, 109);
            this.Grp.TabIndex = 9;
            this.Grp.TabStop = false;
            this.Grp.Text = "Seçili Yer";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.Location = new System.Drawing.Point(6, 45);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(171, 25);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "     Seçili Yeri Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(6, 76);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(171, 25);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "     Seçili Yeri Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtYerAdi
            // 
            this.txtYerAdi.Location = new System.Drawing.Point(6, 19);
            this.txtYerAdi.MaxLength = 40;
            this.txtYerAdi.Name = "txtYerAdi";
            this.txtYerAdi.Size = new System.Drawing.Size(171, 20);
            this.txtYerAdi.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 127);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(184, 251);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // altFrmYerDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 388);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Grp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "altFrmYerDuzenle";
            this.Text = "Yer Düzenle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.altFrmYerDuzenle_FormClosed);
            this.Load += new System.EventHandler(this.altFrmYerDuzenle_Load);
            this.Grp.ResumeLayout(false);
            this.Grp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Grp;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtYerAdi;
        private System.Windows.Forms.ListBox listBox1;
    }
}