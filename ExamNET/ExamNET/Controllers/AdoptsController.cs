using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamNET.Controllers
{
    public class AdoptsController : Controller
    {
        // GET: Adopts
        public ActionResult Index()
        {
            return View();
        }

        // GET: Adopts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Adopts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Adopts/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Adopts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Adopts/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: Adopts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Adopts/Delete/5
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
