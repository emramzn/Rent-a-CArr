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
    public partial class SigortaMuayeneKasko : Form
    {
        SqlConnection baglanti = database.baglan();
        public SigortaMuayeneKasko()
        {
            InitializeComponent();
        }

        private void SigortaMuayeneKasko_Load(object sender, EventArgs e)
        {

        }
        void goster(string a, DataGridView dtgrt)
        {


            ////}


            SqlCommand cmd = new SqlCommand(a, baglanti);
            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adptr.Fill(ds, "tabloAraclar");
            dtgrt.DataSource = ds.Tables["tabloAraclar"];
            dtgrt.Columns["arac_ID"].Visible = false;
            dtgrt.Columns["silindir"].Visible = false;
            dtgrt.Columns["sigortaTarihi"].Visible = false;
            dtgrt.Columns["kaskoTarihi"].Visible = false;
            dtgrt.Columns["muayeneTarihi"].Visible = false;
            dtgrt.Columns["emisyonTarihi"].Visible = false;
            dtgrt.Columns["izinBitis"].Visible = false;
            dtgrt.Columns["bakimPeriyodu"].Visible = false;
            dtgrt.Columns["yasakDurumu"].Visible = false;

        }
        public void dondur(string gun)
        {
            DateTime yarın;
            if (gun == "bir")
            {
                yarın = DateTime.Today.AddDays(1);

            }
            else if (gun == "uc")
            {
                yarın = DateTime.Today.AddDays(3);

            }
            else if (gun == "yedi")
            {
                yarın = DateTime.Today.AddDays(7);

            }
            else if (gun == "on")
            {
                yarın = DateTime.Today.AddDays(10);

            }
            else
            {
                yarın = DateTime.Today.AddDays(10);
            }

            if (sorguolc1_cmb.Text == "SİGORTA")
            {
                goster("select*from tabloAraclar where sigortaTarihi='" + tarih_belirle(yarın.ToString()) + "'", gosterilecek_datagrid);
            }
            else if (sorguolc1_cmb.Text == "KASKO")
            {
                goster("select*from tabloAraclar where kaskoTarihi='" + yarın.ToString() + "'", gosterilecek_datagrid);
            }
            else if (sorguolc1_cmb.Text == "MUAYENE")
            {
                goster("select*from tabloAraclar where muayeneTarihi='" + yarın.ToString() + "'", gosterilecek_datagrid);
            }
            else if (sorguolc1_cmb.Text == "EMİSYON")
            {
                goster("select*from tabloAraclar where emisyonTarihi='" + yarın.ToString() + "'", gosterilecek_datagrid);
            }
            else if (sorguolc1_cmb.Text == "İZİN")
            {
                goster("select*from tabloAraclar where izinBitis='" + yarın.ToString() + "'", gosterilecek_datagrid);
            }
            else
            {
                //TARİHİ GEÇENLERİ BURADA GÖSTERECEĞİZ))
            }
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

        private void son1gun_btn_Click(object sender, EventArgs e)
        {
            dondur("bir");
        }

        private void son3gun_btn_Click(object sender, EventArgs e)
        {
            dondur("uc");
        }

        private void son1hafta_btn_Click(object sender, EventArgs e)
        {
            dondur("yedi");
        }

        private void son10gun_btn_Click(object sender, EventArgs e)
        {
            dondur("on");
        }

        private void tarihigecen_btn_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Today;
            if (sorguolc1_cmb.Text == "SİGORTA")
            {
                goster("select*from tabloAraclar where sigortaTarihi between '10.10.2000' and '" + bugun.ToString() + "'", gosterilecek_datagrid);
            }
            else if (sorguolc1_cmb.Text == "KASKO")
            {
                goster("select*from tabloAraclar where kaskoTarihi between '10.10.1000' and '" + bugun.ToString() + "'", gosterilecek_datagrid);
            }
            else if (sorguolc1_cmb.Text == "MUAYENE")
            {
                goster("select*from tabloAraclar where muayeneTarihi between '10.10.1000' and '" + bugun.ToString() + "'", gosterilecek_datagrid);
            }
            else if (sorguolc1_cmb.Text == "EMİSYON")
            {
                goster("select*from tabloAraclar where emisyonTarihi between '10.10.1000' and '" + bugun.ToString() + "'", gosterilecek_datagrid);
            }
            else if (sorguolc1_cmb.Text == "İZİN")
            {
                goster("select*from tabloAraclar where izinBitis between '10.10.1000' and '" + bugun.ToString() + "'", gosterilecek_datagrid);
            }
        }

        public void arasinigoster()
        {
            if (sorguolc2_cmb.Text == "SİGORTA")
            {
                goster("select*from tabloAraclar where sigortaTarihi between '" + tarihbas_time.Text + "'and'" + tarihson_time.Text + "'", gosterilecek_datagrid);
            }
            else if (sorguolc2_cmb.Text == "KASKO")
            {
                goster("select*from tabloAraclar where kaskoTarihi between '" + tarihbas_time.Text + "'and'" + tarihson_time.Text + "'", gosterilecek_datagrid);
            }
            else if (sorguolc2_cmb.Text == "MUAYENE")
            {
                goster("select*from tabloAraclar where muayeneTarihi between '" + tarihbas_time.Text + "'and'" + tarihson_time.Text + "'", gosterilecek_datagrid);
            }
            else if (sorguolc2_cmb.Text == "EMİSYON")
            {
                goster("select*from tabloAraclar where emisyonTarihi between '" + tarihbas_time.Text + "'and'" + tarihson_time.Text + "'", gosterilecek_datagrid);
            }
            else if (sorguolc2_cmb.Text == "İZİN")
            {
                goster("select*from tabloAraclar where izinBitis between '" + tarihbas_time.Text + "'and'" + tarihson_time.Text + "'", gosterilecek_datagrid);
            }
        }

        private void listele_btn_Click(object sender, EventArgs e)
        {
            arasinigoster();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kapat_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
