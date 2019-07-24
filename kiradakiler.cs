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
    public partial class kiradakiler : Form
    {
        SqlConnection baglanti = database.baglan();
        public kiradakiler()
        {
            InitializeComponent();
        }
        private void kiradakiler_Load(object sender, EventArgs e)
        {
            gosterkirada(kiradakiler_datagrid);
            kiradakiler_datagrid.Columns[0].HeaderText = "PLAKA";
            kiradakiler_datagrid.Columns[1].HeaderText = "AD";
            kiradakiler_datagrid.Columns[2].HeaderText = "SOYAD";
            kiradakiler_datagrid.Columns[3].HeaderText = "TELEFON";
            kiradakiler_datagrid.Columns[4].HeaderText = "KİR.TARH.";
            kiradakiler_datagrid.Columns[5].HeaderText = "KİR.SAATİ";
            kiradakiler_datagrid.Columns[6].HeaderText = "TES.TARH.";
            kiradakiler_datagrid.Columns[7].HeaderText = "TES.SAATİ";
        }
        public void gosterkirada(DataGridView dtgrt)
        {
            try
            {
                string gosterilecek = "select aracPlaka,kiralayanAdi,kiralayanSoyad,kiralayanTelefon,kiralananTarih,kiralananSaat,teslimatTarih,teslimatSaat,durum from aracGecmisKiralama  where durum='alınmadı'";
                SqlCommand cmd = new SqlCommand(gosterilecek, baglanti);
                SqlDataAdapter adptr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adptr.Fill(ds, "aracGecmisKiralama");
                kiradakiler_datagrid.DataSource = ds.Tables["aracGecmisKiralama"];
                kiradakiler_datagrid.Columns["durum"].Visible = false;
            }
            catch
            {

                Bildiri.Uyari("BİLİNMEYEN BİR HATAOLUŞTU!!!", Bildiri.AlertType.dikkat);
            }
          

        }
        private void teslimal_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if ("alinmadi" == kiradakiler_datagrid.CurrentRow.Cells[8].Value.ToString())
                {
                    teslimal teslim = new teslimal();
                    teslim.plaka_txt.Text = kiradakiler_datagrid.CurrentRow.Cells[0].Value.ToString();
                    teslim.ShowDialog();
                    gosterkirada(kiradakiler_datagrid);
                }
                else
                {
                    Bildiri.Uyari("araç kirada olmadığı için teslim alınamıyor", Bildiri.AlertType.dikkat);
                }
            }
            catch
            {

            }

        }

        private void kiradakiler_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kiradakiler_Load_1(object sender, EventArgs e)
        {
            gosterkirada(kiradakiler_datagrid);
            kiradakiler_datagrid.Columns[0].HeaderText = "PLAKA";
            kiradakiler_datagrid.Columns[1].HeaderText = "AD";
            kiradakiler_datagrid.Columns[2].HeaderText = "SOYAD";
            kiradakiler_datagrid.Columns[3].HeaderText = "TELEFON";
            kiradakiler_datagrid.Columns[4].HeaderText = "KİR.TARH.";
            kiradakiler_datagrid.Columns[5].HeaderText = "KİR.SAATİ";
            kiradakiler_datagrid.Columns[6].HeaderText = "TES.TARH.";
            kiradakiler_datagrid.Columns[7].HeaderText = "TES.SAATİ";
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
