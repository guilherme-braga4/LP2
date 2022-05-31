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
    public partial class Exercicio4 : Form
    {
        public Exercicio4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBx1.Text == "" && txtBx2.Text == "" && txtBx3.Text == "" && txtBx4.Text == "" && txtBx5.Text == "" && mskTxtBx1.Text == "") {
                MessageBox.Show("Os campos devem estar preenchidos");
            }
            else {
                int.TryParse(txtBx4.Text, out int producao);
                int.TryParse(mskTxtBx1.Text, out int salario);
                int.TryParse(txtBx5.Text, out int gratificao);

                if (producao >= 100 && producao < 120) { 
                    double salarioBruto = salario + (salario * (1 * 0.05)) + gratificao;
                    if (salarioBruto > 7000)
                        MessageBox.Show("O salário do mês é " + 7000 + "...A produção foi menor do que 150!");
                    else MessageBox.Show("O salário do mês é " + salarioBruto);
                }

                if (producao >= 120 && producao < 150)
                {
                    double salarioBruto = salario + (salario * (1 * 0.05 + 1 * 0.01)) + gratificao;
                    if (salarioBruto > 7000)
                        MessageBox.Show("O salário do mês é " + 7000 + "...A produção foi menor do que 150!");
                    else MessageBox.Show("O salário do mês é " + salarioBruto);
                }

                if (producao >= 150)
                {
                    double salarioBruto = salario + (salario * (1 * 0.05 + 1 * 0.01 + 1 * 0.01)) + gratificao;
                    if (salarioBruto > 7000 && gratificao != 0)
                        MessageBox.Show("O salário do mês é " + salarioBruto);
                    else MessageBox.Show("O salário do mês é " + 7000 + "...não houve gratificação!");
                }
                else {
                    double salarioBruto = salario + gratificao;
                    if (salarioBruto > 7000)
                        MessageBox.Show("O salário do mês é 7000, pois a produção foi menor do que 150 " +  7000);
                    else MessageBox.Show("O salário do mês não possui bônus " + salarioBruto);
                }

                MessageBox.Show("O valor da produção é " + producao);
            }


        }

        private void txtBx4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
