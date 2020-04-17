using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            buttonTemizle.Enabled = false;
        }

        private void buttonYaziyaCevir_Click(object sender, EventArgs e)
        {
            try
            {

            string[] birler = {"","bir","iki","üç","dört","beş","altı","yedi","sekiz","dokuz" };
            string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
            string[] yuzler = { "", "yüz", "ikiyüz", "üçyüz", "dörtyüz", "beşyüz", "altıyüz", "yediyüz", "sekizyüz", "dokuzyüz" };
            string[] binler = { "", "bin", "ikibin", "üçbin", "dörtbin", "beşbin", "altıbin", "yedibin", "sekizbin", "dokuzbin" };
            string[] onbinler = { "", "onbin", "yirmibin", "otuzbin", "kırkbin", "ellibin", "altmışbin", "yetmişbin", "seksenbin", "doksanbin" };

           
                int sayi = Convert.ToInt32(textBoxSayi.Text);

                if (sayi >= 1000000000)
                {
                    MessageBox.Show("Bu işlem sadece birler ile onbinler arasındaki sayıları kapsamaktadır");
                }

                int onbinlerbasamagi = sayi % 100000 / 10000;
                int binlerbasamagi = sayi % 10000 / 1000;
                int yuzlerbasamagi = sayi % 1000 / 100;
                int onlarbasamagi = sayi % 100 / 10;
                int birlerbasamagi = sayi % 10;

                string yazi = onbinler[onbinlerbasamagi] + binler[binlerbasamagi] + yuzler[yuzlerbasamagi] + onlar[onlarbasamagi] + birler[birlerbasamagi];
                labelYazi.Text = yazi;
                
                buttonTemizle.Enabled = true;
                buttonYaziyaCevir.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen sayısal deger giriniz");
            }
            

            

            

        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            buttonTemizle.Enabled = false;
            labelYazi.Text = null;
            textBoxSayi.Text = null;
        }
    }
}
