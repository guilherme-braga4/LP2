namespace Triangulos_Atividade4_Guilherme_Braga
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
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_LadoA = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.VERIFICAR = new System.Windows.Forms.Button();
            this.LIMPAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "LADO C";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_LadoA
            // 
            this.lbl_LadoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LadoA.Location = new System.Drawing.Point(335, 114);
            this.lbl_LadoA.Name = "lbl_LadoA";
            this.lbl_LadoA.Size = new System.Drawing.Size(207, 31);
            this.lbl_LadoA.TabIndex = 3;
            this.lbl_LadoA.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.lbl_LadoA_MaskInputRejected);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.Location = new System.Drawing.Point(335, 178);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(207, 31);
            this.maskedTextBox2.TabIndex = 4;
            this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox3.Location = new System.Drawing.Point(335, 246);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(207, 31);
            this.maskedTextBox3.TabIndex = 5;
            this.maskedTextBox3.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            // 
            // VERIFICAR
            // 
            this.VERIFICAR.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.VERIFICAR.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VERIFICAR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.VERIFICAR.Location = new System.Drawing.Point(153, 351);
            this.VERIFICAR.Name = "VERIFICAR";
            this.VERIFICAR.Size = new System.Drawing.Size(240, 48);
            this.VERIFICAR.TabIndex = 6;
            this.VERIFICAR.Text = "VERIFICAR";
            this.VERIFICAR.UseVisualStyleBackColor = false;
            this.VERIFICAR.Click += new System.EventHandler(this.VERIFICAR_Click);
            // 
            // LIMPAR
            // 
            this.LIMPAR.BackColor = System.Drawing.SystemColors.Info;
            this.LIMPAR.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIMPAR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LIMPAR.Location = new System.Drawing.Point(454, 351);
            this.LIMPAR.Name = "LIMPAR";
            this.LIMPAR.Size = new System.Drawing.Size(240, 48);
            this.LIMPAR.TabIndex = 7;
            this.LIMPAR.Text = "LIMPAR";
            this.LIMPAR.UseVisualStyleBackColor = false;
            this.LIMPAR.Click += new System.EventHandler(this.LIMPAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "LADO B";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "LADO A";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 582);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LIMPAR);
            this.Controls.Add(this.VERIFICAR);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.lbl_LadoA);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox lbl_LadoA;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Button VERIFICAR;
        private System.Windows.Forms.Button LIMPAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

