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
    public partial class kiraya_ver : Form
    {
        public static string belirle="";
        public static SqlConnection baglanti = database.baglan();
        public BorderStyle BorderStyle { get; set; }
        public kiraya_ver()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        public static string gunsayisi { get; set; } /// gun ssayiısını verir

            public static string hk { get; set; }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void araba_sec_btn_Click(object sender, EventArgs e)
        {
            araba_sec arabasec = new araba_sec();
            arabasec.ShowDialog();
        }

        private void musteri_sec_btn_Click(object sender, EventArgs e)
        {
            ekstraToplam = 0;
            extraTxt.Text = ekstraToplam.ToString();
            belirle = "kirala tiklandi";
          
            alinan_ucret_txt.Text = "";
            musteri_sec musterisec = new musteri_sec();
            musterisec.ShowDialog();
            //butnExtra.Visible = true;
            //extraTxt.Visible = true;
            string cumle = "select count(*)from ikinciSofor where tc_birinci='" + tc.Text + "'";

            SqlCommand cmd = new SqlCommand(cumle, baglanti);
            int donus = Convert.ToInt16(cmd.ExecuteScalar());
            if (donus > 0)
            {
                musteri_sec_btn_2.Enabled = true;

            }
            else
            {
                musteri_sec_btn_2.Enabled = false;
            }
        }

        private void iptal_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static string AdSoyadText{ get; set; }
        public static string telText { get; set; }

        public static double ekstraToplam { get; set; }
        private void kirala_btn_Click(object sender, EventArgs e)
        {
            if (ad_soyad_txt.Text == "" || cep_tel_txt.Text == "" || marka_txt.Text == "")
            {

                Bildiri.Uyari("LÜTFEN KİRALAMA BİLGİLERİNİ EKSİKSİZ DOLDURUN !!!", Bildiri.AlertType.dikkat);
            }
            else if (alinan_ucret_txt.Text=="" || (Convert.ToDouble(alinan_ucret_txt.Text))<=0)
            {
                label19.Visible = true;
                label19.ForeColor = Color.Red;
                label19.Text = "(*)";
            }
            else
            {
                

                ////////////aracın geçmiş tablosuna ekleme
                try
                {

                    

                    string gosterilecek = "insert into aracGecmisKiralama(aracPlaka,kiralayanAdi,kiralayanSoyad,kiralayanTelefon,kiralananTarih,kiralananSaat,teslimatTarih,teslimatSaat,ucret,km,durum) values ('" + plaka_txt.Text + "','" + ad.Text + "','" + soyad.Text + "','" + cep_tel_txt.Text + "','" + kiralama_tarihi_time.Text + " ','" + kiralama_saati_time.Text + "','" + teslimat_tarih_time.Text + "','" + teslimat_saat_time.Text + "','" + alinan_ucret_txt.Text + "','" + km_txt.Text + "','alınmadı')";
                    SqlCommand cmd = new SqlCommand(gosterilecek, baglanti);

                    cmd.ExecuteNonQuery();
                    //--------------------


                    sozlesmeYap.plaka = plaka_txt.Text;
                    
                    string gosterilecek2 = "insert into musteriGecmisi(plaka,tcKimlikNo,marka,tarih,saat,teslimatTarihi,teslimatSaati,ucret) values('" + plaka_txt.Text + "','" + tc.Text + "','" + marka_txt.Text + "','" + kiralama_tarihi_time.Text + "','" + kiralama_saati_time.Text + "','" + teslimat_tarih_time.Text + "','" + teslimat_saat_time.Text + "','" + alinan_ucret_txt.Text + "')";
                    SqlCommand komut = new SqlCommand(gosterilecek2, baglanti);
                    komut.ExecuteNonQuery();

                    sozlesmeYap yapSoz = new sozlesmeYap();
                    yapSoz.ShowDialog();


                }
                catch
                {

                    Bildiri.Uyari("BİLİNMEYEN HATA!!", Bildiri.AlertType.dikkat);
                }





                //this.Hide();
            }
        }
        int SimdikiWidth = 1366;
        int SimdikiHeight = 768;
        private void kiraya_ver_Load(object sender, EventArgs e)
        {
            hesapla_btn.Enabled = true;
            
            ad_soyad_txt.Text = "";
            cep_tel_txt.Text = "";
            alinan_ucret_txt.Text = "";
            odeme_turu_cmb.Text = "";
            kiraya_veren_txt.Text = "";
            km_txt.Text = "";
            fatura_txt.Text = "";
            Rectangle ClientCozunurluk = new Rectangle();

            ClientCozunurluk = Screen.GetBounds(ClientCozunurluk);

            float OranWidth = ((float)ClientCozunurluk.Width / (float)SimdikiWidth);

            float OranHeight = ((float)ClientCozunurluk.Height / (float)SimdikiHeight);


            this.Scale(OranWidth, OranHeight);
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



    

        private void hesapla_btn_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime tesTar = Convert.ToDateTime(teslimat_tarih_time.Text);
                DateTime kirTar = Convert.ToDateTime(kiralama_tarihi_time.Text);
                TimeSpan sonuc = tesTar - kirTar;
                gunsayisi = sonuc.TotalDays.ToString();
                label23.Visible = true;
                label23.Text = gunsayisi + " " + "GÜN";
                string toplamGun = sonuc.TotalDays.ToString();
                double hesapla = double.Parse(toplamGun) * (double.Parse(ucret_txt.Text));
                if (hesapla == 0 || hesapla < 0)
                {
                    label17.Visible = true;
                    label17.ForeColor = Color.Red;
                    label17.Text = "(**)";

                    label18.Visible = true;
                    label18.ForeColor = Color.Red;
                    label18.Text = "(**)";

                    label19.Visible = true;
                    label19.ForeColor = Color.Red;
                    label19.Text = "(*)";
                }
                else
                {
                    label17.Visible = false;
                    label18.Visible = false;
                    label19.Visible = false;
                    label23.Visible = false;
                }

                double ekstraHesapla = ekstraToplam;
                
                ekstraToplam = ekstraHesapla * int.Parse(gunsayisi);
                alinan_ucret_txt.Text = (hesapla + ekstraToplam).ToString();




            }
            catch (Exception ERR)
            {

                Bildiri.Uyari("BİLİNMEYEN HATA!! kirayaVerme", Bildiri.AlertType.dikkat);
            }
            finally
            {
                // ekstraToplam = 0;
                if(extraTxt.Text!="")
                {
                    extraTxt.Text = ekstraToplam.ToString();
                    hesapla_btn.Enabled = false;
                }
                //ekstraToplam = 0;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            musteri_ekle yenikira = new musteri_ekle();
            yenikira.Show();
        }

        private void kiraya_ver_Activated(object sender, EventArgs e)
        {
            
        }

        private void alinan_ucret_txt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void butnExtra_Click(object sender, EventArgs e)
        {


            // MessageBox.Show("" + tc.ToString());
                if (tc.Text == "")
                {

                    Bildiri.Uyari("ÖNCE MÜŞTERİ SEÇİN!!", Bildiri.AlertType.dikkat);
                }
                else
                {
                    for (int i = 0; i < sozlesmeYap.yazdirma.Length; i++)
                    {
                        sozlesmeYap.yazdirma[i] = null;
                    }
                    ekstraEklemeler extraOpen = new ekstraEklemeler();
                    ekstraEklemeler.tcKimlikNo = tc.Text;
                    extraOpen.Show();
                }
            
        }

        private void musteri_sec_btn_2_Click(object sender, EventArgs e)
        {
            if (tc.Text != "görünmezler")
            {
                if (netControl.InternetKontrol() == true)
                {
                    ikinciSoforSec ikinci = new ikinciSoforSec();
                    ikinci.tc.Text = tc.Text;
                    ikinci.ShowDialog();
                }
                else
                {

                    Bildiri.Uyari("LÜTFEN İNTERNET BAĞLANTISINI KONTROL EDİN !!", Bildiri.AlertType.dikkat);
                }
            }
            else
            {

                Bildiri.Uyari("Birinci müşteriyi seçmeniz gerekmektedir.", Bildiri.AlertType.dikkat);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tc.Text != "görünmezler")
            {
                ikinciSofor ikinci = new ikinciSofor();
                ikinci.birinci_tc.Text = tc.Text;
                ikinci.ShowDialog();
            }
            else
            {
                Bildiri.Uyari("Birinci müşteriyi seçmeniz gerekmektedir.", Bildiri.AlertType.dikkat);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            try
            {

                string musteriGetir = "select tcKimlikNo,ad,soyad,dogumTarihi,dogumYeri,telefon,cep1,adres,ehl_il,ehlBelgeNo,ehl_ilce,ehlVeriTarihi,pasNo,pasVeriYer,pasVerilisTarihi from musteriler where tcKimlikNo='" + Araçlarım.kirayaver.tc.Text + "'";
                SqlCommand komutVeri = new SqlCommand(musteriGetir, baglanti);

                SqlDataReader readMusteri = komutVeri.ExecuteReader();
                if (readMusteri.Read())
                {
                    sozlesmeYap.ad_soyad = readMusteri["ad"].ToString() + " " + readMusteri["soyad"].ToString();
                    sozlesmeYap.adres = readMusteri["adres"].ToString();
                    sozlesmeYap.telefon = readMusteri["telefon"].ToString();
                    sozlesmeYap.TcKimlik = readMusteri["tcKimlikNo"].ToString();
                    sozlesmeYap.cepTel = readMusteri["cep1"].ToString();
                    sozlesmeYap.dogumTar = readMusteri["dogumTarihi"].ToString();
                    sozlesmeYap.DogumYeri = readMusteri["dogumYeri"].ToString();
                    sozlesmeYap.pasNo = readMusteri["pasNo"].ToString();
                    sozlesmeYap.pasVerilisYer = readMusteri["pasVeriYer"].ToString();
                    sozlesmeYap.pasVerTarih = readMusteri["pasVerilisTarihi"].ToString();
                    sozlesmeYap.ehliyetNo = readMusteri["ehlBelgeNo"].ToString();
                    sozlesmeYap.ehliyetVeriYer = readMusteri["ehl_il"].ToString() + " " + readMusteri["ehl_ilce"].ToString();
                    sozlesmeYap.ehliyetVerilisTar = readMusteri["ehlVeriTarihi"].ToString();

                }

                readMusteri.Close();

                sozlesmeYap.totalToplam = Araçlarım.kirayaver.alinan_ucret_txt.Text;
                sozlesmeYap.tutar = (Convert.ToInt32(Araçlarım.kirayaver.alinan_ucret_txt.Text) - Convert.ToInt32(Araçlarım.kirayaver.extraTxt.Text)).ToString();
                sozlesmeYap.birimFiyat = Araçlarım.kirayaver.ucret_txt.Text;
                sozlesmeYap.kiralamaGunu = Araçlarım.kirayaver.label23.Text;




            }
            catch
            {

                Bildiri.Uyari("BİLİNMEYEN HATA!!KiraÖnizleme", Bildiri.AlertType.hata);
            }

            finally
            {
                
            DialogResult sayfaOnizleme;
            sayfaOnizleme = printPreviewDialog1.ShowDialog();
            if (sayfaOnizleme == DialogResult.OK)
            {
                printDocument1.Print();
            }
            }




        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {


                string[] kordinatlar = { "0", "497", "517", "535", "555", "572", "590", "609", "628", "646", "665", "684", "702" };


                Font efont = new System.Drawing.Font("Arial", 8);

                for (int i = 0; i < sozlesmeYap.yazdirma.Length; i++)
                {


                    if (sozlesmeYap.yazdirma[i] != null)
                    {     //MessageBox.Show(yazdirma[i]);

                        e.Graphics.DrawString("x", efont, Brushes.Black, 515, Convert.ToInt32(kordinatlar[Convert.ToInt16(sozlesmeYap.yazdirma[i])]));
                        e.Graphics.DrawString(sozlesmeYap.yazdirma2[Convert.ToInt16(sozlesmeYap.yazdirma[i]) - 1], efont, Brushes.Black, 625, Convert.ToInt32(kordinatlar[Convert.ToInt16(sozlesmeYap.yazdirma[i])]));


                    }
                }





                e.Graphics.DrawString(sozlesmeYap.ad_soyad, efont, Brushes.Black, 89, 155);
                e.Graphics.DrawString(sozlesmeYap.adres, efont, Brushes.Black, 70, 190);
                e.Graphics.DrawString(sozlesmeYap.telefon, efont, Brushes.Black, 45, 230);
                e.Graphics.DrawString(sozlesmeYap.TcKimlik, efont, Brushes.Black, 150, 230);

                e.Graphics.DrawString(sozlesmeYap.cepTel, efont, Brushes.Black, 262, 230); // cep tel
                e.Graphics.DrawString(sozlesmeYap.dogumTar, efont, Brushes.Black, 56, 270);  //doğum tarihi
                e.Graphics.DrawString(sozlesmeYap.DogumYeri, efont, Brushes.Black, 220, 265);  //d yeri

                e.Graphics.DrawString(sozlesmeYap.pasNo, efont, Brushes.Black, 72, 310); // pas no.
                e.Graphics.DrawString(sozlesmeYap.ehliyetNo, efont, Brushes.Black, 72, 345);  // ehliyet no
                e.Graphics.DrawString(sozlesmeYap.pasVerilisYer, efont, Brushes.Black, 205, 310);  // pas. veriliş yer il ilçe
                e.Graphics.DrawString(sozlesmeYap.pasVerTarih, efont, Brushes.Black, 295, 310); // pas veriliş tarh.
                e.Graphics.DrawString(sozlesmeYap.ehliyetVeriYer, efont, Brushes.Black, 205, 345); // ehl. ver yer.
                e.Graphics.DrawString(sozlesmeYap.ehliyetVerilisTar, efont, Brushes.Black, 295, 345); // ehl ver. tarh.

                e.Graphics.DrawString(sozlesmeYap.totalToplam, efont, Brushes.Black, 585, 843); // tolal toplamı

                e.Graphics.DrawString(sozlesmeYap.tutar, efont, Brushes.Black, 693, 458);  // tutar
                e.Graphics.DrawString(sozlesmeYap.birimFiyat, efont, Brushes.Black, 440, 458);  //birim fiyat

                e.Graphics.DrawString(sozlesmeYap.kiralamaGunu, efont, Brushes.Black, 580, 460); // kiralama gün sayısı


                // KART YAZDIRMA İŞLEMLERİ -

                // 1. 
                e.Graphics.DrawString(sozlesmeYap.kartNo1[0].ToString(), efont, Brushes.Black, 27, 829);
                e.Graphics.DrawString(sozlesmeYap.kartNo1[1].ToString(), efont, Brushes.Black, 45, 829);
                e.Graphics.DrawString(sozlesmeYap.kartNo1[2].ToString(), efont, Brushes.Black, 63, 829);
                e.Graphics.DrawString(sozlesmeYap.kartNo1[3].ToString(), efont, Brushes.Black, 81, 829);

                //2.

                e.Graphics.DrawString(sozlesmeYap.kartNo2[0].ToString(), efont, Brushes.Black, 115, 829);
                e.Graphics.DrawString(sozlesmeYap.kartNo2[1].ToString(), efont, Brushes.Black, 133, 829);
                e.Graphics.DrawString(sozlesmeYap.kartNo2[2].ToString(), efont, Brushes.Black, 151, 829);
                e.Graphics.DrawString(sozlesmeYap.kartNo2[2].ToString(), efont, Brushes.Black, 169, 829);


                //  //3.BÖLÜM
                e.Graphics.DrawString(sozlesmeYap.kartNo3[0].ToString(), efont, Brushes.Black, 205, 829);
                e.Graphics.DrawString(sozlesmeYap.kartNo3[1].ToString(), efont, Brushes.Black, 223, 829);
                e.Graphics.DrawString(sozlesmeYap.kartNo3[2].ToString(), efont, Brushes.Black, 241, 829);
                e.Graphics.DrawString(sozlesmeYap.kartNo3[3].ToString(), efont, Brushes.Black, 259, 829);


                // 4. BÖLÜM
                e.Graphics.DrawString(sozlesmeYap.kartNo4[0].ToString(), efont, Brushes.Black, 290, 829);
                e.Graphics.DrawString(sozlesmeYap.kartNo4[1].ToString(), efont, Brushes.Black, 308, 829);
                e.Graphics.DrawString(sozlesmeYap.kartNo4[2].ToString(), efont, Brushes.Black, 326, 829);
                e.Graphics.DrawString(sozlesmeYap.kartNo4[3].ToString(), efont, Brushes.Black, 344, 829);

                //-----------

                // son kullanma tarihi


                e.Graphics.DrawString(sozlesmeYap.sonKulTar[0].ToString(), efont, Brushes.Black, 230, 865);
                e.Graphics.DrawString(sozlesmeYap.sonKulTar[1].ToString(), efont, Brushes.Black, 250, 865);

                //  //--SKT2---


                e.Graphics.DrawString(sozlesmeYap.sonKulTar[2].ToString(), efont, Brushes.Black, 289, 865);
                e.Graphics.DrawString(sozlesmeYap.sonKulTar[3].ToString(), efont, Brushes.Black, 307, 865);
                e.Graphics.DrawString(sozlesmeYap.sonKulTar[4].ToString(), efont, Brushes.Black, 325, 865);
                e.Graphics.DrawString(sozlesmeYap.sonKulTar[5].ToString(), efont, Brushes.Black, 343, 865);


                //--

                //  //---- GÜVENLİK KODU---
                e.Graphics.DrawString(sozlesmeYap.guvKodu[0].ToString(), efont, Brushes.Black, 27, 865);
                e.Graphics.DrawString(sozlesmeYap.guvKodu[1].ToString(), efont, Brushes.Black, 42, 865);
                e.Graphics.DrawString(sozlesmeYap.guvKodu[2].ToString(), efont, Brushes.Black, 58, 865);


                //------------------------




                e.HasMorePages = false;

                



            }
            catch (Exception err)
            {

                MessageBox.Show("Hata: " + err.Message);
            }
        }
    }
}
