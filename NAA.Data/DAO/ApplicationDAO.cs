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

            _context.Application.Add();
        }

        public void DeleteApplication(int applicationId)
        {
            throw new NotImplementedException();
        }

        public void GetApplicant(int applicantId)
        {
            throw new NotImplementedException();
        }

        public void GetApplicantApplications(int universityId)
        {
            throw new NotImplementedException();
        }

        public void GetApplication(int applicationId)
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

        public void GetUniversityApplications(int applicantId)
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

        //private int GetIdFromUniversityName(string universityName)
        //{
        //    //TODO: change to int!!!
        //    var result = from university in _context.University
        //                 from application in _context.Application
        //                     // where application.UniversityId == university.UniversityId
        //                 where university.UniversityName == universityName
        //                 select university;
        //    return result.First().UniversityId;
        //}

        //private int GetIdFromUniversityName(string universityName)
        //{
        //    //TODO: change to int!!!
        //    var result = from university in _context.University
        //                 from application in _context.Application
        //                     // where application.UniversityId == university.UniversityId
        //                 where university.UniversityName == universityName
        //                 select university;
        //    return result.First().UniversityId;
        //}
    }
}
