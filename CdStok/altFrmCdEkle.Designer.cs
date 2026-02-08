namespace CdStok
{
    partial class altFrmCdEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(altFrmCdEkle));
            this.txtCdAdi = new System.Windows.Forms.TextBox();
            this.lblCdAdi = new System.Windows.Forms.Label();
            this.lblKutu = new System.Windows.Forms.Label();
            this.comboKutu = new System.Windows.Forms.ComboBox();
            this.cbKisisel = new System.Windows.Forms.CheckBox();
            this.lblYer = new System.Windows.Forms.Label();
            this.comboYer = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtDosya = new System.Windows.Forms.TextBox();
            this.btnDosyaEkle = new System.Windows.Forms.Button();
            this.btnDosyaCikart = new System.Windows.Forms.Button();
            this.lblDosya = new System.Windows.Forms.Label();
            this.lbDosyalar = new System.Windows.Forms.ListBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnOnizleme = new System.Windows.Forms.Button();
            this.barcode1 = new IDAutomation.Windows.Forms.LinearBarCode.Barcode();
            this.SuspendLayout();
            // 
            // txtCdAdi
            // 
            this.txtCdAdi.Location = new System.Drawing.Point(69, 10);
            this.txtCdAdi.MaxLength = 40;
            this.txtCdAdi.Name = "txtCdAdi";
            this.txtCdAdi.Size = new System.Drawing.Size(260, 20);
            this.txtCdAdi.TabIndex = 0;
            // 
            // lblCdAdi
            // 
            this.lblCdAdi.AutoSize = true;
            this.lblCdAdi.Location = new System.Drawing.Point(13, 13);
            this.lblCdAdi.Name = "lblCdAdi";
            this.lblCdAdi.Size = new System.Drawing.Size(43, 13);
            this.lblCdAdi.TabIndex = 1;
            this.lblCdAdi.Text = "CD Adı:";
            // 
            // lblKutu
            // 
            this.lblKutu.AutoSize = true;
            this.lblKutu.Location = new System.Drawing.Point(13, 66);
            this.lblKutu.Name = "lblKutu";
            this.lblKutu.Size = new System.Drawing.Size(50, 13);
            this.lblKutu.TabIndex = 2;
            this.lblKutu.Text = "Kutu Adı:";
            // 
            // comboKutu
            // 
            this.comboKutu.FormattingEnabled = true;
            this.comboKutu.Location = new System.Drawing.Point(69, 63);
            this.comboKutu.MaxLength = 40;
            this.comboKutu.Name = "comboKutu";
            this.comboKutu.Size = new System.Drawing.Size(260, 21);
            this.comboKutu.TabIndex = 3;
            this.comboKutu.SelectedIndexChanged += new System.EventHandler(this.comboKutu_SelectedIndexChanged);
            this.comboKutu.TextChanged += new System.EventHandler(this.comboKutu_TextChanged);
            // 
            // cbKisisel
            // 
            this.cbKisisel.AutoSize = true;
            this.cbKisisel.Location = new System.Drawing.Point(274, 201);
            this.cbKisisel.Name = "cbKisisel";
            this.cbKisisel.Size = new System.Drawing.Size(55, 17);
            this.cbKisisel.TabIndex = 8;
            this.cbKisisel.Text = "Kişisel";
            this.cbKisisel.UseVisualStyleBackColor = true;
            // 
            // lblYer
            // 
            this.lblYer.AutoSize = true;
            this.lblYer.Location = new System.Drawing.Point(13, 39);
            this.lblYer.Name = "lblYer";
            this.lblYer.Size = new System.Drawing.Size(44, 13);
            this.lblYer.TabIndex = 5;
            this.lblYer.Text = "Yer Adı:";
            // 
            // comboYer
            // 
            this.comboYer.FormattingEnabled = true;
            this.comboYer.Location = new System.Drawing.Point(69, 36);
            this.comboYer.MaxLength = 40;
            this.comboYer.Name = "comboYer";
            this.comboYer.Size = new System.Drawing.Size(260, 21);
            this.comboYer.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(16, 197);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(249, 23);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtDosya
            // 
            this.txtDosya.Location = new System.Drawing.Point(69, 91);
            this.txtDosya.MaxLength = 40;
            this.txtDosya.Name = "txtDosya";
            this.txtDosya.Size = new System.Drawing.Size(224, 20);
            this.txtDosya.TabIndex = 4;
            // 
            // btnDosyaEkle
            // 
            this.btnDosyaEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnDosyaEkle.Image")));
            this.btnDosyaEkle.Location = new System.Drawing.Point(299, 91);
            this.btnDosyaEkle.Name = "btnDosyaEkle";
            this.btnDosyaEkle.Size = new System.Drawing.Size(30, 23);
            this.btnDosyaEkle.TabIndex = 5;
            this.btnDosyaEkle.UseVisualStyleBackColor = true;
            this.btnDosyaEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDosyaCikart
            // 
            this.btnDosyaCikart.Image = ((System.Drawing.Image)(resources.GetObject("btnDosyaCikart.Image")));
            this.btnDosyaCikart.Location = new System.Drawing.Point(299, 119);
            this.btnDosyaCikart.Name = "btnDosyaCikart";
            this.btnDosyaCikart.Size = new System.Drawing.Size(30, 69);
            this.btnDosyaCikart.TabIndex = 7;
            this.btnDosyaCikart.UseVisualStyleBackColor = true;
            this.btnDosyaCikart.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblDosya
            // 
            this.lblDosya.AutoSize = true;
            this.lblDosya.Location = new System.Drawing.Point(13, 94);
            this.lblDosya.Name = "lblDosya";
            this.lblDosya.Size = new System.Drawing.Size(40, 13);
            this.lblDosya.TabIndex = 12;
            this.lblDosya.Text = "Dosya:";
            // 
            // lbDosyalar
            // 
            this.lbDosyalar.FormattingEnabled = true;
            this.lbDosyalar.Location = new System.Drawing.Point(69, 119);
            this.lbDosyalar.Name = "lbDosyalar";
            this.lbDosyalar.Size = new System.Drawing.Size(224, 69);
            this.lbDosyalar.TabIndex = 6;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.Image = ((System.Drawing.Image)(resources.GetObject("btnYazdir.Image")));
            this.btnYazdir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYazdir.Location = new System.Drawing.Point(125, 90);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(68, 23);
            this.btnYazdir.TabIndex = 22;
            this.btnYazdir.Text = "     Yazdır";
            this.btnYazdir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // btnOnizleme
            // 
            this.btnOnizleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnizleme.Image = ((System.Drawing.Image)(resources.GetObject("btnOnizleme.Image")));
            this.btnOnizleme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnizleme.Location = new System.Drawing.Point(12, 90);
            this.btnOnizleme.Name = "btnOnizleme";
            this.btnOnizleme.Size = new System.Drawing.Size(107, 23);
            this.btnOnizleme.TabIndex = 24;
            this.btnOnizleme.Text = "     Baskı Önizleme";
            this.btnOnizleme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnizleme.UseVisualStyleBackColor = true;
            this.btnOnizleme.Click += new System.EventHandler(this.btnOnizleme_Click);
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
            this.barcode1.Location = new System.Drawing.Point(12, 9);
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
            this.barcode1.TabIndex = 25;
            this.barcode1.TextFontColor = System.Drawing.Color.Black;
            this.barcode1.TextMarginCM = "0.100";
            this.barcode1.TopMarginCM = "0.200";
            this.barcode1.UPCESystem = "0";
            this.barcode1.WhiteBarIncrease = "0";
            this.barcode1.XDimensionCM = "0.0300";
            this.barcode1.XDimensionMILS = "11.8110";
            this.barcode1.Load += new System.EventHandler(this.barcode1_Load);
            // 
            // altFrmCdEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 233);
            this.Controls.Add(this.barcode1);
            this.Controls.Add(this.btnOnizleme);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.lbDosyalar);
            this.Controls.Add(this.lblDosya);
            this.Controls.Add(this.btnDosyaCikart);
            this.Controls.Add(this.btnDosyaEkle);
            this.Controls.Add(this.txtDosya);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.comboYer);
            this.Controls.Add(this.lblYer);
            this.Controls.Add(this.cbKisisel);
            this.Controls.Add(this.comboKutu);
            this.Controls.Add(this.lblKutu);
            this.Controls.Add(this.lblCdAdi);
            this.Controls.Add(this.txtCdAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "altFrmCdEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CD Ekle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.altFrmCdEkle_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.altFrmCdEkle_FormClosed);
            this.Load += new System.EventHandler(this.altFrmCdEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCdAdi;
        private System.Windows.Forms.Label lblCdAdi;
        private System.Windows.Forms.Label lblKutu;
        private System.Windows.Forms.ComboBox comboKutu;
        private System.Windows.Forms.CheckBox cbKisisel;
        private System.Windows.Forms.Label lblYer;
        private System.Windows.Forms.ComboBox comboYer;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtDosya;
        private System.Windows.Forms.Button btnDosyaEkle;
        private System.Windows.Forms.Button btnDosyaCikart;
        private System.Windows.Forms.Label lblDosya;
        private System.Windows.Forms.ListBox lbDosyalar;
        private System.Windows.Forms.Button btnYazdir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnOnizleme;
        private IDAutomation.Windows.Forms.LinearBarCode.Barcode barcode1;

    }
}