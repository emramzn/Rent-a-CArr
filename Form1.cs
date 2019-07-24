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
using System.Drawing.Drawing2D;

namespace Rent_A_Car
{
    public partial class Form1 : Form
    {
        public static SqlConnection baglanti = database.baglan();
        public BorderStyle BorderStyle { get; set; }
       
        public Form1()
        {
            InitializeComponent();
            
           
            this.FormBorderStyle = FormBorderStyle.None;

        }
        bool dragging;
        Point offset;
        int SimdikiWidth = 1366;
        int SimdikiHeight = 768;

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
            yuvarlak_buton ybuton = new yuvarlak_buton();
            
            ybuton.FlatAppearance.BorderSize = 0;
            ybuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Controls.Add(ybuton);

            timer1.Start();
            Rectangle ClientCozunurluk = new Rectangle();

            ClientCozunurluk = Screen.GetBounds(ClientCozunurluk);

            float OranWidth = ((float)ClientCozunurluk.Width / (float)SimdikiWidth);

            float OranHeight = ((float)ClientCozunurluk.Height / (float)SimdikiHeight);


            this.Scale(OranWidth, OranHeight);

            SqlCommand musSayi = new SqlCommand("select count(*) from musteriler",baglanti);
            int musteriSayi = Convert.ToInt16(musSayi.ExecuteScalar());

            SqlCommand aracSayi = new SqlCommand("select count(*) from tabloAraclar", baglanti);
            int AracSayisi = Convert.ToInt16(aracSayi.ExecuteScalar());
            Araçlarım.aracSayisi = AracSayisi.ToString() ;
            Musterilerim.musteriSayisi = musteriSayi.ToString();
            label6.Text = "Sistemde " + AracSayisi.ToString() + " araç ve  " + musteriSayi.ToString() +" müşteri kayıtlı.";

          
        }

        
      

        public static void goster(string a,DataGridView dtgrt)
        {

            string gosterilecek = "";
            //if (a== "tabloAraclar")
            //{
            //    gosterilecek = "select marka,model,yakit,ucret from tabloAraclar";

            //}
            //else if (a=="musteriler")
            //{
            //    gosterilecek = "select ad,soyad,telefon,adres from musteriler";
            //}
            ////else if (a == "tabloAraclar")
            ////{
            ////    gosterilecek = "select aracPlaka,kiralayanAdi,kiralayanSoyad,kiralayanTelefon,kiralananTarih,kiralanansaat,teslimatTarih,teslimatSaat from aracGecmisKiralama where durum=alınmadı";
            ////}
            //else 
            //{
                gosterilecek = "select * from " + a;
            ////}

           
            SqlCommand cmd = new SqlCommand(gosterilecek, baglanti); 
            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adptr.Fill(ds, a);
            dtgrt.DataSource = ds.Tables[a];
            //dtgrt.Columns["ID"].Visible = false;*

        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
            
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            
        }

      

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

       

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
          
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kilitle kl = new Kilitle();
            kl.Show();
        }
        
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label7.Text = DateTime.Now.ToLongTimeString();
        }


        private void musterilerimbtn_Click(object sender, EventArgs e)
        {
           
        }

        private void araclarimbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void arackiralabtn_Click(object sender, EventArgs e)
        {
            
           
        }

        private void teslimalbtn_Click(object sender, EventArgs e)
        {
            
            
        }

        private void BakimServisi_btn_Click(object sender, EventArgs e)
        {

        }

        private void firmaKasasi_btn_Click(object sender, EventArgs e)
        {

        }

        private void hatirlatmalar_btn_Click(object sender, EventArgs e)
        {

        }

        private void teslimataGoreArac_btn_Click(object sender, EventArgs e)
        {

        }

        private void istatistik_btn_Click(object sender, EventArgs e)
        {

        }

        private void kilitle_btn_Click(object sender, EventArgs e)
        {

        }

        private void yoneticibtn_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (sagpanel.Width == 69)
            {
                if (solpanel.Width == 317)
                {
                    solpanel.BackColor = Color.Beige;
                    solpanel.Visible = false;
                    solpanel.Width = 39;
                    panelanimator.ShowSync(solpanel);
                }
                //label1.Visible = false;
               
                sagpanel.Visible = false;
                sagpanel.Width = 361;
                panelanimator2.ShowSync(sagpanel);
             
                
                

            }
            else
            {
                
                sagpanel.Visible = false;
                sagpanel.Width = 69;
                sagpanel.AutoScroll = false;
                panelanimator.ShowSync(sagpanel);
                
                //label1.Visible = true;


            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kilitle kl = new Kilitle();
            kl.Show();
            
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void musterilerimbtn_Click_1(object sender, EventArgs e)
        {
            
        }

        private void teslimalbtn_Click_1(object sender, EventArgs e)
        {

        }

        private void araclarimbtn_Click_1(object sender, EventArgs e)
        {

        }

        private void ayarlarbtn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void faturabtn_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void userControl121_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            analabel.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
            teslimatagorearaclar1.BringToFront();
            panel3.BringToFront();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            //istatistik1.BringToFront();
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            analabel.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
            istatistik1.BringToFront();
            panel3.BringToFront();
        }

        
        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            analabel.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
            hatirlatmalarim1.BringToFront();
            panel3.BringToFront();

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.baslıkpnl = new System.Windows.Forms.Panel();
            this.ad_soyad_lbl = new System.Windows.Forms.Label();
            this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.sagpanel = new System.Windows.Forms.Panel();
            this.bar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ana_menu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label7 = new System.Windows.Forms.Label();
            this.logoanimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton25 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bunifuFlatButton24 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton23 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ortapanel2 = new Rent_A_Car.ortapanel();
            this.teslimatagorearaclar1 = new Rent_A_Car.teslimatagorearaclar();
            this.istatistik1 = new Rent_A_Car.istatistik();
            this.hatirlatmalarim1 = new Rent_A_Car.hatirlatmalarim();
            this.firmakasasi1 = new Rent_A_Car.firmakasasi();
            this.bakimservisi1 = new Rent_A_Car.bakimservisi();
            this.destek1 = new Rent_A_Car.destek();
            this.panel1 = new System.Windows.Forms.Panel();
            this.analabel = new System.Windows.Forms.Label();
            this.solpanel = new System.Windows.Forms.Panel();
            this.bunifuFlatButton15 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton16 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton17 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton18 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton19 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton20 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton21 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton22 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton11 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton12 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton13 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton14 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton9 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton10 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelanimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelanimator2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.baslıkpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.sagpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.solpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // baslıkpnl
            // 
            this.baslıkpnl.BackColor = System.Drawing.Color.DimGray;
            this.baslıkpnl.Controls.Add(this.ad_soyad_lbl);
            this.baslıkpnl.Controls.Add(this.bunifuImageButton5);
            this.baslıkpnl.Controls.Add(this.bunifuImageButton4);
            this.baslıkpnl.Controls.Add(this.bunifuImageButton1);
            this.baslıkpnl.Controls.Add(this.bunifuCustomLabel1);
            this.logoanimator.SetDecoration(this.baslıkpnl, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.baslıkpnl, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator2.SetDecoration(this.baslıkpnl, BunifuAnimatorNS.DecorationType.None);
            this.baslıkpnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.baslıkpnl.Location = new System.Drawing.Point(0, 0);
            this.baslıkpnl.Name = "baslıkpnl";
            this.baslıkpnl.Size = new System.Drawing.Size(1362, 58);
            this.baslıkpnl.TabIndex = 29;
            // 
            // ad_soyad_lbl
            // 
            this.ad_soyad_lbl.AutoSize = true;
            this.panelanimator2.SetDecoration(this.ad_soyad_lbl, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.ad_soyad_lbl, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.ad_soyad_lbl, BunifuAnimatorNS.DecorationType.None);
            this.ad_soyad_lbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ad_soyad_lbl.Location = new System.Drawing.Point(1078, 19);
            this.ad_soyad_lbl.Name = "ad_soyad_lbl";
            this.ad_soyad_lbl.Size = new System.Drawing.Size(108, 24);
            this.ad_soyad_lbl.TabIndex = 97;
            this.ad_soyad_lbl.Text = "Ad Soyad";
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.logoanimator.SetDecoration(this.bunifuImageButton5, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuImageButton5, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator2.SetDecoration(this.bunifuImageButton5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.Location = new System.Drawing.Point(1265, 10);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton5.TabIndex = 96;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuImageButton5.Zoom = 10;
            this.bunifuImageButton5.Click += new System.EventHandler(this.bunifuImageButton5_Click);
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.logoanimator.SetDecoration(this.bunifuImageButton4, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuImageButton4, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator2.SetDecoration(this.bunifuImageButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton4.Image = global::Rent_A_Car.Properties.Resources.if_exit_fullscreen_black_280257__1_;
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(1311, 12);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(41, 36);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 95;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.logoanimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator2.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = global::Rent_A_Car.Properties.Resources.sss;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 8);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(44, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 31;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.panelanimator2.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(76, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(186, 39);
            this.bunifuCustomLabel1.TabIndex = 30;
            this.bunifuCustomLabel1.Text = "Rent A Car";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.panelanimator2.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(394, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 86;
            this.label6.Text = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.baslıkpnl;
            this.bunifuDragControl1.Vertical = true;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // sagpanel
            // 
            this.sagpanel.AutoScroll = true;
            this.sagpanel.BackColor = System.Drawing.Color.White;
            this.sagpanel.Controls.Add(this.bar);
            this.sagpanel.Controls.Add(this.pictureBox1);
            this.sagpanel.Controls.Add(this.ana_menu);
            this.sagpanel.Controls.Add(this.bunifuFlatButton8);
            this.sagpanel.Controls.Add(this.bunifuFlatButton7);
            this.sagpanel.Controls.Add(this.bunifuFlatButton4);
            this.sagpanel.Controls.Add(this.bunifuFlatButton5);
            this.sagpanel.Controls.Add(this.bunifuFlatButton6);
            this.sagpanel.Controls.Add(this.bunifuFlatButton3);
            this.logoanimator.SetDecoration(this.sagpanel, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.sagpanel, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator2.SetDecoration(this.sagpanel, BunifuAnimatorNS.DecorationType.None);
            this.sagpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sagpanel.Location = new System.Drawing.Point(0, 58);
            this.sagpanel.Name = "sagpanel";
            this.sagpanel.Size = new System.Drawing.Size(361, 683);
            this.sagpanel.TabIndex = 39;
            this.sagpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sagpanel_Paint);
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.Teal;
            this.panelanimator2.SetDecoration(this.bar, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bar, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bar, BunifuAnimatorNS.DecorationType.None);
            this.bar.Location = new System.Drawing.Point(0, 109);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(5, 50);
            this.bar.TabIndex = 89;
            this.bar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.panelanimator2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::Rent_A_Car.Properties.Resources.Adsızdsdsdyatay;
            this.pictureBox1.Location = new System.Drawing.Point(14, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // ana_menu
            // 
            this.ana_menu.Activecolor = System.Drawing.Color.Gainsboro;
            this.ana_menu.BackColor = System.Drawing.Color.White;
            this.ana_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ana_menu.BorderRadius = 0;
            this.ana_menu.ButtonText = "               Ana Menü";
            this.ana_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimator2.SetDecoration(this.ana_menu, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.ana_menu, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.ana_menu, BunifuAnimatorNS.DecorationType.None);
            this.ana_menu.DisabledColor = System.Drawing.Color.Gray;
            this.ana_menu.Iconcolor = System.Drawing.Color.Transparent;
            this.ana_menu.Iconimage = global::Rent_A_Car.Properties.Resources.if_Home01_928434;
            this.ana_menu.Iconimage_right = null;
            this.ana_menu.Iconimage_right_Selected = null;
            this.ana_menu.Iconimage_Selected = null;
            this.ana_menu.IconMarginLeft = 20;
            this.ana_menu.IconMarginRight = 0;
            this.ana_menu.IconRightVisible = true;
            this.ana_menu.IconRightZoom = 0D;
            this.ana_menu.IconVisible = true;
            this.ana_menu.IconZoom = 60D;
            this.ana_menu.IsTab = false;
            this.ana_menu.Location = new System.Drawing.Point(2, 110);
            this.ana_menu.Name = "ana_menu";
            this.ana_menu.Normalcolor = System.Drawing.Color.White;
            this.ana_menu.OnHovercolor = System.Drawing.Color.White;
            this.ana_menu.OnHoverTextColor = System.Drawing.Color.Black;
            this.ana_menu.selected = false;
            this.ana_menu.Size = new System.Drawing.Size(357, 43);
            this.ana_menu.TabIndex = 44;
            this.ana_menu.Text = "               Ana Menü";
            this.ana_menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ana_menu.Textcolor = System.Drawing.Color.DimGray;
            this.ana_menu.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ana_menu.Click += new System.EventHandler(this.ana_menu_Click);
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton8.BorderRadius = 0;
            this.bunifuFlatButton8.ButtonText = "               Teslimata Göre Araçlar";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimator2.SetDecoration(this.bunifuFlatButton8, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuFlatButton8, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton8.Iconimage")));
            this.bunifuFlatButton8.Iconimage_right = null;
            this.bunifuFlatButton8.Iconimage_right_Selected = null;
            this.bunifuFlatButton8.Iconimage_Selected = null;
            this.bunifuFlatButton8.IconMarginLeft = 20;
            this.bunifuFlatButton8.IconMarginRight = 0;
            this.bunifuFlatButton8.IconRightVisible = true;
            this.bunifuFlatButton8.IconRightZoom = 0D;
            this.bunifuFlatButton8.IconVisible = true;
            this.bunifuFlatButton8.IconZoom = 60D;
            this.bunifuFlatButton8.IsTab = false;
            this.bunifuFlatButton8.Location = new System.Drawing.Point(2, 159);
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.White;
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton8.selected = false;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(357, 43);
            this.bunifuFlatButton8.TabIndex = 8;
            this.bunifuFlatButton8.Text = "               Teslimata Göre Araçlar";
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuFlatButton8.Click += new System.EventHandler(this.bunifuFlatButton8_Click);
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "               KABİS";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimator2.SetDecoration(this.bunifuFlatButton7, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuFlatButton7, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton7.Iconimage")));
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 20;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 60D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(2, 306);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.White;
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(357, 44);
            this.bunifuFlatButton7.TabIndex = 7;
            this.bunifuFlatButton7.Text = "               KABİS";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuFlatButton7.Click += new System.EventHandler(this.bunifuFlatButton7_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "               Destek";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimator2.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 20;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 60D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(3, 407);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(356, 44);
            this.bunifuFlatButton4.TabIndex = 6;
            this.bunifuFlatButton4.Text = "               Destek";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "               Bakım Servisi";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimator2.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton5.Iconimage")));
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 20;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 60D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(3, 357);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(356, 38);
            this.bunifuFlatButton5.TabIndex = 5;
            this.bunifuFlatButton5.Text = "               Bakım Servisi";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuFlatButton5.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "               Hatırlatmalarım";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimator2.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton6.Iconimage")));
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 20;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 60D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(2, 255);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(357, 45);
            this.bunifuFlatButton6.TabIndex = 4;
            this.bunifuFlatButton6.Text = "               Hatırlatmalarım";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuFlatButton6.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "               İstatistik";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimator2.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 20;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 60D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(2, 208);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(357, 41);
            this.bunifuFlatButton3.TabIndex = 3;
            this.bunifuFlatButton3.Text = "               İstatistik";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.panelanimator2.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(833, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 87;
            this.label7.Text = "label7";
            // 
            // logoanimator
            // 
            this.logoanimator.AnimationType = BunifuAnimatorNS.AnimationType.VertBlind;
            this.logoanimator.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.logoanimator.DefaultAnimation = animation3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.ortapanel2);
            this.panel2.Controls.Add(this.teslimatagorearaclar1);
            this.panel2.Controls.Add(this.istatistik1);
            this.panel2.Controls.Add(this.hatirlatmalarim1);
            this.panel2.Controls.Add(this.firmakasasi1);
            this.panel2.Controls.Add(this.bakimservisi1);
            this.panel2.Controls.Add(this.destek1);
            this.panel2.Controls.Add(this.panel1);
            this.logoanimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator2.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(361, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 683);
            this.panel2.TabIndex = 40;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.bunifuFlatButton25);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.bunifuFlatButton24);
            this.panel3.Controls.Add(this.bunifuFlatButton23);
            this.logoanimator.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator2.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(797, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(147, 188);
            this.panel3.TabIndex = 8;
            this.panel3.Visible = false;
            this.panel3.MouseLeave += new System.EventHandler(this.panel3_MouseLeave);
            // 
            // bunifuFlatButton25
            // 
            this.bunifuFlatButton25.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton25.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton25.BorderRadius = 0;
            this.bunifuFlatButton25.ButtonText = "     Yardım";
            this.bunifuFlatButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimator2.SetDecoration(this.bunifuFlatButton25, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuFlatButton25, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton25, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton25.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton25.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton25.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton25.Iconimage")));
            this.bunifuFlatButton25.Iconimage_right = null;
            this.bunifuFlatButton25.Iconimage_right_Selected = null;
            this.bunifuFlatButton25.Iconimage_Selected = null;
            this.bunifuFlatButton25.IconMarginLeft = 0;
            this.bunifuFlatButton25.IconMarginRight = 0;
            this.bunifuFlatButton25.IconRightVisible = true;
            this.bunifuFlatButton25.IconRightZoom = 0D;
            this.bunifuFlatButton25.IconVisible = true;
            this.bunifuFlatButton25.IconZoom = 60D;
            this.bunifuFlatButton25.IsTab = false;
            this.bunifuFlatButton25.Location = new System.Drawing.Point(3, 94);
            this.bunifuFlatButton25.Name = "bunifuFlatButton25";
            this.bunifuFlatButton25.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton25.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton25.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton25.selected = false;
            this.bunifuFlatButton25.Size = new System.Drawing.Size(141, 42);
            this.bunifuFlatButton25.TabIndex = 2;
            this.bunifuFlatButton25.Text = "     Yardım";
            this.bunifuFlatButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton25.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton25.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.panelanimator2.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "x-button.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(3, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "     Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "x-button.png");
            // 
            // bunifuFlatButton24
            // 
            this.bunifuFlatButton24.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton24.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton24.BorderRadius = 0;
            this.bunifuFlatButton24.ButtonText = "    Ayarlar";
            this.bunifuFlatButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimator2.SetDecoration(this.bunifuFlatButton24, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuFlatButton24, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton24, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton24.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton24.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton24.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton24.Iconimage")));
            this.bunifuFlatButton24.Iconimage_right = null;
            this.bunifuFlatButton24.Iconimage_right_Selected = null;
            this.bunifuFlatButton24.Iconimage_Selected = null;
            this.bunifuFlatButton24.IconMarginLeft = 0;
            this.bunifuFlatButton24.IconMarginRight = 0;
            this.bunifuFlatButton24.IconRightVisible = true;
            this.bunifuFlatButton24.IconRightZoom = 0D;
            this.bunifuFlatButton24.IconVisible = true;
            this.bunifuFlatButton24.IconZoom = 60D;
            this.bunifuFlatButton24.IsTab = false;
            this.bunifuFlatButton24.Location = new System.Drawing.Point(3, 50);
            this.bunifuFlatButton24.Name = "bunifuFlatButton24";
            this.bunifuFlatButton24.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton24.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton24.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton24.selected = false;
            this.bunifuFlatButton24.Size = new System.Drawing.Size(141, 42);
            this.bunifuFlatButton24.TabIndex = 1;
            this.bunifuFlatButton24.Text = "    Ayarlar";
            this.bunifuFlatButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton24.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton24.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuFlatButton24.Click += new System.EventHandler(this.bunifuFlatButton24_Click);
            // 
            // bunifuFlatButton23
            // 
            this.bunifuFlatButton23.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton23.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton23.BorderRadius = 0;
            this.bunifuFlatButton23.ButtonText = "     Hesabım";
            this.bunifuFlatButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimator2.SetDecoration(this.bunifuFlatButton23, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuFlatButton23, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton23, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton23.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton23.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton23.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton23.Iconimage")));
            this.bunifuFlatButton23.Iconimage_right = null;
            this.bunifuFlatButton23.Iconimage_right_Selected = null;
            this.bunifuFlatButton23.Iconimage_Selected = null;
            this.bunifuFlatButton23.IconMarginLeft = 0;
            this.bunifuFlatButton23.IconMarginRight = 0;
            this.bunifuFlatButton23.IconRightVisible = true;
            this.bunifuFlatButton23.IconRightZoom = 0D;
            this.bunifuFlatButton23.IconVisible = true;
            this.bunifuFlatButton23.IconZoom = 60D;
            this.bunifuFlatButton23.IsTab = false;
            this.bunifuFlatButton23.Location = new System.Drawing.Point(3, 6);
            this.bunifuFlatButton23.Name = "bunifuFlatButton23";
            this.bunifuFlatButton23.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton23.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton23.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton23.selected = false;
            this.bunifuFlatButton23.Size = new System.Drawing.Size(141, 42);
            this.bunifuFlatButton23.TabIndex = 0;
            this.bunifuFlatButton23.Text = "     Hesabım";
            this.bunifuFlatButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton23.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton23.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuFlatButton23.Click += new System.EventHandler(this.bunifuFlatButton23_Click);
            // 
            // ortapanel2
            // 
            this.ortapanel2.BackColor = System.Drawing.Color.Beige;
            this.panelanimator2.SetDecoration(this.ortapanel2, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.ortapanel2, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.ortapanel2, BunifuAnimatorNS.DecorationType.None);
            this.ortapanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ortapanel2.Location = new System.Drawing.Point(0, 56);
            this.ortapanel2.Name = "ortapanel2";
            this.ortapanel2.Size = new System.Drawing.Size(1001, 627);
            this.ortapanel2.TabIndex = 7;
            this.ortapanel2.Load += new System.EventHandler(this.ortapanel2_Load_2);
            // 
            // teslimatagorearaclar1
            // 
            this.teslimatagorearaclar1.BackColor = System.Drawing.Color.Beige;
            this.panelanimator2.SetDecoration(this.teslimatagorearaclar1, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.teslimatagorearaclar1, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.teslimatagorearaclar1, BunifuAnimatorNS.DecorationType.None);
            this.teslimatagorearaclar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teslimatagorearaclar1.Location = new System.Drawing.Point(0, 56);
            this.teslimatagorearaclar1.Name = "teslimatagorearaclar1";
            this.teslimatagorearaclar1.Size = new System.Drawing.Size(1001, 627);
            this.teslimatagorearaclar1.TabIndex = 6;
            // 
            // istatistik1
            // 
            this.istatistik1.BackColor = System.Drawing.Color.Beige;
            this.panelanimator2.SetDecoration(this.istatistik1, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.istatistik1, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.istatistik1, BunifuAnimatorNS.DecorationType.None);
            this.istatistik1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.istatistik1.Location = new System.Drawing.Point(0, 56);
            this.istatistik1.Name = "istatistik1";
            this.istatistik1.Size = new System.Drawing.Size(1001, 627);
            this.istatistik1.TabIndex = 5;
            // 
            // hatirlatmalarim1
            // 
            this.hatirlatmalarim1.BackColor = System.Drawing.Color.Beige;
            this.panelanimator2.SetDecoration(this.hatirlatmalarim1, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.hatirlatmalarim1, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.hatirlatmalarim1, BunifuAnimatorNS.DecorationType.None);
            this.hatirlatmalarim1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hatirlatmalarim1.Location = new System.Drawing.Point(0, 56);
            this.hatirlatmalarim1.Name = "hatirlatmalarim1";
            this.hatirlatmalarim1.Size = new System.Drawing.Size(1001, 627);
            this.hatirlatmalarim1.TabIndex = 4;
            // 
            // firmakasasi1
            // 
            this.firmakasasi1.BackColor = System.Drawing.Color.Beige;
            this.panelanimator2.SetDecoration(this.firmakasasi1, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.firmakasasi1, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.firmakasasi1, BunifuAnimatorNS.DecorationType.None);
            this.firmakasasi1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firmakasasi1.Location = new System.Drawing.Point(0, 56);
            this.firmakasasi1.Name = "firmakasasi1";
            this.firmakasasi1.Size = new System.Drawing.Size(1001, 627);
            this.firmakasasi1.TabIndex = 3;
            // 
            // bakimservisi1
            // 
            this.bakimservisi1.BackColor = System.Drawing.Color.Beige;
            this.panelanimator2.SetDecoration(this.bakimservisi1, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bakimservisi1, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bakimservisi1, BunifuAnimatorNS.DecorationType.None);
            this.bakimservisi1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bakimservisi1.Location = new System.Drawing.Point(0, 56);
            this.bakimservisi1.Name = "bakimservisi1";
            this.bakimservisi1.Size = new System.Drawing.Size(1001, 627);
            this.bakimservisi1.TabIndex = 2;
            // 
            // destek1
            // 
            this.destek1.BackColor = System.Drawing.Color.Beige;
            this.panelanimator2.SetDecoration(this.destek1, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.destek1, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.destek1, BunifuAnimatorNS.DecorationType.None);
            this.destek1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.destek1.Location = new System.Drawing.Point(0, 56);
            this.destek1.Name = "destek1";
            this.destek1.Size = new System.Drawing.Size(1001, 627);
            this.destek1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.analabel);
            this.logoanimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator2.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 56);
            this.panel1.TabIndex = 0;
            // 
            // analabel
            // 
            this.analabel.AutoSize = true;
            this.panelanimator2.SetDecoration(this.analabel, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.analabel, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.analabel, BunifuAnimatorNS.DecorationType.None);
            this.analabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.analabel.Location = new System.Drawing.Point(4, 11);
            this.analabel.Name = "analabel";
            this.analabel.Size = new System.Drawing.Size(150, 33);
            this.analabel.TabIndex = 0;
            this.analabel.Text = "Ana Menü";
            // 
            // solpanel
            // 
            this.solpanel.BackColor = System.Drawing.Color.Transparent;
            this.solpanel.Controls.Add(this.bunifuFlatButton15);
            this.solpanel.Controls.Add(this.bunifuFlatButton16);
            this.solpanel.Controls.Add(this.bunifuFlatButton17);
            this.solpanel.Controls.Add(this.bunifuFlatButton18);
            this.solpanel.Controls.Add(this.bunifuFlatButton19);
            this.solpanel.Controls.Add(this.bunifuFlatButton20);
            this.solpanel.Controls.Add(this.bunifuFlatButton21);
            this.solpanel.Controls.Add(this.bunifuFlatButton22);
            this.solpanel.Controls.Add(this.bunifuFlatButton11);
            this.solpanel.Controls.Add(this.bunifuFlatButton12);
            this.solpanel.Controls.Add(this.bunifuFlatButton13);
            this.solpanel.Controls.Add(this.bunifuFlatButton14);
            this.solpanel.Controls.Add(this.bunifuFlatButton9);
            this.solpanel.Controls.Add(this.bunifuFlatButton10);
            this.solpanel.Controls.Add(this.bunifuFlatButton2);
            this.solpanel.Controls.Add(this.bunifuFlatButton1);
            this.solpanel.Controls.Add(this.bunifuImageButton2);
            this.logoanimator.SetDecoration(this.solpanel, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.solpanel, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator2.SetDecoration(this.solpanel, BunifuAnimatorNS.DecorationType.None);
            this.solpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.solpanel.Location = new System.Drawing.Point(1323, 58);
            this.solpanel.Name = "solpanel";
            this.solpanel.Size = new System.Drawing.Size(39, 683);
            this.solpanel.TabIndex = 41;
            this.solpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.solpanel_Paint);
            // 
            // bunifuFlatButton15
            // 
            this.bunifuFlatButton15.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton15.BorderRadius = 0;
            this.bunifuFlatButton15.ButtonText = "bunifuFlatButton15";
            this.bunifuFlatButton15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimator2.SetDecoration(this.bunifuFlatButton15, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuFlatButton15, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton15, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton15.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton15.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton15.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton15.Iconimage")));
            this.bunifuFlatButton15.Iconimage_right = null;
            this.bunifuFlatButton15.Iconimage_right_Selected = null;
            this.bunifuFlatButton15.Iconimage_Selected = null;
            this.bunifuFlatButton15.IconMarginLeft = 0;
            this.bunifuFlatButton15.IconMarginRight = 0;
            this.bunifuFlatButton15.IconRightVisible = true;
            this.bunifuFlatButton15.IconRightZoom = 0D;
            this.bunifuFlatButton15.IconVisible = true;
            this.bunifuFlatButton15.IconZoom = 90D;
            this.bunifuFlatButton15.IsTab = false;
            this.bunifuFlatButton15.Location = new System.Drawing.Point(45, 27);
            this.bunifuFlatButton15.Name = "bunifuFlatButton15";
            this.bunifuFlatButton15.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton15.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton15.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton15.selected = false;
            this.bunifuFlatButton15.Size = new System.Drawing.Size(272, 41);
            this.bunifuFlatButton15.TabIndex = 112;
            this.bunifuFlatButton15.Text = "bunifuFlatButton15";
            this.bunifuFlatButton15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton15.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton15.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton15.Visible = false;
            // 
            // bunifuFlatButton16
            // 
            this.bunifuFlatButton16.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton16.BorderRadius = 0;
            this.bunifuFlatButton16.ButtonText = "bunifuFlatButton16";
            this.bunifuFlatButton16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimator2.SetDecoration(this.bunifuFlatButton16, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuFlatButton16, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton16, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton16.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton16.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton16.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton16.Iconimage")));
            this.bunifuFlatButton16.Iconimage_right = null;
            this.bunifuFlatButton16.Iconimage_right_Selected = null;
            this.bunifuFlatButton16.Iconimage_Selected = null;
            this.bunifuFlatButton16.IconMarginLeft = 0;
            this.bunifuFlatButton16.IconMarginRight = 0;
            this.bunifuFlatButton16.IconRightVisible = true;
            this.bunifuFlatButton16.IconRightZoom = 0D;
            this.bunifuFlatButton16.IconVisible = true;
            this.bunifuFlatButton16.IconZoom = 90D;
            this.bunifuFlatButton16.IsTab = false;
            this.bunifuFlatButton16.Location = new System.Drawing.Point(45, 68);
            this.bunifuFlatButton16.Name = "bunifuFlatButton16";
            this.bunifuFlatButton16.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton16.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton16.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton16.selected = false;
            this.bunifuFlatButton16.Size = new System.Drawing.Size(272, 41);
            this.bunifuFlatButton16.TabIndex = 111;
            this.bunifuFlatButton16.Text = "bunifuFlatButton16";
            this.bunifuFlatButton16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton16.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton16.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton16.Visible = false;
            // 
            // bunifuFlatButton17
            // 
            this.bunifuFlatButton17.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton17.BorderRadius = 0;
            this.bunifuFlatButton17.ButtonText = "bunifuFlatButton17";
            this.bunifuFlatButton17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimator2.SetDecoration(this.bunifuFlatButton17, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuFlatButton17, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton17, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton17.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton17.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton17.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton17.Iconimage")));
            this.bunifuFlatButton17.Iconimage_right = null;
            this.bunifuFlatButton17.Iconimage_right_Selected = null;
            this.bunifuFlatButton17.Iconimage_Selected = null;
            this.bunifuFlatButton17.IconMarginLeft = 0;
            this.bunifuFlatButton17.IconMarginRight = 0;
            this.bunifuFlatButton17.IconRightVisible = true;
            this.bunifuFlatButton17.IconRightZoom = 0D;
            this.bunifuFlatButton17.IconVisible = true;
            this.bunifuFlatButton17.IconZoom = 90D;
            this.bunifuFlatButton17.IsTab = false;
            this.bunifuFlatButton17.Location = new System.Drawing.Point(45, 109);
            this.bunifuFlatButton17.Name = "bunifuFlatButton17";
            this.bunifuFlatButton17.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton17.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton17.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton17.selected = false;
            this.bunifuFlatButton17.Size = new System.Drawing.Size(272, 41);
            this.bunifuFlatButton17.TabIndex = 110;
            this.bunifuFlatButton17.Text = "bunifuFlatButton17";
            this.bunifuFlatButton17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton17.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton17.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton17.Visible = false;
            // 
            // bunifuFlatButton18
            // 
            this.bunifuFlatButton18.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton18.BorderRadius = 0;
            this.bunifuFlatButton18.ButtonText = "bunifuFlatButton18";
            this.bunifuFlatButton18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimator2.SetDecoration(this.bunifuFlatButton18, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuFlatButton18, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton18, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton18.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton18.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton18.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton18.Iconimage")));
            this.bunifuFlatButton18.Iconimage_right = null;
            this.bunifuFlatButton18.Iconimage_right_Selected = null;
            this.bunifuFlatButton18.Iconimage_Selected = null;
            this.bunifuFlatButton18.IconMarginLeft = 0;
            this.bunifuFlatButton18.IconMarginRight = 0;
            this.bunifuFlatButton18.IconRightVisible = true;
            this.bunifuFlatButton18.IconRightZoom = 0D;
            this.bunifuFlatButton18.IconVisible = true;
            this.bunifuFlatButton18.IconZoom = 90D;
            this.bunifuFlatButton18.IsTab = false;
            this.bunifuFlatButton18.Location = new System.Drawing.Point(45, 150);
            this.bunifuFlatButton18.Name = "bunifuFlatButton18";
            this.bunifuFlatButton18.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton18.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton18.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton18.selected = false;
            this.bunifuFlatButton18.Size = new System.Drawing.Size(272, 41);
            this.bunifuFlatButton18.TabIndex = 109;
            this.bunifuFlatButton18.Text = "bunifuFlatButton18";
            this.bunifuFlatButton18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton18.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton18.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton18.Visible = false;
            // 
            // bunifuFlatButton19
            // 
            this.bunifuFlatButton19.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton19.BorderRadius = 0;
            this.bunifuFlatButton19.ButtonText = "bunifuFlatButton19";
            this.bunifuFlatButton19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimator2.SetDecoration(this.bunifuFlatButton19, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuFlatButton19, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton19, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton19.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton19.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton19.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton19.Iconimage")));
            this.bunifuFlatButton19.Iconimage_right = null;
            this.bunifuFlatButton19.Iconimage_right_Selected = null;
            this.bunifuFlatButton19.Iconimage_Selected = null;
            this.bunifuFlatButton19.IconMarginLeft = 0;
            this.bunifuFlatButton19.IconMarginRight = 0;
            this.bunifuFlatButton19.IconRightVisible = true;
            this.bunifuFlatButton19.IconRightZoom = 0D;
            this.bunifuFlatButton19.IconVisible = true;
            this.bunifuFlatButton19.IconZoom = 90D;
            this.bunifuFlatButton19.IsTab = false;
            this.bunifuFlatButton19.Location = new System.Drawing.Point(45, 191);
            this.bunifuFlatButton19.Name = "bunifuFlatButton19";
            this.bunifuFlatButton19.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton19.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton19.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton19.selected = false;
            this.bunifuFlatButton19.Size = new System.Drawing.Size(272, 41);
            this.bunifuFlatButton19.TabIndex = 108;
            this.bunifuFlatButton19.Text = "bunifuFlatButton19";
            this.bunifuFlatButton19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton19.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton19.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton19.Visible = false;
            // 
            // bunifuFlatButton20
            // 
            this.bunifuFlatButton20.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton20.BorderRadius = 0;
            this.bunifuFlatButton20.ButtonText = "bunifuFlatButton20";
            this.bunifuFlatButton20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimator2.SetDecoration(this.bunifuFlatButton20, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuFlatButton20, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton20, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton20.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton20.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton20.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton20.Iconimage")));
            this.bunifuFlatButton20.Iconimage_right = null;
            this.bunifuFlatButton20.Iconimage_right_Selected = null;
            this.bunifuFlatButton20.Iconimage_Selected = null;
            this.bunifuFlatButton20.IconMarginLeft = 0;
            this.bunifuFlatButton20.IconMarginRight = 0;
            this.bunifuFlatButton20.IconRightVisible = true;
            this.bunifuFlatButton20.IconRightZoom = 0D;
            this.bunifuFlatButton20.IconVisible = true;
            this.bunifuFlatButton20.IconZoom = 90D;
            this.bunifuFlatButton20.IsTab = false;
            this.bunifuFlatButton20.Location = new System.Drawing.Point(45, 232);
            this.bunifuFlatButton20.Name = "bunifuFlatButton20";
            this.bunifuFlatButton20.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton20.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton20.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton20.selected = false;
            this.bunifuFlatButton20.Size = new System.Drawing.Size(272, 41);
            this.bunifuFlatButton20.TabIndex = 107;
            this.bunifuFlatButton20.Text = "bunifuFlatButton20";
            this.bunifuFlatButton20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton20.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton20.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton20.Visible = false;
            // 
            // bunifuFlatButton21
            // 
            this.bunifuFlatButton21.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton21.BorderRadius = 0;
            this.bunifuFlatButton21.ButtonText = "bunifuFlatButton21";
            this.bunifuFlatButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimator2.SetDecoration(this.bunifuFlatButton21, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuFlatButton21, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton21, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton21.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton21.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton21.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton21.Iconimage")));
            this.bunifuFlatButton21.Iconimage_right = null;
            this.bunifuFlatButton21.Iconimage_right_Selected = null;
            this.bunifuFlatButton21.Iconimage_Selected = null;
            this.bunifuFlatButton21.IconMarginLeft = 0;
            this.bunifuFlatButton21.IconMarginRight = 0;
            this.bunifuFlatButton21.IconRightVisible = true;
            this.bunifuFlatButton21.IconRightZoom = 0D;
            this.bunifuFlatButton21.IconVisible = true;
            this.bunifuFlatButton21.IconZoom = 90D;
            this.bunifuFlatButton21.IsTab = false;
            this.bunifuFlatButton21.Location = new System.Drawing.Point(45, 273);
            this.bunifuFlatButton21.Name = "bunifuFlatButton21";
            this.bunifuFlatButton21.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton21.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton21.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton21.selected = false;
            this.bunifuFlatButton21.Size = new System.Drawing.Size(272, 41);
            this.bunifuFlatButton21.TabIndex = 106;
            this.bunifuFlatButton21.Text = "bunifuFlatButton21";
            this.bunifuFlatButton21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton21.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton21.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton21.Visible = false;
            // 
            // bunifuFlatButton22
            // 
            this.bunifuFlatButton22.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton22.BorderRadius = 0;
            this.bunifuFlatButton22.ButtonText = "bunifuFlatButton22";
            this.bunifuFlatButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimator2.SetDecoration(this.bunifuFlatButton22, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuFlatButton22, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton22, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton22.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton22.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton22.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton22.Iconimage")));
            this.bunifuFlatButton22.Iconimage_right = null;
            this.bunifuFlatButton22.Iconimage_right_Selected = null;
            this.bunifuFlatButton22.Iconimage_Selected = null;
            this.bunifuFlatButton22.IconMarginLeft = 0;
            this.bunifuFlatButton22.IconMarginRight = 0;
            this.bunifuFlatButton22.IconRightVisible = true;
            this.bunifuFlatButton22.IconRightZoom = 0D;
            this.bunifuFlatButton22.IconVisible = true;
            this.bunifuFlatButton22.IconZoom = 90D;
            this.bunifuFlatButton22.IsTab = false;
            this.bunifuFlatButton22.Location = new System.Drawing.Point(45, 314);
            this.bunifuFlatButton22.Name = "bunifuFlatButton22";
            this.bunifuFlatButton22.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton22.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton22.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton22.selected = false;
            this.bunifuFlatButton22.Size = new System.Drawing.Size(272, 41);
            this.bunifuFlatButton22.TabIndex = 105;
            this.bunifuFlatButton22.Text = "bunifuFlatButton22";
            this.bunifuFlatButton22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton22.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton22.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton22.Visible = false;
            // 
            // bunifuFlatButton11
            // 
            this.bunifuFlatButton11.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton11.BorderRadius = 0;
            this.bunifuFlatButton11.ButtonText = "bunifuFlatButton11";
            this.bunifuFlatButton11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimator2.SetDecoration(this.bunifuFlatButton11, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuFlatButton11, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton11, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton11.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton11.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton11.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton11.Iconimage")));
            this.bunifuFlatButton11.Iconimage_right = null;
            this.bunifuFlatButton11.Iconimage_right_Selected = null;
            this.bunifuFlatButton11.Iconimage_Selected = null;
            this.bunifuFlatButton11.IconMarginLeft = 0;
            this.bunifuFlatButton11.IconMarginRight = 0;
            this.bunifuFlatButton11.IconRightVisible = true;
            this.bunifuFlatButton11.IconRightZoom = 0D;
            this.bunifuFlatButton11.IconVisible = true;
            this.bunifuFlatButton11.IconZoom = 90D;
            this.bunifuFlatButton11.IsTab = false;
            this.bunifuFlatButton11.Location = new System.Drawing.Point(45, 355);
            this.bunifuFlatButton11.Name = "bunifuFlatButton11";
            this.bunifuFlatButton11.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton11.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton11.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton11.selected = false;
            this.bunifuFlatButton11.Size = new System.Drawing.Size(272, 41);
            this.bunifuFlatButton11.TabIndex = 104;
            this.bunifuFlatButton11.Text = "bunifuFlatButton11";
            this.bunifuFlatButton11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton11.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton11.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton11.Visible = false;
            // 
            // bunifuFlatButton12
            // 
            this.bunifuFlatButton12.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton12.BorderRadius = 0;
            this.bunifuFlatButton12.ButtonText = "bunifuFlatButton12";
            this.bunifuFlatButton12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimator2.SetDecoration(this.bunifuFlatButton12, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuFlatButton12, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton12, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton12.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton12.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton12.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton12.Iconimage")));
            this.bunifuFlatButton12.Iconimage_right = null;
            this.bunifuFlatButton12.Iconimage_right_Selected = null;
            this.bunifuFlatButton12.Iconimage_Selected = null;
            this.bunifuFlatButton12.IconMarginLeft = 0;
            this.bunifuFlatButton12.IconMarginRight = 0;
            this.bunifuFlatButton12.IconRightVisible = true;
            this.bunifuFlatButton12.IconRightZoom = 0D;
            this.bunifuFlatButton12.IconVisible = true;
            this.bunifuFlatButton12.IconZoom = 90D;
            this.bunifuFlatButton12.IsTab = false;
            this.bunifuFlatButton12.Location = new System.Drawing.Point(45, 396);
            this.bunifuFlatButton12.Name = "bunifuFlatButton12";
            this.bunifuFlatButton12.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton12.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton12.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton12.selected = false;
            this.bunifuFlatButton12.Size = new System.Drawing.Size(272, 41);
            this.bunifuFlatButton12.TabIndex = 103;
            this.bunifuFlatButton12.Text = "bunifuFlatButton12";
            this.bunifuFlatButton12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton12.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton12.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton12.Visible = false;
            // 
            // bunifuFlatButton13
            // 
            this.bunifuFlatButton13.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton13.BorderRadius = 0;
            this.bunifuFlatButton13.ButtonText = "bunifuFlatButton13";
            this.bunifuFlatButton13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimator2.SetDecoration(this.bunifuFlatButton13, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuFlatButton13, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton13, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton13.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton13.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton13.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton13.Iconimage")));
            this.bunifuFlatButton13.Iconimage_right = null;
            this.bunifuFlatButton13.Iconimage_right_Selected = null;
            this.bunifuFlatButton13.Iconimage_Selected = null;
            this.bunifuFlatButton13.IconMarginLeft = 0;
            this.bunifuFlatButton13.IconMarginRight = 0;
            this.bunifuFlatButton13.IconRightVisible = true;
            this.bunifuFlatButton13.IconRightZoom = 0D;
            this.bunifuFlatButton13.IconVisible = true;
            this.bunifuFlatButton13.IconZoom = 90D;
            this.bunifuFlatButton13.IsTab = false;
            this.bunifuFlatButton13.Location = new System.Drawing.Point(45, 437);
            this.bunifuFlatButton13.Name = "bunifuFlatButton13";
            this.bunifuFlatButton13.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton13.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton13.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton13.selected = false;
            this.bunifuFlatButton13.Size = new System.Drawing.Size(272, 41);
            this.bunifuFlatButton13.TabIndex = 102;
            this.bunifuFlatButton13.Text = "bunifuFlatButton13";
            this.bunifuFlatButton13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton13.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton13.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton13.Visible = false;
            // 
            // bunifuFlatButton14
            // 
            this.bunifuFlatButton14.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton14.BorderRadius = 0;
            this.bunifuFlatButton14.ButtonText = "bunifuFlatButton14";
            this.bunifuFlatButton14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimator2.SetDecoration(this.bunifuFlatButton14, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuFlatButton14, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton14, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton14.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton14.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton14.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton14.Iconimage")));
            this.bunifuFlatButton14.Iconimage_right = null;
            this.bunifuFlatButton14.Iconimage_right_Selected = null;
            this.bunifuFlatButton14.Iconimage_Selected = null;
            this.bunifuFlatButton14.IconMarginLeft = 0;
            this.bunifuFlatButton14.IconMarginRight = 0;
            this.bunifuFlatButton14.IconRightVisible = true;
            this.bunifuFlatButton14.IconRightZoom = 0D;
            this.bunifuFlatButton14.IconVisible = true;
            this.bunifuFlatButton14.IconZoom = 90D;
            this.bunifuFlatButton14.IsTab = false;
            this.bunifuFlatButton14.Location = new System.Drawing.Point(45, 478);
            this.bunifuFlatButton14.Name = "bunifuFlatButton14";
            this.bunifuFlatButton14.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton14.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton14.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton14.selected = false;
            this.bunifuFlatButton14.Size = new System.Drawing.Size(272, 41);
            this.bunifuFlatButton14.TabIndex = 101;
            this.bunifuFlatButton14.Text = "bunifuFlatButton14";
            this.bunifuFlatButton14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton14.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton14.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton14.Visible = false;
            // 
            // bunifuFlatButton9
            // 
            this.bunifuFlatButton9.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton9.BorderRadius = 0;
            this.bunifuFlatButton9.ButtonText = "bunifuFlatButton9";
            this.bunifuFlatButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimator2.SetDecoration(this.bunifuFlatButton9, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuFlatButton9, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton9, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton9.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton9.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton9.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton9.Iconimage")));
            this.bunifuFlatButton9.Iconimage_right = null;
            this.bunifuFlatButton9.Iconimage_right_Selected = null;
            this.bunifuFlatButton9.Iconimage_Selected = null;
            this.bunifuFlatButton9.IconMarginLeft = 0;
            this.bunifuFlatButton9.IconMarginRight = 0;
            this.bunifuFlatButton9.IconRightVisible = true;
            this.bunifuFlatButton9.IconRightZoom = 0D;
            this.bunifuFlatButton9.IconVisible = true;
            this.bunifuFlatButton9.IconZoom = 90D;
            this.bunifuFlatButton9.IsTab = false;
            this.bunifuFlatButton9.Location = new System.Drawing.Point(45, 519);
            this.bunifuFlatButton9.Name = "bunifuFlatButton9";
            this.bunifuFlatButton9.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton9.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton9.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton9.selected = false;
            this.bunifuFlatButton9.Size = new System.Drawing.Size(272, 41);
            this.bunifuFlatButton9.TabIndex = 100;
            this.bunifuFlatButton9.Text = "bunifuFlatButton9";
            this.bunifuFlatButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton9.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton9.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton9.Visible = false;
            // 
            // bunifuFlatButton10
            // 
            this.bunifuFlatButton10.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton10.BorderRadius = 0;
            this.bunifuFlatButton10.ButtonText = "bunifuFlatButton10";
            this.bunifuFlatButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimator2.SetDecoration(this.bunifuFlatButton10, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuFlatButton10, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton10, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton10.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton10.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton10.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton10.Iconimage")));
            this.bunifuFlatButton10.Iconimage_right = null;
            this.bunifuFlatButton10.Iconimage_right_Selected = null;
            this.bunifuFlatButton10.Iconimage_Selected = null;
            this.bunifuFlatButton10.IconMarginLeft = 0;
            this.bunifuFlatButton10.IconMarginRight = 0;
            this.bunifuFlatButton10.IconRightVisible = true;
            this.bunifuFlatButton10.IconRightZoom = 0D;
            this.bunifuFlatButton10.IconVisible = true;
            this.bunifuFlatButton10.IconZoom = 90D;
            this.bunifuFlatButton10.IsTab = false;
            this.bunifuFlatButton10.Location = new System.Drawing.Point(45, 560);
            this.bunifuFlatButton10.Name = "bunifuFlatButton10";
            this.bunifuFlatButton10.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton10.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton10.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton10.selected = false;
            this.bunifuFlatButton10.Size = new System.Drawing.Size(272, 41);
            this.bunifuFlatButton10.TabIndex = 99;
            this.bunifuFlatButton10.Text = "bunifuFlatButton10";
            this.bunifuFlatButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton10.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton10.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton10.Visible = false;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "bunifuFlatButton2";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimator2.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(45, 601);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(272, 41);
            this.bunifuFlatButton2.TabIndex = 98;
            this.bunifuFlatButton2.Text = "bunifuFlatButton2";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Visible = false;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "bunifuFlatButton1";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimator2.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(45, 642);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(272, 41);
            this.bunifuFlatButton1.TabIndex = 97;
            this.bunifuFlatButton1.Text = "bunifuFlatButton1";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Visible = false;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.logoanimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator2.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = global::Rent_A_Car.Properties.Resources.if_menu_alt_134216;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(0, 638);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(39, 42);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 96;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click_1);
            // 
            // panelanimator
            // 
            this.panelanimator.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.panelanimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.panelanimator.DefaultAnimation = animation2;
            // 
            // panelanimator2
            // 
            this.panelanimator2.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.panelanimator2.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.panelanimator2.DefaultAnimation = animation1;
            // 
            // timer3
            // 
            this.timer3.Interval = 4000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.solpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sagpanel);
            this.Controls.Add(this.baslıkpnl);
            this.panelanimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.panelanimator2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kiralama Sistemi";
            this.AutoSizeChanged += new System.EventHandler(this.Form1_Load);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.baslıkpnl.ResumeLayout(false);
            this.baslıkpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.sagpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.solpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            analabel.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
            firmakasasi1.BringToFront();
            panel3.BringToFront();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            analabel.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
            bakimservisi1.BringToFront();
            panel3.BringToFront();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            analabel.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
            destek1.BringToFront();
            panel3.BringToFront();
        }

        private void bunifuImageButton3_Click_1(object sender, EventArgs e)
        {
            
           

           
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ortapanel2_Load(object sender, EventArgs e)
        {

        }

        private void ortapanel2_Load_1(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {

            
            if (solpanel.Width == 39)
            {
                if (sagpanel.Width == 361)
                {
                    sagpanel.Visible = false;
                    sagpanel.Width = 69;
                    panelanimator.ShowSync(sagpanel);
                    
                    //label1.Visible = true;
                }
                //solpanel.BackColor = Color.LightGray;
                solpanel.BackColor = Color.FromArgb(50, 211, 211, 211);
                solpanel.Visible = false;
                solpanel.Width = 317;
                panelanimator2.ShowSync(solpanel);
                



            }
            else
            {
                solpanel.BackColor = Color.Beige;
                solpanel.Visible = false;
                solpanel.Width = 39;
                panelanimator.ShowSync(solpanel);
               


            }
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ana_menu_Click(object sender, EventArgs e)
        {
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            analabel.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
            ortapanel2.BringToFront();
            panel3.BringToFront();
        }

        private void sagpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void solpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ortapanel2_Load_2(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {

            if (panel3.Visible == true)
            {
                panel3.Visible = false;
            }
            else if (panel3.Visible == false)
            {
                panel3.Visible = true;
                timer3.Start();
            }

            
         
          
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (panel3.Visible == true)
            {


                timer3.Stop();
                panel3.Visible = false;


            }
        }

        private void bunifuFlatButton26_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult cikisSor = MessageBox.Show("PROGRAMDAN ÇIKMAK İSTEDİĞİNİZE EMİN MİSİNİZ ?", "ÇIKIŞ İŞLEMİ", MessageBoxButtons.OKCancel);

            if (cikisSor == DialogResult.OK)
            {
                this.Close();
                Kilitle kilit = new Kilitle();
                kilit.ShowDialog();

            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.SeaGreen;
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
        }

        private void bunifuFlatButton23_Click(object sender, EventArgs e)
        {
            Bildiri.Uyari("TAM SÜRÜM İÇİN KULLANILABİLİR!!", Bildiri.AlertType.bilgi);
        }

        private void bunifuFlatButton24_Click(object sender, EventArgs e)
        {
            Ayarlar ay = new Ayarlar();
            ay.Show();
        }
    }
    public class yuvarlak_buton : Button
    {
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(new Rectangle(Point.Empty, this.Size));
            this.Region = new Region(gp);
        }
    }
}
