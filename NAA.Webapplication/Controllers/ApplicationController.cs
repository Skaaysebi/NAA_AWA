using NAA.Data;
using NAA.Data.BEAN;
using NAA.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NAA.Webapplication.Controllers
{
    public class ApplicationController : Controller
    {
        private ApplicationService _applicationService;

        public ApplicationController()
        {
            _applicationService = new ApplicationService();
        }

        [Authorize]
        public ActionResult GetApplications(int ApplicantId)
        {
            IList<ApplicationBEAN> _applications = _applicationService.GetApplicantApplications(ApplicantId);
            ViewBag.applicantId = ApplicantId;
            return View(_applications);
        }

        [Authorize]
        public ActionResult EditApplication(int ApplicationId)
        {
            ApplicationBEAN _applicationToEdit = _applicationService.GetApplication(ApplicationId);
            return View(_applicationToEdit);
        }

        [Authorize]
        [HttpPost]
        public ActionResult EditApplication(ApplicationBEAN application)
        {
            try
            {
                _applicationService.UpdateApplication(application);
                return RedirectToAction("GetApplications", new { ApplicantId = application.ApplicantId, controller = "Application" });
            }
            catch
            {
                return View();
            }
        }

        public ActionResult CreateApplication(int courseId, string CourseName, int ApplicantId, string UniversityName, int UniversityId)
        {
            IList<ApplicationBEAN> _applicantApplication = _applicationService.GetApplicantApplications(ApplicantId);
            if (_applicantApplication.Count < 5)
            {
                return View();
            }
            else
            {
                return RedirectToAction("GetCourse", new { id = courseId, ApplicantId = ApplicantId, UniversityId = UniversityId, Controller = "Course" });
            }
        }

        [Authorize]
        [HttpPost]
        public ActionResult CreateApplication(int courseId, ApplicationBEAN application)
        {
            try
            {
                application.Firm = null;
                application.UniversityOffer = "P";
                _applicationService.CreateApplication(application);
                return RedirectToAction("GetCourses", new { UniversityId = application.UniversityId, UniversityName = application.UniversityName, ApplicantId = application.ApplicantId, Controller = "Course" });
            }
            catch (Exception e)
            {
           
                return View();
            }
        }

        [Authorize]
        public ActionResult DecideAboutApplication(int ApplicationId)
        {
            ApplicationBEAN _applicationToDecideAbout = _applicationService.GetApplication(ApplicationId);
            return View(_applicationToDecideAbout);
        }

        [Authorize]
        [HttpPost]
        public ActionResult AcceptApplication(int ApplicationId)
        {
            try
            {
                // todo What happens after accept of application
                _applicationService.AcceptApplication(ApplicationId);
                return RedirectToAction("ManageApplications", new { id = ApplicationId, controller = "Application" });
            }
            catch
            {
                return View();
            }
        }

        [Authorize]
        [HttpPost]
        public ActionResult DeclineApplication(int id)
        {
            try
            {
                _applicationService.DeclineApplication(id);
                return RedirectToAction("ManageApplications", new { id = id, controller = "Application" });
            }
            catch
            {
                return View();
            }
        }

        [Authorize]
        public ActionResult DeleteApplication(int Id)
        {
            ApplicationBEAN _applicationToDelete = _applicationService.GetApplication(Id);
            ViewBag.Id = Id;
            return View(_applicationToDelete);
        }

        [Authorize]
        [HttpPost]
        public ActionResult DeleteApplication(ApplicationBEAN application)
        {
            try
            {
                var ApplicationId = application.Id;
                ApplicationBEAN _applicationToDelete = _applicationService.GetApplication(ApplicationId);
                _applicationService.DeleteApplication(ApplicationId);
                return RedirectToAction("GetApplications", new { ApplicantId = _applicationToDelete.Id, controller = "Application" });
            }
            catch
            {
                return View();
            }
        }
    }
}
