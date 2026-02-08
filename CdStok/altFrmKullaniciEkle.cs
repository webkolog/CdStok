using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CdStok
{
    public partial class altFrmKullaniciEkle : Form
    {
        public altFrmKullaniciEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool hata = false;
            string hatalar = null;
            if (txtKadi.Text.Trim().Length < 3)
            {
                hata = true;
                hatalar += "Kullanıcı adı 3 karakterden kısa olamaz!\r\n";
            }
            else
            {
                if (dbIslem.aynisiVarmi("Kullanicilar", "KullaniciAdi", txtKadi.Text.Trim()))
                {
                    hata = true;
                    hatalar += txtKadi.Text.Trim() + " isminde kullanıcı zaten kayıtlı!\r\n";
                }
            }
            if (txtSifre.Text.Trim().Length < 6)
            {
                hata = true;
                hatalar += "Şifre 6 karakterden kısa olamaz!\r\n";
            }
            if (txtSifre.Text.Trim() != txtReSifre.Text.Trim())
            {
                hata = true;
                hatalar += "Şifreler birbirlerini tutmuyor!\r\n";
            }
            if (hata) //hata varsa
            {
                MessageBox.Show(hatalar, "Hata Oluştu!");
            }
            else
            {
                string sonID = dbIslem.dbEkleVeriIslem("Kullanicilar", null, null, "KullaniciAdi", "Sifre", "Yonetici", txtKadi.Text.Trim(), txtSifre.Text.Trim(), cbYoneticiMi.Checked.ToString());
                if (sonID != "0")
                        this.Close();
                else
                    MessageBox.Show("Bilinmeyen bir hata oluştu!");
            }
        }

        private void altFrmKullaniciEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            (this.ParentForm as frmCdStok).listView1.Show();
        }
    }
}
