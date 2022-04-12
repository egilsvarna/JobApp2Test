using JobApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobApp2.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        
        
        public ActionResult Create()
        {
            return View();
        }

        // ILGI CINIJOS :D un nesapratu kapec met erroru. 
        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Users user)
        {
            try
            {
                // TODO: Add insert logic here

                if (ModelState.IsValid)
                {
                    using (var db = new User())
                    {
                        user = db.Users.Add(new Users()
                        {
                            Name = user.Name,
                            Email = user.Email,
                            Password = user.Password
                        });

                        db.SaveChanges();
                    }
                    return RedirectToAction("Edit", new { id = user.Id });
                }


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Users users)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
