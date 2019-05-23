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
        private ApplicationEntities _context;

        public ApplicationDAO()
        {
            _context = new ApplicationEntities();
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
                UniversityId = GetIdFromUniversityName(application.UniversityName),
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
            var application = GetActualApplication(applicationId);
            _context.Application.Remove(application);
            _context.SaveChanges();
        }

        public void AcceptApplication(int applicationId)
        {
            var actualApplication = GetActualApplication(applicationId);
            actualApplication.Firm = true;

            _context.SaveChanges();
        }

        public void DeclineApplication(int applicationId)
        {
            var actualApplication = GetActualApplication(applicationId);
            actualApplication.Firm = false;

            _context.SaveChanges();
        }

        public Applicant GetApplicant(int applicantId)
        {
            var result = from applicant in _context.Applicant
                         where applicant.Id == applicantId
                         select applicant;
            return result.First();
        }

        public IList<ApplicationBEAN> GetApplicantApplications(int universityId)
        {
            var results = from application in _context.Application
                         where application.UniversityId == universityId
                         select application;
            var applications = new List<ApplicationBEAN>();
            foreach (var result in results)
            {
                applications.Add(GetApplication(result.Id));
            }
            return applications;
        }

        public ApplicationBEAN GetApplication(int applicationId)
        {
            var actualApplication = GetActualApplication(applicationId);
            var application = new ApplicationBEAN()
            {
                Id = actualApplication.Id,
                ApplicantName = GetNameFromApplicantId(actualApplication.ApplicantId),
                CourseName = actualApplication.CourseName,
                UniversityName = GetNameFromUniversityId(actualApplication.UniversityId),
                UniversityOffer = actualApplication.UniversityOffer,
                PersonalStatement = actualApplication.PersonalStatement,
                TeacherReference = actualApplication.TeacherReference,
                TeacherContactDetails = actualApplication.TeacherContactDetails,
                Firm = actualApplication.Firm,
            };
            return application;
        }

        public List<University> GetUniversities()
        {
            var result = from university in _context.University
                         select university;
            return result.ToList();
        }

        public IList<ApplicationBEAN> GetUniversityApplications(int applicantId)
        {
            var results = from application in _context.Application
                          where application.ApplicantId == applicantId
                          select application;
            var applications = new List<ApplicationBEAN>();
            foreach (var result in results)
            {
                applications.Add(GetApplication(result.Id));
            }
            return applications;
        }

        public void UpdateApplicant(Applicant applicant)
        {
            var result = from aApplicant in _context.Applicant
                              where aApplicant.Id == applicant.Id
                              select aApplicant;
            var dbApplicant = result.First();
            dbApplicant.ApplicantAddress = applicant.ApplicantAddress;
            dbApplicant.ApplicantName = applicant.ApplicantName;
            dbApplicant.Email = applicant.Email;
            dbApplicant.Phone = applicant.Phone;
            _context.SaveChanges();
        }

        public void UpdateApplication(ApplicationBEAN application)
        {
            var actualApplication = GetActualApplication(application.Id);
            actualApplication.ApplicantId = GetIdFromApplicantName(application.ApplicantName);
            actualApplication.CourseName = application.CourseName;
            actualApplication.Firm = application.Firm;
            actualApplication.PersonalStatement = application.PersonalStatement;
            actualApplication.TeacherContactDetails = application.TeacherContactDetails;
            actualApplication.TeacherReference = application.TeacherReference;
            actualApplication.UniversityId = GetIdFromUniversityName(application.UniversityName);
            actualApplication.UniversityOffer = application.UniversityOffer;
            _context.SaveChanges();
        }

        public Applicant GetApplicantByApplication(int applicationId)
        {
            var applicantName = GetIdFromApplicantName(GetApplication(applicationId).ApplicantName);
            return GetApplicant(applicantName);
        }

        // Private Help Methods

        private Application GetActualApplication(int applicationId)
        {
            var result = from application in _context.Application
                         where application.Id == applicationId
                         select application;
            return result.First();
        }

        private int GetIdFromUniversityName(string universityName)
        {
            var result = from university in _context.University
                         from application in _context.Application
                         where application.UniversityId == university.UniversityId
                         where university.UniversityName == universityName
                         select university;
            return result.First().UniversityId;
        }

        public string GetNameFromUniversityId(int universityId)
        {
            var result = from university in _context.University
                         from application in _context.Application
                         where application.UniversityId == university.UniversityId
                         where university.UniversityId == universityId
                         select university;
            return result.First().UniversityName;
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
