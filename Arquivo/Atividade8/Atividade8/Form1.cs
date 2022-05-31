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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Exercício1"];
            if (fc != null)
            {
                fc.Close();
            }

            //lembrar de colocar o isMdiContainer como TRUE

            Exercício1 frm1 = new Exercício1();
            frm1.MdiParent = this;
            frm1.WindowState = FormWindowState.Maximized;
            frm1.Show();
        }

        private void exercício22ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc2 = Application.OpenForms["Exercicio2"];
            if (fc2 != null)
            {
                fc2.Close();
            }

            Exercicio2 frm2 = new Exercicio2();
            frm2.MdiParent = this;
            frm2.WindowState = FormWindowState.Maximized;
            frm2.Show();
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Exercicio3"];
            if (fc != null)
            {
                fc.Close();
            }

            Exercicio3 frm3 = new Exercicio3();
            frm3.MdiParent = this;
            frm3.WindowState = FormWindowState.Maximized;
            frm3.Show();
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Form fc = Application.OpenForms["Exercicio4"];
             if (fc != null)
             {
               fc.Close();
             }

              Exercicio4 frm4 = new Exercicio4();
              frm4.MdiParent = this;
              frm4.WindowState = FormWindowState.Maximized;
              frm4.Show();
        }
    }
}
