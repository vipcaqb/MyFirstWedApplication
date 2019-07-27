using MyFisrtWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFisrtWeb.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index(int a = 0, int b = 0)
        {
            if (a == 0)
            {
                ViewBag.Message = "Phuong trinh vo nghiem";
            }
            else
            {
                var c = -(b / a);
                ViewBag.Message = $"Phuong trinh {a}x + {b} = 0 co nghiem la {c}";
            }
            return View();
        }

        public ActionResult List()
        {
            var listPersons = PersonService.List();
            return View(listPersons);
        }
    }
}