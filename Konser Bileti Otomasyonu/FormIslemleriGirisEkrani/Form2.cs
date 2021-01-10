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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            listBox1.Items.Add("    ");
            listBox1.Items.Add("Tarih : 16.01.2021");
            listBox1.Items.Add("    ");
            listBox1.Items.Add("Saat : 21:00");
            listBox1.Items.Add("      ");
            listBox1.Items.Add("Yer : Cemil Topuzlu Açık Hava Tiyatrosu ,");
            listBox1.Items.Add(" Şişli / İstanbul");
            listBox1.Items.Add("   ");
            listBox1.Items.Add("Ücret : 150 TL");
            listBox2.Items.Add("    ");
            listBox2.Items.Add("Tarih : 16.01.2021   Saat : 21:00   Yer : Cemil Topuzlu Açık Hava Tiyatrosu ,Şişli / İstanbul  Ücret : 150 TL");

        }

        private void button5_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            listBox1.Items.Add("    ");
            listBox1.Items.Add("Tarih : 25.02.2021");
            listBox1.Items.Add("    ");
            listBox1.Items.Add("Saat : 22:00");
            listBox1.Items.Add("      ");
            listBox1.Items.Add("Yer : ANZ stadium , Sidney/Avustralya");
            listBox1.Items.Add("   ");
            listBox1.Items.Add("Ücret : 110 AUD ");

            listBox2.Items.Add("    ");
            listBox2.Items.Add("Tarih : 25.02.2021   Saat : 22:00   Yer : ANZ stadium , Sidney/Avustralya  Ücret : 110 AUD");

        }

        private void button6_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            listBox1.Items.Add("    ");
            listBox1.Items.Add("Tarih : 22.06.2021");
            listBox1.Items.Add("    ");
            listBox1.Items.Add("Saat : 16:00");
            listBox1.Items.Add("      ");
            listBox1.Items.Add("Yer : Marley Park , Dublin/İrlanda");
            listBox1.Items.Add("   ");
            listBox1.Items.Add("Ücret : 90 EURO");

            listBox2.Items.Add("    ");
            listBox2.Items.Add("Tarih : 22.06.2021   Saat : 16:00   Yer : Marley Park , Dublin/İrlanda  Ücret : 90 EURO");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            listBox1.Items.Add("    ");
            listBox1.Items.Add("Tarih : 18.11.2021");
            listBox1.Items.Add("    ");
            listBox1.Items.Add("Saat : 22:00");
            listBox1.Items.Add("      ");
            listBox1.Items.Add("Yer : Jolly joker Antalya Muratpaşa/Antalya");
            listBox1.Items.Add("   ");
            listBox1.Items.Add("Ücret : 115 TL");

            listBox2.Items.Add("    ");
            listBox2.Items.Add("Tarih : 18.11.2021   Saat : 22:00   Yer : Jolly joker Antalya Muratpaşa/Antalya  Ücret : 115 TL");
        }

        private void button8_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            listBox1.Items.Add("    ");
            listBox1.Items.Add("Tarih : 12.09.2021");
            listBox1.Items.Add("    ");
            listBox1.Items.Add("Saat : 20:00");
            listBox1.Items.Add("      ");
            listBox1.Items.Add("Yer : Discovery Park , ");
            listBox1.Items.Add("Sacramento / Amerika Birleşik Devletleri");
            listBox1.Items.Add("   ");
            listBox1.Items.Add("Ücret : 65 DOLAR");

            listBox2.Items.Add("    ");
            listBox2.Items.Add("Tarih : 12.09.2021   Saat : 20:00   Yer : Discovery Park ,Sacramento / Amerika Birleşik Devletleri  Ücret : 65 DOLAR");

        }

        private void button9_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            listBox1.Items.Add("    ");
            listBox1.Items.Add("Tarih : 31.08.2021");
            listBox1.Items.Add("    ");
            listBox1.Items.Add("Saat : 23:00");
            listBox1.Items.Add("      ");
            listBox1.Items.Add("Yer : Dorock XL , Kadıköy/İstanbul");
            listBox1.Items.Add("   ");
            listBox1.Items.Add("Ücret : 210 TL");

            listBox2.Items.Add("    ");
            listBox2.Items.Add("Tarih : 31.08.2021   Saat : 23:00   Yer : Dorock XL , Kadıköy/İstanbul  Ücret : 210 TL");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                MessageBox.Show("BİLETİNİZ KAYIT ALTINA ALINMIŞTIR");
            }
            else
            {
                MessageBox.Show("LÜTFEN KONSER BİLETİ SEÇİNİZ");
            }
            listBox1.Items.Clear();

          

            




        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox2.Visible = true;

           
        }
    }
}
