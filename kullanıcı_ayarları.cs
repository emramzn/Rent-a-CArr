using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Rent_A_Car
{
    
    public partial class kullanıcı_ayarları : UserControl
    {
        SqlConnection baglanti = database.baglan();
        public kullanıcı_ayarları()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (sifre_txt.Text == sifreTekrar_txt.Text)
            {
                try
                {
                    DateTime biraysonra = DateTime.Today.AddDays(30);
                    string cumle = "insert into sifre_tablo(kulad,sifre,ad,soyad,kayit_tarihi) values('" + kulad_txt.Text + "','" + sifre_txt.Text + "','" + ad_txt.Text + "','" + soyad_txt.Text + "','" + tarih_belirle(biraysonra.ToString()) + "')";
                    SqlCommand cmd = new SqlCommand(cumle, baglanti);
                    cmd.ExecuteNonQuery();
                    Bildiri.Uyari("KAYIT BAŞARILI!!", Bildiri.AlertType.basarili);
                    kulad_txt.Text = "";
                    sifreTekrar_txt.Text = "";
                    sifre_txt.Text = "";
                    ad_txt.Text = "";
                    soyad_txt.Text = "";
                }
                catch
                {
                    Bildiri.Uyari("KAYIT YAPILAMADI!!", Bildiri.AlertType.hata);
                }
            }
            else
            {
                Bildiri.Uyari("ŞİFRELER AYNI DEĞİL!", Bildiri.AlertType.hata);
            }
           
        }

        private void kullanıcı_ayarları_Load(object sender, EventArgs e)
        {

        }
        public string tarih_belirle(string tarih)
        {
            string donus = "";
            foreach (char i in tarih)
            {
                if (i.ToString() == " ")
                    break;
                donus += i.ToString();

            }

            return donus;
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
