using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TrabajosGraduacion.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            switch (statusCode)
            {
                case 404: ViewBag.errorMessage = "Página no encontrada";
                    break;
                default:
                    break;
            }
            return View("NoEncontrado");
        }
    }
}
