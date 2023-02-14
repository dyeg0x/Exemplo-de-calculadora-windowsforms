using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadorazao
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text += 1;
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text += 2;
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text += 3;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 4;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 5;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 7;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 8;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 9;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.ResetText();
        }
    }
}
