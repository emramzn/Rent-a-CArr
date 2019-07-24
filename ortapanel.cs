using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_A_Car
{
    public partial class ortapanel : UserControl
    {
        public ortapanel()
        {
            InitializeComponent();
        }

        private void musterilerimbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void kirayaver1_Click(object sender, EventArgs e)
        {
            kiraya_ver kv = new kiraya_ver();
            kv.Show();
        }

        private void teslimalbtn_Click(object sender, EventArgs e)
        {
            teslimal ta = new teslimal();
            ta.Show();
        }

        private void araclarimbtn_Click(object sender, EventArgs e)
        {
            
            
        }

        private void kirayaver1_Click_1(object sender, EventArgs e)
        {
            
            
            
            

        }

        private void musterilerimbtn_Click_1(object sender, EventArgs e)
        {
            


        }

        private void ayarlarbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void araclarimbtn_Click_1(object sender, EventArgs e)
        {
           
           
            
        }

        private void teslimalbtn_Click_1(object sender, EventArgs e)
        {
            
            
            
        }

        private void ortapanel_Load(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void faturabtn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void kirayaver1_Click_2(object sender, EventArgs e)
        {
            Araçlarım.kirayaver.ShowDialog();
        }

        private void musterilerimbtn_Click_2(object sender, EventArgs e)
        {
            Musterilerim ms = new Musterilerim();
            ms.Show();
        }

        private void ayarlarbtn_Click_1(object sender, EventArgs e)
        {
            Ayarlar ayr = new Ayarlar();
            ayr.Show();
        }

        private void araclarimbtn_Click_2(object sender, EventArgs e)
        {
            Araçlarım ar = new Araçlarım();
            ar.Show();
        }

        private void teslimalbtn_Click_2(object sender, EventArgs e)
        {
            kiradakiler kirada = new kiradakiler();
            kirada.ShowDialog();

        }

        private void faturabtn_Click_1(object sender, EventArgs e)
        {
            OPALFATURA fatura = new OPALFATURA();
            fatura.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string a = "merhaba";
            Bildiri.Uyari(a, Bildiri.AlertType.basarili);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Bildiri.Uyari("Herkese Merhaba", Bildiri.AlertType.bilgi);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Bildiri.Uyari("Herkese Merhaba", Bildiri.AlertType.dikkat);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Bildiri.Uyari("Herkese Merhaba", Bildiri.AlertType.hata);
        }
    }
}
