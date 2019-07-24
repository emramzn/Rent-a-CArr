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
    public partial class musteri_sec : Form
    {
        public static SqlConnection baglanti = database.baglan();
        public BorderStyle BorderStyle { get; set; }
        public musteri_sec()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void iptal_btn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void sec_btn_Click(object sender, EventArgs e)
        {
           
            if (kiraya_ver.belirle == "kirala tiklandi")
            {
                Araçlarım.kirayaver.ad.Text = musteriler_datagrid.CurrentRow.Cells[1].Value.ToString();
                Araçlarım.kirayaver.tc.Text = musteriler_datagrid.CurrentRow.Cells[0].Value.ToString();
                Araçlarım.kirayaver.soyad.Text = musteriler_datagrid.CurrentRow.Cells[2].Value.ToString();
                Araçlarım.kirayaver.ad_soyad_txt.Text = musteriler_datagrid.CurrentRow.Cells[1].Value.ToString() + " " + musteriler_datagrid.CurrentRow.Cells[2].Value.ToString();
                Araçlarım.kirayaver.cep_tel_txt.Text = musteriler_datagrid.CurrentRow.Cells[5].Value.ToString();

                Araçlarım.kirayaver.butnExtra.Visible = true;  //kiraya ver formundaki ekstra butonunu aktif eder.

                kiraya_ver.belirle = "";
            }
            if(rezerve_et.belirle== "rezerve tıklandı")
            {
                Araçlarım.rezerveet.musteri_adi_txt.Text = musteriler_datagrid.CurrentRow.Cells[1].Value.ToString();
                Araçlarım.rezerveet.soyad_txt.Text = musteriler_datagrid.CurrentRow.Cells[2].Value.ToString();
                rezerve_et.belirle = "";
            }
          
            Hide();
        }
        int SimdikiWidth = 1366;
        int SimdikiHeight = 768;
        private void musteri_sec_Load(object sender, EventArgs e)
        {
            Form1.goster("musteriler", musteriler_datagrid);

            Rectangle ClientCozunurluk = new Rectangle();

            ClientCozunurluk = Screen.GetBounds(ClientCozunurluk);

            float OranWidth = ((float)ClientCozunurluk.Width / (float)SimdikiWidth);

            float OranHeight = ((float)ClientCozunurluk.Height / (float)SimdikiHeight);


            this.Scale(OranWidth, OranHeight);
        }

        private void musteriler_datagrid_DoubleClick(object sender, EventArgs e)
        {
            if (kiraya_ver.belirle == "kirala tiklandi")
            {
                Araçlarım.kirayaver.ad.Text = musteriler_datagrid.CurrentRow.Cells[1].Value.ToString();
                Araçlarım.kirayaver.tc.Text = musteriler_datagrid.CurrentRow.Cells[0].Value.ToString();
                Araçlarım.kirayaver.soyad.Text = musteriler_datagrid.CurrentRow.Cells[2].Value.ToString();
                Araçlarım.kirayaver.ad_soyad_txt.Text = musteriler_datagrid.CurrentRow.Cells[1].Value.ToString() + " " + musteriler_datagrid.CurrentRow.Cells[2].Value.ToString();
                Araçlarım.kirayaver.cep_tel_txt.Text = musteriler_datagrid.CurrentRow.Cells[5].Value.ToString();
                Araçlarım.kirayaver.butnExtra.Visible = true; //kiraya ver formundaki ekstra butonunu aktif eder.
                kiraya_ver.belirle = "";
                
            }
            if (rezerve_et.belirle == "rezerve tıklandı")
            {
                Araçlarım.rezerveet.musteri_adi_txt.Text = musteriler_datagrid.CurrentRow.Cells[1].Value.ToString();
                Araçlarım.rezerveet.soyad_txt.Text = musteriler_datagrid.CurrentRow.Cells[2].Value.ToString();
                rezerve_et.belirle = "";
            }

            Hide();
        }

        private void bul_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string gosterilecek = "select * from musteriler where ad like  '" + bul_txt.Text + "%' or soyad like'" + bul_txt.Text + "%' or tcKimlikNo like'" + bul_txt.Text + "%'";
                SqlCommand cmd = new SqlCommand(gosterilecek, baglanti);
                SqlDataAdapter adptr = new SqlDataAdapter(cmd);
                DataSet dst = new DataSet();
                adptr.Fill(dst, "musteriler");
                musteriler_datagrid.DataSource = dst.Tables["musteriler"];
            }
            catch(Exception EX)
            {
                Bildiri.Uyari("BİLİNMEYEN HATA!!", Bildiri.AlertType.hata);
            }
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

        private void musteriler_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
