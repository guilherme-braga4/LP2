using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace PNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //declarando a variável tipo matriz que vai ter x e y ou seja, 2 dimensões
            char[,] matrizNotas = new char[8, 10];
            string auxiliar;
            char resposta;
            int numeroQuestao = 0;
            char[] gabarito = new char[10]{'A','B','C','D','A','C','D','A','B','C'};

       
            for (var i = 0; i < 8; i++)
            {
                numeroQuestao = 0;

                for (var j = 0; j < 10; j++)
                {
                    auxiliar = Interaction.InputBox("Digite a resposta da questão: " + (j + 1), "Entrada das respostas");
                    
                    if (char.TryParse(auxiliar, out matrizNotas[i, j]))
                    {
                        if ((matrizNotas[i, j] != 'A') && (matrizNotas[i, j] != 'B') && (matrizNotas[i, j] != 'C') && (matrizNotas[i, j] != 'D') && (matrizNotas[i, j] != 'E'))
                        {
                            MessageBox.Show("Resposta inválida");

                            j--;
                        }

                        else
                        {
                            resposta = matrizNotas[i, j]; 

                            numeroQuestao++; 

                            if (gabarito[j] == resposta)
                            {
                                lstNotas.Items.Add("O Aluno: " + (i + 1) + " acertou a questão: " + (numeroQuestao) + " era " + gabarito[j] + " escolheu: " + resposta);
                            }
                            else lstNotas.Items.Add("O Aluno: " + (i + 1) + " errou a questão: " + (numeroQuestao) + " era " + gabarito[j] + " escolheu: " + resposta);                     

                        }
                    }
                    else
                    {
                        MessageBox.Show("Nota inválida");
                        j--;
                    }
                }
            }
        }
    }
}
