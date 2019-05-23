using NAA.Data.BEAN;
using NAA.Data.iDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Data.DAO
{
    public class ApplicationDAO : IApplicationDAO
    {
        private ApplicationModel _context;

        public ApplicationDAO()
        {
            _context = new ApplicationModel();
        }

        public void CreateApplicant(Applicant applicant)
        {
            _context.Applicant.Add(applicant);
            _context.SaveChanges();
        }

        public void CreateApplication(ApplicationBEAN application)
        {
            Application realApplication = new Application()
            {
                ApplicantId = GetIdFromApplicantName(application.ApplicantName),
                CourseName = application.CourseName,
                TeacherReference = application.TeacherReference,
                //UniversityId = GetIdFromUniversityName(application.UniversityName),
                PersonalStatement = application.PersonalStatement,
                TeacherContactDetails = application.TeacherContactDetails,
                UniversityOffer = application.UniversityOffer,
                Firm = application.Firm
            };
            _context.Application.Add(realApplication);
            _context.SaveChanges();
        }

        public void DeleteApplication(int applicationId)
        {
            var application = GetApplication(applicationId);

        }

        public Applicant GetApplicant(int applicantId)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicationBEAN> GetApplicantApplications(int universityId)
        {
            throw new NotImplementedException();
        }

        public ApplicationBEAN GetApplication(int applicationId)
        {
            throw new NotImplementedException();
        }

        public List<University> GetCourses(int universityId)
        {
            throw new NotImplementedException();
        }

        public List<University> GetUniversities()
        {
            throw new NotImplementedException();
        }

        public IList<ApplicationBEAN> GetUniversityApplications(int applicantId)
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

        public void UpdateOfferOfApplication(int applicationId, ApplicationBEAN application)
        {
            throw new NotImplementedException();
        }

        // Private Help Methods

        private int GetIdFromUniversityName(string universityName)
        {
            //TODO: change to int!!!
            var result = from university in _context.University
                         from application in _context.Application
                         // where application.UniversityId == university.UniversityId
                         where university.UniversityName == universityName
                         select university;
            return result.First().UniversityId;
        }

        private int GetNameFromUniversityId(int universityId)
        {
            //TODO: change to int!!!
            var result = from university in _context.University
                         from application in _context.Application
                             // where application.UniversityId == university.UniversityId
                         where university.UniversityId == universityId
                         select university;
            return result.First().UniversityId;
        }

        private int GetIdFromApplicantName(string applicantName)
        {
            var result = from applicant in _context.Applicant
                         from application in _context.Application
                         where application.ApplicantId == applicant.Id
                         where applicant.ApplicantName == applicantName
                         select applicant;
            return result.First().Id;
        }

        private string GetNameFromApplicantId(int applicantId)
        {
            var result = from applicant in _context.Applicant
                         from application in _context.Application
                         where application.ApplicantId == applicant.Id
                         where applicant.Id == applicantId
                         select applicant;
            return result.First().ApplicantName;
        }
    }
}
