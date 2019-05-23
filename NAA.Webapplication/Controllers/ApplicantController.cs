using NAA.Data;
using NAA.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NAA.Webapplication.Controllers
{
    public class ApplicantController : Controller
    {
        private IApplicationService _applicationService;

        public ApplicantController()
        {
            //_applicationService = new NAA.Services.Services.ApplicationService();
        }
        // GET: Applicant
        public ActionResult Index()
        {
            return View();
        }

        // GET: Applicant/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Applicant/Create
        public ActionResult CreateApplicant()
        {
            return View();
        }

        // POST: Applicant/Create
        [HttpPost]
        public ActionResult CreateApplicant(Applicant applicant)
        {
            try
            {
                // TODO: Add insert logic here
                _applicationService.CreateApplicant(applicant);
                return RedirectToAction("GetApplicant", new { applicantId = applicant.Id, Controller = "Applicant" });
                //return RedirectToAction("ProfileManagement", new { applicantId = applicant.Id, Controller = "Applicant", Action = "ProfileManagement" });
            }
            catch
            {
                return View();
            }
        }

        // GET: Applicant/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Applicant/Edit/5
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

        // GET: Applicant/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Applicant/Delete/5
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
