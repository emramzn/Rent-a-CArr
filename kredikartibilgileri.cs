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
    public partial class kredikartibilgileri : Form
    {
        public BorderStyle BorderStyle { get; set; }
        public kredikartibilgileri()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        SqlConnection sqlBaglan = database.baglan();

        public static string tcKimlikNo { get; set; }
        private void kaydet_btn_Click(object sender, EventArgs e)
        {
            try
            {

                string musteri_ekleme = "INSERT INTO tabloKrediKarti(tcKimlikNo,kartNo,sonKulTarihi,guvenlikNo,aciklama)values('" + tcKimlikNo + "','" + yeniKrediKartNo_txt.Text + "','" + yeniKrediSKT_dateTime.Text + "','" + yeniKrediGuvenlik_txt.Text + "','" + yeniKrediAciklama_txt.Text + "')";
                SqlCommand komutMusteriEkle = new SqlCommand(musteri_ekleme, sqlBaglan);
                int durum = komutMusteriEkle.ExecuteNonQuery();
               
                if (durum == 1)
                {

                    Bildiri.Uyari("YENİ KREDİ KARTI EKLENDİ.", Bildiri.AlertType.bilgi);
                    Close();
                }
                else
                {

                    Bildiri.Uyari("KART EKLEME BAŞARISIZ!!", Bildiri.AlertType.dikkat);
                }

            }
            catch 
            {

                Bildiri.Uyari("BİLİNMEYEN HATA!!", Bildiri.AlertType.dikkat);

            }


        }
        int SimdikiWidth = 1366;
        int SimdikiHeight = 768;
        private void kredikartibilgileri_Load(object sender, EventArgs e)
        {
            try
            {

                string verigetir = "select ad from musteriler where tcKimlikNo='" + tcKimlikNo + "'";
                SqlCommand bilgiGetir = new SqlCommand(verigetir, sqlBaglan);
                SqlDataReader verioku = bilgiGetir.ExecuteReader();
                if (verioku.Read())
                {
                    label6.Text = verioku["ad"].ToString();
                }
                label6.Text = label6.Text + " " + " isimli Müşteri İçin Yeni Kredi Kartı Ekleniyor.";
                verioku.Close();

            }

            catch 
            {

                Bildiri.Uyari("BİLİNMEYEN HATA!!", Bildiri.AlertType.dikkat);
            }

            Rectangle ClientCozunurluk = new Rectangle();

            ClientCozunurluk = Screen.GetBounds(ClientCozunurluk);

            float OranWidth = ((float)ClientCozunurluk.Width / (float)SimdikiWidth);

            float OranHeight = ((float)ClientCozunurluk.Height / (float)SimdikiHeight);


            this.Scale(OranWidth, OranHeight);
        }

        private void iptal_btn_Click(object sender, EventArgs e)
        {
            Close();
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
