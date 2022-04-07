using Microsoft.AspNetCore.Mvc;

namespace WEB_APP.Controllers
{
    public class PersonaController : Controller
    {
        public string Listar ()
        {
            return "Esto es una lista de personas";
        }

        /** Path -> /persona/buscar **/
        public string Buscar(string name, string lastname)
        {
            return "Buscando a la persona " + name + " " + lastname;    
        }

        public IActionResult Personas()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
