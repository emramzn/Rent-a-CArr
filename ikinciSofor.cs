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
    public partial class ikinciSofor : Form
    {
        public ikinciSofor()
        {
            InitializeComponent();
        }
        public static SqlConnection baglanti = database.baglan();
        private void button1_Click(object sender, EventArgs e)
        {
            if (netControl.InternetKontrol() == true)
            {

                string cumle = "insert into ikinciSofor(tc_birinci,adSoyad,adres,telefon,tc,cepTelefon,dogumTarihi,dogumYeri,pasaportNo,pasaportVerilisYeri,pasaportVerilisTarihi,ehliyetNo,ehliyetVerilisYeri,ehliyetVerilisTarihi) values('" + birinci_tc.Text + "','" + ad_soyad_txt.Text + "','" + adres_txt.Text + "','" + telefon_txt.Text + "','" + tc_txt.Text + "','" + cepTelefon_txt.Text + "','" + dogum_tarihi_txt.Text + "','" + dogum_yeri_txt.Text + "','" + pasaport_no_txt.Text + "','" + pasaport_verilis_yeri_txt.Text + "','" + pasaport_verilis_tarihi_txt.Text + "','" + ehliyet_no_txt.Text + "','" + ehliyet_verilis_yeri_txt.Text + "','" + ehliyet_verilis_tarihi_txt.Text + "')";
                SqlCommand cmd = new SqlCommand(cumle, baglanti);
                cmd.ExecuteNonQuery();
                Araçlarım.kirayaver.tc_2.Text = tc_txt.Text;
                Araçlarım.kirayaver.ad_soyad_txt_2.Text = adres_txt.Text;
                Araçlarım.kirayaver.cep_tel_txt_2.Text = cepTelefon_txt.Text;
                Hide();
            }
            else
            {

                Bildiri.Uyari("LÜTFEN İNTERNET BAĞLANTISINI KONTROL EDİN!!", Bildiri.AlertType.dikkat);
            }
            Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ikinciSofor_Load(object sender, EventArgs e)
        {

        }
    }
}
