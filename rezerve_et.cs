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
    public partial class rezerve_et : Form
    {
        public static SqlConnection baglanti = database.baglan();
        public static string belirle = "";
        public BorderStyle BorderStyle { get; set; }
        public rezerve_et()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void kisiler_btn_Click(object sender, EventArgs e)
        {
            belirle = "rezerve tıklandı";
            musteri_sec musterisec = new musteri_sec();
            musterisec.ShowDialog();
            belirle = "";
        }

        private void tamam_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string eklenecek = "insert into aracRezerve(baslama,bitis,ad,soyad,plaka,marka) values('"+tarih_bas_time.Text+"','"+tarih_son_time.Text+"','"+musteri_adi_txt.Text+"','"+soyad_txt.Text+"','"+plaka_txt.Text+"','"+marka.Text+"')";
                SqlCommand cmd = new SqlCommand(eklenecek, baglanti);
                cmd.ExecuteNonQuery();
            }
            catch
            {

                Bildiri.Uyari("BİLİNMEYEN HATA!!", Bildiri.AlertType.hata);
            }
            string rezervle = "";
            try
            {
                rezervle = "update tabloAraclar set durum='REZERVE'  where plaka='" + plaka_txt.Text + "'";
            }
            catch
            {
                Bildiri.Uyari("SEÇİM YAPMADINIZ!", Bildiri.AlertType.dikkat);
            }
            SqlCommand komut = new SqlCommand(rezervle, baglanti);
            try
            {
                komut.ExecuteNonQuery();
            }
            catch
            {

                Bildiri.Uyari("DURUM DEĞİŞTİRLEMEDİ!!", Bildiri.AlertType.hata);
            }
            Hide();
        }

        private void mevcut_rezervasyon_btn_Click(object sender, EventArgs e)
        {
            mevcut_rezervler mevcutrezervler = new mevcut_rezervler();
            mevcutrezervler.label3.Text = plaka_txt.Text;
            mevcutrezervler.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
        int SimdikiWidth = 1366;
        int SimdikiHeight = 768;
        private void rezerve_et_Load(object sender, EventArgs e)
        {
            Rectangle ClientCozunurluk = new Rectangle();

            ClientCozunurluk = Screen.GetBounds(ClientCozunurluk);

            float OranWidth = ((float)ClientCozunurluk.Width / (float)SimdikiWidth);

            float OranHeight = ((float)ClientCozunurluk.Height / (float)SimdikiHeight);


            this.Scale(OranWidth, OranHeight);
        }

      
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
