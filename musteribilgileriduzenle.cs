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
    public partial class musteribilgileriduzenle : Form
    {
        public BorderStyle BorderStyle { get; set; }
        public musteribilgileriduzenle()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        SqlConnection dataGet = database.baglan();
        private void ehlVerilisTarihi_dateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void duzenleyen_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ehliyetBelgeNo_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void kullCihaz_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ehliyetilce_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ehliyetil_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iptal_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tamam_btn_Click(object sender, EventArgs e)
        {
            if (musteriAdi_txt.Text==""||musteriSoyadi_txt.Text==""||musteriTel_txt.Text=="")
            {
                Bildiri.Uyari("Lütfen Ad,Soyad ve Telefon Alanlarını eksiksiz doldurun.", Bildiri.AlertType.dikkat);
            }
            else
            {
                try
                {


                    string updateEt = "update musteriler set     ad='" + musteriAdi_txt.Text + "',soyad='" + musteriSoyadi_txt.Text + "',telefon='" + musteriTel_txt.Text + "',adres='" + musteriAdres_txt.Text + "',cep1='" + musteriCep1_txt.Text + "',cep2='" + musteriCep2_txt.Text + "',mail='" + musteriMail.Text + "',ekBilgi='" + musteriEkBilgi_txt.Text + "',nufusCuzNo='" + nufusCuzNo_txt.Text + "',babaAd='" + babaAdi_txt.Text + "' ,anaAd='" + anaAdi_txt.Text + "',dogumYeri='" + dogumYeri_txt.Text + "',dogumTarihi='" + dogumTarihi_txt.Text + "',medeniHali='" + medeniHali_txt.Text + "',dini='" + dini_txt.Text + "',il='" + il_txt.Text + "',ilce='" + ilce_txt.Text + "',mahalle='" + mahalle_txt.Text + "' ,ciltNo='" + ciltNo_txt.Text + "',aileSiraNo='" + aileSiraNo_txt.Text + "' ,verildigiYer='" + verildigiYer_txt.Text + "' ,verilisNedeni='" + verilisNedeni_txt.Text + "' ,kayitNo='" + kayitNo_txt.Text + "' ,verilisTarihi='" + verilisTarihi_txt.Text + "'     where tcKimlikNo='" + tcKimlikNo_txt.Text + "'";
                    string updateEt2 = "update musteriBelgeleriTablosu set ehliyetil='" + ehliyetil_txt.Text + "', ehliyetilce='" + ehliyetilce_txt.Text + "',ehliyetBelgeNo='" + ehliyetBelgeNo_txt.Text + "',ehliyetVerilisTarihi='" + ehlVerilisTarihi_dateTime.Text + "',ehliyetKullanilanCihaz='" + kullCihaz_txt.Text + "',ehliyetDuzenleyen='" + duzenleyen_txt.Text + "',pasaNo='" + pasaportNo_txt.Text + "',pasaVerildigiYer='" + pasaportVerilYer_txt.Text + "',pasaVerilisTarihi='" + pasaportVerilisTarihi_dateTime.Text + "' where tcKimlikNo='" + tcKimlikNo_txt.Text + "'";

                    SqlCommand komutUpdate = new SqlCommand(updateEt, dataGet);
                    SqlCommand komutUpdate2 = new SqlCommand(updateEt2, dataGet);
                    int sonuc = komutUpdate.ExecuteNonQuery();
                    int sonuc2 = komutUpdate2.ExecuteNonQuery();
                    if (sonuc2 == 1) //&& sonuc2==1
                    {

                        Bildiri.Uyari("MÜŞTERİ BİLGİLERİ DÜZENLEME İŞLEMİ BAŞARILI", Bildiri.AlertType.bilgi);
                        Close();
                    }
                    else
                    {

                        Bildiri.Uyari("KAYIT DÜZENLEME BAŞARISIZ!!!", Bildiri.AlertType.hata);
                    }


                }
                catch
                {

                    Bildiri.Uyari("BİLİNMEYEN HATA!!", Bildiri.AlertType.hata);

                }
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
        int SimdikiWidth = 1366;
        int SimdikiHeight = 768;
        private void musteribilgileriduzenle_Load(object sender, EventArgs e)
        {
            Rectangle ClientCozunurluk = new Rectangle();

            ClientCozunurluk = Screen.GetBounds(ClientCozunurluk);

            float OranWidth = ((float)ClientCozunurluk.Width / (float)SimdikiWidth);

            float OranHeight = ((float)ClientCozunurluk.Height / (float)SimdikiHeight);


            this.Scale(OranWidth, OranHeight);
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
