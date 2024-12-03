using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ProyectoFinal.Models;

namespace ProyectoFinal.Controllers
{
    public class PedidosController : Controller
    {
        private DulceriaContext db = new DulceriaContext();

        // GET: Pedidos
        public ActionResult Index()
        {
            return View(db.Pedidos.ToList());
        }

        // GET: Pedidos/Create
        public ActionResult Create()
        {
            var carrito = Session["Carrito"] as List<DetallePedido>;
            if (carrito == null || !carrito.Any())
            {
                return RedirectToAction("Index", "Carrito");
            }
            return View();
        }

        // POST: Pedidos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pedido pedido)
        {
            if (ModelState.IsValid)
            {
                var carrito = Session["Carrito"] as List<DetallePedido>;
                if (carrito != null && carrito.Any())
                {
                    // Configurar el pedido
                    pedido.FechaPedido = DateTime.Now;
                    pedido.EstadoPedido = "Pendiente";
                    pedido.MontoTotal = carrito.Sum(item => item.Cantidad * item.PrecioUnitario);

                    // Agregar los detalles del pedido
                    pedido.DetallesPedido = carrito;

                    // Guardar en la base de datos
                    db.Pedidos.Add(pedido);
                    db.SaveChanges();

                    // Limpiar el carrito
                    Session["Carrito"] = null;

                    return RedirectToAction("Confirmacion", new { id = pedido.PedidoID });
                }
            }

            return View(pedido);
        }

        // GET: Pedidos/Confirmacion/5
        public ActionResult Confirmacion(int id)
        {
            var pedido = db.Pedidos.Find(id);
            if (pedido == null)
            {
                return HttpNotFound();
            }
            return View(pedido);
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