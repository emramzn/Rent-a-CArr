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
    public partial class araba_sec : Form
    {
        public static SqlConnection baglanti = database.baglan();
        public BorderStyle BorderStyle { get; set; }
        public araba_sec()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void sec_btn_Click(object sender, EventArgs e)
        {
            Araçlarım.kirayaver.marka_txt.Text = araclar_datagrid.CurrentRow.Cells[1].Value.ToString();
            Araçlarım.kirayaver.model_txt.Text = araclar_datagrid.CurrentRow.Cells[2].Value.ToString();
            Araçlarım.kirayaver.plaka_txt.Text = araclar_datagrid.CurrentRow.Cells[4].Value.ToString();
            Hide();
        }
        int SimdikiWidth = 1366;
        int SimdikiHeight = 768;
        private void araba_sec_Load(object sender, EventArgs e)
        {

            try
            {
                string sorguAracGoster = "select * from tabloAraclar where durum='ELİMİZDE'";
                SqlCommand araclarGoster = new SqlCommand(sorguAracGoster, baglanti);
                SqlDataAdapter adaptor = new SqlDataAdapter(araclarGoster);
                DataSet setdata1 = new DataSet();
                adaptor.Fill(setdata1, "tabloAraclar");
                araclar_datagrid.DataSource = setdata1.Tables["tabloAraclar"];
            }
            catch (Exception ERR)
            {

                Bildiri.Uyari("BİLİNMEYEN BİR HATA!", Bildiri.AlertType.hata);
                
            }

            //Form1.goster("tabloAraclar", araclar_datagrid);
            Rectangle ClientCozunurluk = new Rectangle();

            ClientCozunurluk = Screen.GetBounds(ClientCozunurluk);

            float OranWidth = ((float)ClientCozunurluk.Width / (float)SimdikiWidth);

            float OranHeight = ((float)ClientCozunurluk.Height / (float)SimdikiHeight);


            this.Scale(OranWidth, OranHeight);
        }

        private void araclar_datagrid_DoubleClick(object sender, EventArgs e)
        {
            Araçlarım.kirayaver.marka_txt.Text = araclar_datagrid.CurrentRow.Cells[1].Value.ToString() ;
            Araçlarım.kirayaver.model_txt.Text = araclar_datagrid.CurrentRow.Cells[2].Value.ToString();
            Araçlarım.kirayaver.plaka_txt.Text = araclar_datagrid.CurrentRow.Cells[4].Value.ToString();
            Araçlarım.kirayaver.ucret_txt.Text = araclar_datagrid.CurrentRow.Cells[10].Value.ToString();
            Hide();
        }

        private void bul_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string gosterilecek = "select * from tabloAraclar where marka like'" + bul_txt.Text + "%' or model like'" + bul_txt.Text + "%' or renk like'" + bul_txt.Text + "%' or yakit like'" + bul_txt.Text + "%'";
                SqlCommand cmd = new SqlCommand(gosterilecek, baglanti);
                SqlDataAdapter adptr = new SqlDataAdapter(cmd);
                DataSet dst = new DataSet();
                adptr.Fill(dst, "tabloAraclar");
                araclar_datagrid.DataSource = dst.Tables["tabloAraclar"];
            }
            catch(Exception exx)
            {

                Bildiri.Uyari("BİLİNMEYEN BİR HATA OLUŞTU", Bildiri.AlertType.dikkat);
            }
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

        private void sec_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                Araçlarım.kirayaver.marka_txt.Text = araclar_datagrid.CurrentRow.Cells[1].Value.ToString();
                Araçlarım.kirayaver.model_txt.Text = araclar_datagrid.CurrentRow.Cells[2].Value.ToString();
                Araçlarım.kirayaver.plaka_txt.Text = araclar_datagrid.CurrentRow.Cells[4].Value.ToString();
                Araçlarım.kirayaver.ucret_txt.Text = araclar_datagrid.CurrentRow.Cells[10].Value.ToString();

            }
            catch
            {

            }
            Close();
        }

        private void bul_txt_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                string gosterilecek = "select * from tabloAraclar where durum='ELİMİZDE' and (marka like'" + bul_txt.Text + "%' or model like'" + bul_txt.Text + "%' or renk like'" + bul_txt.Text + "%' or yakit like'" + bul_txt.Text + "%')";
                SqlCommand cmd = new SqlCommand(gosterilecek, baglanti);
                SqlDataAdapter adptr = new SqlDataAdapter(cmd);
                DataSet dst = new DataSet();
                adptr.Fill(dst, "tabloAraclar");
                araclar_datagrid.DataSource = dst.Tables["tabloAraclar"];
            }
            catch
            {
                Bildiri.Uyari("BİLİNMEYEN BİR HATA OLUŞTU", Bildiri.AlertType.dikkat);
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
