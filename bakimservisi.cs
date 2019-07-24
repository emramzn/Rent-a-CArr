using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Rent_A_Car
{
    public partial class bakimservisi : UserControl
    {
        SqlConnection baglanti = database.baglan();
        public bakimservisi()
        {
            InitializeComponent();
        }

        private void yenibakim_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (araclar_datagrid.CurrentRow.Cells[11].Value.ToString() == "BAKIMDA")
                {

                    Bildiri.Uyari("ARAÇ ZATEN BAKIMDA!", Bildiri.AlertType.dikkat);
                }
                else
                {
                    var sonuc = MessageBox.Show(araclar_datagrid.CurrentRow.Cells[4].Value.ToString() + " plakalı arac bakıma Alınsın Mı ?", " ARAÇ BAKIM ", MessageBoxButtons.OKCancel);
                    if (sonuc == DialogResult.OK)
                    {
                        bakima_al bakimal = new bakima_al();
                        bakimal.plaka.Text = araclar_datagrid.CurrentRow.Cells[4].Value.ToString();
                        bakimal.ShowDialog();
                        if (bakimal.durum == "")
                        {
                            string bakima_al = "insert into tabloAracBakim(aracPlaka,girisKm,girisTarih,irtibatKisi,yapiciYer,bakimIcerik,bakimTutari) values('" + araclar_datagrid.CurrentRow.Cells[4].Value.ToString() + "','" + bakimal.giris_km_txt.Text + "','" + bakimal.giris_tarih_time.Text + "','" + bakimal.irtibat_kisi_txt.Text + "','" + bakimal.yapilan_yer_txt.Text + "','" + bakimal.bakim_icerik_txt.Text + "','" + bakimal.bakim_tutar_txt.Text + "')";

                            // string bakima_al = "insert into tabloAracBakim(aracPlaka,girisKm,girisTarih,irtibatKisi,yapiciYer,bakimIcerik,bakimTutari) values('1','girisKm','girisTarih','irtibatKisi','yapiciYer','bakimIcerik','bakimTutari')";
                            SqlCommand cmd = new SqlCommand(bakima_al, baglanti);
                            try
                            {
                                cmd.ExecuteNonQuery();
                            }
                            catch
                            {

                                Bildiri.Uyari("EKLEME GERÇEKLEŞTİRİLEMEDİ!!", Bildiri.AlertType.hata);
                            }
                            gosteraraba("tabloAraclar", araclar_datagrid);
                        }
                        else
                        {

                            Bildiri.Uyari(araclar_datagrid.CurrentRow.Cells[4].Value.ToString() + " Plakalı araç bakıma alınmadı.", Bildiri.AlertType.bilgi);
                        }

                    }

                }
            }
            catch
            {

            }

        }

        private void araclar_datagrid_Click(object sender, EventArgs e)
        {
            gosterbakim("tabloAracBakim", bakimlar_datagrid);
            try
            {
                string gosterilecek = "select count(*)from tabloAracBakim where aracPlaka='" + araclar_datagrid.CurrentRow.Cells[4].Value.ToString() + "'";
                SqlCommand KOMUT = new SqlCommand(gosterilecek, baglanti);
                int donusBakim = Convert.ToInt16(KOMUT.ExecuteScalar());
                bakim_lbl.Text = araclar_datagrid.CurrentRow.Cells[4].Value.ToString() + " Plakalı aracınızın toplam " + donusBakim.ToString() + " işlem kaydı ve " + hesapla().ToString() + " TL bakım masrafı kayda geçmiş.";
            }
            catch
            {

            }
        }
        public float hesapla()
        {
            try
            {
                string gosterilecek = "select bakimTutari from tabloAracBakim where aracPlaka='" + araclar_datagrid.CurrentRow.Cells[4].Value.ToString() + "'";
                SqlCommand cm = new SqlCommand(gosterilecek, baglanti);
                float toplam = 0f;
                SqlDataAdapter veriall = new SqlDataAdapter(cm);
                DataSet dst = new DataSet();
                dst.Clear();
                veriall.Fill(dst, "bakimTutari");
                foreach (DataRow dr in dst.Tables[0].Rows)
                {
                    string deger = dr[0].ToString();
                    try
                    {
                        toplam += float.Parse(deger);
                    }
                    catch
                    {
                        toplam += 0;
                    }

                }
                return toplam;
            }
            catch 
            {
                Bildiri.Uyari(" BİLİNMEYEN HATA!!", Bildiri.AlertType.hata);
                
                return 0;
            }
        }
        void gosterbakim(string a, DataGridView dtgrt)
        {
            try
            {
                string gosterilecek = "select*from " + a + " where aracPlaka='" + araclar_datagrid.CurrentRow.Cells[4].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(gosterilecek, baglanti);
                SqlDataAdapter adptr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adptr.Fill(ds, a);
                dtgrt.DataSource = ds.Tables[a];
                //dtgrt.Columns["ID"].Visible = false;
            }
            catch
            {

            }



        }
        void gosteraraba(string a, DataGridView dtgrt)
        {

            string gosterilecek = "";

            gosterilecek = "select * from " + a;
            ////}


            SqlCommand cmd = new SqlCommand(gosterilecek, baglanti);
            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adptr.Fill(ds, a);
            dtgrt.DataSource = ds.Tables[a];
            dtgrt.Columns["arac_ID"].Visible = false;
            dtgrt.Columns["silindir"].Visible = false;
            dtgrt.Columns["sigortaTarihi"].Visible = false;
            dtgrt.Columns["kaskoTarihi"].Visible = false;
            dtgrt.Columns["muayeneTarihi"].Visible = false;
            dtgrt.Columns["emisyonTarihi"].Visible = false;
            dtgrt.Columns["izinBitis"].Visible = false;
            dtgrt.Columns["bakimPeriyodu"].Visible = false;
            dtgrt.Columns["yasakDurumu"].Visible = false;
            dtgrt.Columns["renk"].Visible = false;
            dtgrt.Columns["kasa"].Visible = false;
            dtgrt.Columns["motor"].Visible = false;
            dtgrt.Columns["ucret"].Visible = false;

        }

        private void bakimservisi_Load(object sender, EventArgs e)
        {
            gosteraraba("tabloAraclar", araclar_datagrid);
            araclar_datagrid.Select();
            gosterbakim("tabloAracBakim", bakimlar_datagrid);

            string cumle = "select count(*)from tabloAracBakim";
            SqlCommand cmd = new SqlCommand(cumle, baglanti);
            int donus = Convert.ToInt16(cmd.ExecuteScalar());
            arac_lbl.Text = donus.ToString() + " Aracınız bakımda görünüyor.";



            try
            {
                string gosterilecek = "select count(*)from tabloAracBakim where aracPlaka='" + araclar_datagrid.CurrentRow.Cells[4].Value.ToString() + "'";
                SqlCommand KOMUT = new SqlCommand(gosterilecek, baglanti);
                int donusBakim = Convert.ToInt16(KOMUT.ExecuteScalar());
                bakim_lbl.Text = araclar_datagrid.CurrentRow.Cells[4].Value.ToString() + " Plakalı aracınızın toplam " + donusBakim.ToString() + " işlem kaydı ve " + hesapla().ToString() + " TL bakım masrafı kayda geçmiş.";
            }
            catch
            {

            }

        }
    }
}
