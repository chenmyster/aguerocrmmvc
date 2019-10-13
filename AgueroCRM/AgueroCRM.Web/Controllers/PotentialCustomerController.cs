using AgueroCRM.Data.Models;
using AgueroCRM.Data.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgueroCRM.Web.Controllers
{
    public class PotentialCustomerController : Controller
    {
        private readonly IPotentialCustomerData db;

        public PotentialCustomerController(IPotentialCustomerData db)
        {
            this.db = db;
        }
        // GET: PotentialCustomer
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
            if (model == null)
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
        public ActionResult Create(PotentialCustomer potentialCustomer)
        {
            if (ModelState.IsValid)
            {
                db.Add(potentialCustomer);
                return RedirectToAction("Details", new { id = potentialCustomer.Id });
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PotentialCustomer potentialCustomer)
        {
            if (ModelState.IsValid)
            {
                db.Update(potentialCustomer);
                TempData["Message"] = "You have saved the customer contract!";
                return RedirectToAction("Details", new { id = potentialCustomer.Id });
            }
            return View(potentialCustomer);
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