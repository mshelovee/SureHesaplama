using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Süre_Hesaplama___96
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            tmrSure.Start();
        }

        private void tmrSure_Tick(object sender, EventArgs e)
        {
            string girisZamani = DateTime.Now.ToLongTimeString();
            string cikisZamani = txtSure.Text;
            TimeSpan girisCikisFarki = DateTime.Parse(cikisZamani).Subtract(DateTime.Parse(girisZamani));
            string calismaSuresi = girisCikisFarki.ToString();
            lblFark.Text = calismaSuresi.ToString();
        }
    }
}
