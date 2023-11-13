using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArttirmaOperatoru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2++;

            textBox1.Text = String.Format("sayi1 = {0  }, sayi2 = {1}", sayi1, sayi2);

            //string a = "halil";
            //MessageBox.Show(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = ++sayi2;

            textBox1.Text = String.Format("sayi1 = {0}, sayi2 = {1}", sayi1, sayi2);

            var a = 25135132135M;

            MessageBox.Show(a.GetType().ToString());

            //a = "halil";  ilk atanan değer decimal olduğu için bu string ifade hata verir
            //var türü ilk atanan değerin tipini alır.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
