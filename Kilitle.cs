using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Data.SqlClient;

namespace Rent_A_Car
{
    public partial class Kilitle : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Server=DESKTOP-KP1PN0G\BASE_SQL;Database=RentACar;");
        SqlConnection baglanti2 = database.baglan();
        public BorderStyle BorderStyle { get; set; }
        public Kilitle()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
       
        int SimdikiWidth = 1366;
        int SimdikiHeight = 768;

        private void Kilitle_Load(object sender, EventArgs e)
        {
            
            Rectangle ClientCozunurluk = new Rectangle();

            ClientCozunurluk = Screen.GetBounds(ClientCozunurluk);

            float OranWidth = ((float)ClientCozunurluk.Width / (float)SimdikiWidth);

            float OranHeight = ((float)ClientCozunurluk.Height / (float)SimdikiHeight);
            

            this.Scale(OranWidth, OranHeight);

            kulAdi.Text = "Kullanıcı Adı";
            kulAdi.ForeColor = Color.Gray;
            sifre.Text = "Şifre";
            sifre.ForeColor = Color.Gray;
        }
     

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_MouseMove_1(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            
        }

       

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {

            
        }
      
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
           
        }

       

      

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

     

        private void label1_MouseLeave(object sender, EventArgs e)
        {

        }
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public string kul;
        public string sif;
        public string admin;
        public string pass;
        private void giris_btn_Click(object sender, EventArgs e)
        {
            
            
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void girisbtn_Click(object sender, EventArgs e)
        {
            

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
           
        }
        
        private void sif_textbox_OnTextChange(object sender, EventArgs e)
        {
            
        }

        private void sif_textbox_Enter(object sender, EventArgs e)
        {
           
        }

        private void sif_textbox_Leave(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public int i = 0;
        private void girisbtn_Click_1(object sender, EventArgs e)
        {
            
           
            
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }
       

        private void sif_textbox_KeyPress(object sender, EventArgs e)
        {
            

        }

        private void kul_textbox_OnTextChange(object sender, EventArgs e)
        {
           

        }

        private void kul_textbox_Enter(object sender, EventArgs e)
        {
           
        }

        private void kul_textbox_Click(object sender, EventArgs e)
        {
           
        }

        private void sif_textbox_Enter_1(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void girisbtn_Click_2(object sender, EventArgs e)
        {
           
        }

        private void kul_textbox_OnTextChange_1(object sender, EventArgs e)
        {
            //kulAdi.ForeColor = Color.White;
            //kul_textbox.text = "";
        }

        private void sif_textbox_OnTextChange_1(object sender, EventArgs e)
        {
              
        }

        private void sif_textbox_KeyPress_1(object sender, EventArgs e)
        {

        }

        private void kulAdi_Enter(object sender, EventArgs e)
        {

            if (kulAdi.Text=="Kullanıcı Adı")
            {

                kulAdi.Text = "";
                kulAdi.ForeColor = Color.Black;
            }
        }

        private void kulAdi_Leave(object sender, EventArgs e)
        {
            if (kulAdi.Text == "")
            {
                kulAdi.Text = "Kullanıcı Adı";
                kulAdi.ForeColor = Color.Gray;
            }
        }

        private void sifre_Leave(object sender, EventArgs e)
        {
            if (sifre.Text == "")
            {
                sifre.Text = "Şifre";
                sifre.ForeColor = Color.Gray;
            }
        }

        private void sifre_Enter(object sender, EventArgs e)
        {
            if (sifre.Text == "Şifre")
            {
                sifre.Text = "";
                sifre.ForeColor = Color.Black;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void girisbtn_Enter(object sender, EventArgs e)
        {

        }

        private void sifre_TextChanged(object sender, EventArgs e)
        {
            sifre.ForeColor = Color.Black;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ad_cumle = "select ad from sifre_tablo where kulad='" + kulAdi.Text + "' and sifre='" + sifre.Text + "'";
                SqlCommand cmd_ad = new SqlCommand(ad_cumle, baglanti2);
                SqlDataAdapter adptr_ad = new SqlDataAdapter(cmd_ad);
                DataSet dst = new DataSet();
                string ad_soyad = "";
                dst.Clear();
                adptr_ad.Fill(dst);
                foreach(DataRow oku in dst.Tables[0].Rows)
                {
                    ad_soyad = oku[0].ToString();
                }

                string soyad_cumle = "select soyad from sifre_tablo where kulad='" + kulAdi.Text + "' and sifre='" + sifre.Text + "'";
                SqlCommand cmd_soyad = new SqlCommand(soyad_cumle, baglanti2);
                SqlDataAdapter adptr_soyad = new SqlDataAdapter(cmd_soyad);
                DataSet dst_soyad = new DataSet();
                ad_soyad += " ";
                dst_soyad.Clear();
                adptr_soyad.Fill(dst_soyad);
                foreach (DataRow oku in dst_soyad.Tables[0].Rows)
                {
                    ad_soyad += oku[0].ToString();
                }

                baglanti.Open();
                 string cumle = "select*from sifre_tablo where kulad='"+kulAdi.Text+"' and sifre='"+sifre.Text+"'";
                SqlCommand cmd = new SqlCommand(cumle,baglanti);
                
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.Hide();
                    Form1 fr = new Form1();
                    fr.ad_soyad_lbl.Text = ad_soyad;
                    fr.Show();
                   // Bildiri.Uyari("Sayın "+ad_soyad+" sisteme hoşgeldiniz.", Bildiri.AlertType.basarili);
                }
                else
                {
                    kulAdi.Text = "";
                    sifre.Text = "";
                    label2.Visible = true;
                }
            }
            catch
            {
                Bildiri.Uyari("BİLİNMEYEN HATA'DAN DOLAYI GİRİŞ YAPAMIYORSUNUZ!!", Bildiri.AlertType.hata);
            }

            baglanti.Close();





        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
