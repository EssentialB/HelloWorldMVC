using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WEB_APP.Models;

namespace WEB_APP.Controllers

/*
 *
https://localhost:7132/

Se divide en esto:
-> Protocolo => https/http => https -> su puerto es 443 http -> 80
-> Dominio => localhost / google.com / www.facebook.com
-> Puerto => Si no se espcifica el puerto tomara los valores por defecto
Para poner otro puerto lo tenemos que especificar. Ejm 7255
-> Path ? Opcional => /
-> Parámetros ? Opcional => 

https://portaladminusuarios.reniec.gob.pe/duplicado/ficha.do#!/index
Se divide en esto:
-> Protocolo => https
-> Dominio => portaladminusuarios.reniec.gob.pe
-> Puerto =>  443
-> Path ? Opcional => /duplicado/ficha.do#!/index
-> Parámetros ? Opcional

https://www.google.com/search?q=iphone&rlz=1C1UEAD_esPE992PE992&oq=uiph&aqs=chrome.1.69i57j0i10i433l4j0i10j0i10i131i433j0i10i433l3.1908j0j7&sourceid=chrome&ie=UTF-8
Se divide en esto:
-> Protocolo => https
-> Dominio => www.google.com
-> Puerto =>  443
-> Path ? Opcional => /search
-> Parámetros ? Opcional => q=iphone&rlz=1C1UEAD_esPE992PE992&oq=uiph&aqs=chrome.1.69i57j0i10i433l4j0i10j0i10i131i433j0i10i433l3.1908j0j7&sourceid=chrome&ie=UTF-8

https://localhost:7132/search?name=Fabian&lastname=Salazar (http request o peticion http)

Se divide en esto:
-> Protocolo => https/http => Protocolos de comunicacion de web ->Dif HTTP, protocolo seguro, toda la info antes de salir del navegador a la red, será
encriptada

-> Dominio => localhost / google.com /10.1.1.1=> compu/server -> con esto sabemos a que compu estamos yendo / bases de datos. app webs. serv de correos
-> Puerto => 7255 -  Mecanismo por el cual nos comunicaremos

Dentro de una app, quiero
-> Path ? Opcional => /personas/listar=> productos/buscar => personas/crear
->listar personas, listar productos, crear productos

-> Parámetros ? Opcional =>  name=Fabian&lastname=Salazar
GET tiene limite de caracteres -> Ejm 5000


-> /personas -> GET -> Liste personas
-> /personas -> POST -> crear personas -> API Restful

Peticiones
->methods (GET,POST, PUT, DELETE, PATCH, OPTIONS) => siempre la URL se lanza con GET,
    
->Solo cuando hago POST
Body: (otra forma de enviar parametros hacia mi app) No tiene límites
Datos no son visibles por la URL

https://localhost:5555/login?username=admin&password=12345678 ->GET
Body(oculto): username=admin&password=12345678 ->POST

->header
->cookies
 */
/*
https://localhost:7132/
https://localhost:7132/home/index

    path=>/home/index

    ->MVC 
    1 ->home ->class HomeController
    2 ->index ->method Index()


    /persona/listar
    /persona/buscar?name=Fabian
    PersonaController
    Listar
 */
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /*PATH = /home/index */
        public IActionResult Index()
        {
            return View();
        }

        /*PATH = /home/privacy */
        public IActionResult Privacy()
        {
            return View();
        }

        /*PATH = /home/error */
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}