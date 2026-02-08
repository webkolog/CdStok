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
    public partial class altFrmKutuDuzenle : Form
    {
        SqlConnection conn = dbIslem.baglantiOlustur();

        public altFrmKutuDuzenle()
        {
            InitializeComponent();
        }

        private void altFrmKutuDuzenle_FormClosed(object sender, FormClosedEventArgs e)
        {
            (this.ParentForm as frmCdStok).listView1.Show();
            (this.ParentForm as frmCdStok).cdleriListele();
        }

        private void altFrmKutuDuzenle_Load(object sender, EventArgs e)
        {
            KutulariListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bool hata = false;
            string hatalar = null;
            if (listView1.SelectedItems.Count == 0)
            {
                hata = true;
                hatalar += "Hiç kutu seçmediniz!\n";
            }
            else if (listView1.SelectedItems.Count > 1)
            {
                hata = true;
                hatalar += "Güncelleme yapabilmek için sadece 1 kutu seçmelisiniz!\n";
            }
            else
            {
                if (dbIslem.aynisiVarmi("Kutular", "KutuAdi", "!KutuID", txtKutuAdi.Text.Trim(), listView1.SelectedItems[0].Tag.ToString()))
                {
                    hata = true;
                    hatalar += txtKutuAdi.Text + " isimli bir kutu zaten eklenmiş!\n";
                }
            }
            if (txtKutuAdi.Text.Trim().Length == 0)
            {
                hata = true;
                hatalar += "Kutu adı girmediniz!\r\n";
            }
            if (comboYer.Text.Trim().Length == 0)
            {
                hata = true;
                hatalar += "Hiç yer eklemediniz veya seçmediniz!!\r\n";
            }
            if (hata)
            {
                MessageBox.Show(hatalar);
            }
            else
            {
                //bu işlem zaten yer ekliyse sadece id'sini verecek, ekli değilse ekleyim id'sini verecek
                string YerID = dbIslem.dbEkleVeriIslem("Yerler", "YerAdi", comboYer.Text.Trim());

                dbIslem.dbHizliGuncelle("Kutular", "KutuID", listView1.SelectedItems[0].Tag.ToString(), "KutuAdi", "YerID", txtKutuAdi.Text.Trim(), YerID);
                txtKutuAdi.Clear();
                comboYer.Text = "";
                KutulariListele();
            }
        }

        void KutulariListele()
        {
            listView1.Items.Clear();
            comboYer.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT k.KutuID, k.KutuAdi, y.YerAdi FROM Kutular k JOIN Yerler y ON k.YerID=y.YerID ORDER BY k.KutuAdi ASC", conn);
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                ListViewItem li = new ListViewItem();
                li.Text = sdr["KutuAdi"].ToString();
                li.SubItems.Add(sdr["YerAdi"].ToString());
                li.Tag = sdr["KutuID"];
                listView1.Items.Add(li);
            }
            conn.Close();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM Yerler ORDER BY YerAdi ASC", conn);
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
                comboYer.Items.Add(sdr["YerAdi"]);
            conn.Close();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                txtKutuAdi.Text = listView1.SelectedItems[0].Text;
                comboYer.Text = listView1.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hiç kutu seçmediniz!");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Cdler c JOIN Kutular k ON c.KutuID = k.KutuID WHERE c.KullaniciID != @KullaniciID AND k.KutuID = @KutuID", conn);
                cmd.Parameters.AddWithValue("@KullaniciID", (this.ParentForm as frmCdStok).kullaniciID);
                cmd.Parameters.AddWithValue("@KutuID", listView1.SelectedItems[0].Tag.ToString());
                conn.Open();
                if (cmd.ExecuteReader().HasRows == true & (this.ParentForm as frmCdStok).yoneticiMi == false)
                {
                    //silmeye çalışan aktif kullanıcı yönetici değilse ve bu kutuda başkasınında cd'si kayıtlıysa silemez
                    conn.Close();
                    MessageBox.Show("Bu kutuda başkalarınında cdleri kayıtlı olduğu için silemezsiniz!\nSadece yöneticiler silebilir!");
                }
                else
                {
                    conn.Close();
                    for (int i = 0; i < listView1.SelectedItems.Count; i++)
                        dbIslem.dbVeriSil("Kutular", "KutuID", listView1.SelectedItems[0].Tag.ToString());
                    KutulariListele();
                }
            }
        }
    }
}
