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

        [Authorize]
        public ActionResult GetApplicant(int id)
        { 
            ViewBag.ApplicantId = id;
            ViewBag.Current = System.Web.HttpContext.Current.User.Identity.Name;
            return View();
        }

        [Authorize]
        public ActionResult EditApplicant(int id)
        {
            Applicant _applicantToEdit = _applicationService.GetApplicant(id);
            return View(_applicantToEdit);
        }

        [Authorize]
        [HttpPost]
        public ActionResult EditApplicant(Applicant user)
        {
            _applicationService.UpdateApplicant(user);
            //return RedirectToAction("Usermanagement", new { id = user.Id, controller="Applicant", action = "GetApplicant" });
            return RedirectToAction("GetApplicant", new { id = user.Id, controller="Applicant" });
        }
    }
}
