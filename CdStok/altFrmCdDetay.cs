using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace CdStok
{
    public partial class altFrmCdDetay : Form
    {
        string veriID;
        SqlConnection conn = dbIslem.baglantiOlustur();

        public altFrmCdDetay(string gelenID)
        {
            InitializeComponent();
            veriID = gelenID;
        }

        private void altFrmCdDetay_Load(object sender, EventArgs e)
        {
            PaperSize ps = new PaperSize();
            ps.Height = 80;
            ps.Width = 200;
            ps.PaperName = "BarkodYazdirmaSayfasi";
            printDocument1.DefaultPageSettings.PaperSize = ps;
            SqlCommand cmd = new SqlCommand("SELECT c.CdID, c.KisiselMi, c.CdAdi, c.BarkodNo, c.Tarih, c.KullaniciID, k.KutuAdi, y.YerAdi, CASE d.DurumTuru WHEN 1 THEN 'Arkadaşda' WHEN 2 THEN 'Kayboldu' WHEN 3 THEN 'Çalındı' WHEN 4 THEN 'Bozuldu' ELSE 'Yerinde' END AS Durum, d.DurumNot, d.DurumTarih, kul.KullaniciAdi FROM Cdler c JOIN Kutular k ON c.KutuID=k.KutuID JOIN Yerler y ON k.YerID=y.YerID JOIN Kullanicilar kul ON kul.KullaniciID=c.KullaniciID LEFT JOIN Durumlar d ON d.DurumID=c.DurumID WHERE c.CdID=@veriID", conn);
            cmd.Parameters.AddWithValue("@veriID", veriID);
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                sdr.Read();
                this.Text = sdr["CdAdi"].ToString() + " CD'si Hakkında Detaylı Bilgiler";
                //bu CD'yi şuan programda aktif olan kullanıcı eklemişse: CD ekle/çıkart/düzenle işlemlerini yapabilir
                if (sdr["KullaniciID"].ToString() != (this.ParentForm as frmCdStok).kullaniciID.ToString())
                {
                    txtDosyaAdi.Enabled = false;
                    lisDosyalar.Enabled = false;
                    btnDosyaEkle.Enabled = false;
                    btnDosyaDuzenle.Enabled = false;
                    btnDosyaSil.Enabled = false;
                }
                lblCdAdi.Text = sdr["CdAdi"].ToString();
                lblKutuAdi.Text = sdr["KutuAdi"].ToString();
                lblNerede.Text = sdr["YerAdi"].ToString();
                lblEkleyen.Text = sdr["KullaniciAdi"].ToString();
                lblTarih.Text = Convert.ToDateTime(sdr["Tarih"]).ToString("dd.MM.yyyy");
                lblDurum.Text = sdr["Durum"].ToString();
                txtDurumDetay.Text = sdr["Durum"].ToString() != "Yerinde" ? Convert.ToDateTime(sdr["DurumTarih"]).ToString("dd.MM.yyyy") + "\r\n" + sdr["DurumNot"].ToString() : "CD Kutusunda!";
                barcode1.DataToEncode = sdr["BarkodNo"].ToString();
            }
            conn.Close();
            Yardimci.DosyalariDiz(lisDosyalar, grpDosyalar, veriID);
        }

        private void altFrmCdDetay_FormClosed(object sender, FormClosedEventArgs e)
        {
            (this.ParentForm as frmCdStok).listView1.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics gr = e.Graphics;
            gr.DrawImage(barcode1.Picture, 5, 5);
        }

        private void btnOnizleme_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void btnDosyaEkle_Click(object sender, EventArgs e)
        {
            Yardimci.DosyaEkle(lisDosyalar, grpDosyalar, txtDosyaAdi, veriID);
        }

        private void btnDosyaDuzenle_Click(object sender, EventArgs e)
        {
            Yardimci.DosyaDuzenle(lisDosyalar, grpDosyalar, txtDosyaAdi, veriID);
        }

        private void btnDosyaSil_Click(object sender, EventArgs e)
        {
            Yardimci.DosyaSil(lisDosyalar, grpDosyalar, veriID);
        }
    }
}
