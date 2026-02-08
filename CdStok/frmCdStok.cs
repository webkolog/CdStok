using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace CdStok
{
    public partial class frmCdStok : Form
    {
        public int kullaniciID;
        private string KullaniciAdi;
        public bool yoneticiMi;
        string siraDizme = "ASC", siralama = "c.CdAdi";
        bool arama = false;
        SqlConnection conn = dbIslem.baglantiOlustur();

        public frmCdStok()
        {
            InitializeComponent();
        }

        private void frmCdStok_Load(object sender, EventArgs e)
        {
            //SQL injection riski yok çünkü KullaniciID değişkenine veri veri tabanından geliyor
            SqlCommand cmdKul = new SqlCommand("SELECT * FROM Kullanicilar WHERE KullaniciID = '" + kullaniciID + "'", conn);
            conn.Open();
            SqlDataReader sdr = cmdKul.ExecuteReader();
            if (sdr.HasRows)
            {
                sdr.Read();
                this.Text = "CD Stok Programı (Aktif Kullanıcı: " + sdr["KullaniciAdi"] + ")";
                KullaniciAdi = sdr["KullaniciAdi"].ToString();
                yoneticiMi = Convert.ToBoolean(sdr["Yonetici"]);
                if (Convert.ToBoolean(sdr["Yonetici"]))
                    tsBtnKullanici.Enabled = true;
                else
                    tsBtnKullanici.Enabled = false;
            }
            conn.Close();
            cdleriListele();
        }

        private void altFormAc(Form gelenFrm)
        {
            bool Izin = false;
            if (this.MdiChildren.Count() > 0)
            {
                if (this.MdiChildren[0].Name != gelenFrm.Name)
                {
                    this.MdiChildren[0].Close();
                    Izin = true;
                }
            }
            else
            {
                Izin = true;
            }
            if (Izin)
            {
                listView1.Hide();
                gelenFrm.StartPosition = FormStartPosition.CenterScreen;
                gelenFrm.MdiParent = this;
                gelenFrm.MaximizeBox = false;
                gelenFrm.MinimizeBox = false;
                gelenFrm.FormBorderStyle = FormBorderStyle.FixedSingle;
                gelenFrm.Show();
            }
        }

        private void cDEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            altFrmCdEkle frm = new altFrmCdEkle();
            altFormAc(frm);
        }

        private void seciliCDyiDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sagMenuCdyiDuzenle_Click(sender, e);
        }

        public void cdleriListele()
        {
            /*
             * 1) arkadaşda
             * 2) kayboldu
             * 3) çalındı
             * 4) bozuldu
             * 0) yerinde
             */
            if (tdMiDizmeAZ.Checked)
                siraDizme = tdMiDizmeAZ.Tag.ToString();
            else
                siraDizme = tdMiDizmeZA.Tag.ToString();
            listView1.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT dsy.CdID, c.DurumID, c.CdID, c.KisiselMi, c.CdAdi, c.BarkodNo, c.KullaniciID, k.KutuAdi, y.YerAdi, CASE d.DurumTuru WHEN 1 THEN 'Arkadaşda' WHEN 2 THEN 'Kayboldu' WHEN 3 THEN 'Çalındı' WHEN 4 THEN 'Bozuldu' ELSE 'Yerinde' END AS Durum, kul.KullaniciAdi FROM Cdler c JOIN Kutular k ON c.KutuID=k.KutuID JOIN Yerler y ON k.YerID=y.YerID JOIN Kullanicilar kul ON kul.KullaniciID=c.KullaniciID LEFT JOIN Durumlar d ON d.DurumID=c.DurumID JOIN Dosyalar dsy ON dsy.CdID=c.CdID WHERE c.CdAdi LIKE '%'+@kelime+'%' AND c.KisiselMi=0 AND c.KullaniciID <> @kullaniciID OR c.CdAdi LIKE '%'+@kelime+'%' AND c.KullaniciID = @kullaniciID OR c.BarkodNo LIKE '%'+@kelime+'%' AND c.KisiselMi=0 AND c.KullaniciID <> @kullaniciID OR c.BarkodNo LIKE '%'+@kelime+'%' AND c.KullaniciID = @kullaniciID OR dsy.DosyaAdi LIKE '%'+@kelime+'%' AND c.KisiselMi=0 AND c.KullaniciID <> @kullaniciID OR dsy.DosyaAdi LIKE '%'+@kelime+'%' AND c.KullaniciID = @kullaniciID ORDER BY " + siralama + " " + siraDizme, conn);
            cmd.Parameters.AddWithValue("@kullaniciID", kullaniciID);
            if (arama)
            {
                tsBtnAramaIptal.Enabled = true;
                cmd.Parameters.AddWithValue("@kelime", tsTxtArama.Text);
            }
            else
            {
                tsBtnAramaIptal.Enabled = false;
                cmd.Parameters.AddWithValue("@kelime", "");
            }
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    ListViewItem li = new ListViewItem();
                    li.Tag = sdr["CdID"].ToString();
                    li.Text = sdr["CdAdi"].ToString();
                    li.SubItems.Add(sdr["BarkodNo"].ToString());
                    li.SubItems.Add(sdr["KutuAdi"].ToString());
                    li.SubItems.Add(sdr["YerAdi"].ToString());
                    li.SubItems.Add(sdr["Durum"].ToString());
                    li.SubItems.Add(sdr["KullaniciAdi"].ToString());
                    if (Convert.ToBoolean(sdr["KisiselMi"]))
                        li.BackColor = Color.Salmon;
                    else if (Convert.ToInt32(sdr["KullaniciID"]) == kullaniciID)
                        li.BackColor = Color.AliceBlue;
                    listView1.Items.Add(li);
                }
            }
            else
            {
                MessageBox.Show("Kayıt bulunamadı!");
            }
            conn.Close();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView lv = sender as ListView;
            altFrmCdDetay frm = new altFrmCdDetay(lv.SelectedItems[0].Tag.ToString());
            altFormAc(frm);
        }

        private void tsBtnArama_Click(object sender, EventArgs e)
        {
            tsTxtArama.Text = tsTxtArama.Text.Trim();
            if (tsTxtArama.Text.Length != 0)
            {
                arama = true;
                cdleriListele();
            }
        }

        private void tsBtnAramaIptal_Click(object sender, EventArgs e)
        {
            tsTxtArama.Text = "";
            arama = false;
            cdleriListele();
        }

        private void tdMiDizmeAZ_Click(object sender, EventArgs e)
        {
            tdMiDizmeAZ.Checked = true;
            tdMiDizmeZA.Checked = false;
            cdleriListele();
        }

        private void tdMiDizmeZA_Click(object sender, EventArgs e)
        {
            tdMiDizmeAZ.Checked = false;
            tdMiDizmeZA.Checked = true;
            cdleriListele();
        }

        private void siralamaMenuDegisimi(object sender)
        {
            ToolStripMenuItem tsMI = (ToolStripMenuItem)sender;
            foreach (ToolStripItem tsDDI in tsDdBtnDizme.DropDownItems)
            {
                if (tsDDI is ToolStripMenuItem)
                {
                    ToolStripMenuItem tsMiSec = (ToolStripMenuItem)tsDDI;
                    if (tsMiSec.Name == tdMiDizmeAZ.Name | tsMiSec.Name == tdMiDizmeZA.Name)
                        continue;
                    tsMiSec.Checked = false;
                }
            }
            tsMI.Checked = true;
            siralama = tsMI.Tag.ToString();
            cdleriListele();
        }

        private void cDAdinaGoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            siralamaMenuDegisimi(sender);
        }

        private void barkodNumarasinaGoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            siralamaMenuDegisimi(sender);
        }

        private void kutuAdinaGoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            siralamaMenuDegisimi(sender);
        }

        private void yereGoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            siralamaMenuDegisimi(sender);
        }

        private void durumaGoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            siralamaMenuDegisimi(sender);
        }

        private void kullaniciAdinaGoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            siralamaMenuDegisimi(sender);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                contextMenuStrip1.Enabled = false;
            }
            else
            {
                if (KullaniciAdi == listView1.SelectedItems[0].SubItems[5].Text)
                {
                    foreach (ToolStripMenuItem tsmi in contextMenuStrip1.Items)
                        tsmi.Enabled = true;
                    durumSecimCheck();
                    erisimKisiselMiKontrol();
                    //erişimDurumuKontrol edilecek
                }
                else
                {
                    foreach (ToolStripMenuItem tsmi in contextMenuStrip1.Items)
                    {
                        if (tsmi.Name != sagMenuCdGoster.Name)
                            tsmi.Enabled = false; //bu Cd'yi sistemdeki kullanıcı eklemediyse CD düzenleme gibi menüler görünmesin
                    }
                    if (yoneticiMi == true)
                        sagMenuCdyiSil.Enabled = true;
                }
                contextMenuStrip1.Enabled = true;
            }
        }

        private void sagMenuCdGoster_Click(object sender, EventArgs e)
        {
            altFrmCdDetay frm = new altFrmCdDetay(listView1.SelectedItems[0].Tag.ToString());
            altFormAc(frm);
        }

        private void sagMenuCdyiDuzenle_Click(object sender, EventArgs e)
        {
            altFrmCdDuzenle frm = new altFrmCdDuzenle(listView1.SelectedItems[0].Tag.ToString());
            altFormAc(frm);
        }

        private void tsBtnCD_DropDownOpening(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                foreach (ToolStripDropDownItem tsddi in tsBtnCD.DropDownItems)
                    if (tsddi.Name != "cDEkleToolStripMenuItem")
                        tsddi.Enabled = false;
            }
            else
            {
                if (KullaniciAdi == listView1.SelectedItems[0].SubItems[5].Text)
                    foreach (ToolStripDropDownItem tsddi in tsBtnCD.DropDownItems)
                        tsddi.Enabled = true;
                else
                    foreach (ToolStripDropDownItem tsddi in tsBtnCD.DropDownItems)
                        if (tsddi.Name != "cDEkleToolStripMenuItem")
                            tsddi.Enabled = false;
                if (yoneticiMi == true)
                    seciliCDyiSilToolStripMenuItem.Enabled = true;
            }
        }

        private void sagMenuCdyiSil_Click(object sender, EventArgs e)
        {
            string seciliCdID = listView1.SelectedItems[0].Tag.ToString();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Cdler WHERE CdID = @CdID", conn);
            cmd.Parameters.AddWithValue("@CdID", seciliCdID);
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                sdr.Read();
                if (sdr["DurumID"].ToString() != "0")
                    dbIslem.dbVeriSil("Durumlar", "DurumID", sdr["DurumID"].ToString());
            }
            conn.Close();
            dbIslem.dbVeriSil("Dosyalar", "CdID", seciliCdID);
            dbIslem.dbVeriSil("Cdler", "CdID", seciliCdID);
            cdleriListele();
        }

        private void seciliCDyiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sagMenuCdyiSil_Click(sender, e);
        }

        private void sagMenuCdyeDosyaEkle_Click(object sender, EventArgs e)
        {
            altFrmDosyaYonet frm = new altFrmDosyaYonet(listView1.SelectedItems[0].Tag.ToString());
            altFormAc(frm);
        }

        private void seciliCDyeDosyaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sagMenuCdyeDosyaEkle_Click(sender, e);
        }

        private void sagMenuYerinde_Click(object sender, EventArgs e)
        {
            //eski Durum Silinecek
            string veriID = listView1.SelectedItems[0].Tag.ToString(), DurumID = null;
            DurumID = dbIslem.tekVeriCek("Cdler", "CdID", veriID, "DurumID");
            dbIslem.dbVeriSil("Durumlar", "DurumID", DurumID);
            dbIslem.dbHizliGuncelle("Cdler", "CdID", veriID, "DurumID", "0");
            cdleriListele();
        }

        private void sagMenuArkadasda_Click(object sender, EventArgs e)
        {
            DurumDegistir((sender as ToolStripMenuItem).Tag.ToString());
        }

        private void sagMenuKayboldu_Click(object sender, EventArgs e)
        {
            DurumDegistir((sender as ToolStripMenuItem).Tag.ToString());
        }

        private void sagMenuBozuldu_Click(object sender, EventArgs e)
        {
            DurumDegistir((sender as ToolStripMenuItem).Tag.ToString());
        }

        private void sagMenuCalindi_Click(object sender, EventArgs e)
        {
            DurumDegistir((sender as ToolStripMenuItem).Tag.ToString());
        }

        private void DurumDegistir(string gelenDurum)
        {
            altFrmDurumDegistir frm = new altFrmDurumDegistir(listView1.SelectedItems[0].Tag.ToString(), gelenDurum);
            altFormAc(frm);
        }

        private void yerindeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sagMenuYerinde_Click(sender, e);
        }

        private void arkadasdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sagMenuArkadasda_Click(sender, e);
        }

        private void kaybolduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sagMenuKayboldu_Click(sender, e);
        }

        private void bozulduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sagMenuBozuldu_Click(sender, e);
        }

        private void calindiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sagMenuCalindi_Click(sender, e);
        }

        private void durumSecimCheck()
        {
            string veriID = listView1.SelectedItems[0].Tag.ToString(), DurumID = null, DurumTuru;
            DurumID = dbIslem.tekVeriCek("Cdler", "CdID", veriID, "DurumID");
            if (DurumID != "0")
                DurumTuru = dbIslem.tekVeriCek("Durumlar", "DurumID", DurumID, "DurumTuru");
            else
                DurumTuru = "0";
            foreach (ToolStripMenuItem tsmi in sagMenuCdninDurumunuDegistir.DropDownItems)
            {
                tsmi.Checked = false;
                if (tsmi.Tag.ToString() == DurumTuru)
                    tsmi.Checked = true;
            }
            foreach (ToolStripMenuItem tsmi in seciliCDDurumuToolStripMenuItem.DropDownItems)
            {
                tsmi.Checked = false;
                if (tsmi.Tag.ToString() == DurumTuru)
                    tsmi.Checked = true;
            }
        }

        private void seciliCDDurumuToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            durumSecimCheck();
        }

        private void sagMenuCdKisisel_Click(object sender, EventArgs e)
        {
            erisimKisiselMi(true);
        }

        private void sagMenuCdOrtak_Click(object sender, EventArgs e)
        {
            erisimKisiselMi(false);
        }

        private void KisiselToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sagMenuCdKisisel_Click(sender, e);
        }

        private void OrtakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sagMenuCdOrtak_Click(sender, e);
        }

        private void erisimKisiselMiKontrol()
        {
            string veriID = listView1.SelectedItems[0].Tag.ToString();
            bool kisiselMi = false;
            kisiselMi = Convert.ToBoolean(dbIslem.tekVeriCek("Cdler", "CdID", veriID, "KisiselMi"));
            if (kisiselMi)
            {
                sagMenuCdKisisel.Checked = true;
                sagMenuCdOrtak.Checked = false;
                KisiselToolStripMenuItem.Checked = true;
                OrtakToolStripMenuItem.Checked = false;
            }
            else
            {
                sagMenuCdKisisel.Checked = false;
                sagMenuCdOrtak.Checked = true;
                KisiselToolStripMenuItem.Checked = false;
                OrtakToolStripMenuItem.Checked = true;
            }
        }

        private void erisimKisiselMi(bool kisiselMi)
        {
            string veriID = listView1.SelectedItems[0].Tag.ToString();
            dbIslem.dbHizliGuncelle("Cdler", "CdID", veriID, "KisiselMi", kisiselMi.ToString());
            cdleriListele();
        }

        private void seciliCDErisimDurumuToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            erisimKisiselMiKontrol();
        }

        private void tsBtnKullaniciGiris_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(YeniGiris));
            t.Start();
            this.Close();
        }

        public static void YeniGiris()
        {
            frmGiris frm = new frmGiris();
            Application.Run(frm);
        }

        private void tsBtnHakkimizda_Click(object sender, EventArgs e)
        {
            Hakkinda hkm = new Hakkinda();
            hkm.Show();
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            altFrmKullaniciEkle frm = new altFrmKullaniciEkle();
            altFormAc(frm);
        }

        private void kullanıcılarıDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            altFrmKullaniciDuzenle frm = new altFrmKullaniciDuzenle();
            altFormAc(frm);
        }

        private void tsBtnKutular_Click(object sender, EventArgs e)
        {
            altFrmKutuDuzenle frm = new altFrmKutuDuzenle();
            altFormAc(frm);
        }

        private void tsBtnYerler_Click(object sender, EventArgs e)
        {
            altFrmYerDuzenle frm = new altFrmYerDuzenle();
            altFormAc(frm);
        }

        private void tsTxtArama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                arama = true;
                cdleriListele();
                tsTxtArama.Text = tsTxtArama.Text.Trim();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            altFrmSifreDegistir frm = new altFrmSifreDegistir();
            altFormAc(frm);
        }
    }
}
