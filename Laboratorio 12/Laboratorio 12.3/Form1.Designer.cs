namespace Laboratorio_12._3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSemi = new System.Windows.Forms.Button();
            this.buttonArea = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSalida = new System.Windows.Forms.Button();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxSemiCalc = new System.Windows.Forms.TextBox();
            this.textBoxAreaCalc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa la longuitud de lado A";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 99);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(184, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa la longuitud de lado B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresa la longuitud de lado C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Calcular Semiperimetro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Area de triangulo";
            // 
            // buttonSemi
            // 
            this.buttonSemi.Location = new System.Drawing.Point(110, 197);
            this.buttonSemi.Name = "buttonSemi";
            this.buttonSemi.Size = new System.Drawing.Size(106, 23);
            this.buttonSemi.TabIndex = 5;
            this.buttonSemi.Text = "Semiperimetro";
            this.buttonSemi.UseVisualStyleBackColor = true;
            this.buttonSemi.Click += new System.EventHandler(this.buttonSemi_Click);
            // 
            // buttonArea
            // 
            this.buttonArea.Location = new System.Drawing.Point(222, 197);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(106, 23);
            this.buttonArea.TabIndex = 6;
            this.buttonArea.Text = "Area";
            this.buttonArea.UseVisualStyleBackColor = true;
            this.buttonArea.Click += new System.EventHandler(this.buttonArea_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(334, 197);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(118, 23);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSalida
            // 
            this.buttonSalida.Location = new System.Drawing.Point(458, 197);
            this.buttonSalida.Name = "buttonSalida";
            this.buttonSalida.Size = new System.Drawing.Size(108, 23);
            this.buttonSalida.TabIndex = 8;
            this.buttonSalida.Text = "Salida";
            this.buttonSalida.UseVisualStyleBackColor = true;
            this.buttonSalida.Click += new System.EventHandler(this.buttonSalida_Click);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(334, 51);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 22);
            this.textBoxA.TabIndex = 9;
            this.textBoxA.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(334, 99);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 22);
            this.textBoxB.TabIndex = 10;
            this.textBoxB.TextChanged += new System.EventHandler(this.textBoxB_TextChanged);
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(334, 147);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 22);
            this.textBoxC.TabIndex = 11;
            this.textBoxC.TextChanged += new System.EventHandler(this.textBoxC_TextChanged);
            // 
            // textBoxSemiCalc
            // 
            this.textBoxSemiCalc.Location = new System.Drawing.Point(334, 249);
            this.textBoxSemiCalc.Name = "textBoxSemiCalc";
            this.textBoxSemiCalc.Size = new System.Drawing.Size(100, 22);
            this.textBoxSemiCalc.TabIndex = 12;
            this.textBoxSemiCalc.TextChanged += new System.EventHandler(this.textBoxSemiCalc_TextChanged);
            // 
            // textBoxAreaCalc
            // 
            this.textBoxAreaCalc.Location = new System.Drawing.Point(334, 304);
            this.textBoxAreaCalc.Name = "textBoxAreaCalc";
            this.textBoxAreaCalc.Size = new System.Drawing.Size(100, 22);
            this.textBoxAreaCalc.TabIndex = 13;
            this.textBoxAreaCalc.TextChanged += new System.EventHandler(this.textBoxAreaCalc_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAreaCalc);
            this.Controls.Add(this.textBoxSemiCalc);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.buttonSalida);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonArea);
            this.Controls.Add(this.buttonSemi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSemi;
        private System.Windows.Forms.Button buttonArea;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSalida;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxSemiCalc;
        private System.Windows.Forms.TextBox textBoxAreaCalc;
    }
}

