using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BSTHSPMKNS
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
            int sayi = Int32.Parse(textBox1.Text);
            int sayi2 = Int32.Parse(textBox2.Text);

            textBox3.Text = (sayi + sayi2).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Int32.Parse(textBox1.Text);
            int sayi2 = Int32.Parse(textBox2.Text);

            textBox3.Text = (sayi - sayi2).ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi = Int32.Parse(textBox1.Text);
            int sayi2 = Int32.Parse(textBox2.Text);

            textBox3.Text = (sayi * sayi2).ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi = Int32.Parse(textBox1.Text);
            int sayi2 = Int32.Parse(textBox2.Text);

            textBox3.Text = (sayi / sayi2).ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi = Int32.Parse(textBox1.Text);
            int sayi2 = Int32.Parse(textBox2.Text);

            textBox3.Text = (sayi % sayi2).ToString();
            textBox4.Text = (sayi2 % sayi).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int sayi = Int32.Parse(textBox1.Text);
            int sayi2 = Int32.Parse(textBox2.Text);

            textBox3.Text = (sayi * sayi).ToString();
            textBox4.Text= (sayi2 * sayi2).ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }
        
    }
}
