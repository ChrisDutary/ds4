using System;
using System.Windows.Forms;

namespace Laboratorio_12._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSemi_Click(object sender, EventArgs e)
        {
            double ladoA, ladoB, ladoC, semiperimetro;
            bool isLadoAValid = double.TryParse(textBoxA.Text, out ladoA);
            bool isLadoBValid = double.TryParse(textBoxB.Text, out ladoB);
            bool isLadoCValid = double.TryParse(textBoxC.Text, out ladoC);

            if (isLadoAValid && isLadoBValid && isLadoCValid)
            {
                semiperimetro = (ladoA + ladoB + ladoC) / 2;

                textBoxSemiCalc.Text = semiperimetro.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos para los lados.");
            }
        }

        private void buttonArea_Click(object sender, EventArgs e)
        {
            double ladoA, ladoB, ladoC, semiperimetro, area;

            bool isLadoAValid = double.TryParse(textBoxA.Text, out ladoA);
            bool isLadoBValid = double.TryParse(textBoxB.Text, out ladoB);
            bool isLadoCValid = double.TryParse(textBoxC.Text, out ladoC);

            if (isLadoAValid && isLadoBValid && isLadoCValid)
            {
                semiperimetro = (ladoA + ladoB + ladoC) / 2;

                area = Math.Sqrt(semiperimetro * (semiperimetro - ladoA) * (semiperimetro - ladoB) * (semiperimetro - ladoC));

                textBoxAreaCalc.Text = area.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos para los lados.");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxC.Clear();
            textBoxSemiCalc.Clear();
            textBoxAreaCalc.Clear();
        }

        private void buttonSalida_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSemiCalc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAreaCalc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
