using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TrabajosGraduacion.Controllers
{
    public class HomeController1 : Controller
    {
        private ConexionBD mibd = new ConexionBD();
        public ActionResult Index(string cadena="")
        {
            List<Datos> datos = mibd.buscarDatos(cadena);
            return View(datos);
        }
    }
}
