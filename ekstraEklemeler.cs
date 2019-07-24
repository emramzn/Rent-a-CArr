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
    public partial class ekstraEklemeler : Form
    {
        public ekstraEklemeler()
        {
            InitializeComponent();
        }
        SqlConnection connect = database.baglan();
        public static string tcKimlikNo { get; set; }


        private void kaydet_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(" " + ekstr_adresTes_txt.Text + "\n" + ekstraTrafikCez_Txt.Text + " \n" + ekstraSaatFark_Txt.Text + " \n" + ekstraOgs_Txt.Text + " \n" + ekstraMinHas_Txt.Text + " \n" + ekstrahasar_Txt.Text + "\n " + ekstraGPS_Txt.Text + " \n" + ekstraDizel_Txt.Text + "\n " + ekstraCocuk_Txt.Text + "\n " + ekstaTekYon_txt.Text + "\n " + ekstr_grupFrark_Txt.Text + "\n" + ekSurucu_Txt.Text);
            double extraToplam = Convert.ToDouble(ekstr_adresTes_txt.Text) + Convert.ToDouble(ekstr_grupFrark_Txt.Text) + Convert.ToDouble(ekstraCocuk_Txt.Text) + Convert.ToDouble(ekstraDizel_Txt.Text) + Convert.ToDouble(ekSurucu_Txt.Text) + Convert.ToDouble(ekstraGPS_Txt.Text) + Convert.ToDouble(ekstrahasar_Txt.Text) + Convert.ToDouble(ekstraMinHas_Txt.Text) + Convert.ToDouble(ekstraOgs_Txt.Text) + Convert.ToDouble(ekstraSaatFark_Txt.Text) + Convert.ToDouble(ekstaTekYon_txt.Text) + Convert.ToDouble(ekstraTrafikCez_Txt.Text);
            kiraya_ver.ekstraToplam = extraToplam;//*(int.Parse(kiraya_ver.gunsayisi));
            Araçlarım.kirayaver.extraTxt.Visible = true;
            Araçlarım.kirayaver.extraTxt.Text = extraToplam.ToString();
            Araçlarım.kirayaver.label22.Visible = true;
           Araçlarım.kirayaver.hesapla_btn.Enabled = true;
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



            Close();
        }  

        private void kartNo1Txt_TextChanged(object sender, EventArgs e)
        {
            if (kartNo1Txt.Text.Length == 4)
            {
                kartNo2Text.Focus();
            }
        }

        private void kartNo2Text_TextChanged(object sender, EventArgs e)
        {
            if (kartNo2Text.Text.Length == 4)
            {
                kartNo3Txt.Focus();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

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

        private void skt1Txt_TextChanged(object sender, EventArgs e)
        {
            if (skt1Txt.Text.Length == 2)
            {
                skt2Txt.Focus();
            }
        }

        private void skt2Txt_TextChanged(object sender, EventArgs e)
        {

            if (skt2Txt.Text.Length == 4)

            {
                checkBox4.Focus();
            }
        }

        private void guvenlikoduTxt_TextChanged(object sender, EventArgs e)
        {
            if (guvenlikoduTxt.Text.Length == 3)
            {
                skt1Txt.Focus();

            }
        }

        private void ekstraEklemeler_Load(object sender, EventArgs e)
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


            //string varMi = "select count(*) kartNo from  tabloKrediKarti  where tcKimlikNo='" + tcKimlikNo + "'";
            //SqlCommand kartVarMi = new SqlCommand(varMi, connect);
            //kartVarMi.ExecuteScalar();
           
            //MessageBox.Show(kartVarMi.ToString());
            //if (kartVarMi.ToString() == "1")
            //{


            //    try
            //    {

            //        //--kredi kartı bilgi çekim işlemleri
            //        // MessageBox.Show("" + tcKimlikNo);
            //        string cardInf = "", kartno = "", skt = "", guvNo = "";



            //        string cardREAD = "select kartSinifi,kartNo,sonKulTarihi,guvenlikNo from  tabloKrediKarti  where tcKimlikNo='" + tcKimlikNo + "'";
            //        SqlCommand cmdCardRead = new SqlCommand(cardREAD, connect);
            //        SqlDataReader readerCart = cmdCardRead.ExecuteReader();



            //        if (readerCart.Read())
            //        {

            //            cardInf = readerCart["kartSinifi"].ToString();
            //            kartno = readerCart["kartNo"].ToString();
            //            skt = readerCart["sonKulTarihi"].ToString();//+readerCart["sonKulTarihi"].ToString()[1];
            //            guvenlikoduTxt.Text = readerCart["guvenlikNo"].ToString();

            //            skt1Txt.Text = skt[0].ToString() + skt[1].ToString();
            //            skt2Txt.Text = skt[3].ToString() + skt[4].ToString() + skt[5].ToString() + skt[6].ToString();



            //        }


            //        //guvenlikoduTxt.Text = cardInf[26].ToString() + cardInf[27].ToString() + cardInf[28].ToString();
            //        int bir = 0, iki = 5, uc = 10, dort = 15;
            //        if (kartNo1Txt.Text != null && kartNo2Text.Text != null && kartNo3Txt.Text != null && kartNo4Txt.Text != null)
            //        {

            //            for (int i = 0; i < 4; i++)
            //            {
            //                kartNo1Txt.Text += kartno[bir + i].ToString();
            //                kartNo2Text.Text += kartno[iki + i].ToString();
            //                kartNo3Txt.Text += kartno[uc + i].ToString();
            //                kartNo4Txt.Text += kartno[dort + i].ToString();

            //            }


            //        }




            //        //MessageBox.Show(cardInformation);
            //        //--------------------
            //    }
            //    catch (Exception err)
            //    {

            //        // Bildiri.Uyari("BİLİNMEYEN HATA!! kart", Bildiri.AlertType.dikkat);
            //        MessageBox.Show(err.Message);
            //    }

            //}
        }

        private void ekstr_adresTes_txt_TextChanged(object sender, EventArgs e)
        {
            ekstr_adresTes_txt.ForeColor = Color.Black;
        }

        private void ekstr_adresTes_txt_Enter(object sender, EventArgs e)
        {
            if (ekstr_adresTes_txt.Text == "0")
            {
                ekstr_adresTes_txt.Text = "";
            }
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
            if (ekstraTrafikCez_Txt.Text == "0")
            {
                ekstraTrafikCez_Txt.Text = "";
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

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                ekstr_adresTes_txt.Enabled = true;
                sozlesmeYap.yazdirma[0] = "1";

            }
            else if(!checkBox4.Checked)
            {
                ekstr_adresTes_txt.Enabled = false;
                ekstr_adresTes_txt.Text = "0";

                sozlesmeYap.yazdirma[0] = null;
                sozlesmeYap.yazdirma2[0] = null;
            }
                
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
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

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                ekstraCocuk_Txt.Focus();
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

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {

                ekstraDizel_Txt.Focus();
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

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {

                ekSurucu_Txt.Focus();
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

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {
                ekstraGPS_Txt.Focus();
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

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox7.Checked)
            {
                ekstrahasar_Txt.Focus();
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

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox8.Checked)
            {
                ekstraMinHas_Txt.Focus();
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

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                ekstraOgs_Txt.Focus();
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

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                ekstraSaatFark_Txt.Focus();
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

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                ekstaTekYon_txt.Focus();
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

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                ekstraTrafikCez_Txt.Focus();
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
