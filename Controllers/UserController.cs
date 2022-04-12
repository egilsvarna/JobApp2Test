using JobApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobApp2.Controllers
{
    public class UserController : Controller
    {
        // GET: User

        [HttpGet]
        public ActionResult Index()
        {
            var users = new List<Users>();
            
            //piesledzos datu bazei DB 
            using (var db = new User())
            {
                users = db.Users.ToList();
            }

            return View(users);
        }

    }
}