using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_A_Car
{
    public partial class yazdir : Form
    {
        public BorderStyle BorderStyle { get; set; }
        public yazdir()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
        int SimdikiWidth = 1366;
        int SimdikiHeight = 768;
        private void yazdir_Load(object sender, EventArgs e)
        {
            Rectangle ClientCozunurluk = new Rectangle();

            ClientCozunurluk = Screen.GetBounds(ClientCozunurluk);

            float OranWidth = ((float)ClientCozunurluk.Width / (float)SimdikiWidth);

            float OranHeight = ((float)ClientCozunurluk.Height / (float)SimdikiHeight);


            this.Scale(OranWidth, OranHeight);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

      
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
          
        }


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
          
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
