namespace CdStok
{
    partial class altFrmDurumDegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(altFrmDurumDegistir));
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblNot = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.comboDurumTuru = new System.Windows.Forms.ComboBox();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.dtpDurumTarih = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(13, 13);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(41, 13);
            this.lblDurum.TabIndex = 0;
            this.lblDurum.Text = "Durum:";
            // 
            // lblNot
            // 
            this.lblNot.AutoSize = true;
            this.lblNot.Location = new System.Drawing.Point(13, 39);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(27, 13);
            this.lblNot.TabIndex = 1;
            this.lblNot.Text = "Not:";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(13, 174);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(34, 13);
            this.lblTarih.TabIndex = 2;
            this.lblTarih.Text = "Tarih:";
            // 
            // comboDurumTuru
            // 
            this.comboDurumTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDurumTuru.FormattingEnabled = true;
            this.comboDurumTuru.Location = new System.Drawing.Point(60, 10);
            this.comboDurumTuru.Name = "comboDurumTuru";
            this.comboDurumTuru.Size = new System.Drawing.Size(233, 21);
            this.comboDurumTuru.TabIndex = 3;
            this.comboDurumTuru.SelectedIndexChanged += new System.EventHandler(this.comboDurumTuru_SelectedIndexChanged);
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(60, 36);
            this.txtNot.MaxLength = 150;
            this.txtNot.Multiline = true;
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(233, 128);
            this.txtNot.TabIndex = 4;
            // 
            // dtpDurumTarih
            // 
            this.dtpDurumTarih.Location = new System.Drawing.Point(60, 171);
            this.dtpDurumTarih.Name = "dtpDurumTarih";
            this.dtpDurumTarih.Size = new System.Drawing.Size(233, 20);
            this.dtpDurumTarih.TabIndex = 5;
            this.dtpDurumTarih.ValueChanged += new System.EventHandler(this.dtpDurumTarih_ValueChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(16, 197);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(277, 23);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // altFrmDurumDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 231);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dtpDurumTarih);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.comboDurumTuru);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblNot);
            this.Controls.Add(this.lblDurum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "altFrmDurumDegistir";
            this.Text = "altFrmDurumDegistir";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.altFrmDurumDegistir_FormClosed);
            this.Load += new System.EventHandler(this.altFrmDurumDegistir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblNot;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.ComboBox comboDurumTuru;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.DateTimePicker dtpDurumTarih;
        private System.Windows.Forms.Button btnKaydet;
    }
}