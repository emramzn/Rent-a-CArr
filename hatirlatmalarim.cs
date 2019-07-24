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
    public partial class hatirlatmalarim : UserControl
    {
        public hatirlatmalarim()
        {
            InitializeComponent();
        }

        private void sigortamuayene_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void rezervasyon_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void kiradakiler_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void sigortamuayene_btn1_Click(object sender, EventArgs e)
        {
            SigortaMuayeneKasko a = new SigortaMuayeneKasko();
            a.ShowDialog();
        }

        private void rezervasyon_btn_Click_1(object sender, EventArgs e)
        {
            mevcut_rezervler mvrezerv = new mevcut_rezervler();
            mvrezerv.Show();
        }

        private void kiradakiler_btn1_Click(object sender, EventArgs e)
        {
            kiradakiler kirada = new kiradakiler();
            kirada.ShowDialog();
        }
    }
}
