using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using IDAutomation.Windows.Forms.LinearBarCode;
using System.Drawing.Printing;

namespace CdStok
{
    public partial class altFrmCdEkle : Form
    {
        SqlConnection conn = dbIslem.baglantiOlustur();

        public altFrmCdEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool hata = false;
            string hatalar = null;
            if (txtCdAdi.Text.Trim().Length == 0)
            {
                hata = true;
                hatalar += "Cd Adı girmediniz\r\n";
            }
            else
            {
                if (dbIslem.aynisiVarmi("Cdler", "KullaniciID", "CdAdi", (this.ParentForm as frmCdStok).kullaniciID.ToString(), txtCdAdi.Text))
                {
                    hata = true;
                    hatalar += "Daha önce bu isimle bir CD adını zaten eklemişsin!\r\n";
                }
            }
            if (comboKutu.Text.Trim().Length == 0)
            {
                hata = true;
                hatalar += "Kutu adı girmediniz veya seçmediniz!\r\n";
            }
            if (comboYer.Text.Trim().Length == 0)
            {
                hata = true;
                hatalar += "Yer adı girmediniz veya seçmediniz!\r\n";
            }
            if (lbDosyalar.Items.Count == 0)
            {
                hata = true;
                hatalar += "Hiç dosya eklemediniz!\r\n";
            }
            if (hata)
            {
                MessageBox.Show(hatalar, "Hata Oluştu!");
            }
            else
            {
                //++Ekleme islemleri
                Random rnd = new Random();
                int rasSayi;
                bool barkodAyniMi = false;
                do
                {
                    rasSayi = rnd.Next(100000000, 999999999);
                    barkodAyniMi = dbIslem.aynisiVarmi("Cdler", "BarkodNo", rasSayi.ToString());
                }
                while (barkodAyniMi);
                string sonID = null;
                //buraya transaction koyabilirdim fakat hata çıkma olasılığını düşürdüğüm ve hatalar giderilmeden buraya geçeceği için gerek duymadım
                    sonID = dbIslem.dbEkleVeriIslem("Yerler", null, sonID, "YerAdi", comboYer.Text.Trim());
                    sonID = dbIslem.dbEkleVeriIslem("Kutular", "YerID", sonID, "KutuAdi", comboKutu.Text.Trim());
                    sonID = dbIslem.dbEkleVeriIslem("Cdler", "KutuID", sonID, "CdAdi", "BarkodNo", "KullaniciID", "DurumID", "KisiselMi", "Tarih", txtCdAdi.Text.Trim(), rasSayi.ToString(), (this.ParentForm as frmCdStok).kullaniciID.ToString(), "0", cbKisisel.Checked.ToString(), DateTime.Now.ToString("yyyy-MM-dd"));
                    foreach (string DosyaAdi in lbDosyalar.Items)
                        dbIslem.dbEkleVeriIslem("Dosyalar", "CdID", sonID, "DosyaAdi", DosyaAdi);
                foreach (Control ct in this.Controls)
                    ct.Visible = false;
                barcode1.DataToEncode = rasSayi.ToString();
                barcode1.Show();
                btnYazdir.Visible = true;
                btnOnizleme.Visible = true;
                PaperSize ps = new PaperSize();
                ps.Height = 80;
                ps.Width = 200;
                ps.PaperName = "BarkodYazdirmaSayfasi";
                printDocument1.DefaultPageSettings.PaperSize = ps;
            }
        }

        private void altFrmCdEkle_Load(object sender, EventArgs e)
        {
            barcode1.Hide();
            btnYazdir.Visible = false;
            btnOnizleme.Visible = false;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Kutular ORDER BY KutuAdi ASC", conn);
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
                comboKutu.Items.Add(sdr["KutuAdi"]);
            conn.Close();
            cmd = new SqlCommand("SELECT * FROM Yerler ORDER BY YerAdi ASC", conn);
            conn.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
                comboYer.Items.Add(sdr["YerAdi"]);
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dosya ekle
            if (txtDosya.Text.Trim() == "")
            {
                MessageBox.Show("Dosya adı girmelisiniz!");
                return;
            }
            if (lbDosyalar.Items.Contains(txtDosya.Text.Trim()))
            {
                MessageBox.Show(txtDosya.Text.Trim() + ", isimli dosya zaten listede mevcut!");
            }
            else
            {
                lbDosyalar.Items.Add(txtDosya.Text.Trim());
                txtDosya.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dosya çıkart
            if (lbDosyalar.SelectedIndex == -1)
                MessageBox.Show("Hiç dosya seçmediniz!");
            else
                lbDosyalar.Items.Remove(lbDosyalar.SelectedItem);
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics grp = e.Graphics;
            grp.DrawImage(barcode1.Picture, 5, 5);
        }

        private void altFrmCdEkle_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void altFrmCdEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            (this.ParentForm as frmCdStok).listView1.Show();
            (this.ParentForm as frmCdStok).cdleriListele();
        }

        private void comboKutu_SelectedIndexChanged(object sender, EventArgs e)
        {
            kutuComboDegisim();
        }

        private void comboKutu_TextChanged(object sender, EventArgs e)
        {
            kutuComboDegisim();
        }

        private void kutuComboDegisim()
        {
            SqlCommand cmd = new SqlCommand("SELECT y.YerAdi FROM Kutular k JOIN Yerler y ON k.YerID=y.YerID WHERE k.KutuAdi = @KutuAdi", conn);
            cmd.Parameters.AddWithValue("@KutuAdi", comboKutu.Text);
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                sdr.Read();
                comboYer.Text = sdr["YerAdi"].ToString();
                comboYer.Enabled = false;
            }
            else
            {
                comboYer.Enabled = true;
            }
            conn.Close();
        }

        private void barcode1_Load(object sender, EventArgs e)
        {

        }

        private void btnOnizleme_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }


    }
}
