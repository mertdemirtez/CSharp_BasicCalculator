using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HesapMakinesi
{
    public partial class Form : System.Windows.Forms.Form
    {
        double sayi1 = 0, sayi2 = 0;
        char islem;

        public Form()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            islem = '+';
            textBox1.Clear();
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            islem = '-';
            textBox1.Clear();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            islem = '*';
            textBox1.Clear();
        }
        private void btnBol_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            islem = '/';
            textBox1.Clear();
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            sayi2 = double.Parse(textBox1.Text);

            switch (islem)
            {
                case '+':
                    textBox1.Text = (sayi1 + sayi2).ToString();
                    break;
                case '-':
                    textBox1.Text = (sayi1 - sayi2).ToString();
                    break;
                case '*':
                    textBox1.Text = (sayi1 * sayi2).ToString();
                    break;
                case '/':
                    if (sayi2 != 0)
                    {
                        textBox1.Text = (sayi1 / sayi2).ToString();
                    }
                    else
                    {
                        textBox1.Text = "Hata";
                    }
                    break;
            }
        }

 

        private void btnSil_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
