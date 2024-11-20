using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
namespace Proyecto_2.Models
{
    public class CalculadoraDB
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public List<Calculo> ObtenerTodosCalculos()
        {
            List<Calculo> calculos = new List<Calculo>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Operacion, Resultado FROM HistorialCalculos";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    calculos.Add(new Calculo
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Operacion = reader["Operacion"].ToString(),
                        Resultado = reader["Resultado"].ToString()
                    });
                }
            }
            return calculos;
        }
        public List<Calculo> ObtenerCalculosPorTipo(string tipoOperacion)
        {
            List<Calculo> calculos = new List<Calculo>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Operacion, Resultado FROM HistorialCalculos WHERE Operacion LIKE @tipo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tipo", "%" + tipoOperacion + "%");
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    calculos.Add(new Calculo
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Operacion = reader["Operacion"].ToString(),
                        Resultado = reader["Resultado"].ToString()
                    });
                }
            }
            return calculos;
        }

        // Agregar este nuevo método
        //public List<Calculo> ObtenerCalculosRaizCuadrada()
        //{
        //    List<Calculo> calculos = new List<Calculo>();
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        string query = "SELECT Id, Operacion, Resultado FROM HistorialCalculos WHERE Operacion LIKE '%√%'";
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        conn.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            calculos.Add(new Calculo
        //            {
        //                Id = Convert.ToInt32(reader["Id"]),
        //                Operacion = reader["Operacion"].ToString(),
        //                Resultado = reader["Resultado"].ToString()
        //            });
        //        }
        //    }
        //    return calculos;
        //}
    }
}