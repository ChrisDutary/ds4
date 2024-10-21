using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                double fahrenheit = double.Parse(txtFar.Text);

                double celsius = (fahrenheit - 32) * 5 / 9;
                double kelvin = celsius + 273.15;

                txtFar1.Text = fahrenheit.ToString("f2");
                txtCel1.Text = celsius.ToString("f2");
                txtKel1.Text = kelvin.ToString("f2");
                string conversion = $"(1)Fahrenheit: {fahrenheit:F2} -> Celsius: {celsius:F2}, Kelvin: {kelvin:F2}";
                Registro.Items.Add(conversion); 
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un valor numérico válido en Fahrenheit.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            try
            {
                double celsius = double.Parse(txtCel.Text);

                double fahrenheit = (celsius * 9 / 5) + 32;
                double kelvin = celsius + 273.15;

                txtFar2.Text = fahrenheit.ToString("f2");
                txtCel2.Text = celsius.ToString("f2");
                txtKel2.Text = kelvin.ToString("f2");
                string conversion = $"(2)Celsius: {celsius:F2} -> Fahrenheit: {fahrenheit:F2}, Kelvin: {kelvin:F2}";
                Registro.Items.Add(conversion);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un valor numérico válido en Celsius.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            try
            {
                double kelvin = double.Parse(txtKel.Text);

                if (kelvin < 0)
                {
                    MessageBox.Show("El valor en Kelvin no puede ser negativo.", "Error de Rango", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double celsius = kelvin - 273.15;
                double fahrenheit = (celsius *  9 / 5) + 32;

                txtFar3.Text = fahrenheit.ToString("f2");
                txtCel3.Text = celsius.ToString("f2");
                txtKel3.Text = kelvin.ToString("f2");
                string conversion = $"(3)Kelvin: {kelvin:F2} -> Celsius: {celsius:F2}, Fahrenheit: {fahrenheit:F2}";
                Registro.Items.Add(conversion);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un valor numérico válido en Kelvin.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //primera linea
            txtFar.Text = string.Empty;
            txtCel.Text = string.Empty;
            txtKel.Text = string.Empty;
            txtFar1.Text = string.Empty;
            txtCel1.Text = string.Empty;
            txtKel1.Text = string.Empty;
            //segunda linea
            txtFar2.Text = string.Empty;
            txtCel2.Text = string.Empty;
            txtKel2.Text = string.Empty;
            //para ultima linea
            txtFar3.Text = string.Empty;
            txtCel3.Text = string.Empty;
            txtKel3.Text = string.Empty;

            Registro.Text = string.Empty;
        }

        private void Registro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
