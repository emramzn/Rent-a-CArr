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
    public partial class ikinciSoforSec : Form
    {
        SqlConnection baglanti = database.baglan();
        public ikinciSoforSec()
        {
            InitializeComponent();
        }
        void goster(string a, DataGridView dtgrt)
        {

            string gosterilecek = "";

            gosterilecek = "select*from " + a + " where tc_birinci='" + tc.Text + "'";//= "select * from " + a;// +"where tc_birinci='"+tc.Text+"'";
            ////}


            SqlCommand cmd = new SqlCommand(gosterilecek, baglanti);
            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adptr.Fill(ds, a);
            dtgrt.DataSource = ds.Tables[a];
            dtgrt.Columns["ID"].Visible = false;
            dtgrt.Columns["tc_birinci"].Visible = false;
            dtgrt.Columns["tc"].Visible = false;
            dtgrt.Columns["dogumTarihi"].Visible = false;
            dtgrt.Columns["dogumYeri"].Visible = false;
            dtgrt.Columns["pasaportNo"].Visible = false;
            dtgrt.Columns["pasaportVerilisTarihi"].Visible = false;
            dtgrt.Columns["pasaportVerilisYeri"].Visible = false;
            dtgrt.Columns["ehliyetNo"].Visible = false;
            dtgrt.Columns["ehliyetVerilisTarihi"].Visible = false;
            dtgrt.Columns["ehliyetVerilisYeri"].Visible = false;

        }
        private void ikinciSoforSec_Load(object sender, EventArgs e)
        {
            goster("ikinciSofor", musteriler_datagrid);
        }

        private void sec_btn_Click(object sender, EventArgs e)
        {
            Araçlarım.kirayaver.tc_2.Text = musteriler_datagrid.CurrentRow.Cells[1].Value.ToString();
            Araçlarım.kirayaver.ad_soyad_txt_2.Text = musteriler_datagrid.CurrentRow.Cells[2].Value.ToString();
            Araçlarım.kirayaver.cep_tel_txt_2.Text = musteriler_datagrid.CurrentRow.Cells[6].Value.ToString();
            Hide();
        }

        private void bul_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string gosterilecek = "select * from ikinciSofor where adSoyad like  '" + bul_txt.Text + "%' or adres like'" + bul_txt.Text + "%' or tc like'" + bul_txt.Text + "%'";
                SqlCommand cmd = new SqlCommand(gosterilecek, baglanti);
                SqlDataAdapter adptr = new SqlDataAdapter(cmd);
                DataSet dst = new DataSet();
                adptr.Fill(dst, "ikinciSofor");
                musteriler_datagrid.DataSource = dst.Tables["ikinciSofor"];
            }
            catch (Exception EX)
            {

                Bildiri.Uyari("BİLİNMEYEN BİR HATAOLUŞTU!!!", Bildiri.AlertType.dikkat);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void iptal_btn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void musteriler_datagrid_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Araçlarım.kirayaver.tc_2.Text = musteriler_datagrid.CurrentRow.Cells[1].Value.ToString();
                Araçlarım.kirayaver.ad_soyad_txt_2.Text = musteriler_datagrid.CurrentRow.Cells[2].Value.ToString();
                Araçlarım.kirayaver.cep_tel_txt_2.Text = musteriler_datagrid.CurrentRow.Cells[6].Value.ToString();
                Hide();
            }
            catch
            {

                Bildiri.Uyari("BİLİNMEYEN BİR HATAOLUŞTU!!!", Bildiri.AlertType.dikkat);
            }
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
