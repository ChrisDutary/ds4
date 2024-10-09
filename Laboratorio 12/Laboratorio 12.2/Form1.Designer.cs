namespace Laboratorio_12._2
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
            this.buttoPromedio = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.textBoxN1 = new System.Windows.Forms.TextBox();
            this.textBoxN2 = new System.Windows.Forms.TextBox();
            this.textBoxN3 = new System.Windows.Forms.TextBox();
            this.textBoxProm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota Promedio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota No.1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota  No.2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota No.3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nota Promedio";
            // 
            // buttoPromedio
            // 
            this.buttoPromedio.Location = new System.Drawing.Point(163, 265);
            this.buttoPromedio.Name = "buttoPromedio";
            this.buttoPromedio.Size = new System.Drawing.Size(91, 23);
            this.buttoPromedio.TabIndex = 5;
            this.buttoPromedio.Text = "Promedio";
            this.buttoPromedio.UseVisualStyleBackColor = true;
            this.buttoPromedio.Click += new System.EventHandler(this.buttoPromedio_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(308, 265);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(100, 23);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(452, 265);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(88, 23);
            this.buttonSalir.TabIndex = 7;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // textBoxN1
            // 
            this.textBoxN1.Location = new System.Drawing.Point(308, 102);
            this.textBoxN1.Name = "textBoxN1";
            this.textBoxN1.Size = new System.Drawing.Size(100, 22);
            this.textBoxN1.TabIndex = 8;
            this.textBoxN1.TextChanged += new System.EventHandler(this.texBoxN1_TextChanged);
            // 
            // textBoxN2
            // 
            this.textBoxN2.Location = new System.Drawing.Point(308, 155);
            this.textBoxN2.Name = "textBoxN2";
            this.textBoxN2.Size = new System.Drawing.Size(100, 22);
            this.textBoxN2.TabIndex = 9;
            this.textBoxN2.TextChanged += new System.EventHandler(this.textBoxN2_TextChanged);
            // 
            // textBoxN3
            // 
            this.textBoxN3.Location = new System.Drawing.Point(308, 207);
            this.textBoxN3.Name = "textBoxN3";
            this.textBoxN3.Size = new System.Drawing.Size(100, 22);
            this.textBoxN3.TabIndex = 10;
            this.textBoxN3.TextChanged += new System.EventHandler(this.textBoxN3_TextChanged);
            // 
            // textBoxProm
            // 
            this.textBoxProm.Location = new System.Drawing.Point(308, 324);
            this.textBoxProm.Name = "textBoxProm";
            this.textBoxProm.Size = new System.Drawing.Size(100, 22);
            this.textBoxProm.TabIndex = 11;
            this.textBoxProm.TextChanged += new System.EventHandler(this.textBoxProm_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxProm);
            this.Controls.Add(this.textBoxN3);
            this.Controls.Add(this.textBoxN2);
            this.Controls.Add(this.textBoxN1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttoPromedio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calcular promedio";
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
        private System.Windows.Forms.Button buttoPromedio;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.TextBox textBoxN1;
        private System.Windows.Forms.TextBox textBoxN2;
        private System.Windows.Forms.TextBox textBoxN3;
        private System.Windows.Forms.TextBox textBoxProm;
    }
}

