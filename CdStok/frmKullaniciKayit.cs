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
    public partial class frmKullaniciKayit : Form
    {
        public frmKullaniciKayit()
        {
            InitializeComponent();
        }

        int kullaniciID = 0;
        SqlConnection conn = dbIslem.baglantiOlustur();

        public void programiAc()
        {
            frmCdStok frm = new frmCdStok();
            frm.kullaniciID = kullaniciID;
            Application.Run(frm);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool hata = false;
            string hatalar = null; //bu değişkenlerle oluşan tüm hataları toplayıp tek bir messagebox ile gösterdim
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
                    hatalar += txtKadi.Text + " isminde kullanıcı zaten kayıtlı!\r\n";
                }
            }
            if (txtSifre.Text.Length < 6)
            {
                hata = true;
                hatalar += "Şifre 6 karakterden kısa olamaz!\r\n";
            }
            if (txtSifre.Text != txtReSifre.Text)
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
                bool Yonetici = false;
                //daha önce hiç kullanıcı kayıt olmadıysa, ilk kayıt olan kullanıcı yönetici olsun
                if (!dbIslem.aynisiVarmi("Kullanicilar"))
                    Yonetici = true;
                string sonID = dbIslem.dbEkleVeriIslem("Kullanicilar", null, null, "KullaniciAdi", "Sifre", "Yonetici", txtKadi.Text.Trim(), txtSifre.Text, Yonetici.ToString());
                if (sonID != "0")
                {
                    DialogResult cevap = MessageBox.Show("Şimdi otomatik giriş yapmak ister misin?", "Hesabın başarıyla oluşturuldu!", MessageBoxButtons.YesNo);
                    if (cevap == DialogResult.Yes)
                    {
                        kullaniciID = Convert.ToInt32(sonID); //enson üye olan kullanicinin id nosunu aldım ve kullaniciID'ye atayarak frmCdStok formuna gönderdim
                        System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(programiAc));
                        t.Start();
                        this.Close();
                    }
                    else
                    {
                        txtKadi.Clear();
                        txtSifre.Clear();
                        txtReSifre.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Bilinmeyen bir hata oluştu!");
                }
            }
        }
    }
}
