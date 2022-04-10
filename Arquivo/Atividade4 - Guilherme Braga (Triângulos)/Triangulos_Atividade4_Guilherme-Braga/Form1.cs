using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulos_Atividade4_Guilherme_Braga
{
    public partial class Form1 : Form
    {
        double ladoA;
        double ladoB;
        double ladoC;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_LadoA_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void VERIFICAR_Click(object sender, EventArgs e)
        {
           if (double.TryParse(lbl_LadoA.Text, out ladoA) && double.TryParse(maskedTextBox2.Text, out ladoB) && double.TryParse(maskedTextBox3.Text, out ladoC))
            if ((ladoA < (ladoB + ladoC)) && (ladoA > Math.Abs(ladoB - ladoC)) && (ladoB < (ladoA + ladoC)) && (ladoB > Math.Abs(ladoA - ladoC)) && (ladoC < (ladoA + ladoB)) && (ladoC > Math.Abs(ladoA -ladoB))) {
                {
                    if ((ladoA == ladoB) && (ladoB == ladoC) && (ladoC == ladoA))
                    {
                        MessageBox.Show("O triângulo é Equilátero");
                    }
                    else if ((ladoA == ladoB) || (ladoA == ladoC) || (ladoB == ladoC))
                    {
                        MessageBox.Show("O triângulo é Isóceles");
                    }
                    else 
                    {
                        MessageBox.Show("O triângulo é Escaleno");
                    }
                }
            }
        }

        private void LIMPAR_Click(object sender, EventArgs e)
        {
            lbl_LadoA.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
        }

      }
}
