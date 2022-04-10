using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalculadora
{
    public partial class Form1 : Form
    {
        double numero1, numero2, resultado; // globais

        private void txtNumero2_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNumero2.Text, out numero2))
            {
                // MessageBox.Show("Número 2 inválido!");
                // txtNumero1.Focus();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out numero1) &&
               (double.TryParse(txtNumero2.Text, out numero2)))
            {
                resultado = numero1 + numero2;
                txtResultado.Text = resultado.ToString();

                // btnLimpar(sender, e); //AQUI
            }
            else
                MessageBox.Show("Números inválidos!");
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out numero1) &&
               (double.TryParse(txtNumero2.Text, out numero2)))
            {
                resultado = numero1 - numero2;
                txtResultado.Text = resultado.ToString();

                // btnLimpar(sender, e); //AQUI
            }
            else
                MessageBox.Show("Números inválidos!");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out numero1) &&
               (double.TryParse(txtNumero2.Text, out numero2)))
            {
                resultado = numero1 * numero2;
                txtResultado.Text = resultado.ToString();

                // btnLimpar(sender, e); //AQUI
            }
            else
                MessageBox.Show("Números inválidos!");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out numero1) &&
               (double.TryParse(txtNumero2.Text, out numero2)))
            {
                if (numero2 == 0)
                    MessageBox.Show("Não pode ser dividido por zero!");
                else
                {
                    resultado = numero1 / numero2;
                    txtResultado.Text = resultado.ToString();

                   // btnLimpar(sender, e); //AQUI
                }
            }
            else
                MessageBox.Show("Números inválidos!");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumero1_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNumero1.Text, out numero1))
            {
                
                // MessageBox.Show("Número 1 inválido!");
                // txtNumero1.Focus();
            }

        }

    }
}
