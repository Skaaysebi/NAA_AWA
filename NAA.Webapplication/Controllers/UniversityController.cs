using NAA.Data;
using NAA.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NAA.Webapplication.Controllers
{
    public class UniversityController : Controller
    {
        private IApplicationService _applicationService;

        public UniversityController()
        {
            //_applicationService = new NAA.Services.Services.ApplicationService();
        }
        // GET: University
        public ActionResult GetUniversities(int ApplicantId)
        {
            ViewBag.ApplicantId = ApplicantId;
            return View(_applicationService.GetUniversities());
        }

        // GET: University/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: University/Create
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

        // GET: University/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: University/Edit/5
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

        // GET: University/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: University/Delete/5
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
