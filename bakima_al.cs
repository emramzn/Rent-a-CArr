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
    public partial class bakima_al : Form
    {
        public string durum = "";
        SqlConnection baglanti = database.baglan();
        public BorderStyle BorderStyle { get; set; }
        public bakima_al()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void iptal_btn_Click(object sender, EventArgs e)
        {
            durum = "kapatıldı";
            Hide();
        }

        private void kaydet_btn_Click(object sender, EventArgs e)
        {
            if (bakim_tutar_txt.Text=="")
            {

                Bildiri.Uyari("Bakım Tutarını Giriniz.", Bildiri.AlertType.hata);
            }

            else
            {
                ////aracın durumunu değiştirme bakımda yapma
                string yasakla = "";
                try
                {
                    yasakla = "update tabloAraclar set durum='BAKIMDA'  where plaka='" + plaka.Text + "'";
                }
                catch
                {
                    Bildiri.Uyari("seçim yapmadınız.", Bildiri.AlertType.hata);
                }
                SqlCommand komut = new SqlCommand(yasakla, baglanti);
                try
                {
                    komut.ExecuteNonQuery();
                }
                catch
                {

                    Bildiri.Uyari("durum değiştirilemedi", Bildiri.AlertType.dikkat);
                }
                Close();
            }
        }

        private void bakima_al_Load(object sender, EventArgs e)
        {

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
