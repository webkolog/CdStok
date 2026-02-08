using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CdStok
{
    public partial class altFrmCdDuzenle : Form
    {
        string veriID;
        bool ilkAcilis = false;
        SqlConnection conn = dbIslem.baglantiOlustur();

        public altFrmCdDuzenle(string gelenID)
        {
            InitializeComponent();
            veriID = gelenID;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string yerID = null, kutuID = null;
            bool hata = false;
            string hatalar = null;
            if (txtCdAdi.Text.Trim().Length == 0)
            {
                hata = true;
                hatalar += "Cd Adı girmediniz\r\n";
            }
            else
            {
                //aynı isimli fakat farklı ID ile kaydedilmiş Cd varsa bu isimi kullanmaya izin verme
                if (dbIslem.aynisiVarmi("Cdler", "KullaniciID", "CdAdi", "!CdID", (this.ParentForm as frmCdStok).kullaniciID.ToString(), txtCdAdi.Text.Trim(), veriID))
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
            if (hata)
            {
                MessageBox.Show(hatalar, "Hata Oluştu!");
            }
            else
            {
                if (comboYer.SelectedIndex == -1)
                {
                    yerID = dbIslem.dbEkleVeriIslem("Yerler", null, null, "YerAdi", comboYer.Text.Trim());
                }
                else
                {
                    yerID = (comboYer.SelectedItem as YerSaklayici).YerID;
                }
                if (comboKutu.SelectedIndex == -1)
                {
                    kutuID = dbIslem.dbEkleVeriIslem("Kutular", "YerID", yerID, "KutuAdi", comboKutu.Text.Trim());
                }
                else
                {
                    kutuID = (comboKutu.SelectedItem as KutuSaklayici).KutuID;
                }
                dbIslem.dbHizliGuncelle("Kutular", "KutuID", kutuID, "KutuAdi", comboKutu.Text.Trim());
                dbIslem.dbHizliGuncelle("Yerler", "YerID", yerID, "YerAdi", comboYer.Text.Trim());
                int etki = dbIslem.dbHizliGuncelle("Cdler", "CdID", veriID, "CdAdi", "KutuID", "KisiselMi", txtCdAdi.Text.Trim(), kutuID, cbKisisel.Checked.ToString());
                if (etki > 0)
                {
                    (this.ParentForm as frmCdStok).cdleriListele();
                    this.Close();
                }
            }
        }

        private void altFrmCdDuzenle_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT c.CdID, c.KisiselMi, c.CdAdi, c.BarkodNo, c.KullaniciID, k.KutuAdi, k.KutuID, y.YerAdi, y.YerID, CASE d.DurumTuru WHEN 1 THEN 'Arkadaşda' WHEN 2 THEN 'Kayboldu' WHEN 3 THEN 'Çalındı' WHEN 4 THEN 'Bozuldu' ELSE 'Yerinde' END AS Durum, kul.KullaniciAdi FROM Cdler c JOIN Kutular k ON c.KutuID=k.KutuID JOIN Yerler y ON k.YerID=y.YerID JOIN Kullanicilar kul ON kul.KullaniciID=c.KullaniciID LEFT JOIN Durumlar d ON d.DurumID=c.DurumID WHERE c.CdID = @CdID", conn);
            cmd.Parameters.AddWithValue("@CdID", veriID);
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                sdr.Read();
                this.Text = sdr["CdAdi"].ToString() + " CD'sini Düzenle";
                txtCdAdi.Text = sdr["CdAdi"].ToString();
                YerSaklayici yerSakla = new YerSaklayici();
                yerSakla.YerID = sdr["YerID"].ToString();
                yerSakla.YerAdi = sdr["YerAdi"].ToString();
                comboYer.Tag = yerSakla;
                comboYer.Text = yerSakla.ToString();
                KutuSaklayici kutuSakla = new KutuSaklayici();
                kutuSakla.KutuID = sdr["KutuID"].ToString();
                kutuSakla.KutuAdi = sdr["KutuAdi"].ToString();
                comboKutu.Tag = kutuSakla;
                comboKutu.Text = kutuSakla.ToString();
                cbKisisel.Checked = Convert.ToBoolean(sdr["KisiselMi"]);
            }
            conn.Close();
            cmd = new SqlCommand("SELECT * FROM Yerler ORDER BY YerAdi ASC", conn);
            conn.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                YerSaklayici yerSakla = new YerSaklayici();
                yerSakla.YerID = sdr["YerID"].ToString();
                yerSakla.YerAdi = sdr["YerAdi"].ToString();
                comboYer.Items.Add(yerSakla);
            }
            conn.Close();
            cmd = new SqlCommand("SELECT * FROM Kutular ORDER BY KutuAdi ASC", conn);
            conn.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                KutuSaklayici kutuSakla = new KutuSaklayici();
                kutuSakla.KutuID = sdr["KutuID"].ToString();
                kutuSakla.KutuAdi = sdr["KutuAdi"].ToString();
                comboKutu.Items.Add(kutuSakla);
            }
            conn.Close();
            Yardimci.DosyalariDiz(lisDosyalar, grpDosyalar, veriID);
            comboYer.Enabled = false;
            ilkAcilis = true;
        }

        private void altFrmCdDuzenle_FormClosed(object sender, FormClosedEventArgs e)
        {
            (this.ParentForm as frmCdStok).listView1.Show();
        }

        private void btnDosyaEkle_Click(object sender, EventArgs e)
        {
            Yardimci.DosyaEkle(lisDosyalar, grpDosyalar, txtDosyaAdi, veriID);
        }

        private void comboKutu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ilkAcilis)
                kutuComboDegisim();
        }

        private void comboKutu_TextChanged(object sender, EventArgs e)
        {
            if (ilkAcilis)
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
