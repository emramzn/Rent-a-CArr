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
    public partial class Bildiri : Form
    {
        public Bildiri(string message, AlertType type)
        {
            string yazilacak = "";
            if (message.Length >= 36)
            {
                int bosluk_indisi = 0;
                int sayac = 0;
                foreach (char i in message)
                {

                    if (sayac < 36)
                    {
                        if (i.ToString() == " ")
                        {
                            bosluk_indisi++;
                        }
                    }
                    sayac++;
                }
                
                sayac = 0;
                foreach (char i in message)
                {
                    yazilacak += i.ToString();
                    if (i.ToString() == " ")
                    {
                        sayac++;
                    }
                    if (sayac == bosluk_indisi)
                    {
                        yazilacak += "\n";
                        bosluk_indisi = 0;
                    }
                }
            }
            InitializeComponent();
            if(message.Length>=36)
                yazitxt.Text = yazilacak;
            else
                yazitxt.Text = message;




            switch (type)
            {
                case AlertType.basarili:
                    this.BackColor = Color.SeaGreen;
                    icon.Image = resimlistesi.Images[3];
                    break;
                case AlertType.bilgi:
                    this.BackColor = Color.Gray;
                    icon.Image = resimlistesi.Images[2];
                    break;
                case AlertType.dikkat:
                    this.BackColor = Color.Crimson;
                    icon.Image = resimlistesi.Images[1];
                    break;
                case AlertType.hata:
                    this.BackColor = Color.FromArgb(255, 128, 0);
                    icon.Image = resimlistesi.Images[0];
                    break;
            }
        }

        public static void Uyari(string message, AlertType type)
        {
            new custom_alert_notifications.Bildiri(message, type).Show();
        }

        private void Bildiri_Load(object sender, EventArgs e)
        {
            this.Top = -1 * (this.Height);
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;

            goruntulezamanı.Start();
        }
        public enum AlertType
        {
            basarili, bilgi, dikkat, hata
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            kapatzamanı.Start();
        }

        private void zamandoldu_Tick(object sender, EventArgs e)
        {
            kapatzamanı.Start();
        }

        int interval = 0;

        private void goruntulezamanı_Tick(object sender, EventArgs e)
        {
            if (this.Top < 60)
            {
                this.Top += interval;
                interval += 2;
            }
            else
            {
                goruntulezamanı.Stop();
            }
        }

        private void kapatzamanı_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.2;

            }
            else
            {
                this.Close();
            }
        }

        private void yazitxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Bildiri_Activated(object sender, EventArgs e)
        {
        }
    }
}
