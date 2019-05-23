using NAA.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NAA.Webapplication.Controllers
{
    public class CourseController : Controller
    {
        private IApplicationService _applicationService;

        public CourseController()
        {
            //_applicationService = new NAA.Services.Services.ApplicationService();
        }

        // GET: University/Details/5
        public ActionResult GetCourses(int UniversityId, int ApplicantId)
        {
            ViewBag.ApplicantId = ApplicantId;
            ViewBag.UniversityId = UniversityId;
            return View(_applicationService.GetCourses(UniversityId));
        }

        // GET: University/Details/5
        public ActionResult GetCourse(int CourseId, int UniversityId, int ApplicantId)
        {
            ViewBag.ApplicantId = ApplicantId;
            ViewBag.UniversityId = UniversityId;
            return View(_applicationService.GetCourse(UniversityId, CourseId));
        }

        // GET: Course/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Course/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Course/Create
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

        // GET: Course/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Course/Edit/5
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

        // GET: Course/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Course/Delete/5
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
