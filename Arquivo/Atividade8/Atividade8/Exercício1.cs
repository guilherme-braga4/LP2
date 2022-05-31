using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade8
{
    public partial class Exercício1 : Form
    {
        public Exercício1()
        {
            InitializeComponent();
        }

        private void richTxtFrase_TextChanged(object sender, EventArgs e)
        {
            if (richTxtFrase.Text.Length > 100)
            {
                MessageBox.Show("O texto não pode conter mais do que 100 caracteres");
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (richTxtFrase.Text == "") {
                MessageBox.Show("Está vazio");
            }
            else
            {
                int i = 0;
                foreach (char c in richTxtFrase.Text)
                {
                    if (c == ' ')
                    {
                        i++;
                    }
                }
                MessageBox.Show("O número de espaços em branco é " + i);
            }   
           }

        

        private void btn2_Click(object sender, EventArgs e)
        {

            if (richTxtFrase.Text == "")
            {
                MessageBox.Show("Está vazio");
            }
            else
            {
                int i = 0;
                foreach (char c in richTxtFrase.Text)
                {
                    if (c == 'r' || c == 'R')
                    {
                        i++;
                    }
                }
                MessageBox.Show("O número de letras 'R' ou 'r' é " + i);
            }   

        }

        private void btn3_Click(object sender, EventArgs e)
        {

            if (richTxtFrase.Text == "")
            {
                MessageBox.Show("Está vazio");
            }
            else
            {
                int i = 0;
                foreach (char c in richTxtFrase.Text)
                {
                    if (c == c )
                    {
                        i++;
                    }
                }
                MessageBox.Show("O número de letras pares é " + i);
            }  

        }

        private void Exercício1_Load(object sender, EventArgs e)
        {

        }
    }
}
