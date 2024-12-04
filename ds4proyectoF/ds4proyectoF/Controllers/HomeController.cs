using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ds4proyectoF.Models;
using Newtonsoft.Json;


namespace ds4proyectoF.Controllers
{
    public class HomeController : Controller

    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MarysDBContext"].ConnectionString;
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Menu()
        {
            return View();
        }

        public ActionResult Carrito()
        {
            return View();
        }

        public ActionResult OpcionesEntrega()
        {
            return View();
        }
        public ActionResult ConfirmarPedido()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult GuardarPedido(string nombreCliente, string productos, decimal total, bool retiroLocal, bool delivery, string direccion)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Convertir JSON a lista formateada
                var productosLista = JsonConvert.DeserializeObject<List<dynamic>>(productos);
                string productosFormateados = string.Join(", ", productosLista.Select(p =>
                    $"{p.nombre} (Cantidad: {p.cantidad})"
                ));

                string query = @"INSERT INTO Pedidos (NombreCliente, Productos, Total, RetiroLocal, Delivery, Ubicacion) 
                        VALUES (@nombre, @productos, @total, @retiro, @delivery, @ubicacion)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", nombreCliente);
                cmd.Parameters.AddWithValue("@productos", productosFormateados);
                cmd.Parameters.AddWithValue("@total", total);
                cmd.Parameters.AddWithValue("@retiro", retiroLocal);
                cmd.Parameters.AddWithValue("@delivery", delivery);
                cmd.Parameters.AddWithValue("@ubicacion", string.IsNullOrEmpty(direccion) ? DBNull.Value : (object)direccion);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            return Json(new { success = true });
        }

    }
}