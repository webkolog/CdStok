namespace CdStok
{
    partial class altFrmDosyaYonet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(altFrmDosyaYonet));
            this.grpDosyalar = new System.Windows.Forms.GroupBox();
            this.btnDosyaEkle = new System.Windows.Forms.Button();
            this.btnDosyaDuzenle = new System.Windows.Forms.Button();
            this.btnDosyaSil = new System.Windows.Forms.Button();
            this.txtDosyaAdi = new System.Windows.Forms.TextBox();
            this.lisDosyalar = new System.Windows.Forms.ListBox();
            this.grpDosyalar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDosyalar
            // 
            this.grpDosyalar.Controls.Add(this.btnDosyaEkle);
            this.grpDosyalar.Controls.Add(this.btnDosyaDuzenle);
            this.grpDosyalar.Controls.Add(this.btnDosyaSil);
            this.grpDosyalar.Controls.Add(this.txtDosyaAdi);
            this.grpDosyalar.Controls.Add(this.lisDosyalar);
            this.grpDosyalar.Location = new System.Drawing.Point(12, 12);
            this.grpDosyalar.Name = "grpDosyalar";
            this.grpDosyalar.Size = new System.Drawing.Size(313, 237);
            this.grpDosyalar.TabIndex = 45;
            this.grpDosyalar.TabStop = false;
            this.grpDosyalar.Text = "İçindeki Dosyalar";
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
            // txtDosyaAdi
            // 
            this.txtDosyaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDosyaAdi.Location = new System.Drawing.Point(9, 19);
            this.txtDosyaAdi.MaxLength = 40;
            this.txtDosyaAdi.Name = "txtDosyaAdi";
            this.txtDosyaAdi.Size = new System.Drawing.Size(210, 20);
            this.txtDosyaAdi.TabIndex = 39;
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
            // altFrmDosyaYonet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 258);
            this.Controls.Add(this.grpDosyalar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "altFrmDosyaYonet";
            this.Text = "altFrmDosyaYonet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.altFrmDosyaYonet_FormClosed);
            this.Load += new System.EventHandler(this.altFrmDosyaYonet_Load);
            this.grpDosyalar.ResumeLayout(false);
            this.grpDosyalar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDosyalar;
        private System.Windows.Forms.Button btnDosyaEkle;
        private System.Windows.Forms.Button btnDosyaDuzenle;
        private System.Windows.Forms.Button btnDosyaSil;
        private System.Windows.Forms.TextBox txtDosyaAdi;
        private System.Windows.Forms.ListBox lisDosyalar;
    }
}