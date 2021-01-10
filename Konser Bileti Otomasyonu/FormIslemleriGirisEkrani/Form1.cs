using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormIslemleriGirisEkrani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            Form2 yeni = new Form2();
            if (textBoxKullaniciAd.Text == "admin" && textBoxKullaniciSifre.Text == "admin")
            {
                yeni.Show();
                this.Hide();
                

            }
            else {
                MessageBox.Show("Giriş Başarısız");
                
                textBoxKullaniciAd.Clear();
                
                textBoxKullaniciSifre.Clear();
                
            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Güzel seçim ama Önce giriş yapmalısın..");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Güzel seçim ama Önce giriş yapmalısın..");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Güzel seçim ama Önce giriş yapmalısın..");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Güzel seçim ama Önce giriş yapmalısın..");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Güzel seçim ama Önce giriş yapmalısın..");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Güzel seçim ama Önce giriş yapmalısın..");
        }
    }
}
