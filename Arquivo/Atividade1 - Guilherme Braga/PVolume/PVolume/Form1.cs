using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    {
        Double raio;
        Double altura;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            

            if (!Double.TryParse(textBox1.Text, out raio))
            {
                MessageBox.Show("O Raio digitado é inválido");
               // textBox1.Focus();
            }
            else
                if (raio <=0)
            {
                MessageBox.Show("O Raio deve ser maior que zero");
              //  textBox1.Focus();
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            

            if (!Double.TryParse(textBox2.Text, out altura))
            {
                MessageBox.Show("A Altura digitada é inválida");
               // textBox2.Focus();
            }
            else 
                if (altura <=0)
            {
                MessageBox.Show("A Altura deve ser maior que zero");
               // textBox2.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (!Double.TryParse(textBox1.Text, out raio))
            {
                MessageBox.Show("O Raio digitado é inválido");
                textBox1.Focus();
            }
            else
                if (raio <= 0)
            {
                MessageBox.Show("O Raio deve ser maior que zero");
                textBox1.Focus();
            }
            else // testar a altura
            {
                if (!Double.TryParse(textBox2.Text, out altura))
                {
                    MessageBox.Show("A Altura digitada é inválida");
                    textBox2.Focus();
                }
                else
                    if (altura <= 0)
                {
                    MessageBox.Show("A Altura deve ser maior que zero");
                    textBox2.Focus();
                }
                else // fazer calculo
                {
                    // Volume = pi x r 2 altura


                    volume = Math.PI * Math.Pow(raio, 2) * altura;

                    textBox3.Text = volume.ToString("N2");

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
