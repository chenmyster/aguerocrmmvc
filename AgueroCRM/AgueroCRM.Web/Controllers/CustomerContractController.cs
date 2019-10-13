using AgueroCRM.Data.Models;
using AgueroCRM.Data.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgueroCRM.Web.Controllers
{
    public class CustomerContractController : Controller
    {
        private readonly ICustomerContractData db;

        public CustomerContractController(ICustomerContractData db)
        {
            this.db = db;
        }
        // GET: CustomerContract
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
        public ActionResult Create(CustomerContract customerContract)
        {
            if (ModelState.IsValid)
            {
                db.Add(customerContract);
                return RedirectToAction("Details", new { id = customerContract.Id });
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
        public ActionResult Edit(CustomerContract customerContract)
        {
            if (ModelState.IsValid)
            {
                db.Update(customerContract);
                TempData["Message"] = "You have saved the customer contract!";
                return RedirectToAction("Details", new { id = customerContract.Id });
            }
            return View(customerContract);
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