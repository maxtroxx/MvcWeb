using MvcWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWeb.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public Task<ActionResult> Index()
        {
            if (Session["Carrito"] == null)
            {
                Session["Carrito"] == new List<Producto>();
            }

            return View(db.Productoes.ToList());
        }

        public Task<ActionResult> AddToCart(int id)
        {
            var productos = db.Productoes.ToList(id);
            List<Producto> productocarrito = (List<Producto>)Session["Carrito"];
            productocarrito.Add(Producto);
            Session["Carrito"] = productocarrito;
            return PartialView("_carrito");

            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}