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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        int kullaniciID;
        SqlConnection conn = dbIslem.baglantiOlustur();

        public static void YeniKayit()
        {
            frmKullaniciKayit frm = new frmKullaniciKayit();
            Application.Run(frm);
        }

        public void programiAc()
        {
            frmCdStok frm = new frmCdStok();
            frm.kullaniciID = kullaniciID;
            Application.Run(frm);
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            //frmGiris form'unu kapatınca program kapanmaması için eklediğim kod
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(YeniKayit));
            t.Start();
            this.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand cmdKullanici = new SqlCommand("SELECT * FROM Kullanicilar WHERE KullaniciAdi = @Kadi AND Sifre = @Sifre", conn);
            cmdKullanici.Parameters.AddWithValue("@Kadi", txtKadi.Text);
            cmdKullanici.Parameters.AddWithValue("@Sifre", txtSifre.Text);
            conn.Open();
            kullaniciID = Convert.ToInt32(cmdKullanici.ExecuteScalar());
            if (kullaniciID > 0)
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(programiAc));
                t.Start();
                conn.Close();
                this.Close();
            }
            else
            {
                conn.Close();
                MessageBox.Show("Kullanıcı adın veya şifren yanlış!");
            }
        }

        private void frmGiris_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
