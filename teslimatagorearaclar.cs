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
    public partial class teslimatagorearaclar : UserControl
    {
        SqlConnection baglanti = database.baglan();
        public teslimatagorearaclar()
        {
            InitializeComponent();
        }

        private void tum_araclar_btn_Click(object sender, EventArgs e)
        {
            goster("select*from aracGecmisKiralama where durum='alınmadı'");
        }
        public void goster(string secim)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(secim, baglanti);
                SqlDataAdapter adptr = new SqlDataAdapter(cmd);
                DataSet dst = new DataSet();
                adptr.Fill(dst, "aracGecmisKiralama");
                araclar_datagrid.DataSource = dst.Tables["aracGecmisKiralama"];
                araclar_datagrid.Columns["ID"].Visible = false;
                araclar_datagrid.Columns["km"].Visible = false;
                araclar_datagrid.Columns["ucret"].Visible = false;
                araclar_datagrid.Columns["kiralananSaat"].Visible = false;
                araclar_datagrid.Columns["kiralananTarih"].Visible = false;
                araclar_datagrid.Columns["durum"].Visible = false;
            }
            catch
            {

                Bildiri.Uyari("BİLİNMEYEN HATA!!", Bildiri.AlertType.hata);
            }

        }

        private void butarihgoster_lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            goster("select*from aracGecmisKiralama where durum='alınmadı' and teslimatTarih='" + belli_time.Text + "'");
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void teslimatagorearaclar_Load(object sender, EventArgs e)
        {
            goster("select*from aracGecmisKiralama where durum='alınmadı' and teslimatTarih='" + bugun_time.Text + "'");
        }

        private void bugungoster_lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            goster("select*from aracGecmisKiralama where durum='alınmadı' and teslimatTarih='" + bugun_time.Text + "'");

        }
    }
}
