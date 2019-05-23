using NAA.Data;
using NAA.Data.BEAN;
using NAA.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Services.Services
{
    public class ApplicationService : IApplicationService
    {
        private NAA.Services.uk.ac.shu.hallam.webteach_net.SheffieldWebService _service;

        public ApplicationService()
        {
            _service = new uk.ac.shu.hallam.webteach_net.SheffieldWebService();
        }

        public void CreateApplicant(Applicant applicant)
        {
            throw new NotImplementedException();
        }

        public void CreateApplication(ApplicationBEAN application)
        {
            throw new NotImplementedException();
        }

        public void DeleteApplication(int applicationId)
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

        public List<CourseBEAN> GetCourses(int universityId)
        {
            //_service.
        }

        public List<University> GetUniversities()
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
