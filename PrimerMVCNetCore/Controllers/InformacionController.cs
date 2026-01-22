using Microsoft.AspNetCore.Mvc;

namespace PrimerMVCNetCore.Controllers
{
    public class InformacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ControladorVista()
        {
            //vamos a enviar informacion simple a nuestra vista
            ViewData["Nombre"] = "Alumno";
            ViewData["Edad"] = "20";
            ViewBag.DiaSemana = "Jueves";
            return View();
        }
    }
}
