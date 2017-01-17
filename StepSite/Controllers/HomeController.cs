using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.Entities;

namespace StepSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EfContext efdb = new EfContext();
            //Product p = new Product
            //{
            //    Name ="Bulka"
            //};

            //efdb.Products.Add(p);
            //efdb.SaveChanges();

            ViewBag.Message = efdb.Products.Count();

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
    }
}