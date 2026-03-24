using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using pruebaCinestar.Controllers.dao;
namespace pruebaCinestar.Controllers
{
    public class PeliculaController : Controller
    {
        daoPelicula daoPelicula = new daoPelicula();
        public ActionResult getPeliculas(string id )
        {
            return View(daoPelicula.getPeliculas(id));
        }

        public ActionResult getPelicula(string id)
        {
            return View(daoPelicula.getPelicula(id));
        }


    }
}
