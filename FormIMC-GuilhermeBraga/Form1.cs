using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormIMC_GuilhermeBraga
{
    public partial class Form1 : Form
    {
        double imc;
        double peso;
        double altura;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(maskedTextBox1.Text, out peso) && double.TryParse(maskedTextBox2.Text, out altura)) {
                if (peso != 0 && altura != 0 )
                {
                    imc = (peso / (altura * altura));
                    if (imc < 18.5)
                    {
                        MessageBox.Show("O seu IMC é " + imc.ToString() + " e sua classificação é Magreza");

                    }
                    else if (imc >= 18.5 && imc <= 24.9)
                    {
                        MessageBox.Show("O seu IMC é " + imc.ToString() + "  sua classificação é Normal");
                    }
                    else if (imc >= 25 && imc <= 29.9)e
                    {
                        MessageBox.Show("O seu IMC é " + imc.ToString() + " e sua classificação é Sobrepeso");
                    }
                    else if (imc >= 30 && imc <= 39.9)
                    {
                        MessageBox.Show("O seu IMC é " + imc.ToString() + " e sua classificação é Obesidade");
                    }
                    else
                    {
                        MessageBox.Show("O seu IMC é " + imc.ToString() + " e sua classificação é Obesidade Grave");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
        }
    }
}
