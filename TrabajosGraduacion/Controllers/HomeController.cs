using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TrabajosGraduacion.Data;
using TrabajosGraduacion.Models;

namespace TrabajosGraduacion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Estadisticas()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Estadisticas()
        {
            return View();
        }

       
    }
//    public async Task<IActionResult> Index(string sortOrder, string searchString)
  //  {
       // ViewData["NameSortParm"] = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
        //ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
        //ViewData["CurrentFilter"] = searchString;

        //var students = from s in DbContext.
    //                   select s;
  //      if (!String.IsNullOrEmpty(searchString))
      //  {
        //    students = students.Where(s => s.LastName.Contains(searchString)
                  //                 || s.FirstMidName.Contains(searchString));
        //}
        //switch (sortOrder)
        //{
          //  case "name_desc":
            //    students = students.OrderByDescending(s => s.LastName);
              //  break;
            //case "Date":
            //    students = students.OrderBy(s => s.EnrollmentDate);
             //   break;
         //   case "date_desc":
        //        students = students.OrderByDescending(s => s.EnrollmentDate);
       //         break;
       //     default:
       //         students = students.OrderBy(s => s.LastName);
      //          break;
    //    }
    //    return View(await students.AsNoTracking().ToListAsync());
//    }
}
