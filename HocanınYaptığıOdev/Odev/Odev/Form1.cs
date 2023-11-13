using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListeYazTiklandiginda(object sender, EventArgs e)
        {
            //nesnelere isim vermek önemlidir.
            //nesnelerdeki font büyüklüğünü değiştirmek properties
            //penceresinden çok kolaydır.
            //array kullanımını hatırladık
            //for kullanımını hatırladık
            //array eleman sayısı : lenght dir.
            //listBox lar clear ile temizlenir.

            lstIsimListesi.Items.Clear();

            string[] isimler = new string[] { 
                "halil", 
                "osman", 
                "ayşe", 
                "fatma", 
                "ali", 
                "veli", 
                "kırkdokuz", 
                "elli", 
                "hayriye", 
                "haydar" };

            //lstIsimListesi.Items.Add("halil");
            //lstIsimListesi.Items.Add("osman");
            //lstIsimListesi.Items.Add("ayşe");
            //lstIsimListesi.Items.Add("fatma");
            //lstIsimListesi.Items.Add("ali");
            //lstIsimListesi.Items.Add("veli");
            //lstIsimListesi.Items.Add("kırkdokuz");
            //lstIsimListesi.Items.Add("elli");
            //lstIsimListesi.Items.Add("hayriye");
            //lstIsimListesi.Items.Add("haydar");

            for (int i = 0; i < isimler.Length; i++)
            {
                lstIsimListesi.Items.Add(isimler[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
