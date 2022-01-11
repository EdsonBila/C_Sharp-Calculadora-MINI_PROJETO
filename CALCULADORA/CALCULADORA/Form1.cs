using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)// botao 0
        {// OU textResultado.Text = textResultado.Text + "0";
            textResultado.Text += "0"; 
        }

        private void button15_Click(object sender, EventArgs e)// botao 1
        {
            textResultado.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)// botao 2
        {
            textResultado.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)// botao 3
        {
            textResultado.Text += "3";
        }

        private void button20_Click(object sender, EventArgs e)// botao 4
        {
            textResultado.Text += "4";
        }

        private void button19_Click(object sender, EventArgs e)// botao 5
        {
            textResultado.Text += "5";
        }

        private void button18_Click(object sender, EventArgs e)// botao 6
        {
            textResultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)// botao 7
        {
            textResultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)// botao 8
        {
            textResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)// botao 9
        {
            textResultado.Text += "9";
        }

        private void button8_Click(object sender, EventArgs e)// botao .
        {
            textResultado.Text += ".";
        }

        private void button11_Click(object sender, EventArgs e)// botao =
        {
            valor2 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);

            if(operacao == "SOMA")
            {
                textResultado.Text = Convert.ToString(valor1 + valor2); 
            }
            else if(operacao == "SUB")
            {
                textResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if(operacao == "MULT")
            {
                textResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else
            {
                textResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void button17_Click(object sender, EventArgs e)// botao -
        {
            if (textResultado.Text != "")
            {
                valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                textResultado.Text = "";
                operacao = "SUB";
                lblOperacao.Text = "-";
            }
            
        }

        private void button12_Click(object sender, EventArgs e)// botao X
        {
            if (textResultado.Text != "")
            {
                valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                textResultado.Text = "";
                operacao = "MULT";
                lblOperacao.Text = "X";
            }
            
        }

        private void button7_Click(object sender, EventArgs e)// botao /
        {
            if (textResultado.Text != "")
            {
                valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                textResultado.Text = "";
                operacao = "DIV";
                lblOperacao.Text = "/";
            }
            
        }

        private void button5_Click(object sender, EventArgs e)// botao CE
        {
            textResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)// botao C
        {
            textResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)// botao +
        {
            if(textResultado.Text != "")
            {
                valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                textResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
            
        }
    }
}
