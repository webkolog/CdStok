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
    public partial class altFrmSifreDegistir : Form
    {
        public altFrmSifreDegistir()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool hata = false;
            string hatalar = null;
            if (!dbIslem.aynisiVarmi("Kullanicilar", "KullaniciID", "Sifre", (this.ParentForm as frmCdStok).kullaniciID.ToString(), txtSifre.Text))
            {
                hata = true;
                hatalar += "Eski şifrenizi doğru yazmadnız!\r\n";
            }
            if (txtYeniSifre.Text.Length < 6)
            {
                hata = true;
                hatalar += "Yeni şifreniz 6 karakterden az olmamalı!\r\n";
            }
            if (txtYeniSifre.Text != txtReYeniSifre.Text)
            {
                hata = true;
                hatalar += "Yeni şifreleriniz birbirini tutmuyor!\r\n";
            }
            if (hata)
            {
                MessageBox.Show(hatalar);
            }
            else
            {
                dbIslem.dbHizliGuncelle("Kullanicilar", "KullaniciID", (this.ParentForm as frmCdStok).kullaniciID.ToString(), "Sifre", txtYeniSifre.Text);
                this.Close();
            }
        }

        private void altFrmSifreDegistir_FormClosed(object sender, FormClosedEventArgs e)
        {
            (this.ParentForm as frmCdStok).listView1.Show();
        }
    }
}
