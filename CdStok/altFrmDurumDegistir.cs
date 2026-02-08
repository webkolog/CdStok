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
    public partial class altFrmDurumDegistir : Form
    {
        string veriID, yeniDurum, eskiDurum, DurumID;
        SqlConnection conn = dbIslem.baglantiOlustur();

        public altFrmDurumDegistir(string gelenID, string gelenDurum)
        {
            InitializeComponent();
            veriID = gelenID;
            yeniDurum = gelenDurum;
        }

        private void altFrmDurumDegistir_Load(object sender, EventArgs e)
        {
            comboDurumTuru.Items.Add("Yerinde");
            comboDurumTuru.Items.Add("Arkadaşda");
            comboDurumTuru.Items.Add("Kayboldu");
            comboDurumTuru.Items.Add("Çalındı");
            comboDurumTuru.Items.Add("Bozuldu");
            SqlCommand cmd = new SqlCommand("SELECT c.CdAdi, c.DurumID, d.DurumTuru, CASE d.DurumTuru WHEN 1 THEN 'Arkadaşda' WHEN 2 THEN 'Kayboldu' WHEN 3 THEN 'Çalındı' WHEN 4 THEN 'Bozuldu' ELSE 'Yerinde' END AS Durum, d.DurumTarih, d.DurumNot  FROM Cdler c LEFT JOIN Durumlar d ON c.DurumID=d.DurumID WHERE c.CdId=@CdID", conn);
            cmd.Parameters.AddWithValue("@CdId", veriID);
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                sdr.Read();
                DurumID = sdr["DurumID"].ToString();
                eskiDurum = sdr["DurumTuru"].ToString() != "" ? sdr["DurumTuru"].ToString() : "0";
                this.Text = sdr["CdAdi"].ToString() + " isimli CD'nin durumu";
                comboDurumTuru.SelectedIndex = Convert.ToInt32(yeniDurum);
                txtNot.Text = sdr["DurumNot"].ToString();
                if (sdr["DurumTarih"].ToString() != "")
                    dtpDurumTarih.Value = Convert.ToDateTime(sdr["DurumTarih"]);
            }
            conn.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            yeniDurum = comboDurumTuru.SelectedIndex.ToString();
            if (yeniDurum == "0" & eskiDurum != "0")
            {
                //eski durum silinecek
                dbIslem.dbVeriSil("Durumlar", "DurumID", DurumID);
                dbIslem.dbHizliGuncelle("Cdler", "CdID", veriID, "DurumID", "0");
            }
            else if (yeniDurum != "0" & eskiDurum == "0")
            {
                //yeni durum eklenecek
                string eklenenDurumID = dbIslem.dbEkleVeriIslem("Durumlar", null, null, "DurumTuru", "DurumNot", "DurumTarih", yeniDurum, txtNot.Text.Trim(), dtpDurumTarih.Value.ToString("yyyy-MM-dd"));
                dbIslem.dbHizliGuncelle("Cdler", "CdID", veriID, "DurumID", eklenenDurumID);
            }
            else
            {
                //mevcut durum güncellenecek
                dbIslem.dbHizliGuncelle("Durumlar", "DurumID", DurumID, "DurumTuru", "DurumNot", "DurumTarih", yeniDurum, txtNot.Text.Trim(), dtpDurumTarih.Value.ToString("yyyy-MM-dd"));
                dbIslem.dbHizliGuncelle("Cdler", "CdID", veriID, "DurumID", DurumID);
            }
            (this.ParentForm as frmCdStok).cdleriListele();
            this.Close();
        }

        private void altFrmDurumDegistir_FormClosed(object sender, FormClosedEventArgs e)
        {
            (this.ParentForm as frmCdStok).listView1.Show();
        }

        private void dtpDurumTarih_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboDurumTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboDurumTuru.SelectedItem.ToString() == "Yerinde")
            {
                txtNot.Clear();
                txtNot.Enabled = false;
            }
            else
            {
                if (txtNot.Enabled == false)
                {
                    txtNot.Enabled = true;
                }
            }
        }
    }
}
