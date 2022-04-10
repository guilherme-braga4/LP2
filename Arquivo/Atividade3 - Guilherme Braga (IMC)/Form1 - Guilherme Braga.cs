using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double imc;
        short peso;
        float altura;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mskbxPeso(object sender, mskbxPeso e)
        {

        }

        private void mskbxAltura(object sender, mskbxAltura e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(mskbxPeso.text, out peso && double.TryParse(mskbxAltura.text, out altura))
            {
                if (peso !== 0 && altura !== 0) { 
                imc = peso / (altura * altura);
                    if (imc < 18.5)
                    {
                        MessageBox.Show("O seu IMC é " + imc.ToString() + " e sua classificação é Magreza");
                    }
                    else if (imc >= 18.5 && imc <= 24.9)
                    {
                        MessageBox.Show("O seu IMC é " + imc.ToString() + " e sua classificação é Normal");
                    }
                    else if (imc >= 25 && imc <= 29.9)
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
    }
}
