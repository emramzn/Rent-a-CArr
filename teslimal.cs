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
    public partial class teslimal : Form
    {
        SqlConnection baglanti = database.baglan();
        public BorderStyle BorderStyle { get; set; }
        public teslimal()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void iptal_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
        void aldiktansora()
        {
            string yasak_kaldir = "";
            try
            {
                yasak_kaldir = "update tabloAraclar set durum='ELİMİZDE'  where plaka='" + plaka_txt.Text + "'";
            }
            catch
            {

                Bildiri.Uyari("SEÇİM YAPMADINIZ!!", Bildiri.AlertType.dikkat);
            }
            SqlCommand cmd = new SqlCommand(yasak_kaldir, baglanti);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {

                Bildiri.Uyari("BAKIMDAN ALINAMADI!!", Bildiri.AlertType.dikkat);
            }
        }
        private void teslimal_btn_Click(object sender, EventArgs e)
        {
            string teslimal= "";
            try
            {
                teslimal = "update aracGecmisKiralama set teslimatTarih='"+tarih_time.Text+"',teslimatSaat='"+saat_time.Text+ "',km='" + km_txt.Text + "',durum='alındı' where aracPlaka='" + plaka_txt.Text+"' and durum='alınmadı'";

                Close();

            }
            catch
            {

                Bildiri.Uyari("SEÇİM YAPMADINIZ!!", Bildiri.AlertType.dikkat);
            }
            SqlCommand cmd = new SqlCommand(teslimal, baglanti);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {

                Bildiri.Uyari("BAKIMDAN ALINAMADI!!", Bildiri.AlertType.dikkat);
            }
            aldiktansora();
        }
        int SimdikiWidth = 1366;
        int SimdikiHeight = 768;
        private void teslimal_Load(object sender, EventArgs e)
        {
            Rectangle ClientCozunurluk = new Rectangle();

            ClientCozunurluk = Screen.GetBounds(ClientCozunurluk);

            float OranWidth = ((float)ClientCozunurluk.Width / (float)SimdikiWidth);

            float OranHeight = ((float)ClientCozunurluk.Height / (float)SimdikiHeight);


            this.Scale(OranWidth, OranHeight);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

       
       
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
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
