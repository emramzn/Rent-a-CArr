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
    public partial class musteriGecmisKiralama : Form
    {
        public musteriGecmisKiralama()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = database.baglan();
        public  string tcKimlikNo { get; set; }
        private void musteriGecmisKiralama_Load(object sender, EventArgs e)
        {
            try
            {


                string listele = "select plaka,marka,tarih,teslimatTarihi,ucret from musteriGecmisi";
                SqlCommand komutBilgiGetir = new SqlCommand(listele, baglanti);
                SqlDataAdapter adapter1 = new SqlDataAdapter(komutBilgiGetir);
                DataSet dataSetBilgiler = new DataSet();
                adapter1.Fill(dataSetBilgiler, "musteriGecmisi");
                musteriKiralama_dataGrid.DataSource = dataSetBilgiler.Tables["musteriGecmisi"];


            }
            catch (Exception err)
            {

                Bildiri.Uyari("BİLİNMEYEN HATA!!", Bildiri.AlertType.hata);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
