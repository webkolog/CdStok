namespace CdStok
{
    partial class altFrmKullaniciDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(altFrmKullaniciDuzenle));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.cbYoneticiMi = new System.Windows.Forms.CheckBox();
            this.Grp = new System.Windows.Forms.GroupBox();
            this.Grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(13, 97);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(351, 221);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kullanıcı Adı";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Yönetici Mi?";
            this.columnHeader2.Width = 100;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(6, 19);
            this.txtKullaniciAdi.MaxLength = 16;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(171, 20);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.Location = new System.Drawing.Point(6, 45);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(171, 25);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "     Seçili Kullanıcıyı Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(183, 45);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(162, 25);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "     Seçili Kullanıcıyı Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cbYoneticiMi
            // 
            this.cbYoneticiMi.AutoSize = true;
            this.cbYoneticiMi.Location = new System.Drawing.Point(183, 21);
            this.cbYoneticiMi.Name = "cbYoneticiMi";
            this.cbYoneticiMi.Size = new System.Drawing.Size(78, 17);
            this.cbYoneticiMi.TabIndex = 4;
            this.cbYoneticiMi.Text = "Yönetici Mi";
            this.cbYoneticiMi.UseVisualStyleBackColor = true;
            // 
            // Grp
            // 
            this.Grp.Controls.Add(this.btnGuncelle);
            this.Grp.Controls.Add(this.cbYoneticiMi);
            this.Grp.Controls.Add(this.btnSil);
            this.Grp.Controls.Add(this.txtKullaniciAdi);
            this.Grp.Location = new System.Drawing.Point(13, 12);
            this.Grp.Name = "Grp";
            this.Grp.Size = new System.Drawing.Size(351, 78);
            this.Grp.TabIndex = 5;
            this.Grp.TabStop = false;
            this.Grp.Text = "Seçili Kullanıcı";
            // 
            // altFrmKullaniciDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 332);
            this.Controls.Add(this.Grp);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "altFrmKullaniciDuzenle";
            this.Text = "altFrmKullaniciDuzenle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.altFrmKullaniciDuzenle_FormClosed);
            this.Load += new System.EventHandler(this.altFrmKullaniciDuzenle_Load);
            this.Grp.ResumeLayout(false);
            this.Grp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.CheckBox cbYoneticiMi;
        private System.Windows.Forms.GroupBox Grp;


    }
}