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
    public partial class musterikredikartibilgileri : Form
    {
        public BorderStyle BorderStyle { get; set; }
        public musterikredikartibilgileri()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        SqlConnection sqlBagla = database.baglan();
        public static string tcKimlikNo { get; set; }

        void dataListele() // MÜŞTERİ BİLG,İLERİ DATAGRİDVİEV'İ DOLDURUR  
        {

            string listele = "select kartNo,sonKulTarihi,guvenlikNo,aciklama from tabloKrediKarti where tcKimlikNo='" + tcKimlikNo + "'";
            SqlCommand komutBilgiGetir = new SqlCommand(listele, sqlBagla);
            SqlDataAdapter adapter1 = new SqlDataAdapter(komutBilgiGetir);
            DataSet dataSetBilgiler = new DataSet();
            adapter1.Fill(dataSetBilgiler, "tabloKrediKarti");
            dataGridView1.DataSource = dataSetBilgiler.Tables["tabloKrediKarti"];


        }
        private void krediKartiEkle_btn_Click(object sender, EventArgs e)
        {
            kredikartibilgileri kartbilgiic = new kredikartibilgileri();
            kredikartibilgileri.tcKimlikNo = tcKimlikNo;
            kartbilgiic.ShowDialog();
        }
        int SimdikiWidth = 1366;
        int SimdikiHeight = 768;
        private void musterikredikartibilgileri_Load(object sender, EventArgs e)
        {
            dataListele();

            Rectangle ClientCozunurluk = new Rectangle();

            ClientCozunurluk = Screen.GetBounds(ClientCozunurluk);

            float OranWidth = ((float)ClientCozunurluk.Width / (float)SimdikiWidth);

            float OranHeight = ((float)ClientCozunurluk.Height / (float)SimdikiHeight);


            this.Scale(OranWidth, OranHeight);

        }

        private void kapat_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void musterikredikartibilgileri_Activated(object sender, EventArgs e)
        {
            dataListele();
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
