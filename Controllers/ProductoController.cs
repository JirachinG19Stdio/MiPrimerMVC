using Microsoft.AspNetCore.Mvc;
using MiPrimerMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace MiPrimerMVC.Controllers
{
    public class ProductoController : Controller
    {
        private static List<Producto> _productos = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Teclado mecánico", Descripcion = "Teclado RGB switches rojos", Precio = 45.99m, Stock = 20 },
            new Producto { Id = 2, Nombre = "Mouse inalámbrico", Descripcion = "Mouse ergonómico 2.4GHz", Precio = 19.99m, Stock = 35 }
        };
        public IActionResult Index()
        {
            return View(_productos);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Producto producto)
        {
            if (ModelState.IsValid)
            {
                producto.Id = _productos.Any() ? _productos.Max(p => p.Id) + 1 : 1;
                _productos.Add(producto);
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }
        // GET: Producto/Delete/5
        public IActionResult Delete(int id)
        {
            var producto = _productos.FirstOrDefault(p => p.Id == id);
            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }

        // POST: Producto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var producto = _productos.FirstOrDefault(p => p.Id == id);
            if (producto != null)
            {
                _productos.Remove(producto);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}