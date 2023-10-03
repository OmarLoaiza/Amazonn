using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Amazonn.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Detalles(int id)
        //{
        //    // Lógica para obtener los detalles del producto con el ID proporcionado desde la B.D.
        //    var producto = ObtenerDetallesDelProducto(id);

        //    // Pasar el producto a la vista 
        //    return View(producto);
        //}


    }
}