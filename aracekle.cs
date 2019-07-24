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
    public partial class aracekle : Form
    {
        SqlConnection baglanti = database.baglan();
        public BorderStyle BorderStyle { get; set; }
        public aracekle()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void aracekle_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void kayit_btn_Click(object sender, EventArgs e)
        {
            
            
            string arac_ekleme="";
            try
            {
                arac_ekleme = "insert into tabloAraclar(marka,model,yil,plaka,kasa,renk,silindir,motor,yakit,ucret,durum,sigortaTarihi,kaskoTarihi,muayeneTarihi,emisyonTarihi,izinBitis,bakimPeriyodu,yasakDurumu) values('" + marka_txt.Text + "','" + model_txt.Text + "','" + yil_txt.Text + "','" + plaka_txt.Text + "','" + kasa_txt.Text + "','" + renk_txt.Text + "','" + hacim_txt.Text + "','" + motor_txt.Text + "','" + yakit_cmb.Text + "','" + float.Parse(ucret_txt.Text).ToString() + "','ELİMİZDE','" + sigorta_time.Text + "','" + kasko_time.Text + "','" + muayene_time.Text + "','" + emisyon_time.Text + "','" + izin_time.Text + "','" + float.Parse(bakim_txt.Text).ToString() + "','izinli')";

            }
            catch
            {

                Bildiri.Uyari("boş değerleri kaydedemezsiniz", Bildiri.AlertType.dikkat);
            }
           SqlCommand cmd = new SqlCommand(arac_ekleme, baglanti);
            try
            {
                cmd.ExecuteNonQuery();
                Hide();
            }
            catch
            {

                Bildiri.Uyari("ekleme gerçekleştirilemedi", Bildiri.AlertType.hata);
            }
     
        }

        private void iptal_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void panel3_Paint(object sender, PaintEventArgs e)
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

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
