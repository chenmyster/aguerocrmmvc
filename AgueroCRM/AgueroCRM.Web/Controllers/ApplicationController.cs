using AgueroCRM.Data.Models;
using AgueroCRM.Data.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgueroCRM.Web.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly IApplicationData db;

        public ApplicationController(IApplicationData db)
        {
            this.db = db;
        }
        // GET: Applications
        [HttpGet]
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = db.Get(id);
            if(model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Application application)
        {
            if(ModelState.IsValid)
            {
                db.Add(application);
                return RedirectToAction("Details",new { id = application.Id });
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = db.Get(id);
            if(model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Application application)
        {
            if (ModelState.IsValid)
            {
                db.Update(application);
                TempData["Message"] = "You have saved the application!";
                return RedirectToAction("Details", new { id = application.Id });
            }
            return View(application);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection form)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }
    }
}