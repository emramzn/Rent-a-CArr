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
    public partial class musteri_ekle : Form
    {
        SqlConnection baglanti = database.baglan();
        public BorderStyle BorderStyle { get; set; }
        public musteri_ekle()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }



        private void ekle_btn_Click(object sender, EventArgs e)
        {
            if (ad_txt.Text == "" || soyad_txt.Text == "" || tcKimlikNo_txt.Text == "" || tel_txt.Text == "")
            {

                Bildiri.Uyari("AD  , SOYAD ,TELEFON  VE T.C KİMLİK NO ALANLARI BOŞ BIRAKILAMAZ ", Bildiri.AlertType.bilgi);

            }
            else if (tcKimlikNo_txt.Text.Length != 11 || tcKimlikNo_txt.Text.ToString()[0] == '0')
            {

                Bildiri.Uyari("lütfen T.C Kimlik No alanını hatasız doldurun. [T.C kimlik No -> 11 karakter olmalı ve Geçerli karakterler içermeli] ", Bildiri.AlertType.bilgi);
            }
            else
            {

                try
                {

                    string sorguEkleme = "insert into musteriler(tcKimlikNo,ad,soyad,dogumTarihi,dogumYeri,telefon,cep1,adres,ekBilgi,ehl_il,ehl_ilce,ehlBelgeNo,ehlVeriTarihi,pasNo,pasVeriYer,pasVerilisTarihi)values('" + tcKimlikNo_txt.Text + "','" + ad_txt.Text + "','" + soyad_txt.Text + "','" + dogumTarihi_txt.Text + "','" + dogumYeri_text.Text + "','" + tel_txt.Text + "','" + cep1_txt.Text + "','" + adres_txt.Text + "','" + ekbilgi_txt.Text + "','" + ehl_il_txt.Text + "','" + ehl_ilce_txt.Text + "','" + ehlBelgeNo_txt.Text + "','" + ehlVerilisTar_txt.Text + "','" + pasaNo.Text + "','" + pasVerilYer_txt.Text + "','" + pasaVerilisTar_txt.Text + "')";

                    SqlCommand komutMusEkleme = new SqlCommand(sorguEkleme, baglanti);
                    int sonuc = komutMusEkleme.ExecuteNonQuery();
                    if (sonuc == 1)
                    {

                        Bildiri.Uyari("EKELEME BAŞARILI", Bildiri.AlertType.bilgi);

                    }
                    Araçlarım.kirayaver.ad_soyad_txt.Text = ad_txt.Text + " " + soyad_txt.Text;
                    Araçlarım.kirayaver.cep_tel_txt.Text = tel_txt.Text;
                    // MessageBox.Show(ad_txt.Text);




                }
                catch (Exception ev)
                {

                    Bildiri.Uyari("EKELEME BAŞARISIZ!!", Bildiri.AlertType.dikkat);
                }

                finally
                {
                    this.Close();
                }



            }

        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
        int SimdikiWidth = 1366;
        int SimdikiHeight = 768;
        private void musteri_ekle_Load(object sender, EventArgs e)
        {

            ekstr_adresTes_txt.Text = "0";
            ekstr_adresTes_txt.ForeColor = Color.Gray;
            ekstaTekYon_txt.Text = "0";
            ekstaTekYon_txt.ForeColor = Color.Gray;
            ekstraCocuk_Txt.Text = "0";
            ekstraCocuk_Txt.ForeColor = Color.Gray;
            ekstraDizel_Txt.Text = "0";
            ekstraDizel_Txt.ForeColor = Color.Gray;
            ekstraGPS_Txt.Text = "0";
            ekstraGPS_Txt.ForeColor = Color.Gray;
            ekstrahasar_Txt.Text = "0";
            ekstrahasar_Txt.ForeColor = Color.Gray;
            ekstraMinHas_Txt.Text = "0";
            ekstraMinHas_Txt.ForeColor = Color.Gray;
            ekstraSaatFark_Txt.Text = "0";
            ekstraSaatFark_Txt.ForeColor = Color.Gray;
            ekSurucu_Txt.Text = "0";
            ekSurucu_Txt.ForeColor = Color.Gray;
            ekstr_grupFrark_Txt.Text = "0";
            ekstr_grupFrark_Txt.ForeColor = Color.Gray;
            ekstraTrafikCez_Txt.Text = "0";
            ekstraTrafikCez_Txt.ForeColor = Color.Gray;
            ekstraOgs_Txt.Text = "0";
            ekstraOgs_Txt.ForeColor = Color.Gray;




            label17.Visible = false;
            label3.Visible = false;
            label12.Visible = false;
            label11.Visible = false;




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

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void musteri_ekle_FormClosing(object sender, FormClosingEventArgs e)
        {
            //kiraya_ver.AdSoyadText = ad_txt.Text + " " + soyad_txt.Text;
            //kiraya_ver.telText = tel_txt.Text;
        }

        private void musteri_ekle_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Araçlarım.kirayaver.cep_tel_txt.Text = tel_txt.Text;
            //Araçlarım.kirayaver.ad_soyad_txt.Text= ad_txt.Text + " " + soyad_txt.Text;

            //MessageBox.Show(ad_txt.Text + " " + soyad_txt.Text);
        }

        private void dogumTarihi_txt_TextChanged(object sender, EventArgs e)
        {


            if (dogumTarihi_txt.Text.Length == 4 && ad_txt.Text != "" && soyad_txt.Text != "" && tcKimlikNo_txt.Text != "")
            {
                label11.Visible = false;
                label17.Visible = false;
                label12.Visible = false;
                bool durum;

                try
                {

                    long TC = long.Parse(tcKimlikNo_txt.Text);
                    int yil = int.Parse(dogumTarihi_txt.Text);
                    string ad = ad_txt.Text.Trim().ToString().ToUpper(), soyad = soyad_txt.Text.Trim().ToString().ToUpper();
                    using (kimlikDogrulama.KPSPublicSoapClient servis = new kimlikDogrulama.KPSPublicSoapClient())

                    {
                        durum = servis.TCKimlikNoDogrula(TC, ad, soyad, yil);

                    }

                }
                catch 
                {

                    durum = false;

                }



                if (durum == false)
                {
                    gostergePicture.BackColor = Color.Red;
                    label3.Visible = true;
                    label3.ForeColor = Color.Red;
                    label3.Text = "BU KİMLİK BİLGİLERİ BULUNMAMAKTADIR!!.";

                }
                else //if(durum=true)
                {
                    gostergePicture.BackColor = Color.Green;
                    label3.Visible = true;
                    label3.ForeColor = Color.Green;
                    label3.Text = "GİRİLEN BİLGİLER DOĞRU";
                }



                //---------------------
            }


            //-------------------------------------------  
            else if (dogumTarihi_txt.Text.Length != 4)
            {
                label11.Visible = true;
                label11.ForeColor = Color.Red;
                label11.Text = "(**)";
            }
            else if (ad_txt.Text != "" && soyad_txt.Text != "")
            {
                label12.Visible = false;
                label17.Visible = false;
            }


            else if (ad_txt.Text == "" || soyad_txt.Text == "")
            {
                label12.Visible = true;
                label17.Visible = true;
                label12.ForeColor = Color.Red;
                label17.ForeColor = Color.Red;
                label12.Text = "(*)";
                label17.Text = "(*)";
            }
            else
            {

                Bildiri.Uyari("LÜTFEN GİRİLEN BİLGİLERİ KONTROL EDİN!", Bildiri.AlertType.dikkat);
            }

        }

        private void tcKimlikNo_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }

        }

        private void dogumTarihi_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void tcKimlikNo_txt_TextChanged(object sender, EventArgs e)
        {
            if (tcKimlikNo_txt.Text.Length > 11)
            {
                label19.Visible = true;
                label19.Text = "(sadece 11 krkter)";
                label19.ForeColor = Color.Red;
            }
            else
            {
                label19.Visible = false;

            }
        }

        private void tcKimlikNo_txt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tcKimlikNo_txt_TextChanged_2(object sender, EventArgs e)
        {
            if (tcKimlikNo_txt.Text.Length > 11)
            {
                label19.Visible = true;
                label19.Text = "(sadece 11 krkter)";
                label19.ForeColor = Color.Red;

            }
            else
            {
                label19.Visible = false;

            }
        }

        private void dogumTarihi_txt_TextChanged_1(object sender, EventArgs e)
        {
            gostergePicture.Visible = false;
            progresbar_pcture.Visible = true;
            label3.Visible = true;
            label3.ForeColor = Color.Blue;
            label3.Text = "KONTROL EDİLİYOR...";


            if (dogumTarihi_txt.Text.Length == 4 && ad_txt.Text != "" && soyad_txt.Text != "" && tcKimlikNo_txt.Text != "")
            {






                label11.Visible = false;
                label17.Visible = false;
                label12.Visible = false;
                bool durum;




                try
                {

                    long TC = long.Parse(tcKimlikNo_txt.Text);
                    int yil = int.Parse(dogumTarihi_txt.Text);
                    string ad = ad_txt.Text.Trim().ToString().ToUpper(), soyad = soyad_txt.Text.Trim().ToString().ToUpper();
                    using (kimlikDogrulama.KPSPublicSoapClient servis = new kimlikDogrulama.KPSPublicSoapClient())

                    {

                        durum = servis.TCKimlikNoDogrula(TC, ad, soyad, yil);

                    }

                }
                catch 
                {

                    durum = false;

                }



                if (durum == false)
                {
                    progresbar_pcture.Visible = false;
                    gostergePicture.Visible = true;
                    gostergePicture.BackColor = Color.Red;
                    label3.Visible = true;
                    label3.ForeColor = Color.Red;
                    label3.Text = "BU KİMLİK BİLGİLERİ BULUNMAMAKTADIR!!.";

                }
                else //if(durum=true)
                {
                    progresbar_pcture.Visible = false;
                    gostergePicture.Visible = true;
                    gostergePicture.BackColor = Color.Green;
                    label3.Visible = true;
                    label3.ForeColor = Color.Green;
                    label3.Text = "GİRİLEN BİLGİLER DOĞRU";
                }



                //---------------------
            }


            //-------------------------------------------  
            else if (dogumTarihi_txt.Text.Length != 4)
            {
                label11.Visible = true;
                label11.ForeColor = Color.Red;
                label11.Text = "(**)";
            }
            else if (ad_txt.Text != "" && soyad_txt.Text != "")
            {
                label12.Visible = false;
                label17.Visible = false;
            }


            else if (ad_txt.Text == "" || soyad_txt.Text == "")
            {
                label12.Visible = true;
                label17.Visible = true;
                label12.ForeColor = Color.Red;
                label17.ForeColor = Color.Red;
                label12.Text = "(*)";
                label17.Text = "(*)";
            }
            else
            {

                Bildiri.Uyari("LÜTFEN GİRİLEN BİLGİLERİ KONTROL EDİN!", Bildiri.AlertType.dikkat);
            }

        }

        private void kartNo1Txt_TextChanged(object sender, EventArgs e)
        {
            try

            {

                if (kartNo1Txt.Text.Length > 0)
                {
                    pictureBoxKartTuru.Image = ımageList1.Images[3];
                    if (kartNo1Txt.Text[0].ToString() == "3")
                    {
                        pictureBoxKartTuru.Image = ımageList1.Images[2];
                    }
                    else if (kartNo1Txt.Text[0].ToString() == "4")
                    {
                        pictureBoxKartTuru.Image = ımageList1.Images[1];
                    }
                    else if (kartNo1Txt.Text[0].ToString() == "5")
                    {
                        pictureBoxKartTuru.Image = ımageList1.Images[0];
                    }
                    else if (kartNo1Txt.Text == "")
                    {
                        pictureBoxKartTuru.Image = ımageList1.Images[3];
                    }
                }

                if (kartNo1Txt.Text.Length == 4)
                {
                    kartNo2Text.Focus();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void kartNo2Text_TextChanged(object sender, EventArgs e)
        {

            if (kartNo2Text.Text.Length == 4)
            {
                kartNo3Txt.Focus();
            }
        }

        private void kartNo3Txt_TextChanged(object sender, EventArgs e)
        {
            if (kartNo3Txt.Text.Length == 4)
            {
                kartNo4Txt.Focus();
            }
        }

        private void kartNo4Txt_TextChanged(object sender, EventArgs e)
        {
            if (kartNo4Txt.Text.Length == 4)
            {
                guvenlikoduTxt.Focus();
            }
        }

        private void guvenlikoduTxt_TextChanged(object sender, EventArgs e)
        {
            if (guvenlikoduTxt.Text.Length == 3)
            {
                skt1Txt.Focus();
            }
        }

        private void skt1Txt_TextChanged(object sender, EventArgs e)
        {
            if (skt1Txt.Text.Length == 2)
            {
                skt2Txt.Focus();
            }
        }

        private void ekle_btn_Click_1(object sender, EventArgs e)
        {

            string kartSinifi = "", skt = "";

            skt = skt1Txt.Text + "/" + skt2Txt.Text;    //kartın son kullanma tarihi

            //if (visaRadioBtn.Checked)
            //{
            //    kartSinifi = "VISA";
            //}
            //else if (masterRadioBtn.Checked)
            //{
            //    kartSinifi = "MASTER CARD";
            //}
            //else if (amexRadioBtn.Checked)
            //{
            //    kartSinifi = "AMEX";
            //}


            if (ad_txt.Text == "" || soyad_txt.Text == "" || tcKimlikNo_txt.Text == "" || tel_txt.Text == "")
            {

                Bildiri.Uyari("AD  , SOYAD ,TELEFON  VE T.C KİMLİK NO ALANLARI BOŞ BIRAKILAMAZ", Bildiri.AlertType.dikkat);

            }
            else if (tcKimlikNo_txt.Text.Length != 11 || tcKimlikNo_txt.Text.ToString()[0] == '0')
            {
                Bildiri.Uyari("lütfen T.C Kimlik No alanını hatasız doldurun. [T.C kimlik No -> 11 karakter olmalı ve Geçerli karakterler içermeli]", Bildiri.AlertType.dikkat);

            }
            else
            {

                try
                {
                    //----------KİŞİSEL BİLGİLER EKLEME BÖLÜMÜ--------
                    string sorguEkleme = "insert into musteriler(tcKimlikNo,ad,soyad,dogumTarihi,dogumYeri,telefon,cep1,adres,ekBilgi,ehl_il,ehl_ilce,ehlBelgeNo,ehlVeriTarihi,pasNo,pasVeriYer,pasVerilisTarihi)values('" + tcKimlikNo_txt.Text + "','" + ad_txt.Text + "','" + soyad_txt.Text + "','" + dogumTarihi_txt.Text + "','" + dogumYeri_text.Text + "','" + tel_txt.Text + "','" + cep1_txt.Text + "','" + adres_txt.Text + "','" + ekbilgi_txt.Text + "','" + ehl_il_txt.Text + "','" + ehl_ilce_txt.Text + "','" + ehlBelgeNo_txt.Text + "','" + ehlVerilisTar_txt.Text + "','" + pasaNo.Text + "','" + pasVerilYer_txt.Text + "','" + pasaVerilisTar_txt.Text + "')";
                    //-------------------------


                    //////KREDİ KARTI BİLGİLERİ EKLEME BÖLÜMÜ-----
                    //string kartNo = kartNo1Txt.Text + "-" + kartNo2Text.Text + "-" + kartNo3Txt.Text + "-" + kartNo4Txt.Text;
                    //string sorguKrediEkleme = "insert into tabloKrediKarti(tcKimlikNo,kartSinifi,kartNo,sonKulTarihi,guvenlikNo)VALUES('" + tcKimlikNo_txt.Text + "','" + kartSinifi + "','" + kartNo + "','" + skt + "','" + guvenlikoduTxt.Text + "') ";

                    //SqlCommand kartEklemeKomutu = new SqlCommand(sorguKrediEkleme, baglanti);


                    ////-------------------------------
                    SqlCommand komutMusEkleme = new SqlCommand(sorguEkleme, baglanti);
                    int sonuc = komutMusEkleme.ExecuteNonQuery();
                   // int kartEklemesonuc = kartEklemeKomutu.ExecuteNonQuery();
                    if (sonuc == 1)
                    {
                        Bildiri.Uyari("EKELEME BAŞARILI", Bildiri.AlertType.basarili);
                        

                    }
                    Araçlarım.kirayaver.ad_soyad_txt.Text = ad_txt.Text + " " + soyad_txt.Text;
                    Araçlarım.kirayaver.ad.Text = ad_txt.Text;
                    Araçlarım.kirayaver.soyad.Text = soyad_txt.Text;
                    Araçlarım.kirayaver.tc.Text = tcKimlikNo_txt.Text;
                    Araçlarım.kirayaver.cep_tel_txt.Text = tel_txt.Text;
                    double extraToplam = Convert.ToDouble(ekstr_adresTes_txt.Text) + Convert.ToDouble(ekstr_grupFrark_Txt.Text) + Convert.ToDouble(ekstraCocuk_Txt.Text) + Convert.ToDouble(ekstraDizel_Txt.Text) + Convert.ToDouble(ekSurucu_Txt.Text) + Convert.ToDouble(ekstraGPS_Txt.Text) + Convert.ToDouble(ekstrahasar_Txt.Text) + Convert.ToDouble(ekstraMinHas_Txt.Text) + Convert.ToDouble(ekstraOgs_Txt.Text) + Convert.ToDouble(ekstraSaatFark_Txt.Text) + Convert.ToDouble(ekstaTekYon_txt.Text) + Convert.ToDouble(ekstraTrafikCez_Txt.Text);
                    kiraya_ver.ekstraToplam = extraToplam;
                    Araçlarım.kirayaver.extraTxt.Text = extraToplam.ToString();
                    Araçlarım.kirayaver.extraTxt.Visible = true;
                    Araçlarım.kirayaver.label22.Visible = true;

                    // SÖZLEŞME VERİLERİ BÖLÜMÜ

                    

                    double extraToplam2 = Convert.ToDouble(ekstr_adresTes_txt.Text) + Convert.ToDouble(ekstr_grupFrark_Txt.Text) + Convert.ToDouble(ekstraCocuk_Txt.Text) + Convert.ToDouble(ekstraDizel_Txt.Text) + Convert.ToDouble(ekSurucu_Txt.Text) + Convert.ToDouble(ekstraGPS_Txt.Text) + Convert.ToDouble(ekstrahasar_Txt.Text) + Convert.ToDouble(ekstraMinHas_Txt.Text) + Convert.ToDouble(ekstraOgs_Txt.Text) + Convert.ToDouble(ekstraSaatFark_Txt.Text) + Convert.ToDouble(ekstaTekYon_txt.Text) + Convert.ToDouble(ekstraTrafikCez_Txt.Text);
                    kiraya_ver.ekstraToplam = extraToplam;
                    Araçlarım.kirayaver.extraTxt.Visible = true;
                    Araçlarım.kirayaver.extraTxt.Text = extraToplam2.ToString();
                    Araçlarım.kirayaver.label22.Visible = true;


                    // sözleşme forum haberleşmesi

                    sozlesmeYap.kartNo1 = kartNo1Txt.Text;
                    sozlesmeYap.kartNo2 = kartNo2Text.Text;
                    sozlesmeYap.kartNo3 = kartNo3Txt.Text;
                    sozlesmeYap.kartNo4 = kartNo4Txt.Text;

                    //-------------------

                    //--guvenlik kodu

                    sozlesmeYap.guvKodu = guvenlikoduTxt.Text;

                    //------

                    //- son kull tarihi---

                    sozlesmeYap.sonKulTar = skt1Txt.Text + skt2Txt.Text;
                    //-------



                    //----------------------------


                }
                catch (Exception ev)
                {

                    Bildiri.Uyari("EKELEME BAŞARISIZ", Bildiri.AlertType.hata);
                }

                finally
                {


                    Close();

                }



            }
        }

        private void sil_btn_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void tcKimlikNo_txt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }

        }

        private void dogumTarihi_txt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                ekstr_adresTes_txt.Enabled = true;
                sozlesmeYap.yazdirma[0] = "1";
                ekstr_adresTes_txt.Focus();

            }
            else if (!checkBox4.Checked)
            {
                ekstr_adresTes_txt.Enabled = false;
                ekstr_adresTes_txt.Text = "0";

                sozlesmeYap.yazdirma[0] = null;
                sozlesmeYap.yazdirma2[0] = null;
            }
        }

        private void ekstr_adresTes_txt_TextChanged(object sender, EventArgs e)
        {
            ekstr_adresTes_txt.ForeColor = Color.Black;
        }

        private void ekstr_adresTes_txt_Leave(object sender, EventArgs e)
        {
            if (ekstr_adresTes_txt.Text == "")
            {

                ekstr_adresTes_txt.Text = "0";
                ekstr_adresTes_txt.ForeColor = Color.Gray;
            }

            else if (ekstr_adresTes_txt.Text != "0")
            {
                sozlesmeYap.yazdirma2[0] = ekstr_adresTes_txt.Text;
            }
            else if (ekstr_adresTes_txt.Text == "0")
            {
                sozlesmeYap.yazdirma2[0] = "0";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                ekstr_grupFrark_Txt.Focus();
                ekstr_grupFrark_Txt.Enabled = true;
                sozlesmeYap.yazdirma[1] = "2";

            }
            else if (!checkBox5.Checked)
            {
                ekstr_grupFrark_Txt.Enabled = false;
                ekstr_grupFrark_Txt.Text = "0";
                sozlesmeYap.yazdirma[1] = null;
                sozlesmeYap.yazdirma2[1] = null;

            }
        }

        private void ekstr_grupFrark_Txt_Leave(object sender, EventArgs e)
        {
            if (ekstr_grupFrark_Txt.Text == "")
            {

                ekstr_grupFrark_Txt.Text = "0";
                ekstr_grupFrark_Txt.ForeColor = Color.Gray;
            }

            else if (ekstr_grupFrark_Txt.Text != "0")
            {
                sozlesmeYap.yazdirma2[1] = ekstr_grupFrark_Txt.Text;
            }
            else if (ekstr_grupFrark_Txt.Text == "0")
            {
                sozlesmeYap.yazdirma2[1] = "0";
            }
        }

        private void ekstr_grupFrark_Txt_TextChanged(object sender, EventArgs e)
        {
            ekstr_grupFrark_Txt.ForeColor = Color.Black;
        }

        private void ekstraCocuk_Txt_TextChanged(object sender, EventArgs e)
        {
            ekstraCocuk_Txt.ForeColor = Color.Black;
        }

        private void ekstraDizel_Txt_TextChanged(object sender, EventArgs e)
        {
            ekstraDizel_Txt.ForeColor = Color.Black;
        }

        private void ekSurucu_Txt_TextChanged(object sender, EventArgs e)
        {
            ekSurucu_Txt.ForeColor = Color.Black;
        }

        private void ekstraGPS_Txt_TextChanged(object sender, EventArgs e)
        {
            ekstraGPS_Txt.ForeColor = Color.Black;
        }

        private void ekstrahasar_Txt_TextChanged(object sender, EventArgs e)
        {
            ekstrahasar_Txt.ForeColor = Color.Black;
        }

        private void ekstraMinHas_Txt_TextChanged(object sender, EventArgs e)
        {
            ekstraMinHas_Txt.ForeColor = Color.Black;
        }

        private void ekstraOgs_Txt_TextChanged(object sender, EventArgs e)
        {
            ekstraOgs_Txt.ForeColor = Color.Black;

        }

        private void ekstraSaatFark_Txt_TextChanged(object sender, EventArgs e)
        {
            ekstraSaatFark_Txt.ForeColor = Color.Black;
        }

        private void ekstaTekYon_txt_TextChanged(object sender, EventArgs e)
        {
            ekstaTekYon_txt.ForeColor = Color.Black;
        }

        private void ekstraTrafikCez_Txt_TextChanged(object sender, EventArgs e)
        {
            ekstraTrafikCez_Txt.ForeColor = Color.Black;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                ekstraCocuk_Txt.Enabled = true;
                sozlesmeYap.yazdirma[2] = "3";

            }
            else if (!checkBox6.Checked)
            {
                ekstraCocuk_Txt.Enabled = false;
                ekstraCocuk_Txt.Text = "0";
                sozlesmeYap.yazdirma[2] = null;
                sozlesmeYap.yazdirma2[2] = null;

            }
        }

        private void ekstraCocuk_Txt_Leave(object sender, EventArgs e)
        {
            if (ekstraCocuk_Txt.Text == "")
            {

                ekstraCocuk_Txt.Text = "0";
                ekstraCocuk_Txt.ForeColor = Color.Gray;
            }

            else if (ekstraCocuk_Txt.Text != "0")
            {
                sozlesmeYap.yazdirma2[2] = ekstraCocuk_Txt.Text;
            }
            else if (ekstraCocuk_Txt.Text == "0")
            {
                sozlesmeYap.yazdirma2[2] = "0";
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                ekstraDizel_Txt.Enabled = true;
                sozlesmeYap.yazdirma[3] = "4";

            }
            else if (!checkBox10.Checked)
            {
                ekstraDizel_Txt.Enabled = false;
                ekstraDizel_Txt.Text = "0";
                sozlesmeYap.yazdirma[3] = null;
                sozlesmeYap.yazdirma2[3] = null;

            }
        }

        private void ekstraDizel_Txt_Leave(object sender, EventArgs e)
        {

            if (ekstraDizel_Txt.Text == "")
            {

                ekstraDizel_Txt.Text = "0";
                ekstraDizel_Txt.ForeColor = Color.Gray;
            }

            else if (ekstraDizel_Txt.Text != "0")
            {
                sozlesmeYap.yazdirma2[3] = ekstraDizel_Txt.Text;
            }
            else if (ekstraDizel_Txt.Text == "0")
            {
                sozlesmeYap.yazdirma2[3] = "0";
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                ekSurucu_Txt.Enabled = true;
                sozlesmeYap.yazdirma[4] = "5";

            }
            else if (!checkBox12.Checked)
            {
                ekSurucu_Txt.Enabled = false;
                ekSurucu_Txt.Text = "0";
                sozlesmeYap.yazdirma[4] = null;
                sozlesmeYap.yazdirma2[4] = null;


            }
        }

        private void ekSurucu_Txt_Leave(object sender, EventArgs e)
        {
            if (ekSurucu_Txt.Text == "")
            {

                ekSurucu_Txt.Text = "0";
                ekSurucu_Txt.ForeColor = Color.Gray;
            }

            else if (ekSurucu_Txt.Text != "0")
            {
                sozlesmeYap.yazdirma2[4] = ekSurucu_Txt.Text;
            }
            else if (ekSurucu_Txt.Text == "0")
            {
                sozlesmeYap.yazdirma2[4] = "0";
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox14.Checked)
            {
                ekstraGPS_Txt.Enabled = true;
                sozlesmeYap.yazdirma[5] = "6";

            }
            else if (!checkBox14.Checked)
            {
                ekstraGPS_Txt.Enabled = false;
                ekstraGPS_Txt.Text = "0";
                sozlesmeYap.yazdirma[5] = null;
                sozlesmeYap.yazdirma2[5] = null;


            }
        }

        private void ekstraGPS_Txt_Leave(object sender, EventArgs e)
        {

            if (ekstraGPS_Txt.Text == "")
            {

                ekstraGPS_Txt.Text = "0";
                ekstraGPS_Txt.ForeColor = Color.Gray;
            }

            else if (ekstraGPS_Txt.Text != "0")
            {
                sozlesmeYap.yazdirma2[5] = ekstraGPS_Txt.Text;
            }
            else if (ekstraGPS_Txt.Text == "0")
            {
                sozlesmeYap.yazdirma2[5] = "0";
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                ekstrahasar_Txt.Enabled = true;
                sozlesmeYap.yazdirma[6] = "7";

            }
            else if (!checkBox7.Checked)
            {
                ekstrahasar_Txt.Enabled = false;
                ekstrahasar_Txt.Text = "0";

                sozlesmeYap.yazdirma[6] = null;
                sozlesmeYap.yazdirma2[6] = null;

            }
        }

        private void ekstrahasar_Txt_Leave(object sender, EventArgs e)
        {
            if (ekstrahasar_Txt.Text == "")
            {

                ekstrahasar_Txt.Text = "0";
                ekstrahasar_Txt.ForeColor = Color.Gray;
            }

            else if (ekstrahasar_Txt.Text != "0")
            {
                sozlesmeYap.yazdirma2[6] = ekstrahasar_Txt.Text;
            }
            else if (ekstrahasar_Txt.Text == "0")
            {
                sozlesmeYap.yazdirma2[6] = "0";
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                ekstraMinHas_Txt.Enabled = true;
                sozlesmeYap.yazdirma[7] = "8";

            }
            else if (!checkBox8.Checked)
            {
                ekstraMinHas_Txt.Enabled = false;
                ekstraMinHas_Txt.Text = "0";
                sozlesmeYap.yazdirma[7] = null;
                sozlesmeYap.yazdirma2[7] = null;


            }
        }

        private void ekstraMinHas_Txt_Leave(object sender, EventArgs e)
        {
            if (ekstraMinHas_Txt.Text == "")
            {

                ekstraMinHas_Txt.Text = "0";
                ekstraMinHas_Txt.ForeColor = Color.Gray;
            }

            else if (ekstraMinHas_Txt.Text != "0")
            {
                sozlesmeYap.yazdirma2[7] = ekstraMinHas_Txt.Text;
            }
            else if (ekstraMinHas_Txt.Text == "0")
            {
                sozlesmeYap.yazdirma2[7] = "0";
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                ekstraOgs_Txt.Enabled = true;
                sozlesmeYap.yazdirma[8] = "9";

            }
            else if (!checkBox9.Checked)
            {
                ekstraOgs_Txt.Enabled = false;
                ekstraOgs_Txt.Text = "0";
                sozlesmeYap.yazdirma[8] = null;
                sozlesmeYap.yazdirma2[8] = null;


            }
        }

        private void ekstraOgs_Txt_Leave(object sender, EventArgs e)
        {
            if (ekstraOgs_Txt.Text == "")
            {

                ekstraOgs_Txt.Text = "0";
                ekstraOgs_Txt.ForeColor = Color.Gray;
            }

            else if (ekstraOgs_Txt.Text != "0")
            {
                sozlesmeYap.yazdirma2[8] = ekstraOgs_Txt.Text;
            }
            else if (ekstraOgs_Txt.Text == "0")
            {
                sozlesmeYap.yazdirma2[8] = "0";
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                ekstraSaatFark_Txt.Enabled = true;
                sozlesmeYap.yazdirma[9] = "10";

            }
            else if (!checkBox11.Checked)
            {
                ekstraSaatFark_Txt.Enabled = false;
                ekstraSaatFark_Txt.Text = "0";
                sozlesmeYap.yazdirma[9] = null;
                sozlesmeYap.yazdirma2[9] = null;


            }
        }

        private void ekstraSaatFark_Txt_Leave(object sender, EventArgs e)
        {
            if (ekstraSaatFark_Txt.Text == "")
            {

                ekstraSaatFark_Txt.Text = "0";
                ekstraSaatFark_Txt.ForeColor = Color.Gray;
            }

            else if (ekstraSaatFark_Txt.Text != "0")
            {
                sozlesmeYap.yazdirma2[9] = ekstraSaatFark_Txt.Text;
            }
            else if (ekstraSaatFark_Txt.Text == "0")
            {
                sozlesmeYap.yazdirma2[9] = "0";
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                ekstaTekYon_txt.Enabled = true;
                sozlesmeYap.yazdirma[10] = "11";

            }
            else if (!checkBox13.Checked)
            {
                ekstaTekYon_txt.Enabled = false;
                ekstaTekYon_txt.Text = "0";
                sozlesmeYap.yazdirma[10] = null;
                sozlesmeYap.yazdirma2[10] = null;


            }
        }

        private void ekstaTekYon_txt_Leave(object sender, EventArgs e)
        {
            if (ekstaTekYon_txt.Text == "")
            {

                ekstaTekYon_txt.Text = "0";
                ekstaTekYon_txt.ForeColor = Color.Gray;
            }

            else if (ekstaTekYon_txt.Text != "0")
            {
                sozlesmeYap.yazdirma2[10] = ekstaTekYon_txt.Text;
            }
            else if (ekstaTekYon_txt.Text == "0")
            {
                sozlesmeYap.yazdirma2[10] = "0";
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                ekstraTrafikCez_Txt.Enabled = true;
                sozlesmeYap.yazdirma[11] = "12";

            }
            else if (!checkBox15.Checked)
            {
                ekstraTrafikCez_Txt.Enabled = false;
                ekstraTrafikCez_Txt.Text = "0";
                sozlesmeYap.yazdirma[11] = null;
                sozlesmeYap.yazdirma2[11] = null;


            }
        }

        private void ekstraTrafikCez_Txt_Leave(object sender, EventArgs e)
        {
            if (ekstraTrafikCez_Txt.Text == "")
            {

                ekstraTrafikCez_Txt.Text = "0";
                ekstraTrafikCez_Txt.ForeColor = Color.Gray;
            }

            else if (ekstraTrafikCez_Txt.Text != "0")
            {
                sozlesmeYap.yazdirma2[11] = ekstraTrafikCez_Txt.Text;
            }
            else if (ekstraTrafikCez_Txt.Text == "0")
            {
                sozlesmeYap.yazdirma2[11] = "0";
            }
        }

        private void ekstr_adresTes_txt_Enter(object sender, EventArgs e)
        {
            if (ekstr_adresTes_txt.Text == "0")
            {
                ekstr_adresTes_txt.Text = "";
            }
        }

        private void ekstr_grupFrark_Txt_Enter(object sender, EventArgs e)
        {

            if (ekstr_grupFrark_Txt.Text == "0")
            {
                ekstr_grupFrark_Txt.Text = "";
            }

        }

        private void ekstraCocuk_Txt_Enter(object sender, EventArgs e)
        {
            if (ekstraCocuk_Txt.Text == "0")
            {
                ekstraCocuk_Txt.Text = "";
            }
        }

        private void ekstraDizel_Txt_Enter(object sender, EventArgs e)
        {
            if (ekstraDizel_Txt.Text == "0")
            {
                ekstraDizel_Txt.Text = "";
            }
        }

        private void ekSurucu_Txt_Enter(object sender, EventArgs e)
        {
            if (ekSurucu_Txt.Text == "0")
            {
                ekSurucu_Txt.Text = "";
            }
        }

        private void ekstraGPS_Txt_Enter(object sender, EventArgs e)
        {
            if (ekstraGPS_Txt.Text == "0")
            {
                ekstraGPS_Txt.Text = "";
            }
        }

        private void ekstrahasar_Txt_Enter(object sender, EventArgs e)
        {
            if (ekstrahasar_Txt.Text == "0")
            {
                ekstrahasar_Txt.Text = "";
            }
        }

        private void ekstraMinHas_Txt_Enter(object sender, EventArgs e)
        {
            if (ekstraMinHas_Txt.Text == "0")
            {
                ekstraMinHas_Txt.Text = "";
            }
        }

        private void ekstraOgs_Txt_Enter(object sender, EventArgs e)
        {

            if (ekstraOgs_Txt.Text == "0")
            {
                ekstraOgs_Txt.Text = "";
            }
        }

        private void ekstraSaatFark_Txt_Enter(object sender, EventArgs e)
        {

            if (ekstraSaatFark_Txt.Text == "0")
            {
                ekstraSaatFark_Txt.Text = "";
            }
        }

        private void ekstaTekYon_txt_Enter(object sender, EventArgs e)
        {
            if (ekstaTekYon_txt.Text == "0")
            {
                ekstaTekYon_txt.Text = "";
            }
        }

        private void ekstraTrafikCez_Txt_Enter(object sender, EventArgs e)
        {
            if (ekstaTekYon_txt.Text == "0")
            {
                ekstaTekYon_txt.Text = "";
            }
        }
    }
}
