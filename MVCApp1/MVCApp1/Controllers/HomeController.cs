using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ToDoList()
        {
            var lista = new List<String>();
            {
                lista.Add("Só");
                lista.Add("Cukor");
                lista.Add("Spagetti");
                lista.Add("Marhahús");
                lista.Add("Paradicsom");
            }

            ViewBag.lista = lista;

            return View();
        }
    }
}