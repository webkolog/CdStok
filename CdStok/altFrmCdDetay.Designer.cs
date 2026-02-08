namespace CdStok
{
    partial class altFrmCdDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(altFrmCdDetay));
            this.lblCdAdi = new System.Windows.Forms.Label();
            this.lblKutuAdi = new System.Windows.Forms.Label();
            this.lblNerede = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grpDosyalar = new System.Windows.Forms.GroupBox();
            this.btnDosyaSil = new System.Windows.Forms.Button();
            this.lisDosyalar = new System.Windows.Forms.ListBox();
            this.btnDosyaEkle = new System.Windows.Forms.Button();
            this.txtDosyaAdi = new System.Windows.Forms.TextBox();
            this.btnDosyaDuzenle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEkleyen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.grpDurum = new System.Windows.Forms.GroupBox();
            this.txtDurumDetay = new System.Windows.Forms.TextBox();
            this.barcode1 = new IDAutomation.Windows.Forms.LinearBarCode.Barcode();
            this.grpBarkod = new System.Windows.Forms.GroupBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnOnizleme = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.grpDosyalar.SuspendLayout();
            this.grpDurum.SuspendLayout();
            this.grpBarkod.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCdAdi
            // 
            this.lblCdAdi.AutoSize = true;
            this.lblCdAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCdAdi.Location = new System.Drawing.Point(90, 9);
            this.lblCdAdi.Name = "lblCdAdi";
            this.lblCdAdi.Size = new System.Drawing.Size(65, 16);
            this.lblCdAdi.TabIndex = 0;
            this.lblCdAdi.Text = "_ _ _ _ _ _";
            // 
            // lblKutuAdi
            // 
            this.lblKutuAdi.AutoSize = true;
            this.lblKutuAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKutuAdi.Location = new System.Drawing.Point(90, 25);
            this.lblKutuAdi.Name = "lblKutuAdi";
            this.lblKutuAdi.Size = new System.Drawing.Size(65, 16);
            this.lblKutuAdi.TabIndex = 0;
            this.lblKutuAdi.Text = "_ _ _ _ _ _";
            // 
            // lblNerede
            // 
            this.lblNerede.AutoSize = true;
            this.lblNerede.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNerede.Location = new System.Drawing.Point(90, 41);
            this.lblNerede.Name = "lblNerede";
            this.lblNerede.Size = new System.Drawing.Size(65, 16);
            this.lblNerede.TabIndex = 0;
            this.lblNerede.Text = "_ _ _ _ _ _";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(376, 41);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(65, 16);
            this.lblDurum.TabIndex = 0;
            this.lblDurum.Text = "_ _ _ _ _ _";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "CD Adı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(9, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kutu Adı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(9, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nerede:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(302, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Durum:";
            // 
            // grpDosyalar
            // 
            this.grpDosyalar.Controls.Add(this.btnDosyaSil);
            this.grpDosyalar.Controls.Add(this.lisDosyalar);
            this.grpDosyalar.Controls.Add(this.btnDosyaEkle);
            this.grpDosyalar.Controls.Add(this.txtDosyaAdi);
            this.grpDosyalar.Controls.Add(this.btnDosyaDuzenle);
            this.grpDosyalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpDosyalar.Location = new System.Drawing.Point(2, 56);
            this.grpDosyalar.Name = "grpDosyalar";
            this.grpDosyalar.Size = new System.Drawing.Size(288, 265);
            this.grpDosyalar.TabIndex = 2;
            this.grpDosyalar.TabStop = false;
            this.grpDosyalar.Text = "İçindeki Dosyalar";
            // 
            // btnDosyaSil
            // 
            this.btnDosyaSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDosyaSil.Image = ((System.Drawing.Image)(resources.GetObject("btnDosyaSil.Image")));
            this.btnDosyaSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDosyaSil.Location = new System.Drawing.Point(159, 49);
            this.btnDosyaSil.Name = "btnDosyaSil";
            this.btnDosyaSil.Size = new System.Drawing.Size(119, 22);
            this.btnDosyaSil.TabIndex = 3;
            this.btnDosyaSil.Text = "     Seçili Dosyayı Sil";
            this.btnDosyaSil.UseVisualStyleBackColor = true;
            this.btnDosyaSil.Click += new System.EventHandler(this.btnDosyaSil_Click);
            // 
            // lisDosyalar
            // 
            this.lisDosyalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lisDosyalar.ForeColor = System.Drawing.Color.Black;
            this.lisDosyalar.FormattingEnabled = true;
            this.lisDosyalar.Location = new System.Drawing.Point(10, 82);
            this.lisDosyalar.Name = "lisDosyalar";
            this.lisDosyalar.Size = new System.Drawing.Size(268, 173);
            this.lisDosyalar.TabIndex = 0;
            // 
            // btnDosyaEkle
            // 
            this.btnDosyaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDosyaEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnDosyaEkle.Image")));
            this.btnDosyaEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDosyaEkle.Location = new System.Drawing.Point(193, 21);
            this.btnDosyaEkle.Name = "btnDosyaEkle";
            this.btnDosyaEkle.Size = new System.Drawing.Size(85, 22);
            this.btnDosyaEkle.TabIndex = 2;
            this.btnDosyaEkle.Text = "     Dosya Ekle";
            this.btnDosyaEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDosyaEkle.UseVisualStyleBackColor = true;
            this.btnDosyaEkle.Click += new System.EventHandler(this.btnDosyaEkle_Click);
            // 
            // txtDosyaAdi
            // 
            this.txtDosyaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDosyaAdi.Location = new System.Drawing.Point(10, 21);
            this.txtDosyaAdi.MaxLength = 40;
            this.txtDosyaAdi.Name = "txtDosyaAdi";
            this.txtDosyaAdi.Size = new System.Drawing.Size(175, 20);
            this.txtDosyaAdi.TabIndex = 1;
            // 
            // btnDosyaDuzenle
            // 
            this.btnDosyaDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDosyaDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnDosyaDuzenle.Image")));
            this.btnDosyaDuzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDosyaDuzenle.Location = new System.Drawing.Point(10, 49);
            this.btnDosyaDuzenle.Name = "btnDosyaDuzenle";
            this.btnDosyaDuzenle.Size = new System.Drawing.Size(143, 22);
            this.btnDosyaDuzenle.TabIndex = 4;
            this.btnDosyaDuzenle.Text = "     Seçili Dosyayı Değiştir";
            this.btnDosyaDuzenle.UseVisualStyleBackColor = true;
            this.btnDosyaDuzenle.Click += new System.EventHandler(this.btnDosyaDuzenle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ekleyen:";
            // 
            // lblEkleyen
            // 
            this.lblEkleyen.AutoSize = true;
            this.lblEkleyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEkleyen.Location = new System.Drawing.Point(376, 9);
            this.lblEkleyen.Name = "lblEkleyen";
            this.lblEkleyen.Size = new System.Drawing.Size(65, 16);
            this.lblEkleyen.TabIndex = 0;
            this.lblEkleyen.Text = "_ _ _ _ _ _";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(302, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tarih:";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(376, 25);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(65, 16);
            this.lblTarih.TabIndex = 0;
            this.lblTarih.Text = "_ _ _ _ _ _";
            // 
            // grpDurum
            // 
            this.grpDurum.Controls.Add(this.txtDurumDetay);
            this.grpDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpDurum.Location = new System.Drawing.Point(296, 56);
            this.grpDurum.Name = "grpDurum";
            this.grpDurum.Size = new System.Drawing.Size(288, 130);
            this.grpDurum.TabIndex = 2;
            this.grpDurum.TabStop = false;
            this.grpDurum.Text = "Durum Detay";
            // 
            // txtDurumDetay
            // 
            this.txtDurumDetay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDurumDetay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDurumDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDurumDetay.Location = new System.Drawing.Point(9, 21);
            this.txtDurumDetay.Multiline = true;
            this.txtDurumDetay.Name = "txtDurumDetay";
            this.txtDurumDetay.ReadOnly = true;
            this.txtDurumDetay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDurumDetay.Size = new System.Drawing.Size(268, 95);
            this.txtDurumDetay.TabIndex = 1;
            this.txtDurumDetay.TabStop = false;
            // 
            // barcode1
            // 
            this.barcode1.ApplyTilde = false;
            this.barcode1.BackColor = System.Drawing.Color.White;
            this.barcode1.BarHeightCM = "1.000";
            this.barcode1.BearerBarHorizontal = "0";
            this.barcode1.BearerBarVertical = "0";
            this.barcode1.CaptionAbove = "";
            this.barcode1.CaptionBelow = "";
            this.barcode1.CaptionBottomAlignment = System.Drawing.StringAlignment.Center;
            this.barcode1.CaptionBottomColor = System.Drawing.Color.Black;
            this.barcode1.CaptionBottomSpace = "0.10";
            this.barcode1.CaptionFontAbove = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.barcode1.CaptionFontBelow = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.barcode1.CaptionTopAlignment = System.Drawing.StringAlignment.Center;
            this.barcode1.CaptionTopColor = System.Drawing.Color.Black;
            this.barcode1.CaptionTopSpace = "0.10";
            this.barcode1.CharacterGrouping = "0";
            this.barcode1.CheckCharacter = false;
            this.barcode1.CheckCharacterInText = true;
            this.barcode1.CODABARStartChar = "A";
            this.barcode1.CODABARStopChar = "B";
            this.barcode1.Code128Set = IDAutomation.Windows.Forms.LinearBarCode.Barcode.Code128CharacterSets.Auto;
            this.barcode1.DataToEncode = "123456789012";
            this.barcode1.DoPaint = true;
            this.barcode1.FitControlToBarcode = true;
            this.barcode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barcode1.ForeColor = System.Drawing.Color.Black;
            this.barcode1.LeftMarginCM = "0.200";
            this.barcode1.Location = new System.Drawing.Point(9, 44);
            this.barcode1.Name = "barcode1";
            this.barcode1.NarrowToWideRatio = "2.0";
            this.barcode1.PostnetHeightShort = "0.1270";
            this.barcode1.PostnetHeightTall = "0.3226";
            this.barcode1.PostnetSpacing = "0.066";
            this.barcode1.Resolution = IDAutomation.Windows.Forms.LinearBarCode.Barcode.Resolutions.Printer;
            this.barcode1.ResolutionCustomDPI = "600.00";
            this.barcode1.ResolutionPrinterToUse = "";
            this.barcode1.RotationAngle = IDAutomation.Windows.Forms.LinearBarCode.Barcode.RotationAngles.Zero_Degrees;
            this.barcode1.ShowText = true;
            this.barcode1.ShowTextLocation = IDAutomation.Windows.Forms.LinearBarCode.Barcode.HRTextPositions.Bottom;
            this.barcode1.Size = new System.Drawing.Size(195, 75);
            this.barcode1.SuppSeparationCM = "0.500";
            this.barcode1.SymbologyID = IDAutomation.Windows.Forms.LinearBarCode.Barcode.Symbologies.Code39;
            this.barcode1.TabIndex = 3;
            this.barcode1.TextFontColor = System.Drawing.Color.Black;
            this.barcode1.TextMarginCM = "0.100";
            this.barcode1.TopMarginCM = "0.200";
            this.barcode1.UPCESystem = "0";
            this.barcode1.WhiteBarIncrease = "0";
            this.barcode1.XDimensionCM = "0.0300";
            this.barcode1.XDimensionMILS = "11.8110";
            // 
            // grpBarkod
            // 
            this.grpBarkod.Controls.Add(this.btnYazdir);
            this.grpBarkod.Controls.Add(this.btnOnizleme);
            this.grpBarkod.Controls.Add(this.barcode1);
            this.grpBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBarkod.Location = new System.Drawing.Point(296, 192);
            this.grpBarkod.Name = "grpBarkod";
            this.grpBarkod.Size = new System.Drawing.Size(288, 129);
            this.grpBarkod.TabIndex = 4;
            this.grpBarkod.TabStop = false;
            this.grpBarkod.Text = "Barkod :";
            // 
            // btnYazdir
            // 
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.Image = ((System.Drawing.Image)(resources.GetObject("btnYazdir.Image")));
            this.btnYazdir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYazdir.Location = new System.Drawing.Point(122, 21);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(60, 23);
            this.btnYazdir.TabIndex = 4;
            this.btnYazdir.Text = "     Yazdır";
            this.btnYazdir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnOnizleme
            // 
            this.btnOnizleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnizleme.Image = ((System.Drawing.Image)(resources.GetObject("btnOnizleme.Image")));
            this.btnOnizleme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnizleme.Location = new System.Drawing.Point(9, 21);
            this.btnOnizleme.Name = "btnOnizleme";
            this.btnOnizleme.Size = new System.Drawing.Size(107, 23);
            this.btnOnizleme.TabIndex = 4;
            this.btnOnizleme.Text = "     Baskı Önizleme";
            this.btnOnizleme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnizleme.UseVisualStyleBackColor = true;
            this.btnOnizleme.Click += new System.EventHandler(this.btnOnizleme_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // altFrmCdDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 324);
            this.Controls.Add(this.grpBarkod);
            this.Controls.Add(this.grpDurum);
            this.Controls.Add(this.grpDosyalar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblEkleyen);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblNerede);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblKutuAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCdAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "altFrmCdDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "altFrmCdDetay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.altFrmCdDetay_FormClosed);
            this.Load += new System.EventHandler(this.altFrmCdDetay_Load);
            this.grpDosyalar.ResumeLayout(false);
            this.grpDosyalar.PerformLayout();
            this.grpDurum.ResumeLayout(false);
            this.grpDurum.PerformLayout();
            this.grpBarkod.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCdAdi;
        private System.Windows.Forms.Label lblKutuAdi;
        private System.Windows.Forms.Label lblNerede;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grpDosyalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lisDosyalar;
        private System.Windows.Forms.Label lblEkleyen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.GroupBox grpDurum;
        private IDAutomation.Windows.Forms.LinearBarCode.Barcode barcode1;
        private System.Windows.Forms.TextBox txtDurumDetay;
        private System.Windows.Forms.GroupBox grpBarkod;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnOnizleme;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnDosyaSil;
        private System.Windows.Forms.Button btnDosyaEkle;
        private System.Windows.Forms.Button btnDosyaDuzenle;
        private System.Windows.Forms.TextBox txtDosyaAdi;
    }
}