
namespace Atividade8
{
    partial class Exercicio2
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
            this.btn1 = new System.Windows.Forms.Button();
            this.txtBx1 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn1.Location = new System.Drawing.Point(473, 361);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(208, 56);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Gerar número H";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtBx1
            // 
            this.txtBx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtBx1.Location = new System.Drawing.Point(473, 252);
            this.txtBx1.Name = "txtBx1";
            this.txtBx1.Size = new System.Drawing.Size(208, 32);
            this.txtBx1.TabIndex = 2;
            this.txtBx1.TextChanged += new System.EventHandler(this.txtBx1_TextChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl1.Location = new System.Drawing.Point(481, 197);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(188, 26);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Digite o número N";
            // 
            // Exercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 603);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtBx1);
            this.Controls.Add(this.btn1);
            this.Name = "Exercicio2";
            this.Text = "Exercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtBx1;
        private System.Windows.Forms.Label lbl1;
    }
}