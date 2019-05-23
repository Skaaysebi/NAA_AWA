using NAA.Data;
using NAA.Data.BEAN;
using NAA.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using NAA.Data.BEAN;
using NAA.Services.IServices;

namespace NAA.Webapplication.Controllers
{
    public class ApplicationController : Controller
    {
        private IApplicationService _applicationService;

        public ApplicationController()
        {
            //_applicationService = new IApplicationService();
        }

        [Authorize]
        public ActionResult ManageApplications(int id)
        {
            IList<ApplicationBEAN> _applications = _applicationService.GetApplicantApplications(id);
            ViewBag.applicantId = id;
            return View(_applications);
        }

        [Authorize]
        public ActionResult EditApplication(int id)
        {
            ApplicationBEAN _applicationToEdit = _applicationService.GetApplication(id);
            return View(_applicationToEdit);
        }

        [Authorize]
        [HttpPost]
        public ActionResult EditApplication(ApplicationBEAN application)
        {
            try
            {
                _applicationService.UpdateApplication(application);
                return RedirectToAction("ManageApplications", new { id = application.Id, controller = "Application" });
            }
            catch
            {
                return View();
            }
        }

        public ActionResult CreateApplication(int courseId, string CourseName, int ApplicantId, int UniversityId)
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult CreateApplication(int courseId, ApplicationBEAN application)
        {
            try
            {
                // TODO: Add insert logic here
                _applicationService.CreateApplication(application);
                return RedirectToAction("GetCourseDetails", new { courseId = courseId, ApplicantId = application.ApplicantId, UniversityId = application.UniversityId, Controller = "Course" });
            }
            catch
            {
                return View();
            }
        }

        [Authorize]
        public ActionResult DecideAboutApplication(int id)
        {
            ApplicationBEAN _applicationToDecideAbout = _applicationService.GetApplication(id);
            return View(_applicationToDecideAbout);
        }

        [Authorize]
        [HttpPost]
        public ActionResult AcceptApplication(int id)
        {
            try
            {
                // todo What happens after accept of application
                _applicationService.AcceptApplication(id);
                return RedirectToAction("ManageApplications", new { id = id, controller = "Application" });
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
        public ActionResult DeleteApplication(int id)
        {
            ApplicationBEAN _applicationToDelete = _applicationService.GetApplication(id);
            return View(_applicationToDelete);
        }

        [Authorize]
        [HttpPost]
        public ActionResult DeleteApplication(ApplicationBEAN application)
        {
            try
            {
                // Check if Application can be deleted or not?
                ApplicationBEAN _applicationToDelete = _applicationService.GetApplication(application.Id);
                _applicationService.DeleteApplication(_applicationToDelete.Id);
                return RedirectToAction("ManageApplications", new { id = _applicationToDelete.Id, controller = "Application" });
            }
            catch
            {
                return View();
            }
        }
    }
}
