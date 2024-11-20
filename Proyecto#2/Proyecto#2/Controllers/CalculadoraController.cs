using System;
using System.Collections.Generic;
using System.Web.Http;
using Proyecto_2.Models;

namespace Proyecto_2.Controllers
{
    public class CalculadoraController : ApiController
    {
        private CalculadoraDB db = new CalculadoraDB();

        // GET: api/Calculadora
        [HttpGet]
        public IHttpActionResult GetTodosCalculos()
        {
            try
            {
                var calculos = db.ObtenerTodosCalculos();
                return Ok(calculos);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // GET: api/Calculadora/sumas
        [HttpGet]
        [Route("api/Calculadora/sumas")]
        public IHttpActionResult GetSumas()
        {
            try
            {
                var sumas = db.ObtenerCalculosPorTipo("+");
                return Ok(sumas);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // GET: api/Calculadora/restas
        [HttpGet]
        [Route("api/Calculadora/restas")]
        public IHttpActionResult GetRestas()
        {
            try
            {
                var restas = db.ObtenerCalculosPorTipo("-");
                return Ok(restas);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // GET: api/Calculadora/multiplicaciones
        [HttpGet]
        [Route("api/Calculadora/multiplicaciones")]
        public IHttpActionResult GetMultiplicaciones()
        {
            try
            {
                var multiplicaciones = db.ObtenerCalculosPorTipo("X");
                return Ok(multiplicaciones);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // GET: api/Calculadora/divisiones
        [HttpGet]
        [Route("api/Calculadora/divisiones")]
        public IHttpActionResult GetDivisiones()
        {
            try
            {
                var divisiones = db.ObtenerCalculosPorTipo("/");
                return Ok(divisiones);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // GET: api/Calculadora/raices
        [HttpGet]
        [Route("api/Calculadora/raices")]
        public IHttpActionResult GetRaicesCuadradas()
        {
            try
            {
                var raices = db.ObtenerCalculosPorTipo("√");
                return Ok(raices);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}