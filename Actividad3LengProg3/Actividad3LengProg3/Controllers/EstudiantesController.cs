using Actividad3LengProg3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Actividad3LengProg3.Controllers
{
    public class EstudiantesController : Controller
    {
        public static List<EstudianteViewModel> estudiantes = new List<EstudianteViewModel>();
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Registrar(EstudianteViewModel estudiante)
        {
            if (ModelState.IsValid)
            {
                estudiantes.Add(estudiante);
                TempData["Mensaje"] = "Estudiante registrado exitosamente.";
                //return RedirectToAction("Lista");
            }
            return View("Index", estudiante);
        }


        public IActionResult Lista() { 
        
            return View(estudiantes);
        
        }


        public IActionResult Editar(string matricula)
        {

            return View();

        }


        [HttpPost]
        public IActionResult Editar(EstudianteViewModel model)
        {
            return View();
        }


        public IActionResult Eliminar(string matricula)
        {

            return View();

        }

    }
}
