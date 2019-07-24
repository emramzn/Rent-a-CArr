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
    public partial class OPALFATURA : Form
    {
        public OPALFATURA()
        {
            InitializeComponent();
        }
        SqlConnection connectionBag = database.baglan();



        public static string adSoyad { get; set; }
        public static string islemTutariYazi { get; set; }
        public static string adres { get; set; }
        public static string tcNo { get; set; }
        public static string aciklama { get; set; }
        public static string islemTutari { get; set; }

        public static string islemTuru { get; set; }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {


              
                string secMusteri = "select ad,soyad,tcKimlikNo,telefon,adres from musteriler where tcKimlikNo ='" + textBox1.Text.ToString() + "' or telefon ='" + textBox1.Text.ToString() + "'";

                SqlCommand faturaBilgi = new SqlCommand(secMusteri, connectionBag);

                SqlDataReader readerFatura = faturaBilgi.ExecuteReader();
                if (readerFatura.Read())
                {

                    textBox3.Text = readerFatura["ad"].ToString() + " " + readerFatura["soyad"].ToString();
                    textBox2.Text = readerFatura["adres"].ToString();
                    textBox5.Text = readerFatura["tcKimlikNo"].ToString();


                }
                else
                {
                    MessageBox.Show("BULUNAMADI");
                }
                readerFatura.Close();
               


            }
            catch (Exception ERR)
            {

                MessageBox.Show("HATA :" + ERR.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            aciklama = textBox4.Text;
            adSoyad = textBox3.Text;
            tcNo = textBox5.Text;
            adres = textBox2.Text;
            islemTuru = comboBox1.Text;
            islemTutari = tutar_txt.Text;
            islemTutariYazi = "YALNIZ " + label8.Text;



            //MessageBox.Show((netControl.InternetKontrol()).ToString());
            DialogResult sayfaOnizleme;
            sayfaOnizleme = printPreviewDialog1.ShowDialog();
            if (sayfaOnizleme == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void tutar_txt_TextChanged(object sender, EventArgs e)
        {
            string sayi = "", krs = "";

            try
            {


                string boyut = tutar_txt.Text.Length.ToString();
                string deger = tutar_txt.Text.ToString();



                int sayac = 0;
                if (boyut == "1")
                {
                    switch (deger[0])
                    {
                        case '1':
                            sayi = sayi + "BİR ";
                            break;

                        case '2':
                            sayi = sayi + "İKİ ";
                            break;
                        case '3':
                            sayi = sayi + "ÜÇ ";
                            break;
                        case '4':
                            sayi = sayi + "DÖRT ";
                            break;
                        case '5':
                            sayi = sayi + "BEŞ ";
                            break;
                        case '6':
                            sayi = sayi + "ALTI ";
                            break;
                        case '7':
                            sayi = sayi + "YEDİ ";
                            break;
                        case '8':
                            sayi = sayi + "SEKİZ ";
                            break;
                        case '9':
                            sayi = sayi + "DOKUZ ";
                            break;
                        default:
                            break;
                    }

                }

                if (boyut == "2")
                {

                    switch (deger[0])
                    {
                        case '1':
                            sayi = sayi + "ON ";
                            break;

                        case '2':
                            sayi = sayi + "YİRMİ ";
                            break;
                        case '3':
                            sayi = sayi + "OTUZ ";
                            break;
                        case '4':
                            sayi = sayi + "KIRK ";
                            break;
                        case '5':
                            sayi = sayi + "ELLİ ";
                            break;
                        case '6':
                            sayi = sayi + "ALTMIŞ ";
                            break;
                        case '7':
                            sayi = sayi + "YETMİŞ ";
                            break;
                        case '8':
                            sayi = sayi + "SEKSEN ";
                            break;
                        case '9':
                            sayi = sayi + "DOKSAN ";
                            break;
                        default:
                            break;
                    }
                    switch (deger[1])
                    {
                        case '1':
                            sayi = sayi + "BİR ";
                            break;

                        case '2':
                            sayi = sayi + "İKİ ";
                            break;
                        case '3':
                            sayi = sayi + "ÜÇ ";
                            break;
                        case '4':
                            sayi = sayi + "DÖRT ";
                            break;
                        case '5':
                            sayi = sayi + "BEŞ ";
                            break;
                        case '6':
                            sayi = sayi + "ALTI ";
                            break;
                        case '7':
                            sayi = sayi + "YEDİ ";
                            break;
                        case '8':
                            sayi = sayi + "SEKİZ ";
                            break;
                        case '9':
                            sayi = sayi + "DOKUZ ";
                            break;
                        default:
                            break;
                    }


                }
                if (boyut == "3")
                {


                    switch (deger[0])
                    {
                        case '1':
                            sayi = sayi + "YÜZ ";
                            break;

                        case '2':
                            sayi = sayi + "İKİYÜZ ";
                            break;
                        case '3':
                            sayi = sayi + "ÜÇYÜZ ";
                            break;
                        case '4':
                            sayi = sayi + "DÖRTYÜZ ";
                            break;
                        case '5':
                            sayi = sayi + "BEŞYÜZ ";
                            break;
                        case '6':
                            sayi = sayi + "ALTIYÜZ ";
                            break;
                        case '7':
                            sayi = sayi + "YEDİYÜZ ";
                            break;
                        case '8':
                            sayi = sayi + "SEKİZYÜZ ";
                            break;
                        case '9':
                            sayi = sayi + "DOKUZYÜZ ";
                            break;
                        default:
                            break;
                    }

                    switch (deger[1])
                    {
                        case '1':
                            sayi = sayi + "ON ";
                            break;

                        case '2':
                            sayi = sayi + "YİRMİ ";
                            break;
                        case '3':
                            sayi = sayi + "OTUZ ";
                            break;
                        case '4':
                            sayi = sayi + "KIRK ";
                            break;
                        case '5':
                            sayi = sayi + "ELLİ ";
                            break;
                        case '6':
                            sayi = sayi + "ALTMIŞ ";
                            break;
                        case '7':
                            sayi = sayi + "YETMİŞ ";
                            break;
                        case '8':
                            sayi = sayi + "SEKSEN ";
                            break;
                        case '9':
                            sayi = sayi + "DOKSAN ";
                            break;
                        default:
                            break;
                    }
                    switch (deger[2])
                    {
                        case '1':
                            sayi = sayi + "BİR ";
                            break;

                        case '2':
                            sayi = sayi + "İKİ ";
                            break;
                        case '3':
                            sayi = sayi + "ÜÇ ";
                            break;
                        case '4':
                            sayi = sayi + "DÖRT ";
                            break;
                        case '5':
                            sayi = sayi + "BEŞ ";
                            break;
                        case '6':
                            sayi = sayi + "ALTI ";
                            break;
                        case '7':
                            sayi = sayi + "YEDİ ";
                            break;
                        case '8':
                            sayi = sayi + "SEKİZ ";
                            break;
                        case '9':
                            sayi = sayi + "DOKUZ ";
                            break;
                        default:
                            break;
                    }


                }


                if (boyut == "4")
                {

                    switch (deger[0])
                    {
                        case '1':
                            sayi = sayi + "BİN ";
                            break;

                        case '2':
                            sayi = sayi + "İKİBİN ";
                            break;
                        case '3':
                            sayi = sayi + "ÜÇBİN ";
                            break;
                        case '4':
                            sayi = sayi + "DÖRTBİN ";
                            break;
                        case '5':
                            sayi = sayi + "BEŞBİN ";
                            break;
                        case '6':
                            sayi = sayi + "ALTIBİN ";
                            break;
                        case '7':
                            sayi = sayi + "YEDİBİN ";
                            break;
                        case '8':
                            sayi = sayi + "SEKİZBİN ";
                            break;
                        case '9':
                            sayi = sayi + "DOKUZBİN ";
                            break;
                        default:
                            break;
                    }


                    switch (deger[1])
                    {
                        case '1':
                            sayi = sayi + "YÜZ ";
                            break;

                        case '2':
                            sayi = sayi + "İKİYÜZ ";
                            break;
                        case '3':
                            sayi = sayi + "ÜÇYÜZ ";
                            break;
                        case '4':
                            sayi = sayi + "DÖRTYÜZ ";
                            break;
                        case '5':
                            sayi = sayi + "BEŞYÜZ ";
                            break;
                        case '6':
                            sayi = sayi + "ALTIYÜZ ";
                            break;
                        case '7':
                            sayi = sayi + "YEDİYÜZ ";
                            break;
                        case '8':
                            sayi = sayi + "SEKİZYÜZ ";
                            break;
                        case '9':
                            sayi = sayi + "DOKUZYÜZ ";
                            break;
                        default:
                            break;
                    }

                    switch (deger[2])
                    {
                        case '1':
                            sayi = sayi + "ON ";
                            break;

                        case '2':
                            sayi = sayi + "YİRMİ ";
                            break;
                        case '3':
                            sayi = sayi + "OTUZ ";
                            break;
                        case '4':
                            sayi = sayi + "KIRK ";
                            break;
                        case '5':
                            sayi = sayi + "ELLİ ";
                            break;
                        case '6':
                            sayi = sayi + "ALTMIŞ ";
                            break;
                        case '7':
                            sayi = sayi + "YETMİŞ ";
                            break;
                        case '8':
                            sayi = sayi + "SEKSEN ";
                            break;
                        case '9':
                            sayi = sayi + "DOKSAN ";
                            break;
                        default:
                            break;
                    }
                    switch (deger[3])
                    {
                        case '1':
                            sayi = sayi + "BİR ";
                            break;

                        case '2':
                            sayi = sayi + "İKİ ";
                            break;
                        case '3':
                            sayi = sayi + "ÜÇ ";
                            break;
                        case '4':
                            sayi = sayi + "DÖRT ";
                            break;
                        case '5':
                            sayi = sayi + "BEŞ ";
                            break;
                        case '6':
                            sayi = sayi + "ALTI ";
                            break;
                        case '7':
                            sayi = sayi + "YEDİ ";
                            break;
                        case '8':
                            sayi = sayi + "SEKİZ ";
                            break;
                        case '9':
                            sayi = sayi + "DOKUZ ";
                            break;
                        default:
                            break;
                    }


                }

                if (boyut == "5")
                {
                    switch (deger[0])
                    {
                        case '1':
                            sayi = sayi + "ON ";
                            break;

                        case '2':
                            sayi = sayi + "YİRMİ ";
                            break;
                        case '3':
                            sayi = sayi + "OTUZ ";
                            break;
                        case '4':
                            sayi = sayi + "KIRK ";
                            break;
                        case '5':
                            sayi = sayi + "ELLİ ";
                            break;
                        case '6':
                            sayi = sayi + "ALTMIŞ ";
                            break;
                        case '7':
                            sayi = sayi + "YETMİŞ ";
                            break;
                        case '8':
                            sayi = sayi + "SEKSEN ";
                            break;
                        case '9':
                            sayi = sayi + "DOKSAN ";
                            break;
                        default:
                            break;
                    }

                    switch (deger[1])
                    {
                        case '0':
                            sayi = sayi + "BİN ";
                            break;
                        case '1':
                            sayi = sayi + "BİRBİN ";
                            break;

                        case '2':
                            sayi = sayi + "İKİBİN ";
                            break;
                        case '3':
                            sayi = sayi + "ÜÇBİN ";
                            break;
                        case '4':
                            sayi = sayi + "DÖRTBİN ";
                            break;
                        case '5':
                            sayi = sayi + "BEŞBİN ";
                            break;
                        case '6':
                            sayi = sayi + "ALTIBİN ";
                            break;
                        case '7':
                            sayi = sayi + "YEDİBİN ";
                            break;
                        case '8':
                            sayi = sayi + "SEKİZBİN ";
                            break;
                        case '9':
                            sayi = sayi + "DOKUZBİN ";
                            break;
                        default:
                            break;
                    }




                    switch (deger[2])
                    {
                        case '1':
                            sayi = sayi + "YÜZ ";
                            break;

                        case '2':
                            sayi = sayi + "İKİYÜZ ";
                            break;
                        case '3':
                            sayi = sayi + "ÜÇYÜZ ";
                            break;
                        case '4':
                            sayi = sayi + "DÖRTYÜZ ";
                            break;
                        case '5':
                            sayi = sayi + "BEŞYÜZ ";
                            break;
                        case '6':
                            sayi = sayi + "ALTIYÜZ ";
                            break;
                        case '7':
                            sayi = sayi + "YEDİYÜZ ";
                            break;
                        case '8':
                            sayi = sayi + "SEKİZYÜZ ";
                            break;
                        case '9':
                            sayi = sayi + "DOKUZYÜZ ";
                            break;
                        default:
                            break;
                    }

                    switch (deger[3])
                    {
                        case '1':
                            sayi = sayi + "ON ";
                            break;

                        case '2':
                            sayi = sayi + "YİRMİ ";
                            break;
                        case '3':
                            sayi = sayi + "OTUZ ";
                            break;
                        case '4':
                            sayi = sayi + "KIRK ";
                            break;
                        case '5':
                            sayi = sayi + "ELLİ ";
                            break;
                        case '6':
                            sayi = sayi + "ALTMIŞ ";
                            break;
                        case '7':
                            sayi = sayi + "YETMİŞ ";
                            break;
                        case '8':
                            sayi = sayi + "SEKSEN ";
                            break;
                        case '9':
                            sayi = sayi + "DOKSAN ";
                            break;
                        default:
                            break;
                    }
                    switch (deger[4])
                    {
                        case '1':
                            sayi = sayi + "BİR ";
                            break;

                        case '2':
                            sayi = sayi + "İKİ ";
                            break;
                        case '3':
                            sayi = sayi + "ÜÇ ";
                            break;
                        case '4':
                            sayi = sayi + "DÖRT";
                            break;
                        case '5':
                            sayi = sayi + "BEŞ ";
                            break;
                        case '6':
                            sayi = sayi + "ALTI ";
                            break;
                        case '7':
                            sayi = sayi + "YEDİ ";
                            break;
                        case '8':
                            sayi = sayi + "SEKİZ ";
                            break;
                        case '9':
                            sayi = sayi + "DOKUZ ";
                            break;
                        default:
                            break;
                    }


                }
                label8.Text = sayi + " TL ";



            }
            catch (Exception err)
            {

                MessageBox.Show("Hata : " + err.Message);
            }
        }

        private void OPALFATURA_Load(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Gray;
            textBox1.Text = "Telefon - T.C Kimlik No V.B";
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Telefon - T.C Kimlik No V.B")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.ForeColor = Color.Gray;
                textBox1.Text = "Telefon - T.C Kimlik No V.B";
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font efont = new System.Drawing.Font("Arial", 12);



            e.Graphics.DrawString(adSoyad, efont, Brushes.Black, 120, 150);

            e.Graphics.DrawString("Adres ", efont, Brushes.Black, 60, 215);

            e.Graphics.DrawString(adres, efont, Brushes.Black, 120, 215);

            e.Graphics.DrawString("T.C No : ", efont, Brushes.Black, 58, 290);

            e.Graphics.DrawString(tcNo, efont, Brushes.Black, 120, 290);


            e.Graphics.DrawString(aciklama, efont, Brushes.Black, 65, 400);

            e.Graphics.DrawString(islemTuru, efont, Brushes.Black, 65, 500);


            e.Graphics.DrawString("TOPLAM", efont, Brushes.Black, 510, 843);
            e.Graphics.DrawString(islemTutari + " TL", efont, Brushes.Black, 670, 843);


            double kdvtutari = double.Parse(islemTutari) * (0.18);
            e.Graphics.DrawString(  "KDV %18", efont, Brushes.Black, 510, 800);
            e.Graphics.DrawString( kdvtutari.ToString(), efont, Brushes.Black, 670, 800);


            e.Graphics.DrawString(islemTutariYazi, efont, Brushes.Black, 200, 880);


            e.HasMorePages = false;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
