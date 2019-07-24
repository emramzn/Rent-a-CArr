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
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ana_menu_Click(object sender, EventArgs e)
        {
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            analabel.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
            kullanıcı_ayarları1.BringToFront();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            analabel.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            analabel.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            analabel.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            analabel.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
        }
    }
}
