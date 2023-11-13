using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _5.Ders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            //textBox2.Clear();

            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2++;
            //sayi1 = sayi2--;
            textBox1.Text = String.Format("sayi1 = {0} , sayi2 = {1} ", sayi1, sayi2);
            //textBox2.Text = String.Format("sayi1 = {0} , sayi2 = {1} ", sayi1, sayi2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            //textBox2.Clear();

            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = ++sayi2;
            //sayi1 = --sayi2;
            textBox1.Text = String.Format("sayi1 = {0} , sayi2 = {1} ", sayi1, sayi2);
            //textBox2.Text = String.Format("sayi1 = {0} , sayi2 = {1} ", sayi1, sayi2);
        }

       

        
    }
}
