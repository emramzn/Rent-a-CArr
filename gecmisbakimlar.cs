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
    public partial class gecmisbakimlar : Form
    {
        public static SqlConnection baglanti = database.baglan();
        public BorderStyle BorderStyle { get; set; }
        public gecmisbakimlar()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        public void hesapla()
        {
            try
            {


                string gosterilecek = "select bakimTutari from tabloAracBakim where aracPlaka='" + label3.Text + "'";

                SqlCommand cm = new SqlCommand(gosterilecek, baglanti);
                float toplam = 0f;
                SqlDataAdapter veriall = new SqlDataAdapter(cm);
                DataSet dst = new DataSet();
                dst.Clear();
                veriall.Fill(dst, "bakimTutari");
                int sayac = 0;
                foreach (DataRow dr in dst.Tables[0].Rows)
                {
                    string deger = dr[0].ToString();
                    toplam += float.Parse(deger);
                    sayac++;
                }
                toplam_lbl.Text = toplam.ToString() + " TL Bakım parası harcanmış.";
                adet_lbl.Text = sayac.ToString() + " Adet kayıt bulunmakta.";


            }
            catch
            {

                Bildiri.Uyari("BİLİNMEYEN HATA!!", Bildiri.AlertType.dikkat);
            }
                        
        }
        int SimdikiWidth = 1366;
        int SimdikiHeight = 768;
        private void gecmisbakimlar_Load(object sender, EventArgs e)
        {
            goster("tabloAracBakim", gecmis_bakim_datagrid);
            hesapla();

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
                string gosterilecek = "select*from " + a + " where aracPlaka='" + label3.Text + "'";
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

        private void kapat_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string gosterilecek = "delete from tabloAracBakim where aracPlaka ='" + label3.Text + "' and id='"+gecmis_bakim_datagrid.CurrentRow.Cells[7].Value.ToString()+"'";
                SqlCommand cmd = new SqlCommand(gosterilecek, baglanti);
                cmd.ExecuteNonQuery();
                //dtgrt.Columns["ID"].Visible = false;
            }
            catch
            {

                Bildiri.Uyari("BİLİNMEYEN HATA!!", Bildiri.AlertType.dikkat);
            }
            goster("tabloAracBakim", gecmis_bakim_datagrid);
            hesapla();
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

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
