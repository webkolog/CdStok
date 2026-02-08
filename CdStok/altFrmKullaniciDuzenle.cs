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
    public partial class altFrmKullaniciDuzenle : Form
    {
        SqlConnection conn = dbIslem.baglantiOlustur();

        public altFrmKullaniciDuzenle()
        {
            InitializeComponent();
        }

        private void altFrmKullaniciDuzenle_Load(object sender, EventArgs e)
        {
            KullanicilariDiz();
        }

        private void altFrmKullaniciDuzenle_FormClosed(object sender, FormClosedEventArgs e)
        {
            (this.ParentForm as frmCdStok).listView1.Show();
            (this.ParentForm as frmCdStok).cdleriListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bool hata = false;
            string hatalar = null;
            if (txtKullaniciAdi.Text.Trim().Length == 0)
            {
                hata = true;
                hatalar += "Kullanıcı adı yazmadınız!\r\n";
            }
            if (listView1.SelectedItems.Count < 1)
            {
                hata = true;
                hatalar += "Hiç kullanıcı seçmediniz!\r\n";
            }
            else
            {
                if (dbIslem.aynisiVarmi("Kullanicilar", "KullaniciAdi", "!KullaniciID", txtKullaniciAdi.Text.Trim(), listView1.SelectedItems[0].Tag.ToString()))
                {
                    hata = true;
                    hatalar += txtKullaniciAdi.Text.Trim() + ", ismiyle zaten bir kullanıcı kayıtlı!\r\n";
                }
                if ((this.ParentForm as frmCdStok).kullaniciID.ToString() == listView1.SelectedItems[0].Tag.ToString() & cbYoneticiMi.Checked == false)
                {
                    hata = true;
                    hatalar += "Kendi kendinizi yöneticilikden çıkartamazsınız!\r\n";
                }
            }
            if (hata)
            {
                MessageBox.Show(hatalar);
            }
            else
            {
                dbIslem.dbHizliGuncelle("Kullanicilar", "KullaniciID", listView1.SelectedItems[0].Tag.ToString(), "KullaniciAdi", "Yonetici", txtKullaniciAdi.Text.Trim(), cbYoneticiMi.Checked.ToString());
                txtKullaniciAdi.Clear();
                cbYoneticiMi.Checked = false;
                KullanicilariDiz();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            bool hata = false;
            string hatalar = null;
            if (listView1.SelectedItems.Count < 1)
            {
                hata = true;
                hatalar += "Hiç kullanıcı seçmediniz!\r\n";
            }
            else
            {
                if ((this.ParentForm as frmCdStok).kullaniciID.ToString() == listView1.SelectedItems[0].Tag.ToString())
                {
                    hata = true;
                    hatalar += "Kendi kendinizi silemezsiniz!\r\n";
                }
            }
            if (hata)
            {
                MessageBox.Show(hatalar);
            }
            else
            {
                dbIslem.dbVeriSil("Kullanicilar", "KullaniciID", listView1.SelectedItems[0].Tag.ToString());
                KullanicilariDiz();
            }
        }

        void KullanicilariDiz()
        {
            listView1.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Kullanicilar ORDER BY KullaniciAdi ASC", conn);
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                ListViewItem li = new ListViewItem();
                if (sdr["Yonetici"].ToString() == "True")
                    li.BackColor = Color.AliceBlue;
                if (sdr["KullaniciID"].ToString() == (this.ParentForm as frmCdStok).kullaniciID.ToString())
                    li.BackColor = Color.Salmon;
                li.Text = sdr["KullaniciAdi"].ToString();
                li.SubItems.Add(sdr["Yonetici"].ToString() == "True" ? "Evet" : "Hayır");
                li.Tag = sdr["KullaniciID"];
                listView1.Items.Add(li);
            }
            conn.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                txtKullaniciAdi.Text = listView1.SelectedItems[0].Text;
                cbYoneticiMi.Checked = listView1.SelectedItems[0].SubItems[1].Text == "Evet" ? true : false;
            }
        }
    }
}
