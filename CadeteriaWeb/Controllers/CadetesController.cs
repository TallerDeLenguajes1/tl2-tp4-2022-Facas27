using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace CadeteriaWeb.Controllers
{
    
    public class CadetesController : Controller
    {
        private readonly ILogger<CadetesController> _logger;

        public CadetesController(ILogger<CadetesController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index(){
            return View();  
        }

        public IActionResult AltaCadetes()
        {
            string path = @"C:\Users\facun\OneDrive\Escritorio\tp4\tl2-tp4-2022-Facas27\CadeteriaWeb\Cadetes.csv";
            string id  = Request.Form["id"];
            string nombre = Request.Form["nombre"];
            string direccion = Request.Form["direccion"];
            string telefono = Request.Form["telefono"];
            string cadena = $" {id} ; {nombre} ; {direccion} ; {telefono}\n";
            System.IO.File.AppendAllText(path, cadena);

            return View();
        }
        public IActionResult MostrarCadetes(){
            
            return View();
        }
        public IActionResult BuscarCadetes(){
            return View();
        }
        public IActionResult EliminarCadetes(){
            string id  = Request.Form["id"];
            string path = @"C:\Users\facun\OneDrive\Escritorio\tp4\tl2-tp4-2022-Facas27\CadeteriaWeb\Cadetes.csv";
            string[]leer = System.IO.File.ReadAllLines(path);
            System.IO.File.WriteAllText(path,"");
            bool band = false;
            for (int i = 0; i < leer.Length; i++)
            {
                string[]datos = leer[i].Split(";");
                if (id == datos[0].Trim())
                {
                  band = true;   
                }else
                {
                    System.IO.File.AppendAllText(path, leer[i] +"\n");
                }

                
            }
            if (band)
            {
                return View("Eliminado");
                
            }else
            {
                return View("NoEliminado");
            
            }

            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}