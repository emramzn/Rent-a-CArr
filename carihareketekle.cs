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
    public partial class carihareketekle : Form
    {
        public carihareketekle()
        {
            InitializeComponent();
        }
        SqlConnection veriBase = database.baglan();

        public static string tcKimlikNo { get; set; }
        private void carihareketekle_Load(object sender, EventArgs e)
        {

        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int islemHacmi = 0; int islemAdedi = 0;

                string cariEkle = "insert into tabloCariHesap(tcKimlikNo,tarih,tutar,odemeTuru,aciklama,odemeler,islemHacmi,islemAdedi)values('" + tcKimlikNo.ToString() + "','" + cari_dateTime.Text + "','" + cariTutar_txt.Text + "','" + cariOdemeTuru_combo.Text + "','" + aciklama.Text + "','" + cariTutar_txt.Text + "','[ 2 ]','[ 1 ]')";

                SqlCommand komutEkle = new SqlCommand(cariEkle, veriBase);
                int sonuc = komutEkle.ExecuteNonQuery();
                if (sonuc == 1)
                {

                    //DEVAM EDİLECEK YERLER İÇİNDE ---
                    string toplamOdeme = "";
                    string verigetir = "select odemeler,tutar from tabloCariHesap where tcKimlikNo='" + tcKimlikNo + "'";
                    SqlCommand bilgiGetir = new SqlCommand(verigetir, veriBase);
                    SqlDataReader verioku = bilgiGetir.ExecuteReader();
                    if (verioku.Read())
                    {
                        toplamOdeme = verioku["odemeler"].ToString();// + Convert.ToInt32(verioku["tutar"].ToString());

                    }
                    verioku.Close();

                    //  MessageBox.Show(toplamOdeme.ToString());
                    carikartislemleri.odemeToplam = toplamOdeme;





                    Bildiri.Uyari("Cari Hesap Eklendi.", Bildiri.AlertType.bilgi);
                    Close();



                }
                else
                {

                    Bildiri.Uyari("Cari Hesap Eklenemedi!!", Bildiri.AlertType.dikkat);
                }




            }
            catch (Exception erorr)
            {


                Bildiri.Uyari("BİLİNMEYEN HATA!!", Bildiri.AlertType.dikkat);
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

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
