using DAL.Abstract;
using DAL.Concrete;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StepSite.Controllers
{
    public class UserController : Controller
    {
        private IUserProvider mUserProvider;
        public UserController()
        {
            mUserProvider = new UserProvider();
        }

        // GET: User
        public ActionResult Index()
        {
            var model=mUserProvider.GetAllUsers()
                .ToList();
            return View(model);
        }
        public ActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User model)
        {
            if(ModelState.IsValid)
            {
                User createUser = mUserProvider.CreateUser(model.Username, model.Password);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}