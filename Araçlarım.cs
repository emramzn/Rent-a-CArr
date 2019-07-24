using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Rent_A_Car
{
    public partial class Araçlarım : Form
    {

        SqlConnection baglanti = database.baglan();
        public BorderStyle BorderStyle { get; set; }
        public Araçlarım()
        {
            InitializeComponent();
            
        }
        int SimdikiWidth = 1366;
        int SimdikiHeight = 768;
        public static string olustur { get; set; }
        void goster(string a, DataGridView dtgrt)
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
            dtgrt.Columns["motor"].Visible = false;
           dtgrt.Columns["plaka"].Visible = false;
            dtgrt.Columns["kasa"].Visible = false;
        }
        public static string aracSayisi { get; set; }
        private void Araçlarım_Load(object sender, EventArgs e)
        {
            aracAra_Txt.Text = "Marka,Model,Renk,Yakıt";
            aracAra_Txt.ForeColor = Color.Gray;

            Rectangle ClientCozunurluk = new Rectangle();

            ClientCozunurluk = Screen.GetBounds(ClientCozunurluk);

            float OranWidth = ((float)ClientCozunurluk.Width / (float)SimdikiWidth);

            float OranHeight = ((float)ClientCozunurluk.Height / (float)SimdikiHeight);

            this.Scale(OranWidth, OranHeight);

            label8.Text = "Sistemde "+aracSayisi+ " araç kayıtlı.";
            goster("tabloAraclar", araclarim_datagrid);              
        }

     
        public static kiraya_ver kirayaver = new kiraya_ver();
        
        public static rezerve_et rezerveet = new rezerve_et();
      


        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

        private void yeniaraceklebtn_Click(object sender, EventArgs e)
        {
            aracekle arac = new aracekle();
            arac.ShowDialog();
            goster("tabloAraclar", araclarim_datagrid);
        }

       

        private void kirayaverbtn_Click(object sender, EventArgs e)
        {
            if ("KIRADA" == araclarim_datagrid.CurrentRow.Cells[11].Value.ToString())
            {
                Bildiri.Uyari("araç zaten kirada", Bildiri.AlertType.bilgi);
            }
            else if ("BAKIMDA" == araclarim_datagrid.CurrentRow.Cells[11].Value.ToString())
            {
                Bildiri.Uyari("bakımda ki aracı kiraya veremezsiniz.", Bildiri.AlertType.bilgi);
            }
            else if ("yasaklı" == araclarim_datagrid.CurrentRow.Cells[18].Value.ToString())
            {
                Bildiri.Uyari("bu araç yasaklı, yasaklı araçları kiraya veremezsiniz.", Bildiri.AlertType.bilgi);
            }
            else if ("REZERVE" == araclarim_datagrid.CurrentRow.Cells[11].Value.ToString())
            {
                Bildiri.Uyari("bu araç rezervlidir, kiralayabilmek için rezervliler listesinden silmelisiniz.", Bildiri.AlertType.bilgi);
            }
            else
            {

                kirayaver.marka_txt.Text = araclarim_datagrid.CurrentRow.Cells[1].Value.ToString();
                kirayaver.model_txt.Text = araclarim_datagrid.CurrentRow.Cells[2].Value.ToString();
                kirayaver.plaka_txt.Text = araclarim_datagrid.CurrentRow.Cells[4].Value.ToString();
                kirayaver.ucret_txt.Text = araclarim_datagrid.CurrentRow.Cells[10].Value.ToString();


                kirayaver.ShowDialog();
                //string degistir = "";
                //try
                //{
                //    degistir = "update tabloAraclar set durum='kirada'  where plaka='" + araclarim_datagrid.CurrentRow.Cells[4].Value.ToString() + "'";


                //}
                //catch
                //{
                //    MessageBox.Show("seçim yapmadınız.");
                //}
                //SqlCommand cmd = new SqlCommand(degistir, baglanti);
                //try
                //{
                //    cmd.ExecuteNonQuery();
                //}
                //catch
                //{
                //    MessageBox.Show("durum değiştirilemedi");
                //}
                goster("tabloAraclar", araclarim_datagrid);
            }
        }

        private void teslimalbtn_Click(object sender, EventArgs e)
        {
            if ("KIRADA" == araclarim_datagrid.CurrentRow.Cells[11].Value.ToString())
            {
                teslimal teslim = new teslimal();
                teslim.plaka_txt.Text = araclarim_datagrid.CurrentRow.Cells[4].Value.ToString();
                teslim.ShowDialog();


                goster("tabloAraclar", araclarim_datagrid);
            }
            else
            {
                Bildiri.Uyari("araç kirada olmadığı için teslim alınamıyor", Bildiri.AlertType.bilgi);
            }

        }

        private void rezerveetbtn_Click(object sender, EventArgs e)
        {
            rezerveet.plaka_txt.Text = araclarim_datagrid.CurrentRow.Cells[4].Value.ToString();
            rezerveet.marka.Text = araclarim_datagrid.CurrentRow.Cells[1].Value.ToString();
            rezerveet.ShowDialog();

            goster("tabloAraclar", araclarim_datagrid);
        }

        private void silbtn_Click(object sender, EventArgs e)
        {

            if (araclarim_datagrid.CurrentRow.Cells[11].Value.ToString() == "KİRADA")
            {
                Bildiri.Uyari("SİLİNMEK İSTENEN ARAÇ KİRADA!!!", Bildiri.AlertType.dikkat);
            }
            else
            {

                var result = MessageBox.Show(araclarim_datagrid.CurrentRow.Cells[4].Value.ToString() + " PLAKALI ARACIN TÜM BİLGİLERİ SİLİNSİN Mİ ?", "ARAÇ SİLME İŞLEMİ", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        string arac_silme = "delete from tabloAraclar where plaka='" + araclarim_datagrid.CurrentRow.Cells[4].Value.ToString() + "'";
                        string arac_silmeBakim = "delete from tabloAracBakim where aracplaka='" + araclarim_datagrid.CurrentRow.Cells[4].Value.ToString() + "'";
                        string arac_silmeGecmis = "delete from aracGecmisKiralama where aracplaka='" + araclarim_datagrid.CurrentRow.Cells[4].Value.ToString() + "'";
                        SqlCommand cmd = new SqlCommand(arac_silme, baglanti);
                        SqlCommand cmdBakim = new SqlCommand(arac_silmeBakim, baglanti);
                        SqlCommand cmdGecmis = new SqlCommand(arac_silmeGecmis, baglanti);
                        cmdBakim.ExecuteNonQuery();
                        cmdGecmis.ExecuteNonQuery();
                        cmd.ExecuteNonQuery();
                        // MessageBox.Show(araclarim_datagrid.CurrentRow.Cells[4].Value.ToString());
                    }
                    catch
                    {
                        Bildiri.Uyari("silme gerçekleştirilemedi", Bildiri.AlertType.bilgi);
                       // MessageBox.Show("Hata: " + err.Message);
                    }

                    goster("tabloAraclar", araclarim_datagrid);
                    araclarim_datagrid.Columns[0].HeaderText = "SIRA NO";
                }
            }

        }

        private void bakimaal_Click(object sender, EventArgs e)
        {
            if (araclarim_datagrid.CurrentRow.Cells[11].Value.ToString() == "BAKIMDA")
            {
                Bildiri.Uyari("araç zaten bakımda", Bildiri.AlertType.bilgi);
            }
            else
            {
                var sonuc = MessageBox.Show(araclarim_datagrid.CurrentRow.Cells[4].Value.ToString() + " plakalı arac bakıma Alınsın Mı ?", " ARAÇ BAKIM ", MessageBoxButtons.OKCancel);
                if (sonuc == DialogResult.OK)
                {
                    bakima_al bakimal = new bakima_al();
                    bakimal.plaka.Text = araclarim_datagrid.CurrentRow.Cells[4].Value.ToString();
                    bakimal.ShowDialog();
                    string bakima_al = "insert into tabloAracBakim(aracPlaka,girisKm,girisTarih,irtibatKisi,yapiciYer,bakimIcerik,bakimTutari) values('" + araclarim_datagrid.CurrentRow.Cells[4].Value.ToString() + "','" + bakimal.giris_km_txt.Text + "','" + bakimal.giris_tarih_time.Text + "','" + bakimal.irtibat_kisi_txt.Text + "','" + bakimal.yapilan_yer_txt.Text + "','" + bakimal.bakim_icerik_txt.Text + "','" + bakimal.bakim_tutar_txt.Text + "')";

                    // string bakima_al = "insert into tabloAracBakim(aracPlaka,girisKm,girisTarih,irtibatKisi,yapiciYer,bakimIcerik,bakimTutari) values('1','girisKm','girisTarih','irtibatKisi','yapiciYer','bakimIcerik','bakimTutari')";
                    SqlCommand cmd = new SqlCommand(bakima_al, baglanti);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        Bildiri.Uyari("ekleme gerçekleştirilemedi", Bildiri.AlertType.bilgi);
                    }
                    goster("tabloAraclar", araclarim_datagrid);
                }

            }
        }

        private void bakimbitisi_Click(object sender, EventArgs e)
        {
            string yasak_kaldir = "";
            try
            {
                yasak_kaldir = "update tabloAraclar set durum='ELİMİZDE'  where plaka='" + araclarim_datagrid.CurrentRow.Cells[4].Value.ToString() + "'";
            }
            catch
            {
                Bildiri.Uyari("seçim yapmadınız.", Bildiri.AlertType.bilgi);
            }
            SqlCommand cmd = new SqlCommand(yasak_kaldir, baglanti);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Bildiri.Uyari("bakımdan alınamadı.", Bildiri.AlertType.dikkat);
            }
            goster("tabloAraclar", araclarim_datagrid);
        }

        private void gecmisbakımlarbtn_Click(object sender, EventArgs e)
        {

            gecmisbakimlar gecmisbakim = new gecmisbakimlar();
            gecmisbakim.label3.Text = araclarim_datagrid.CurrentRow.Cells[4].Value.ToString();
            gecmisbakim.ShowDialog();
        }

        private void gecmiskiralamalar_Click(object sender, EventArgs e)
        {
            gecmis_kiralar gecmiskiralar = new gecmis_kiralar();
            gecmiskiralar.label3.Text = araclarim_datagrid.CurrentRow.Cells[4].Value.ToString();
            gecmiskiralar.ShowDialog();
        }

        private void yasaklabtn_Click(object sender, EventArgs e)
        {
            string yasakla = "";
            try
            {
                yasakla = "update tabloAraclar set yasakDurumu='yasaklı'  where plaka='" + araclarim_datagrid.CurrentRow.Cells[4].Value.ToString() + "'";
            }
            catch
            {
                Bildiri.Uyari("seçim yapmadınız.", Bildiri.AlertType.bilgi);
            }
            SqlCommand cmd = new SqlCommand(yasakla, baglanti);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Bildiri.Uyari("durum değiştirilemedi.", Bildiri.AlertType.dikkat);
            }
            goster("tabloAraclar", araclarim_datagrid);
        }

        private void yasagikaldir_Click(object sender, EventArgs e)
        {

            string yasak_kaldir = "";
            try
            {
                yasak_kaldir = "update tabloAraclar set yasakDurumu='izinli'  where plaka='" + araclarim_datagrid.CurrentRow.Cells[4].Value.ToString() + "'";
            }
            catch
            {
                Bildiri.Uyari("seçim yapmadınız..", Bildiri.AlertType.bilgi);
            }
            SqlCommand cmd = new SqlCommand(yasak_kaldir, baglanti);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Bildiri.Uyari("durum değiştirilemedi.", Bildiri.AlertType.dikkat);
            }
            goster("tabloAraclar", araclarim_datagrid);
        }

    

        private void yazdirbtn_Click(object sender, EventArgs e)
        {
            yazdir yazilamiyor = new yazdir();
            yazilamiyor.Show();
        }

        private void aracAra_Txt_Click(object sender, EventArgs e)
        {
            aracAra_Txt.Text = "";
        }

        private void aracAra_Txt_TextChanged(object sender, EventArgs e)
        {
            aracAra_Txt.ForeColor = Color.Black;
            try
            {
                string gosterilecek = "select * from tabloAraclar where marka like'" + aracAra_Txt.Text + "%' or model like'" + aracAra_Txt.Text + "%' or renk like'" + aracAra_Txt.Text + "%' or yakit like'" + aracAra_Txt.Text + "%'";
                SqlCommand cmd = new SqlCommand(gosterilecek, baglanti);
                SqlDataAdapter adptr = new SqlDataAdapter(cmd);
                DataSet dst = new DataSet();
                adptr.Fill(dst, "tabloAraclar");
                araclarim_datagrid.DataSource = dst.Tables["tabloAraclar"];
            }
            catch (Exception exx)
            {
                Bildiri.Uyari("BİLİNMEYEN BİR HATAOLUŞTU!!", Bildiri.AlertType.dikkat);
            }
        }

        private void baslıkpnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
