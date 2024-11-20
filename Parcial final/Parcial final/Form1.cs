using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Parcial_final
{
    public partial class Form1 : Form
    {
        // Cadena de conexión a la base de datos
        private string connectionString = @"Server=DESKTOP-539IR1D\SQLEXPRESS;Database=TeatroBD;Trusted_Connection=True;";



        public Form1()
        {
            InitializeComponent();
        }

        // Método que se ejecuta al cargar el formulario
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Evento asociado al botón "Cargar Obras"
        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarObras();
        }

        // Evento asociado al botón "Agregar Obra"
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarObra();
            CargarObras(); // Refresca la lista de obras después de agregar
        }

        // Método para cargar las obras desde la base de datos al DataGridView
        private void CargarObras()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Obras";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        dgvObras.DataSource = dataTable; // Asocia los datos al DataGridView
                    }
                    else
                    {
                        MessageBox.Show("No hay obras registradas en la base de datos.");
                        dgvObras.DataSource = null; // Limpia el DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar las obras: {ex.Message}");
                }
            }
        }


        // Método para agregar una nueva obra a la base de datos
        private void AgregarObra()
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(txtDirector.Text) ||
                string.IsNullOrWhiteSpace(txtGenero.Text) ||
                string.IsNullOrWhiteSpace(txtClasificacion.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Obras (ID_Obra,Titulo, Director, Genero, Clasificacion) VALUES (@ID_Obra,@Titulo, @Director, @Genero, @Clasificacion)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Obra", txtID.Text);
                        command.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
                        command.Parameters.AddWithValue("@Director", txtDirector.Text);
                        command.Parameters.AddWithValue("@Genero", txtGenero.Text);
                        command.Parameters.AddWithValue("@Clasificacion", txtClasificacion.Text);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Obra agregada con éxito.");

                        // Limpia los campos
                        txtID.Clear();
                        txtTitulo.Clear();
                        txtDirector.Clear();
                        txtGenero.Clear();
                        txtClasificacion.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar la obra: {ex.Message}");
                }
            }
        }


    }
}
