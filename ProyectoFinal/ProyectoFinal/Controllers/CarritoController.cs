using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ProyectoFinal.Models;

namespace ProyectoFinal.Controllers
{
    public class CarritoController : Controller
    {
        private DulceriaContext db = new DulceriaContext();

        // GET: Carrito
        public ActionResult Index()
        {
            // Obtener el carrito de la sesión
            var carrito = Session["Carrito"] as List<DetallePedido> ?? new List<DetallePedido>();
            return View(carrito);
        }

        // POST: Carrito/AgregarAlCarrito
        [HttpPost]
        public ActionResult AgregarAlCarrito(int productoId, int cantidad)
        {
            // Obtener el producto
            var producto = db.Productos.Find(productoId);
            if (producto == null)
            {
                return HttpNotFound();
            }

            // Obtener o crear el carrito en la sesión
            var carrito = Session["Carrito"] as List<DetallePedido> ?? new List<DetallePedido>();

            // Verificar si el producto ya está en el carrito
            var itemCarrito = carrito.FirstOrDefault(i => i.ProductoID == productoId);
            if (itemCarrito != null)
            {
                itemCarrito.Cantidad += cantidad;
            }
            else
            {
                // Agregar nuevo item al carrito
                carrito.Add(new DetallePedido
                {
                    ProductoID = productoId,
                    Cantidad = cantidad,
                    PrecioUnitario = producto.Precio,
                    Producto = producto
                });
            }

            // Guardar el carrito en la sesión
            Session["Carrito"] = carrito;

            return RedirectToAction("Index");
        }

        // POST: Carrito/EliminarDelCarrito
        [HttpPost]
        public ActionResult EliminarDelCarrito(int productoId)
        {
            var carrito = Session["Carrito"] as List<DetallePedido>;
            if (carrito != null)
            {
                var item = carrito.FirstOrDefault(i => i.ProductoID == productoId);
                if (item != null)
                {
                    carrito.Remove(item);
                    Session["Carrito"] = carrito;
                }
            }
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}