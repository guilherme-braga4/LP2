namespace Atividade8
{
    partial class Exercício1
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
            this.richTxtFrase = new System.Windows.Forms.RichTextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTxtFrase
            // 
            this.richTxtFrase.Location = new System.Drawing.Point(92, 72);
            this.richTxtFrase.Name = "richTxtFrase";
            this.richTxtFrase.Size = new System.Drawing.Size(535, 183);
            this.richTxtFrase.TabIndex = 0;
            this.richTxtFrase.Text = "";
            this.richTxtFrase.TextChanged += new System.EventHandler(this.richTxtFrase_TextChanged);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn1.Location = new System.Drawing.Point(30, 356);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(204, 103);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Espaço em Branco";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn2.Location = new System.Drawing.Point(262, 356);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(198, 103);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "N Letras \"R\"";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn3.Location = new System.Drawing.Point(507, 356);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(198, 103);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "N Letras em Pares (Ex: \"SS\")";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // Exercício1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 619);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.richTxtFrase);
            this.Name = "Exercício1";
            this.Text = "Exercício1";
            this.Load += new System.EventHandler(this.Exercício1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxtFrase;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
    }
}