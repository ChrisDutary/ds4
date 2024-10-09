using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_12._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttoPromedio_Click(object sender, EventArgs e)
        {
            // Declarar las variables para almacenar los valores de los TextBoxes
            double num1, num2, num3, promedio;

            // Intentar convertir los valores ingresados en los TextBoxes a double
            bool isNum1Valid = double.TryParse(textBoxN1.Text, out num1);
            bool isNum2Valid = double.TryParse(textBoxN2.Text, out num2);
            bool isNum3Valid = double.TryParse(textBoxN3.Text, out num3);

            // Verificar que todas las conversiones sean exitosas
            if (isNum1Valid && isNum2Valid && isNum3Valid)
            {
                // Calcular el promedio
                promedio = (num1 + num2 + num3) / 3;

                // Mostrar el resultado en el textBoxProm
                textBoxProm.Text = promedio.ToString();
            }
            else
            {
                // Mostrar un mensaje de error si uno de los valores no es válido
                MessageBox.Show("Por favor, ingresa valores numéricos válidos en los tres campos.");
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void texBoxN1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxN2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxN3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPromedio_Click(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxN1.Clear();
            textBoxN2.Clear();
            textBoxN3.Clear();
            textBoxProm.Clear();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxProm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
