using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using NAA.Data.DAO;
using NAA.Services.Services;
using NAA.Data.BEAN;

namespace NAA.Webapplication.Controllers
{
    public class ApplicantController : Controller
    {
        private ApplicationService _applicationService;

        public ApplicantController()
        {
            _applicationService = new ApplicationService();
        }

        public ActionResult Usermanagement(int id)
        {
            return View();
        }

        public ActionResult EditProfile(int id)
        {

            return View();
        }

        [HttpPost]
        public ActionResult EditProfile(int id, ApplicationBEAN user)
        {
            _applicationService.
            return RedirectToAction("Usermanagement", new { id = user.Id, controller="Applicant" });
        }
    }
}
