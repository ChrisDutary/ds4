using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_12._1
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

        private void button1_Click(object sender, EventArgs e)
        {
            double velocidad, tiempo, distancia;

            bool isVelocidadValid = double.TryParse(textBox1.Text, out velocidad);
            bool isTiempoValid = double.TryParse(textBox2.Text, out tiempo);

            if (isVelocidadValid && isTiempoValid)
            {
                distancia = velocidad * tiempo;

                textBox3.Text = distancia.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos en ambos campos.");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
