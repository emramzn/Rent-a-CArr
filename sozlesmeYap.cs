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
    public partial class sozlesmeYap : Form
    {

        public sozlesmeYap()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = database.baglan();


        public static string[] yazdirma = new string[16];
        public static string[] yazdirma2 = new string[16];


        // kullanıcı bilgileri-----
        public static string ad_soyad { get; set; }
        public static string adres { get; set; }
        public static string telefon { get; set; }
        public static string TcKimlik { get; set; }
        public static string cepTel { get; set; }
        public static string dogumTar { get; set; }
        public static string DogumYeri { get; set; }
        public static string pasNo { get; set; }
        public static string ehliyetNo { get; set; }
        public static string pasVerilisYer { get; set; }
        public static string pasVerTarih { get; set; }
        public static string ehliyetVeriYer { get; set; }
        public static string ehliyetVerilisTar { get; set; }


        // ikinci şoför -----
        public static string adSoyad2 { get; set; }
        public static string adres2 { get; set; }
        public static string telefon2 { get; set; }
        
        public static string TcNo2 { get; set; }
        public static string ceptel2 { get; set; }
        public static string dogumTar2 { get; set; }
        public static string ehlyetNo2 { get; set; }
        public static string pasNo2 { get; set; }
        public static string pasVerilisYer2 { get; set; }
        public static string pasVerilisTar2 { get; set; }
        public static string ehliyetVeriYer2 { get; set; }
        public static string ehlVeriTar2 { get; set; }

        //----------------------
        //--Birim Fiyat--------
        public static string birimFiyat { get; set; }
        //--------------------
        //Kiralama günü-----

        public static string kiralamaGunu { get; set; }

        // tutar----

        public static string tutar { get; set; }
        
        //----

        // totalde toplam
        public static string totalToplam { get; set; }
        //

        //kart bilgileri ------

        public static string kartNo1 { get; set; }
        public static string kartNo2 { get; set; }
        public static string kartNo3 { get; set; }
        public static string kartNo4 { get; set; }

        // guuvenlik kodu

        public static string guvKodu { get; set; }


        /// son kull. tar.

        public static string sonKulTar { get; set; }

        public static string plaka { get; set; }
        //  
        //---


        private void button1_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
            //MessageBox.Show("tc kimlik : "+Araçlarım.kirayaver.tc.Text);

            //try
            //{

            //    string musteriGetir = "select tcKimlikNo,ad,soyad,dogumTarihi,dogumYeri,telefon,cep1,adres,ehl_il,ehl_ilce,ehlBelgeNo,ehlVeriTarihi,pasNo,pasVeriYer,pasVerilisTarihi from musteriler where tcKimlikNo='10231547444'";
            //    SqlCommand komutVeri = new SqlCommand(musteriGetir, baglanti);

            //    SqlDataReader readMusteri = komutVeri.ExecuteReader();
            //    if (readMusteri.Read())
            //    {
            //        sozlesmeYap.ad_soyad = readMusteri["ad"].ToString() +""+ readMusteri["soyad"].ToString();
            //        sozlesmeYap.adres = readMusteri["adres"].ToString();
            //        sozlesmeYap.telefon = readMusteri["telefon"].ToString();
            //        sozlesmeYap.TcKimlik = readMusteri["tcKimlikNo"].ToString();
            //        sozlesmeYap.cepTel = readMusteri["cep1"].ToString();
            //        sozlesmeYap.dogumTar = readMusteri["dogumTarihi"].ToString();
            //        sozlesmeYap.DogumYeri = readMusteri["dogumYeri"].ToString();
            //        sozlesmeYap.pasNo = readMusteri["pasNo"].ToString();
            //        sozlesmeYap.pasVerilisYer = readMusteri["pasVeriYer"].ToString();
            //        sozlesmeYap.pasVerTarih = readMusteri["pasVerilisTarihi"].ToString();
            //        sozlesmeYap.ehliyetNo = readMusteri["ehlBelgeNo"].ToString();
            //        sozlesmeYap.ehliyetVeriYer = readMusteri["ehl_il"].ToString() + "" + readMusteri["ehl_ilce"].ToString();
            //        sozlesmeYap.ehliyetVerilisTar = readMusteri["ehlVeriTarihi"].ToString();
            //    }


            //    sozlesmeYap.totalToplam = Araçlarım.kirayaver.alinan_ucret_txt.Text;


            //}
            //catch (Exception err)
            //{

            //    MessageBox.Show("HATA : " + err.Message);
            //}
            //DialogResult yazdirmaislemi;
            //yazdirmaislemi = printDialog1.ShowDialog();
            //if (yazdirmaislemi==DialogResult.OK)
            //{
            //    printDocument1.Print();
            //}


            printDocument1.Print();

            string degistir = "update tabloAraclar set durum='KIRADA'  where plaka='" + plaka.ToString() + "'";
            SqlCommand durumGuncelle = new SqlCommand(degistir, baglanti);
            durumGuncelle.ExecuteNonQuery();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {


                string[] kordinatlar = { "0", "497", "517", "535", "555", "572", "590", "609", "628", "646", "665", "684", "702" };


                Font efont = new System.Drawing.Font("Arial", 8);

                for (int i = 0; i < yazdirma.Length; i++)
                {


                    if (yazdirma[i] != null)
                    {     //MessageBox.Show(yazdirma[i]);

                        e.Graphics.DrawString("x", efont, Brushes.Black, 515, Convert.ToInt32(kordinatlar[Convert.ToInt16(yazdirma[i])]));
                        e.Graphics.DrawString(yazdirma2[Convert.ToInt16(yazdirma[i]) - 1], efont, Brushes.Black, 625, Convert.ToInt32(kordinatlar[Convert.ToInt16(yazdirma[i])]));


                    }
                }





                e.Graphics.DrawString(ad_soyad, efont, Brushes.Black, 89, 155);
                e.Graphics.DrawString(adres, efont, Brushes.Black, 70, 190);
                e.Graphics.DrawString(telefon, efont, Brushes.Black, 45, 230);
                e.Graphics.DrawString(TcKimlik, efont, Brushes.Black, 150, 230);

                e.Graphics.DrawString(cepTel, efont, Brushes.Black, 262, 230); // cep tel
                e.Graphics.DrawString(dogumTar, efont, Brushes.Black, 56, 270);  //doğum tarihi
                e.Graphics.DrawString(DogumYeri, efont, Brushes.Black, 220, 265);  //d yeri

                e.Graphics.DrawString(pasNo, efont, Brushes.Black, 72, 310); // pas no.
                e.Graphics.DrawString(ehliyetNo, efont, Brushes.Black, 72, 345);  // ehliyet no
                e.Graphics.DrawString(pasVerilisYer, efont, Brushes.Black, 205, 310);  // pas. veriliş yer il ilçe
                e.Graphics.DrawString(pasVerTarih, efont, Brushes.Black, 295, 310); // pas veriliş tarh.
                e.Graphics.DrawString(ehliyetVeriYer, efont, Brushes.Black, 205, 345); // ehl. ver yer.
                e.Graphics.DrawString(ehliyetVerilisTar, efont, Brushes.Black, 295, 345); // ehl ver. tarh.

                e.Graphics.DrawString(totalToplam, efont, Brushes.Black, 585, 843); // tolal toplamı

                e.Graphics.DrawString(tutar, efont, Brushes.Black, 693, 458);  // tutar
                e.Graphics.DrawString(birimFiyat, efont, Brushes.Black, 440, 458);  //birim fiyat

                e.Graphics.DrawString(kiralamaGunu, efont, Brushes.Black, 580, 460); // kiralama gün sayısı


                // KART YAZDIRMA İŞLEMLERİ -

                // 1. 
                e.Graphics.DrawString(kartNo1[0].ToString(), efont, Brushes.Black, 27, 829);
                e.Graphics.DrawString(kartNo1[1].ToString(), efont, Brushes.Black, 45, 829);
                e.Graphics.DrawString(kartNo1[2].ToString(), efont, Brushes.Black, 63, 829);
                e.Graphics.DrawString(kartNo1[3].ToString(), efont, Brushes.Black, 81, 829);

                //2.

                e.Graphics.DrawString(kartNo2[0].ToString(), efont, Brushes.Black, 115, 829);
                e.Graphics.DrawString(kartNo2[1].ToString(), efont, Brushes.Black, 133, 829);
                e.Graphics.DrawString(kartNo2[2].ToString(), efont, Brushes.Black, 151, 829);
                e.Graphics.DrawString(kartNo2[2].ToString(), efont, Brushes.Black, 169, 829);


                //  //3.BÖLÜM
                e.Graphics.DrawString(kartNo3[0].ToString(), efont, Brushes.Black, 205, 829);
                e.Graphics.DrawString(kartNo3[1].ToString(), efont, Brushes.Black, 223, 829);
                e.Graphics.DrawString(kartNo3[2].ToString(), efont, Brushes.Black, 241, 829);
                e.Graphics.DrawString(kartNo3[3].ToString(), efont, Brushes.Black, 259, 829);


                // 4. BÖLÜM
                e.Graphics.DrawString(kartNo4[0].ToString(), efont, Brushes.Black, 290, 829);
                e.Graphics.DrawString(kartNo4[1].ToString(), efont, Brushes.Black, 308, 829);
                e.Graphics.DrawString(kartNo4[2].ToString(), efont, Brushes.Black, 326, 829);
                e.Graphics.DrawString(kartNo4[3].ToString(), efont, Brushes.Black, 344, 829);

                //-----------

                // son kullanma tarihi


                e.Graphics.DrawString(sonKulTar[0].ToString(), efont, Brushes.Black, 230, 865);
                e.Graphics.DrawString(sonKulTar[1].ToString(), efont, Brushes.Black, 250, 865);

                //  //--SKT2---


                e.Graphics.DrawString(sonKulTar[2].ToString(), efont, Brushes.Black, 289, 865);
                e.Graphics.DrawString(sonKulTar[3].ToString(), efont, Brushes.Black, 307, 865);
                e.Graphics.DrawString(sonKulTar[4].ToString(), efont, Brushes.Black, 325, 865);
                e.Graphics.DrawString(sonKulTar[5].ToString(), efont, Brushes.Black, 343, 865);


                //--

                //  //---- GÜVENLİK KODU---
                e.Graphics.DrawString(guvKodu[0].ToString(), efont, Brushes.Black, 27, 865);
                e.Graphics.DrawString(guvKodu[1].ToString(), efont, Brushes.Black, 42, 865);
                e.Graphics.DrawString(guvKodu[2].ToString(), efont, Brushes.Black, 58, 865);


                //------------------------

              


                e.HasMorePages = false;









            }
            catch
            {
                Bildiri.Uyari("SÖZLEŞME DURUMU!!", Bildiri.AlertType.hata);
                //HATA GÖRME KAPATILDI BURADAN AÇIN...
                // MessageBox.Show("Hata: " + err.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //MessageBox.Show((netControl.InternetKontrol()).ToString());
            DialogResult sayfaOnizleme;
            sayfaOnizleme = printPreviewDialog1.ShowDialog();
            if (sayfaOnizleme == DialogResult.OK)
            {
                printDocument1.Print();
            }


            //printPreviewDialog1.ShowDialog();
        }
        
        private void sozlesmeYap_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Araçlarım.kirayaver.tc.Text);
            try
            {

                string musteriGetir = "select tcKimlikNo,ad,soyad,dogumTarihi,dogumYeri,telefon,cep1,adres,ehl_il,ehlBelgeNo,ehl_ilce,ehlVeriTarihi,pasNo,pasVeriYer,pasVerilisTarihi from musteriler where tcKimlikNo='" + Araçlarım.kirayaver.tc.Text+"'";
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
                sozlesmeYap.tutar =(Convert.ToInt32(Araçlarım.kirayaver.alinan_ucret_txt.Text) - Convert.ToInt32(Araçlarım.kirayaver.extraTxt.Text)).ToString();
                sozlesmeYap.birimFiyat = Araçlarım.kirayaver.ucret_txt.Text;
                sozlesmeYap.kiralamaGunu = Araçlarım.kirayaver.label23.Text;

               

               
            }
            catch 
            {

                Bildiri.Uyari("BİLİNMEYEN HATA!!", Bildiri.AlertType.hata);
            }
        }

        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

          

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
