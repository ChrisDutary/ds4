using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace TeatrosWeb.Forms.Salas
{
    public partial class Salas : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarSalas();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarSala();
        }

        private void GuardarSala()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDireccion.Text))
            {
                MostrarMensaje("Por favor complete todos los campos");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConnection.GetConnection().ConnectionString))
                {
                    string query = "INSERT INTO SalasTeatro (Nombre, Direccion) VALUES (@Nombre, @Direccion)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        LimpiarCampos();
                        CargarSalas();
                        MostrarMensaje("Sala guardada correctamente");
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("Error al guardar la sala: " + ex.Message);
            }
        }

        private void CargarSalas()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConnection.GetConnection().ConnectionString))
                {
                    string query = "SELECT SalaID, Nombre, Direccion FROM SalasTeatro ORDER BY SalaID DESC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        gvSalas.DataSource = dt;
                        gvSalas.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("Error al cargar las salas: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
        }

        private void MostrarMensaje(string mensaje)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage",
                $"alert('{mensaje}');", true);
        }
    }
}