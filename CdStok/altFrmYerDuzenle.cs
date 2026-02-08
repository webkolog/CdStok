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
    public partial class altFrmYerDuzenle : Form
    {
        SqlConnection conn = dbIslem.baglantiOlustur();

        public altFrmYerDuzenle()
        {
            InitializeComponent();
        }

        private void altFrmYerDuzenle_FormClosed(object sender, FormClosedEventArgs e)
        {
            (this.ParentForm as frmCdStok).listView1.Show();
            (this.ParentForm as frmCdStok).cdleriListele();
        }

        private void altFrmYerDuzenle_Load(object sender, EventArgs e)
        {
            YerleriListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bool hata = false;
            string hatalar = null;
            if (listBox1.SelectedIndex == -1)
            {
                hata = true;
                hatalar += "Hiç yer seçmediniz!\n";
            }
            else
            {
                if (dbIslem.aynisiVarmi("Yerler", "YerAdi", "!YerID", txtYerAdi.Text.Trim(), (listBox1.SelectedItem as YerSaklayici).YerID))
                {
                    hata = true;
                    hatalar += txtYerAdi.Text.Trim() + " isimli bir yer zaten eklenmiş!\n";
                }
            }
            if (txtYerAdi.Text.Trim().Length == 0)
            {
                hata = true;
                hatalar += "Yer adı girmediniz!\r\n";
            }
            if (hata)
            {
                MessageBox.Show(hatalar);
            }
            else
            {
                dbIslem.dbHizliGuncelle("Yerler", "YerID", (listBox1.SelectedItem as YerSaklayici).YerID, "YerAdi", txtYerAdi.Text.Trim());
                txtYerAdi.Clear();
                YerleriListele();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                txtYerAdi.Text = (listBox1.SelectedItem as YerSaklayici).YerAdi;
        }

        void YerleriListele()
        {
            listBox1.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Yerler ORDER BY YerAdi ASC", conn);
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                YerSaklayici yerSakla = new YerSaklayici();
                yerSakla.YerID = sdr["YerID"].ToString();
                yerSakla.YerAdi = sdr["YerAdi"].ToString();
                listBox1.Items.Add(yerSakla);
            }
            conn.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            /*
* Silme işlemleri için Trigger yapmışdım:

Yer silinirse
Kutu silinsin

Kutu silinirse
Cd silinsin

Cd silinirse
dosyalar silinsin
durumlar silinsin

Kullanıcı silinirse
Cd silinsin
*/
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Hiç yer seçmediniz!");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Cdler c JOIN Kutular k ON c.KutuID = k.KutuID JOIN Yerler y ON k.YerID = y.YerID WHERE c.KullaniciID != @kid AND y.YerID = @yid", conn);
                cmd.Parameters.AddWithValue("@kid", (this.ParentForm as frmCdStok).kullaniciID);
                cmd.Parameters.AddWithValue("@yid", (listBox1.SelectedItem as YerSaklayici).YerID);
                conn.Open();
                if (cmd.ExecuteReader().HasRows == true & (this.ParentForm as frmCdStok).yoneticiMi == false)
                {
                    //silmeye çalışan aktif kullanıcı yönetici değilse ve bu yerde başkasınında cd'si kayıtlıysa silemez
                    conn.Close();
                    MessageBox.Show("Bu yerde başkalarınında cdleri kayıtlı olduğu için silemezsiniz!\nSadece yöneticiler silebilir!");
                }
                else
                {
                    conn.Close();
                    //nested trigger söz konusu, bu sayade bağlantılı kutular, cdler, dosyalar ve durumlar silinecek
                    dbIslem.dbVeriSil("Yerler", "YerID", (listBox1.SelectedItem as YerSaklayici).YerID);
                    YerleriListele();
                }
            }
        }
    }
}
