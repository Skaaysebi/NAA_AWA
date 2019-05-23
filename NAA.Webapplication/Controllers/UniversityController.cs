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
        [Authorize]
        public ActionResult GetUniversities(int applicantId)
        {
            ViewBag.applicantId = applicantId;
            return View(_applicationService.GetUniversities());
        }

        // GET: University/Details/5
        [Authorize]
        public ActionResult GetCourses(int universityId, int applicantId)
        {
            return View(_applicationService.GetCourses(universityId));
        }

        // GET: University/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: University/Create
        [HttpPost]
        [Authorize]
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
        [Authorize]
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: University/Edit/5
        [HttpPost]
        [Authorize]
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
        [Authorize]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: University/Delete/5
        [Authorize]
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
