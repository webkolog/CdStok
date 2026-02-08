namespace CdStok
{
    partial class altFrmCdDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(altFrmCdDuzenle));
            this.btnKaydet = new System.Windows.Forms.Button();
            this.comboYer = new System.Windows.Forms.ComboBox();
            this.lblYer = new System.Windows.Forms.Label();
            this.cbKisisel = new System.Windows.Forms.CheckBox();
            this.comboKutu = new System.Windows.Forms.ComboBox();
            this.lblKutu = new System.Windows.Forms.Label();
            this.lblCdAdi = new System.Windows.Forms.Label();
            this.txtCdAdi = new System.Windows.Forms.TextBox();
            this.btnDosyaSil = new System.Windows.Forms.Button();
            this.lisDosyalar = new System.Windows.Forms.ListBox();
            this.btnDosyaEkle = new System.Windows.Forms.Button();
            this.txtDosyaAdi = new System.Windows.Forms.TextBox();
            this.btnDosyaDuzenle = new System.Windows.Forms.Button();
            this.grpDosyalar = new System.Windows.Forms.GroupBox();
            this.grpDosyalar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(15, 329);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(249, 23);
            this.btnKaydet.TabIndex = 37;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // comboYer
            // 
            this.comboYer.FormattingEnabled = true;
            this.comboYer.Location = new System.Drawing.Point(68, 32);
            this.comboYer.MaxLength = 40;
            this.comboYer.Name = "comboYer";
            this.comboYer.Size = new System.Drawing.Size(260, 21);
            this.comboYer.TabIndex = 28;
            // 
            // lblYer
            // 
            this.lblYer.AutoSize = true;
            this.lblYer.Location = new System.Drawing.Point(12, 35);
            this.lblYer.Name = "lblYer";
            this.lblYer.Size = new System.Drawing.Size(44, 13);
            this.lblYer.TabIndex = 32;
            this.lblYer.Text = "Yer Adı:";
            // 
            // cbKisisel
            // 
            this.cbKisisel.AutoSize = true;
            this.cbKisisel.Location = new System.Drawing.Point(273, 333);
            this.cbKisisel.Name = "cbKisisel";
            this.cbKisisel.Size = new System.Drawing.Size(55, 17);
            this.cbKisisel.TabIndex = 36;
            this.cbKisisel.Text = "Kişisel";
            this.cbKisisel.UseVisualStyleBackColor = true;
            // 
            // comboKutu
            // 
            this.comboKutu.FormattingEnabled = true;
            this.comboKutu.Location = new System.Drawing.Point(68, 59);
            this.comboKutu.MaxLength = 40;
            this.comboKutu.Name = "comboKutu";
            this.comboKutu.Size = new System.Drawing.Size(260, 21);
            this.comboKutu.TabIndex = 30;
            this.comboKutu.SelectedIndexChanged += new System.EventHandler(this.comboKutu_SelectedIndexChanged);
            this.comboKutu.TextChanged += new System.EventHandler(this.comboKutu_TextChanged);
            // 
            // lblKutu
            // 
            this.lblKutu.AutoSize = true;
            this.lblKutu.Location = new System.Drawing.Point(12, 62);
            this.lblKutu.Name = "lblKutu";
            this.lblKutu.Size = new System.Drawing.Size(50, 13);
            this.lblKutu.TabIndex = 29;
            this.lblKutu.Text = "Kutu Adı:";
            // 
            // lblCdAdi
            // 
            this.lblCdAdi.AutoSize = true;
            this.lblCdAdi.Location = new System.Drawing.Point(12, 9);
            this.lblCdAdi.Name = "lblCdAdi";
            this.lblCdAdi.Size = new System.Drawing.Size(43, 13);
            this.lblCdAdi.TabIndex = 27;
            this.lblCdAdi.Text = "CD Adı:";
            // 
            // txtCdAdi
            // 
            this.txtCdAdi.Location = new System.Drawing.Point(68, 6);
            this.txtCdAdi.MaxLength = 40;
            this.txtCdAdi.Name = "txtCdAdi";
            this.txtCdAdi.Size = new System.Drawing.Size(260, 20);
            this.txtCdAdi.TabIndex = 26;
            // 
            // btnDosyaSil
            // 
            this.btnDosyaSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDosyaSil.Image = ((System.Drawing.Image)(resources.GetObject("btnDosyaSil.Image")));
            this.btnDosyaSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDosyaSil.Location = new System.Drawing.Point(166, 47);
            this.btnDosyaSil.Name = "btnDosyaSil";
            this.btnDosyaSil.Size = new System.Drawing.Size(141, 22);
            this.btnDosyaSil.TabIndex = 41;
            this.btnDosyaSil.Text = "     Seçili Dosyayı Sil";
            this.btnDosyaSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDosyaSil.UseVisualStyleBackColor = true;
            this.btnDosyaSil.Click += new System.EventHandler(this.btnDosyaSil_Click);
            // 
            // lisDosyalar
            // 
            this.lisDosyalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lisDosyalar.ForeColor = System.Drawing.Color.Black;
            this.lisDosyalar.FormattingEnabled = true;
            this.lisDosyalar.Location = new System.Drawing.Point(9, 80);
            this.lisDosyalar.Name = "lisDosyalar";
            this.lisDosyalar.Size = new System.Drawing.Size(298, 147);
            this.lisDosyalar.TabIndex = 38;
            // 
            // btnDosyaEkle
            // 
            this.btnDosyaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDosyaEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnDosyaEkle.Image")));
            this.btnDosyaEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDosyaEkle.Location = new System.Drawing.Point(225, 19);
            this.btnDosyaEkle.Name = "btnDosyaEkle";
            this.btnDosyaEkle.Size = new System.Drawing.Size(82, 22);
            this.btnDosyaEkle.TabIndex = 40;
            this.btnDosyaEkle.Text = "     Dosya Ekle";
            this.btnDosyaEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDosyaEkle.UseVisualStyleBackColor = true;
            this.btnDosyaEkle.Click += new System.EventHandler(this.btnDosyaEkle_Click);
            // 
            // txtDosyaAdi
            // 
            this.txtDosyaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDosyaAdi.Location = new System.Drawing.Point(9, 19);
            this.txtDosyaAdi.MaxLength = 40;
            this.txtDosyaAdi.Name = "txtDosyaAdi";
            this.txtDosyaAdi.Size = new System.Drawing.Size(210, 20);
            this.txtDosyaAdi.TabIndex = 39;
            // 
            // btnDosyaDuzenle
            // 
            this.btnDosyaDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDosyaDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnDosyaDuzenle.Image")));
            this.btnDosyaDuzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDosyaDuzenle.Location = new System.Drawing.Point(9, 47);
            this.btnDosyaDuzenle.Name = "btnDosyaDuzenle";
            this.btnDosyaDuzenle.Size = new System.Drawing.Size(151, 22);
            this.btnDosyaDuzenle.TabIndex = 42;
            this.btnDosyaDuzenle.Text = "     Seçili Dosyayı Değiştir";
            this.btnDosyaDuzenle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDosyaDuzenle.UseVisualStyleBackColor = true;
            this.btnDosyaDuzenle.Click += new System.EventHandler(this.btnDosyaDuzenle_Click);
            // 
            // grpDosyalar
            // 
            this.grpDosyalar.Controls.Add(this.btnDosyaEkle);
            this.grpDosyalar.Controls.Add(this.btnDosyaDuzenle);
            this.grpDosyalar.Controls.Add(this.btnDosyaSil);
            this.grpDosyalar.Controls.Add(this.txtDosyaAdi);
            this.grpDosyalar.Controls.Add(this.lisDosyalar);
            this.grpDosyalar.Location = new System.Drawing.Point(15, 86);
            this.grpDosyalar.Name = "grpDosyalar";
            this.grpDosyalar.Size = new System.Drawing.Size(313, 237);
            this.grpDosyalar.TabIndex = 44;
            this.grpDosyalar.TabStop = false;
            this.grpDosyalar.Text = "İçindeki Dosyalar";
            // 
            // altFrmCdDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 364);
            this.Controls.Add(this.grpDosyalar);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.comboYer);
            this.Controls.Add(this.lblYer);
            this.Controls.Add(this.cbKisisel);
            this.Controls.Add(this.comboKutu);
            this.Controls.Add(this.lblKutu);
            this.Controls.Add(this.lblCdAdi);
            this.Controls.Add(this.txtCdAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "altFrmCdDuzenle";
            this.Text = "altFrmCdDuzenle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.altFrmCdDuzenle_FormClosed);
            this.Load += new System.EventHandler(this.altFrmCdDuzenle_Load);
            this.grpDosyalar.ResumeLayout(false);
            this.grpDosyalar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox comboYer;
        private System.Windows.Forms.Label lblYer;
        private System.Windows.Forms.CheckBox cbKisisel;
        private System.Windows.Forms.ComboBox comboKutu;
        private System.Windows.Forms.Label lblKutu;
        private System.Windows.Forms.Label lblCdAdi;
        private System.Windows.Forms.TextBox txtCdAdi;
        private System.Windows.Forms.Button btnDosyaSil;
        private System.Windows.Forms.ListBox lisDosyalar;
        private System.Windows.Forms.Button btnDosyaEkle;
        private System.Windows.Forms.TextBox txtDosyaAdi;
        private System.Windows.Forms.Button btnDosyaDuzenle;
        private System.Windows.Forms.GroupBox grpDosyalar;
    }
}