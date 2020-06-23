using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mStok_lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(textBox1.Text.ToString());
            int g = Convert.ToInt32(textBox2.Text.ToString());

            Random rD = new Random();
            int x1 = rD.Next(1, 100);
            int x2 = rD.Next(1, 100);

            textBox3.Text = x1.ToString();
            textBox4.Text = x2.ToString();

            BigInteger Y1 = BigInteger.ModPow(g, x1, p);
            BigInteger Y2 = BigInteger.ModPow(g, x2, p);

            textBox5.Text = Y1.ToString();
            textBox6.Text = Y2.ToString();

            BigInteger Z1 = BigInteger.ModPow(Y2, x1, p);
            BigInteger Z2 = BigInteger.ModPow(Y1, x2, p);

            textBox7.Text = Z1.ToString();
            textBox8.Text = Z2.ToString();

        }
    }
}
