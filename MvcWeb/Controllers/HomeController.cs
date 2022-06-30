using MvcWeb.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MvcWeb.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public async Task<ActionResult> Index()
        {
            if (Session["Carrito"] == null)
            {
                Session["Carrito"] = new List<Producto>();
            }

            return View(await db.Productoes.ToListAsync());
        }

        public ActionResult AddToCart(int Id)
        {
            var productos = db.Productoes.Find(Id);
            List<Producto> productocarrito = (List<Producto>)Session["Carrito"];
            productocarrito.Add(productos);
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