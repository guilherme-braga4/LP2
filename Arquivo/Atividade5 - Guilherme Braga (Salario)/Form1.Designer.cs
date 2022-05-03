namespace Atividade5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.mskbxSalario = new System.Windows.Forms.MaskedTextBox();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.txtbxFilhos = new System.Windows.Forms.TextBox();
            this.txtbxNome = new System.Windows.Forms.TextBox();
            this.grpbx1 = new System.Windows.Forms.GroupBox();
            this.chkbxF = new System.Windows.Forms.CheckBox();
            this.chkbxM = new System.Windows.Forms.CheckBox();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.chkbx3 = new System.Windows.Forms.CheckBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lblAliq1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.lblAliq2 = new System.Windows.Forms.Label();
            this.lblFamilia = new System.Windows.Forms.Label();
            this.lblLiquido = new System.Windows.Forms.Label();
            this.lblDesc1 = new System.Windows.Forms.Label();
            this.lblDesc2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.grpbx1.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNome.Location = new System.Drawing.Point(75, 77);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(133, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome funcionário";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSalario.Location = new System.Drawing.Point(75, 120);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(99, 20);
            this.lblSalario.TabIndex = 1;
            this.lblSalario.Text = "Salário bruto";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFilhos.Location = new System.Drawing.Point(75, 163);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(128, 20);
            this.lblFilhos.TabIndex = 2;
            this.lblFilhos.Text = "Número de filhos";
            // 
            // mskbxSalario
            // 
            this.mskbxSalario.Location = new System.Drawing.Point(223, 122);
            this.mskbxSalario.Mask = "$99000.00";
            this.mskbxSalario.Name = "mskbxSalario";
            this.mskbxSalario.Size = new System.Drawing.Size(131, 20);
            this.mskbxSalario.TabIndex = 4;
            // 
            // btnVerifica
            // 
            this.btnVerifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVerifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVerifica.Location = new System.Drawing.Point(145, 213);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(146, 33);
            this.btnVerifica.TabIndex = 6;
            this.btnVerifica.Text = "Verificar Desconto";
            this.btnVerifica.UseVisualStyleBackColor = false;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // txtbxFilhos
            // 
            this.txtbxFilhos.Location = new System.Drawing.Point(223, 163);
            this.txtbxFilhos.Name = "txtbxFilhos";
            this.txtbxFilhos.Size = new System.Drawing.Size(131, 20);
            this.txtbxFilhos.TabIndex = 7;
            // 
            // txtbxNome
            // 
            this.txtbxNome.Location = new System.Drawing.Point(223, 77);
            this.txtbxNome.Name = "txtbxNome";
            this.txtbxNome.Size = new System.Drawing.Size(131, 20);
            this.txtbxNome.TabIndex = 8;
            // 
            // grpbx1
            // 
            this.grpbx1.Controls.Add(this.chkbxM);
            this.grpbx1.Controls.Add(this.chkbxF);
            this.grpbx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpbx1.Location = new System.Drawing.Point(447, 77);
            this.grpbx1.Name = "grpbx1";
            this.grpbx1.Size = new System.Drawing.Size(200, 169);
            this.grpbx1.TabIndex = 9;
            this.grpbx1.TabStop = false;
            this.grpbx1.Text = "Sexo";
            // 
            // chkbxF
            // 
            this.chkbxF.AutoSize = true;
            this.chkbxF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkbxF.Location = new System.Drawing.Point(80, 42);
            this.chkbxF.Name = "chkbxF";
            this.chkbxF.Size = new System.Drawing.Size(38, 24);
            this.chkbxF.TabIndex = 0;
            this.chkbxF.Text = "F";
            this.chkbxF.UseVisualStyleBackColor = true;
            // 
            // chkbxM
            // 
            this.chkbxM.AutoSize = true;
            this.chkbxM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkbxM.Location = new System.Drawing.Point(80, 103);
            this.chkbxM.Name = "chkbxM";
            this.chkbxM.Size = new System.Drawing.Size(41, 24);
            this.chkbxM.TabIndex = 1;
            this.chkbxM.Text = "M";
            this.chkbxM.UseVisualStyleBackColor = true;
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.chkbx3);
            this.pnl1.Location = new System.Drawing.Point(447, 252);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(200, 100);
            this.pnl1.TabIndex = 10;
            // 
            // chkbx3
            // 
            this.chkbx3.AutoSize = true;
            this.chkbx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkbx3.Location = new System.Drawing.Point(60, 41);
            this.chkbx3.Name = "chkbx3";
            this.chkbx3.Size = new System.Drawing.Size(83, 24);
            this.chkbx3.TabIndex = 0;
            this.chkbx3.Text = "Casado";
            this.chkbx3.UseVisualStyleBackColor = true;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl4.Location = new System.Drawing.Point(76, 293);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(51, 20);
            this.lbl4.TabIndex = 11;
            this.lbl4.Text = "label1";
            // 
            // lblAliq1
            // 
            this.lblAliq1.AutoSize = true;
            this.lblAliq1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAliq1.Location = new System.Drawing.Point(46, 415);
            this.lblAliq1.Name = "lblAliq1";
            this.lblAliq1.Size = new System.Drawing.Size(109, 20);
            this.lblAliq1.TabIndex = 12;
            this.lblAliq1.Text = "Alíquota INSS";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(171, 415);
            this.maskedTextBox1.Mask = "$";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 13;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(171, 463);
            this.maskedTextBox2.Mask = "$";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 14;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(171, 513);
            this.maskedTextBox3.Mask = "$";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox3.TabIndex = 15;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(171, 561);
            this.maskedTextBox4.Mask = "$";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox4.TabIndex = 16;
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Location = new System.Drawing.Point(527, 463);
            this.maskedTextBox5.Mask = "$";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox5.TabIndex = 17;
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.Location = new System.Drawing.Point(527, 513);
            this.maskedTextBox6.Mask = "$";
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox6.TabIndex = 18;
            // 
            // lblAliq2
            // 
            this.lblAliq2.AutoSize = true;
            this.lblAliq2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAliq2.Location = new System.Drawing.Point(47, 463);
            this.lblAliq2.Name = "lblAliq2";
            this.lblAliq2.Size = new System.Drawing.Size(108, 20);
            this.lblAliq2.TabIndex = 19;
            this.lblAliq2.Text = "Alíquota IRPF";
            // 
            // lblFamilia
            // 
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFamilia.Location = new System.Drawing.Point(45, 513);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(112, 20);
            this.lblFamilia.TabIndex = 20;
            this.lblFamilia.Text = "Salário Família";
            // 
            // lblLiquido
            // 
            this.lblLiquido.AutoSize = true;
            this.lblLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLiquido.Location = new System.Drawing.Point(47, 561);
            this.lblLiquido.Name = "lblLiquido";
            this.lblLiquido.Size = new System.Drawing.Size(113, 20);
            this.lblLiquido.TabIndex = 21;
            this.lblLiquido.Text = "Salário Líquido";
            // 
            // lblDesc1
            // 
            this.lblDesc1.AutoSize = true;
            this.lblDesc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDesc1.Location = new System.Drawing.Point(385, 463);
            this.lblDesc1.Name = "lblDesc1";
            this.lblDesc1.Size = new System.Drawing.Size(120, 20);
            this.lblDesc1.TabIndex = 22;
            this.lblDesc1.Text = "Desconto INSS";
            // 
            // lblDesc2
            // 
            this.lblDesc2.AutoSize = true;
            this.lblDesc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDesc2.Location = new System.Drawing.Point(386, 513);
            this.lblDesc2.Name = "lblDesc2";
            this.lblDesc2.Size = new System.Drawing.Size(119, 20);
            this.lblDesc2.TabIndex = 23;
            this.lblDesc2.Text = "Desconto IRPF";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(351, 367);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 24;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 650);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lblDesc2);
            this.Controls.Add(this.lblDesc1);
            this.Controls.Add(this.lblLiquido);
            this.Controls.Add(this.lblFamilia);
            this.Controls.Add(this.lblAliq2);
            this.Controls.Add(this.maskedTextBox6);
            this.Controls.Add(this.maskedTextBox5);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lblAliq1);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.grpbx1);
            this.Controls.Add(this.txtbxNome);
            this.Controls.Add(this.txtbxFilhos);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.mskbxSalario);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbx1.ResumeLayout(false);
            this.grpbx1.PerformLayout();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.MaskedTextBox mskbxSalario;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.TextBox txtbxFilhos;
        private System.Windows.Forms.TextBox txtbxNome;
        private System.Windows.Forms.GroupBox grpbx1;
        private System.Windows.Forms.CheckBox chkbxM;
        private System.Windows.Forms.CheckBox chkbxF;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.CheckBox chkbx3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lblAliq1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.Label lblAliq2;
        private System.Windows.Forms.Label lblFamilia;
        private System.Windows.Forms.Label lblLiquido;
        private System.Windows.Forms.Label lblDesc1;
        private System.Windows.Forms.Label lblDesc2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

