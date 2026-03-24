using Microsoft.AspNetCore.Mvc;
using pruebaCinestar.Controllers.dao;

namespace pruebaCinestar.Controllers
{
    public class CineController : Controller
    {
        daoCine dao = new daoCine();
        public IActionResult Inicio()
        {
            return View();
        }

        public IActionResult getCines()
        {
            return View(dao.getCines());
        }

        public IActionResult getCine(int id)
        {
            ViewBag.Cine = dao.getCine(id.ToString());
            ViewBag.Tarifas = dao.getCineTarifas(id.ToString());
            ViewBag.Peliculas = dao.getCinePeliculas(id.ToString());
            return View();
        }
    }
}
