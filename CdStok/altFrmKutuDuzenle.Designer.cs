namespace CdStok
{
    partial class altFrmKutuDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(altFrmKutuDuzenle));
            this.Grp = new System.Windows.Forms.GroupBox();
            this.comboYer = new System.Windows.Forms.ComboBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtKutuAdi = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grp
            // 
            this.Grp.Controls.Add(this.comboYer);
            this.Grp.Controls.Add(this.btnGuncelle);
            this.Grp.Controls.Add(this.btnSil);
            this.Grp.Controls.Add(this.txtKutuAdi);
            this.Grp.Location = new System.Drawing.Point(12, 12);
            this.Grp.Name = "Grp";
            this.Grp.Size = new System.Drawing.Size(360, 78);
            this.Grp.TabIndex = 7;
            this.Grp.TabStop = false;
            this.Grp.Text = "Seçili Kutu";
            // 
            // comboYer
            // 
            this.comboYer.FormattingEnabled = true;
            this.comboYer.Location = new System.Drawing.Point(183, 19);
            this.comboYer.MaxLength = 25;
            this.comboYer.Name = "comboYer";
            this.comboYer.Size = new System.Drawing.Size(168, 21);
            this.comboYer.TabIndex = 4;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.Location = new System.Drawing.Point(6, 45);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(171, 25);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "     Seçili Kutuyu Güncelle";
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
            this.btnSil.Size = new System.Drawing.Size(171, 25);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "     Seçili Kutuları Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtKutuAdi
            // 
            this.txtKutuAdi.Location = new System.Drawing.Point(6, 19);
            this.txtKutuAdi.MaxLength = 40;
            this.txtKutuAdi.Name = "txtKutuAdi";
            this.txtKutuAdi.Size = new System.Drawing.Size(171, 20);
            this.txtKutuAdi.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 97);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(360, 221);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "KutuAdı";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nerede";
            this.columnHeader2.Width = 175;
            // 
            // altFrmKutuDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 329);
            this.Controls.Add(this.Grp);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "altFrmKutuDuzenle";
            this.Text = "altFrmKutuDuzenle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.altFrmKutuDuzenle_FormClosed);
            this.Load += new System.EventHandler(this.altFrmKutuDuzenle_Load);
            this.Grp.ResumeLayout(false);
            this.Grp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Grp;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtKutuAdi;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox comboYer;
    }
}