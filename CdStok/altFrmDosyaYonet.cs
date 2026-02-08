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
    public partial class altFrmDosyaYonet : Form
    {
        string veriID;
        SqlConnection conn = dbIslem.baglantiOlustur();

        public altFrmDosyaYonet(string gelenID)
        {
            InitializeComponent();
            veriID = gelenID;
        }

        private void altFrmDosyaYonet_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Cdler WHERE CdID = @CdID", conn);
            cmd.Parameters.AddWithValue("@CdID", veriID);
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                sdr.Read();
                this.Text = sdr["CdAdi"].ToString() + " CD'sinin Dosyaları";
            }
            conn.Close();
            Yardimci.DosyalariDiz(lisDosyalar, grpDosyalar, veriID);
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

        private void altFrmDosyaYonet_FormClosed(object sender, FormClosedEventArgs e)
        {
            (this.ParentForm as frmCdStok).listView1.Show();
        }
    }
}
