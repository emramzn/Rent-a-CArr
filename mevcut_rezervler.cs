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
    public partial class mevcut_rezervler : Form
    {
        public static SqlConnection baglanti = database.baglan();
        public BorderStyle BorderStyle { get; set; }
        public mevcut_rezervler()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        int SimdikiWidth = 1366;
        int SimdikiHeight = 768;
        private void mevcut_rezervler_Load(object sender, EventArgs e)
        {
            goster("aracRezerve", rezerv_datagrid);

            Rectangle ClientCozunurluk = new Rectangle();

            ClientCozunurluk = Screen.GetBounds(ClientCozunurluk);

            float OranWidth = ((float)ClientCozunurluk.Width / (float)SimdikiWidth);

            float OranHeight = ((float)ClientCozunurluk.Height / (float)SimdikiHeight);


            this.Scale(OranWidth, OranHeight);
        }
        void goster(string a, DataGridView dtgrt)
        {
            try
            {
                string gosterilecek = "select*from " + a + "";
                SqlCommand cmd = new SqlCommand(gosterilecek, baglanti);
                SqlDataAdapter adptr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adptr.Fill(ds, a);
                dtgrt.DataSource = ds.Tables[a];
                //dtgrt.Columns["ID"].Visible = false;
            }
            catch
            {

            }



        }

        private void sil_btn_Click(object sender, EventArgs e)
        {

            string rezerv_kaldir = "";
            try
            {
                rezerv_kaldir = "update tabloAraclar set durum='ELİMİZDE'  where plaka='" + rezerv_datagrid.CurrentRow.Cells[4].Value.ToString() + "'";
                SqlCommand komut = new SqlCommand(rezerv_kaldir, baglanti);
                komut.ExecuteNonQuery();
                //MessageBox.Show("emre");
            }
            catch
            {

                Bildiri.Uyari("BİLİNMEYEN HATA!!", Bildiri.AlertType.dikkat);
            }
            try
            {
                string silincek = "delete from aracRezerve where id='" + rezerv_datagrid.CurrentRow.Cells[6].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(silincek, baglanti);
                cmd.ExecuteNonQuery();
            }
            catch
            {

                Bildiri.Uyari("seçim yapmadığınız için silme işlemi gerçekleştirilemiyor..", Bildiri.AlertType.bilgi);
            }
            goster("aracRezerve", rezerv_datagrid);
          
            
            
          
        }

        private void kapat_btn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            string gosterilecek = "select*from aracRezerve where baslama between '"+tarih_bas_time.Text+"' and '"+tarih_son_time.Text+"'";
            SqlCommand cmd = new SqlCommand(gosterilecek, baglanti);
            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adptr.Fill(ds, "aracRezerve");
            rezerv_datagrid.DataSource = ds.Tables["aracRezerve"];
        }

        private void yazdir_btn_Click(object sender, EventArgs e)
        {
            yazdir yazilamiyor = new yazdir();
            yazilamiyor.Show();
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
