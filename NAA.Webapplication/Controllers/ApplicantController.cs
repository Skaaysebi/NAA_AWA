using NAA.Data;
using NAA.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using NAA.Data.DAO;
using NAA.Services.Services;
using NAA.Services.IServices;
using NAA.Data.BEAN;

namespace NAA.Webapplication.Controllers
{
    public class ApplicantController : Controller
    {
        private IApplicationService _applicationService;

        public ApplicantController()
        {
            //_applicationService = new ApplicationService();
        }

        public ActionResult ProfileManagement(int id)
        {
            ViewBag.ApplicantId = id;
            return View();
        }

        public ActionResult EditProfile(int id)
        {
            Applicant _applicantToEdit = _applicationService.getApplicant(id);
            return View(_applicantToEdit);
        }

        [HttpPost]
        public ActionResult EditProfile(Applicant user)
        {
            _applicationService.UpdateApplicant(user);
            return RedirectToAction("Usermanagement", new { id = user.Id, controller="Applicant" });
        }
    }
}
