using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Proyecto_1
{
    public partial class Form1 : Form
    {

        double result = 0;
        string operation = "";
        bool isOperationPerformed = false;
        bool isNegative = false;
        string connectionString = "Data Source=DESKTOP-539IR1D\\SQLEXPRESS;Initial Catalog=CalculadoraDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";



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

            
            if (txtNum.Text == "0" && button.Text == "-")
            {
                
                txtNum.Text = "-";
                isOperationPerformed = false;
                return; 
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
                string previousText = txtNum.Text; 
                bool specialOperation = false; 

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
                        listBox1.Items.Add(result + " ^2 = " + txtNum.Text); 
                        specialOperation = true; 
                        break;
                    case "√":
                        txtNum.Text = Math.Sqrt(result).ToString();
                        listBox1.Items.Add("√" + result + " = " + txtNum.Text); 
                        specialOperation = true; 
                        break;
                }

                
                string calculation = $"{result} {operation} {previousText} = {txtNum.Text}";
                if (!specialOperation)
                {
                    listBox1.Items.Add(calculation); 
                }

                result = Double.Parse(txtNum.Text); 
                label1.Text = ""; 

   
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO HistorialCalculos (Operacion, Resultado) VALUES (@operacion, @resultado)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@operacion", calculation);
                    cmd.Parameters.AddWithValue("@resultado", txtNum.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            operation = "x^2"; 
            label1.Text = txtNum.Text + " ^2";
            result = Double.Parse(txtNum.Text); 
            isOperationPerformed = true;
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            operation = "√"; 
            label1.Text = "√" + txtNum.Text;
            result = Double.Parse(txtNum.Text); 
            isOperationPerformed = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); 
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); 


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT Operacion, Resultado FROM HistorialCalculos";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string operacion = reader["Operacion"].ToString();
                    string resultado = reader["Resultado"].ToString();
                    listBox1.Items.Add(operacion + " = " + resultado); 
                }

                reader.Close();
            }
        }
    }
}
