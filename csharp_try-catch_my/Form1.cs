﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_try_catch_my
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                int toplam = sayi1 + sayi2;
                MessageBox.Show("Sayıların toplamı:" + toplam.ToString());
            }
            catch(Exception hata)
            {
                MessageBox.Show("Lütfen değerlerinizi kontrol ediniz"+hata.ToString());
            }
            finally //hata yoksa try+finally bloğu çalışır. hata varsa catch+finally bloğu çalışır
            {
                MessageBox.Show("Finally kodu çalıştı");
            }


        }
    }
}
