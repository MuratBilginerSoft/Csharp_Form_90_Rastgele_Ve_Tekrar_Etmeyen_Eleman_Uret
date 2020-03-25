using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rastgele_Ve_Tekrar_Etmeyen_Eleman_Üret
{
    public partial class Form1 : Form
    {

        int[] sayı = new int[20];
        Random r = new Random();
        int x;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                do
                {
                    x = r.Next(1, 50);
                } while (Array.IndexOf(sayı, x) != -1); // Bu Kod diziye aynı değerin girilmesine engelliyor.

                sayı[i] = x;
                listBox1.Items.Add(x);
            }

            Array.Sort(sayı);

            for (int j = 0; j < 20; j++)
            {
                listBox2.Items.Add(sayı[j]);
            }
        }
    }
}
