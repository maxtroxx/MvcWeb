using MvcWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWeb.Controllers
{
    public class MiCarritoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: MiCarrito
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalcularTotal(int id ,int stock)
        {
            List<Producto> prodCarrito = (List<Producto>)Session["Carrito"];
            var prod = prodCarrito.Where(p => p.Id == id).First();
            var stockRestante = prod.stock - stock;
            int total = prod.precio * stock;
            return Content(total.ToString("C0"));
        }

        public ActionResult ConfirmarCompra()
        {
            return View();
        }
        public ActionResult ActualizarStock(int id, int cantidad)
        {
            List<Producto> prodCarrito = (List<Producto>)Session["Carrito"];
            var prod = prodCarrito.Where(p => p.Id == id).First();
            int stockRestante = prod.stock - cantidad;
            return Content(stockRestante.ToString());
        }
        // GET: MiCarrito/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MiCarrito/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MiCarrito/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MiCarrito/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MiCarrito/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MiCarrito/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MiCarrito/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
