﻿using NAA.Data;
using NAA.Data.BEAN;
using NAA.Data.DAO;
using NAA.Data.iDAO;
using NAA.Services.IServices;
using NAA.Services.uk.ac.shu.hallam.webteach_net;
using NAA.Services.uk.ac.shu.hallam.webteach_net1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Services.Services
{
    public class ApplicationService : IApplicationService
    {
        private IUniversityManagerService _universityManagerService;
        private IApplicationDAO _dao;

        public ApplicationService()
        {
            _universityManagerService = new UniversityManagerService();
            _dao = new ApplicationDAO();
        }

        public void CreateApplicant(Applicant applicant)
        {
            _dao.CreateApplicant(applicant);
        }

        public void CreateApplication(ApplicationBEAN application)
        {
            _dao.CreateApplication(application);
        }

        public void DeleteApplication(int applicationId)
        {
            _dao.DeleteApplication(applicationId);
        }

        public Applicant getApplicant(Applicant applicant)
        {
            return _dao.GetApplicant(applicant.Id);
        }

        public IList<ApplicationBEAN> GetApplicantApplications(int applicantID)
        {
            return _dao.GetApplicantApplications(applicantID);
        }

        public ApplicationBEAN GetApplication(int applicationId)
        {
            return _dao.GetApplication(applicationId);
        }

        public CourseBEAN GetCourse(int universityId, int courseId)
        {
            return _universityManagerService.GetCourse(universityId, courseId);
        }

        public IList<CourseBEAN> GetCourses(int universityId)
        {
            return _universityManagerService.GetUniversityCourses(universityId);
        }

        public IList<University> GetUniversities()
        {
            throw new NotImplementedException();
        }

        public void UpdateApplicant(Applicant applicant)
        {
            throw new NotImplementedException();
        }

        public void UpdateApplication(ApplicationBEAN application)
        {
            throw new NotImplementedException();
        }
    }
}
