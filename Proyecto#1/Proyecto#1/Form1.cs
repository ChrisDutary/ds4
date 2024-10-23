using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_1
{
    public partial class Form1 : Form
    {

        double result = 0;
        string operation = "";
        bool isOperationPerformed = false;
        bool isNegative = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void  button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if ((txtNum.Text == "0") || isOperationPerformed)
                txtNum.Clear();

            isOperationPerformed = false;

            if (button.Text == ".")
            {
                if (!txtNum.Text.Contains("."))
                    txtNum.Text += button.Text;
            }
            else
            {
                txtNum.Text += button.Text;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (txtNum.Text.Length > 0)
                txtNum.Text = txtNum.Text.Remove(txtNum.Text.Length - 1, 1);
            if (txtNum.Text == "")
                txtNum.Text = "0";
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txtNum.Text = "0";
            result = 0;
            label1.Text = "";

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;

            // Verificar si no hay ningún número ingresado y el operador es "-"
            if (txtNum.Text == "0" && button.Text == "-")
            {
                // Permitir el uso de un número negativo
                txtNum.Text = "-";
                isOperationPerformed = false;
                return; // No procesar la operación aún
            }

            if (result != 0)
            {
                btnIgual.PerformClick();
                label1.Text = result + " " + operation;
                isOperationPerformed = true;
            }
            else
            {
                result = Double.Parse(txtNum.Text);
                label1.Text = result + " " + operation;
                isOperationPerformed = true;
            }
            txtNum.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                string previousText = txtNum.Text; // Guardar el texto actual antes del cálculo
                bool specialOperation = false; // Bandera para evitar duplicado en ListBox

                switch (operation)
                {
                    case "+":
                        txtNum.Text = (result + Double.Parse(txtNum.Text)).ToString();
                        break;
                    case "-":
                        txtNum.Text = (result - Double.Parse(txtNum.Text)).ToString();
                        break;
                    case "X":
                        txtNum.Text = (result * Double.Parse(txtNum.Text)).ToString();
                        break;
                    case "/":
                        if (txtNum.Text != "0")
                        {
                            txtNum.Text = (result / Double.Parse(txtNum.Text)).ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se puede dividir por cero.");
                            return;
                        }
                        break;
                    case "%":
                        txtNum.Text = (result % Double.Parse(txtNum.Text)).ToString();
                        break;
                    case "x^2":
                        txtNum.Text = Math.Pow(result, 2).ToString();
                        listBox1.Items.Add(result + " ^2 = " + txtNum.Text); // Solo agregar aquí
                        specialOperation = true; // Marcar como operación especial
                        break;
                    case "√":
                        txtNum.Text = Math.Sqrt(result).ToString();
                        listBox1.Items.Add("√" + result + " = " + txtNum.Text); // Solo agregar aquí
                        specialOperation = true; // Marcar como operación especial
                        break;
                }

                // Guardar el cálculo en el ListBox solo si no es una operación especial
                if (!specialOperation)
                {
                    string calculation = $"{result} {operation} {previousText} = {txtNum.Text}";
                    listBox1.Items.Add(calculation); // Agregar el cálculo realizado al ListBox
                }

                result = Double.Parse(txtNum.Text); // Actualizar el resultado
                label1.Text = ""; // Limpiar la etiqueta de la operación
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            operation = "x^2"; // Guardamos la operación
            label1.Text = txtNum.Text + " ^2";
            result = Double.Parse(txtNum.Text); // Guardamos el número para la operación
            isOperationPerformed = true;
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            operation = "√"; // Guardamos la operación
            label1.Text = "√" + txtNum.Text;
            result = Double.Parse(txtNum.Text); // Guardamos el número para la operación
            isOperationPerformed = true;
        }

            private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
