using ProjectMVC.Models;
using ProjectMVC.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectMVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Verify(Account c)
        {
            string name = "Admin";
            string password = "root";


            if (c.Name == name && c.Password == password)
            {
                List<Films> films = new DAOFilms().Retreive();
                ViewBag.data = films;
                return View("ListeFilms");
            }
            else
            {
                ViewBag.Message = "failed";
                return View("Login");
            }
                
        }
    }
}