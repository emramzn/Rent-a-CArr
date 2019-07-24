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
    public partial class carikartislemleri : Form
    {
        public BorderStyle BorderStyle { get; set; }
        public carikartislemleri()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        public static string odemeToplam { get; set; }
        public static string tcKimlikNo { get; set; }
        SqlConnection veri = database.baglan();
        void dataListele() // MÜŞTERİ BİLG,İLERİ DATAGRİDVİEV'İ DOLDURUR  
        {

            string listele = "select tarih,tutar,odemeTuru,aciklama from tabloCariHesap where tcKimlikNo='" + tcKimlikNo + "'";
            SqlCommand komutBilgiGetir = new SqlCommand(listele, veri);
            SqlDataAdapter adapter1 = new SqlDataAdapter(komutBilgiGetir);
            DataSet dataSetBilgiler = new DataSet();
            adapter1.Fill(dataSetBilgiler, "tabloCariHesap");
            CariHesapBilgisi_dataGrid.DataSource = dataSetBilgiler.Tables["tabloCariHesap"];


        }
        private void kartBilgileri_btn_Click(object sender, EventArgs e)
        {
            musterikredikartibilgileri musterikartbilgi = new musterikredikartibilgileri();

            musterikredikartibilgileri.tcKimlikNo = tcKimlikNo;
            string verigetir = "select ad,soyad,telefon,adres from musteriler where tcKimlikNo='" + tcKimlikNo + "'";
            SqlCommand bilgiGetir = new SqlCommand(verigetir, veri);
            SqlDataReader verioku = bilgiGetir.ExecuteReader();
            if (verioku.Read())
            {
                musterikartbilgi.musteriAdi_lbl.Text = verioku["ad"].ToString();
                musterikartbilgi.musteriSoyadi_lbl.Text = verioku["soyad"].ToString();
                musterikartbilgi.musteriCepTel_lbl.Text = verioku["telefon"].ToString();
                musterikartbilgi.musteriAdres_lbl.Text = verioku["adres"].ToString();


            }

            verioku.Close();
            
            musterikartbilgi.ShowDialog();


        }

        private void cariHareketEkle_btn_Click(object sender, EventArgs e)
        {
            carihareketekle carihareket = new carihareketekle();
            carihareket.ShowDialog();
        }

        private void duzenle_btn_Click(object sender, EventArgs e)
        {

        }
        int SimdikiWidth = 1366;
        int SimdikiHeight = 768;
        private void carikartislemleri_Load(object sender, EventArgs e)
        {
            Rectangle ClientCozunurluk = new Rectangle();

            ClientCozunurluk = Screen.GetBounds(ClientCozunurluk);

            float OranWidth = ((float)ClientCozunurluk.Width / (float)SimdikiWidth);

            float OranHeight = ((float)ClientCozunurluk.Height / (float)SimdikiHeight);


            this.Scale(OranWidth, OranHeight);
        }

        private void carikartislemleri_Activated(object sender, EventArgs e)
        {
            dataListele();
        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CariHesapBilgisi_dataGrid_DoubleClick(object sender, EventArgs e)
        {

        }

        private void yazdir_btn_Click(object sender, EventArgs e)
        {
            yazdir yazilamiyor = new yazdir();
            yazilamiyor.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            

        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
       

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void panel5_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
          
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
