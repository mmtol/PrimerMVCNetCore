using Microsoft.AspNetCore.Mvc;
using PrimerMVCNetCore.Models;

namespace PrimerMVCNetCore.Controllers
{
    public class InformacionController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult VistaControllerPost()
        {
            return View();
        }

        //[HttpPost]
        public IActionResult VistaControllerPost(Persona persona, string aficiones)
        {
            ViewData["Mensaje"] = "Nombre " + persona.Nombre + ", Email " + persona.Email + ", Edad " + persona.Edad + " y además " + aficiones;
            return View();
        }

        public IActionResult VistaControladorGet(string saludo, int? year)
        {
            //para comprobar que hemos recibido los datos mediante un IActionLink
            //devolvemos un mensaje a la vista
            if (year == null)
            {
                ViewData["Mensaje"] = "Que year es?????";
            }
            else if (saludo == null)
            {
                ViewData["Mensaje"] = "Aqui nadie saluda...";
            }
            else
            {
                ViewData["Mensaje"] = saludo + " en el año " + year;
            }
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

        public IActionResult ControladorVistaModel()
        {
            Persona persona = new Persona();
            persona.Nombre = "Alumno";
            persona.Email = "alumno@gmail.com";
            persona.Edad = 20;

            return View(persona);
        }
    }
}
