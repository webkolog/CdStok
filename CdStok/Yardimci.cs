using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CdStok
{
    class Yardimci
    {
        public static void DosyalariDiz(ListBox lstBox, GroupBox grpDosya, string veriID)
        {
            SqlConnection conn = dbIslem.baglantiOlustur();
            lstBox.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Dosyalar WHERE CdID = @CdID ORDER BY DosyaAdi ASC", conn);
            cmd.Parameters.AddWithValue("@CdID", veriID);
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            int i = 0;
            while (sdr.Read())
            {
                DosyaSaklayici ds = new DosyaSaklayici();
                ds.dosyaAdi = sdr["DosyaAdi"].ToString();
                ds.dosyaID = sdr["DosyaID"].ToString();
                lstBox.Items.Add(ds);
                i++;
            }
            grpDosya.Text = "İçindeki Dosyalar (" + i + ")";
            conn.Close();
        }

        public static void DosyaSil(ListBox lstBox, GroupBox grpDosya, string veriID)
        {
            if (lstBox.SelectedIndex == -1)
            {
                MessageBox.Show("Listeden hiç dosya seçmediniz!");
                return;
            }
            if (lstBox.Items.Count < 2)
            {
                MessageBox.Show("daha fazla dosya silemezsiniz!");
                return;
            }
            DosyaSaklayici ds = (DosyaSaklayici)lstBox.SelectedItem;
            dbIslem.dbVeriSil("Dosyalar", "DosyaID", ds.dosyaID);
            DosyalariDiz(lstBox, grpDosya, veriID);
        }

        public static void DosyaEkle(ListBox lstBox, GroupBox grpDosya, TextBox txtDosya, string veriID)
        {
            if (txtDosya.Text.Trim().Length == 0)
            {
                MessageBox.Show("Dosya adı girmediniz!");
                return;
            }
            dbIslem.dbEkleVeriIslem("Dosyalar", "CdID", veriID, "DosyaAdi", txtDosya.Text.Trim());
            txtDosya.Clear();
            DosyalariDiz(lstBox, grpDosya, veriID);
        }

        public static void DosyaDuzenle(ListBox lstBox, GroupBox grpDosya, TextBox txtDosya, string veriID)
        {
            bool hata = false;
            string hatalar = null;
            DosyaSaklayici ds = (DosyaSaklayici)lstBox.SelectedItem;
            if (lstBox.SelectedIndex == -1)
            {
                hata = true;
                hatalar += "Listeden hiç dosya seçmediniz!\r\n";
            }
            else
            {
                if (dbIslem.aynisiVarmi("Dosyalar", "DosyaAdi", "DosyaID", txtDosya.Text.Trim(), ds.dosyaID))
                {
                    hata = true;
                    hatalar += txtDosya.Text.Trim() + " isimli dosya zaten bu CD içerisinde mevcut!\r\n";
                }
            }
            if (txtDosya.Text.Trim().Length == 0)
            {
                hata = true;
                hatalar += "Yeni dosya adı girmediniz!\r\n";
            }
            if (hata)
            {
                MessageBox.Show(hatalar, "Hata Oluştu!");
            }
            else
            {
                dbIslem.dbHizliGuncelle("Dosyalar", "DosyaID", ds.dosyaID, "DosyaAdi", txtDosya.Text.Trim());
                txtDosya.Clear();
                DosyalariDiz(lstBox, grpDosya, veriID);
            }
        }
    }

    class KutuSaklayici
    {
        public string KutuID = null, KutuAdi = null;
        public override string ToString()
        {
            return KutuAdi;
        }
    }

    class YerSaklayici
    {
        public string YerID = null, YerAdi = null;
        public override string ToString()
        {
            return YerAdi;
        }
    }

    class DosyaSaklayici
    {
        public string dosyaID = null, dosyaAdi = null;
        public override string ToString()
        {
            return dosyaAdi;
        }
    }



}
