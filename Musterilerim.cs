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
    public partial class Musterilerim : Form
    {
        public BorderStyle BorderStyle { get; set; }
        public Musterilerim()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        int SimdikiWidth = 1366;
        int SimdikiHeight = 768;
        SqlConnection datas = database.baglan();
        void dataListele() // MÜŞTERİ BİLG,İLERİ DATAGRİDVİEV'İ DOLDURUR  
        {

            string listele = "select * from musteriler";
            SqlCommand komutBilgiGetir = new SqlCommand(listele, datas);
            SqlDataAdapter adapter1 = new SqlDataAdapter(komutBilgiGetir);
            DataSet dataSetBilgiler = new DataSet();
            adapter1.Fill(dataSetBilgiler, "musteriler");
            musteriBilgileri_dataGrid.DataSource = dataSetBilgiler.Tables["musteriler"];



        }
        public static string musteriSayisi { get; set; }
        private void Müşterilerim_Load(object sender, EventArgs e)
        {
            this.musteriBilgileri_dataGrid.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.musteriBilgileri_dataGrid.DefaultCellStyle.ForeColor = Color.Black;
            this.musteriBilgileri_dataGrid.DefaultCellStyle.BackColor = Color.Beige;
            this.musteriBilgileri_dataGrid.DefaultCellStyle.SelectionForeColor = Color.White;
            this.musteriBilgileri_dataGrid.DefaultCellStyle.SelectionBackColor = Color.Black;

            MusteriArama_Txt.Text = "AD,SOYAD,TELEFON";
            MusteriArama_Txt.ForeColor = Color.Gray;


            dataListele();

            Rectangle ClientCozunurluk = new Rectangle();

            ClientCozunurluk = Screen.GetBounds(ClientCozunurluk);

            float OranWidth = ((float)ClientCozunurluk.Width / (float)SimdikiWidth);

            float OranHeight = ((float)ClientCozunurluk.Height / (float)SimdikiHeight);

            this.Scale(OranWidth, OranHeight);

            label8.Text = "Sistemde "+musteriSayisi+" müşteri kayıtlı.";
        }
       

        
        public static string TcKimlikNo { get; set; }
        private void krediKartiBilgileri_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void musteriTuru_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void duzenle_btn_Click(object sender, EventArgs e)
        {
            

        }

        private void cariKartiAc_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void aracKirala_btn_Click(object sender, EventArgs e)
        {
           // kiraya_ver kirayaver = new kiraya_ver();
            //kirayaver.ShowDialog();
        }

        private void musteriBilgileri_dataGrid_DoubleClick(object sender, EventArgs e)
        {

            musteribilgileriduzenle duzenleMusteriBilgi = new musteribilgileriduzenle();



            duzenleMusteriBilgi.tcKimlikNo_txt.Text = musteriBilgileri_dataGrid.CurrentRow.Cells[0].Value.ToString();
            duzenleMusteriBilgi.musteriAdi_txt.Text = musteriBilgileri_dataGrid.CurrentRow.Cells[1].Value.ToString();
            duzenleMusteriBilgi.musteriSoyadi_txt.Text = musteriBilgileri_dataGrid.CurrentRow.Cells[2].Value.ToString();
            duzenleMusteriBilgi.musteriTel_txt.Text = musteriBilgileri_dataGrid.CurrentRow.Cells[3].Value.ToString();
            duzenleMusteriBilgi.musteriCep1_txt.Text = musteriBilgileri_dataGrid.CurrentRow.Cells[4].Value.ToString();
            duzenleMusteriBilgi.musteriCep2_txt.Text = musteriBilgileri_dataGrid.CurrentRow.Cells[5].Value.ToString();
            duzenleMusteriBilgi.musteriAdres_txt.Text = musteriBilgileri_dataGrid.CurrentRow.Cells[6].Value.ToString();
            duzenleMusteriBilgi.musteriMail.Text = musteriBilgileri_dataGrid.CurrentRow.Cells[7].Value.ToString();
            duzenleMusteriBilgi.musteriEkBilgi_txt.Text = musteriBilgileri_dataGrid.CurrentRow.Cells[8].Value.ToString();
        





            string sorguDuzenle = "select ehliyetil,ehliyetilce,ehliyetBelgeNo,ehliyetVerilisTarihi,ehliyetKullanilanCihaz,ehliyetDuzenleyen,pasaNo,pasaVerildigiYer,pasaVerilisTarihi from musteriBelgeleriTablosu  where tcKimlikNo='" + musteriBilgileri_dataGrid.CurrentRow.Cells[0].Value.ToString() + "'";
            SqlCommand komutBelge = new SqlCommand(sorguDuzenle, datas);

            SqlDataReader belgeOku = komutBelge.ExecuteReader();

            if (belgeOku.Read())
            {

                duzenleMusteriBilgi.ehliyetil_txt.Text = belgeOku["ehliyetil"].ToString();
                duzenleMusteriBilgi.ehliyetilce_txt.Text = belgeOku["ehliyetilce"].ToString();
                duzenleMusteriBilgi.ehliyetBelgeNo_txt.Text = belgeOku["ehliyetBelgeNo"].ToString();
                duzenleMusteriBilgi.ehlVerilisTarihi_dateTime.Text = belgeOku["ehliyetVerilisTarihi"].ToString();
                duzenleMusteriBilgi.kullCihaz_txt.Text = belgeOku["ehliyetKullanilanCihaz"].ToString();
                duzenleMusteriBilgi.duzenleyen_txt.Text = belgeOku["ehliyetDuzenleyen"].ToString();
                duzenleMusteriBilgi.pasaportNo_txt.Text = belgeOku["pasaNo"].ToString();
                duzenleMusteriBilgi.pasaportVerilYer_txt.Text = belgeOku["pasaVerildigiYer"].ToString();
                duzenleMusteriBilgi.pasaportVerilisTarihi_dateTime.Text = belgeOku["pasaVerilisTarihi"].ToString();


            }



            belgeOku.Close();
            duzenleMusteriBilgi.Show();
            
        }

        private void Müşterilerim_Activated(object sender, EventArgs e)
        {
            dataListele();
        }

        private void yazdir_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void gecmisKiralamalar_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void MusteriArama_Txt_TextChanged(object sender, EventArgs e)
        {

            MusteriArama_Txt.ForeColor = Color.Black;
          
                try
                {
                    if (MusteriArama_Txt.Text.Length > 2)
                    {


                        string gosterilecek = "select * from musteriler where tcKimlikNo like '" + MusteriArama_Txt.Text + "%' or ad like'" + MusteriArama_Txt.Text + "%' or soyad like'" + MusteriArama_Txt.Text + "%' or telefon like'" + MusteriArama_Txt.Text + "%'";

                        SqlCommand cmd = new SqlCommand(gosterilecek, datas);
                        SqlDataAdapter adptr = new SqlDataAdapter(cmd);
                        DataSet dst = new DataSet();
                        adptr.Fill(dst, "musteriler");
                        musteriBilgileri_dataGrid.DataSource = dst.Tables["musteriler"];
                    }
                }
                catch 
                {

                Bildiri.Uyari("BİLİNMEYEN HATA!!", Bildiri.AlertType.hata);
                }


            }
           
        

        private void MusteriArama_Txt_Leave(object sender, EventArgs e)
        {
            if (MusteriArama_Txt.Text == "")
            {
                MusteriArama_Txt.Text = "AD,SOYAD,TELEFON";
                MusteriArama_Txt.ForeColor = Color.Gray;
            }
        }

        private void MusteriArama_Txt_Enter(object sender, EventArgs e)
        {
            if (MusteriArama_Txt.Text == "AD,SOYAD,TELEFON")
            {
                MusteriArama_Txt.Text = "";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
           

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
           
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void gecmisKiralamalar_btn_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
           
        }

        private void krediKartiBilgileri_btn_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
           
        }

        private void yazdir_btn_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click_2(object sender, EventArgs e)
        {

        }

        private void musteri_ekle_Click(object sender, EventArgs e)
        {
            musteri_ekle musteri_ekle = new musteri_ekle();
            musteri_ekle.ShowDialog();
        }

        private void carikardislemleri_Click(object sender, EventArgs e)
        {
            try
            {

                carikartislemleri carihesap = new carikartislemleri();
                carihareketekle.tcKimlikNo = musteriBilgileri_dataGrid.CurrentRow.Cells[0].Value.ToString();
                carikartislemleri.tcKimlikNo = musteriBilgileri_dataGrid.CurrentRow.Cells[0].Value.ToString();
                carihesap.ad_lbl.Text = musteriBilgileri_dataGrid.CurrentRow.Cells[1].Value.ToString();
                carihesap.soyad_lbl.Text = musteriBilgileri_dataGrid.CurrentRow.Cells[2].Value.ToString();
                carihesap.telefon_lbl.Text = musteriBilgileri_dataGrid.CurrentRow.Cells[3].Value.ToString();
                carihesap.adres_lbl.Text = musteriBilgileri_dataGrid.CurrentRow.Cells[6].Value.ToString();

                string kartBulSorgu = "select count(*) from tabloKrediKarti where tcKimlikNo='" + musteriBilgileri_dataGrid.CurrentRow.Cells[0].Value.ToString() + "'";
                SqlCommand komutKartlar = new SqlCommand(kartBulSorgu, datas);
                int kartAdedi = Convert.ToInt16(komutKartlar.ExecuteScalar());
                carihesap.krediKarti_lbl.Text = kartAdedi.ToString() + " Adet Kredi Kartı Bulunmaktadır.";

                string veriOkuma = "Select odemeler,islemHacmi,islemAdedi from tabloCariHesap where tcKimlikNo='" + musteriBilgileri_dataGrid.CurrentRow.Cells[0].Value.ToString() + "'";
                SqlCommand hesapSorgusu = new SqlCommand(veriOkuma, datas);
                SqlDataReader hesapOku = hesapSorgusu.ExecuteReader();
                if (hesapOku.Read())
                {
                    carihesap.odemeleri_lbl.Text = hesapOku["odemeler"].ToString();
                    carihesap.islemHacmi_lbl.Text = hesapOku["islemHacmi"].ToString();
                    carihesap.islemAdedi_lbl.Text = hesapOku["islemAdedi"].ToString();
                }

                hesapOku.Close();

                string odemesorgu = "Select tarih,tutar,odemeTuru,aciklama from tabloCariHesap where tcKimlikNo='" + musteriBilgileri_dataGrid.CurrentRow.Cells[0].Value.ToString() + "'";
                SqlCommand odemeKomut = new SqlCommand(odemesorgu, datas);

                SqlDataAdapter adapter1 = new SqlDataAdapter(odemeKomut);
                DataSet setdata = new DataSet();
                adapter1.Fill(setdata, "tabloCariHesap");
                carihesap.CariHesapBilgisi_dataGrid.DataSource = setdata.Tables["tabloCariHesap"];



                carihesap.ShowDialog();

            }
            catch
            {

                Bildiri.Uyari("BİLİNMEYEN HATA!!", Bildiri.AlertType.hata);
            }
        }

        private void musterituru_Click(object sender, EventArgs e)
        {
            musteriturubelirle musteriturubelirle = new musteriturubelirle();
            musteriturubelirle.ShowDialog();
        }

        private void duzenlebtn_Click(object sender, EventArgs e)
        {
            musteribilgileriduzenle duzenleMusteriBilgi = new musteribilgileriduzenle();



            duzenleMusteriBilgi.tcKimlikNo_txt.Text = musteriBilgileri_dataGrid.CurrentRow.Cells[0].Value.ToString();
            duzenleMusteriBilgi.musteriAdi_txt.Text = musteriBilgileri_dataGrid.CurrentRow.Cells[1].Value.ToString();
            duzenleMusteriBilgi.musteriSoyadi_txt.Text = musteriBilgileri_dataGrid.CurrentRow.Cells[2].Value.ToString();
            duzenleMusteriBilgi.musteriTel_txt.Text = musteriBilgileri_dataGrid.CurrentRow.Cells[3].Value.ToString();
            duzenleMusteriBilgi.musteriCep1_txt.Text = musteriBilgileri_dataGrid.CurrentRow.Cells[4].Value.ToString();
            duzenleMusteriBilgi.musteriCep2_txt.Text = musteriBilgileri_dataGrid.CurrentRow.Cells[5].Value.ToString();
            duzenleMusteriBilgi.musteriAdres_txt.Text = musteriBilgileri_dataGrid.CurrentRow.Cells[6].Value.ToString();
            duzenleMusteriBilgi.musteriMail.Text = musteriBilgileri_dataGrid.CurrentRow.Cells[7].Value.ToString();
            duzenleMusteriBilgi.musteriEkBilgi_txt.Text = musteriBilgileri_dataGrid.CurrentRow.Cells[8].Value.ToString();


            string sorguDuzenle = "select ehliyetil,ehliyetilce,ehliyetBelgeNo,ehliyetVerilisTarihi,ehliyetKullanilanCihaz,ehliyetDuzenleyen,pasaNo,pasaVerildigiYer,pasaVerilisTarihi from musteriBelgeleriTablosu  where tcKimlikNo='" + musteriBilgileri_dataGrid.CurrentRow.Cells[0].Value.ToString() + "'";
            SqlCommand komutBelge = new SqlCommand(sorguDuzenle, datas);

            SqlDataReader belgeOku = komutBelge.ExecuteReader();

            if (belgeOku.Read())
            {

                duzenleMusteriBilgi.ehliyetil_txt.Text = belgeOku["ehliyetil"].ToString();
                duzenleMusteriBilgi.ehliyetilce_txt.Text = belgeOku["ehliyetilce"].ToString();
                duzenleMusteriBilgi.ehliyetBelgeNo_txt.Text = belgeOku["ehliyetBelgeNo"].ToString();
                duzenleMusteriBilgi.ehlVerilisTarihi_dateTime.Text = belgeOku["ehliyetVerilisTarihi"].ToString();
                duzenleMusteriBilgi.kullCihaz_txt.Text = belgeOku["ehliyetKullanilanCihaz"].ToString();
                duzenleMusteriBilgi.duzenleyen_txt.Text = belgeOku["ehliyetDuzenleyen"].ToString();
                duzenleMusteriBilgi.pasaportNo_txt.Text = belgeOku["pasaNo"].ToString();
                duzenleMusteriBilgi.pasaportVerilYer_txt.Text = belgeOku["pasaVerildigiYer"].ToString();
                duzenleMusteriBilgi.pasaportVerilisTarihi_dateTime.Text = belgeOku["pasaVerilisTarihi"].ToString();

            }



            belgeOku.Close();
            duzenleMusteriBilgi.Show();
        }

        private void kiralabtn_Click(object sender, EventArgs e)
        {
            try
            {
                Araçlarım.kirayaver.ShowDialog();
                Araçlarım.kirayaver.ad.Text = //musteriBilgileri_dataGrid.CurrentRow.Cells[1].Value.ToString();
                Araçlarım.kirayaver.tc.Text = musteriBilgileri_dataGrid.CurrentRow.Cells[0].Value.ToString();
                Araçlarım.kirayaver.soyad.Text = musteriBilgileri_dataGrid.CurrentRow.Cells[2].Value.ToString();
                Araçlarım.kirayaver.ad_soyad_txt.Text = musteriBilgileri_dataGrid.CurrentRow.Cells[1].Value.ToString() + " " + musteriBilgileri_dataGrid.CurrentRow.Cells[2].Value.ToString();
                Araçlarım.kirayaver.cep_tel_txt.Text = musteriBilgileri_dataGrid.CurrentRow.Cells[5].Value.ToString();

                Araçlarım.kirayaver.butnExtra.Visible = true;  //kiraya ver formundaki ekstra butonunu aktif eder.

        
            }
            catch
            {

            }
    
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
           // try
            //{
                string cumle="delete from musteriler where tcKimlikNo='"+musteriBilgileri_dataGrid.CurrentRow.Cells[0].Value.ToString()+"'";
                SqlCommand cmd = new SqlCommand(cumle, datas);
                cmd.ExecuteNonQuery();

                string listele = "select * from musteriler";
                SqlCommand komutBilgiGetir = new SqlCommand(listele, datas);
                SqlDataAdapter adapter1 = new SqlDataAdapter(komutBilgiGetir);
                DataSet dataSetBilgiler = new DataSet();
                adapter1.Fill(dataSetBilgiler, "musteriler");
                musteriBilgileri_dataGrid.DataSource = dataSetBilgiler.Tables["musteriler"];
            //}
           // catch
            //{

            //}
        }

        private void gecmiskiralamalar_Click(object sender, EventArgs e)
        {
            musteriGecmisKiralama kiralamaGecmis = new musteriGecmisKiralama();
            kiralamaGecmis.tcKimlikNo = musteriBilgileri_dataGrid.CurrentRow.Cells[0].Value.ToString();
            kiralamaGecmis.Show();
        }

        private void kredikartibilgileri_Click(object sender, EventArgs e)
        {
            musterikredikartibilgileri kartbilgileri = new musterikredikartibilgileri();


            TcKimlikNo = musteriBilgileri_dataGrid.CurrentRow.Cells[0].Value.ToString();
            musterikredikartibilgileri.tcKimlikNo = musteriBilgileri_dataGrid.CurrentRow.Cells[0].Value.ToString(); ;
            string verigetir = "select ad,soyad,telefon,adres from musteriler where tcKimlikNo='" + TcKimlikNo + "'";
            SqlCommand bilgiGetir = new SqlCommand(verigetir, datas);
            SqlDataReader verioku = bilgiGetir.ExecuteReader();
            if (verioku.Read())
            {
                kartbilgileri.musteriAdi_lbl.Text = verioku["ad"].ToString();
                kartbilgileri.musteriSoyadi_lbl.Text = verioku["soyad"].ToString();
                kartbilgileri.musteriCepTel_lbl.Text = verioku["telefon"].ToString();
                kartbilgileri.musteriAdres_lbl.Text = verioku["adres"].ToString();


            }

            verioku.Close();




            kartbilgileri.ShowDialog();
        }

        private void yazdirbtn_Click(object sender, EventArgs e)
        {
            yazdir yazilamiyor = new yazdir();
            yazilamiyor.Show();
        }

        private void musteriBilgileri_dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MusteriArama_Txt_Click(object sender, EventArgs e)
        {
            MusteriArama_Txt.Text = "";
        }

        private void MusteriArama_Txt_TextChanged_1(object sender, EventArgs e)
        {
            MusteriArama_Txt.ForeColor = Color.Black;
            try
            {
                string gosterilecek = "select * from musteriler where ad like'" + MusteriArama_Txt.Text + "%' or soyad like'" + MusteriArama_Txt.Text + "%' or telefon like'" + MusteriArama_Txt.Text + "%'";
                SqlCommand cmd = new SqlCommand(gosterilecek, datas);
                SqlDataAdapter adptr = new SqlDataAdapter(cmd);
                DataSet dst = new DataSet();
                adptr.Fill(dst, "musteriler");
                musteriBilgileri_dataGrid.DataSource = dst.Tables["musteriler"];
            }
            catch 
            {
                Bildiri.Uyari("BİLİNMEYEN HATA!!", Bildiri.AlertType.hata);
            }
        }
    }
}
