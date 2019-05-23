using NAA.Data;
using NAA.Data.BEAN;
using NAA.Data.DAO;
using NAA.Data.iDAO;
using NAA.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Services.Services
{
    public class ApplicationServiceUniversity
    {

        private IApplicationDAO _applicationDAO;

        public ApplicationServiceUniversity()
        {
            _applicationDAO = new ApplicationDAO();
        }
        public Applicant GetApplicantByApplication(int applicationId)
        {
            return _applicationDAO.GetApplicantByApplication(applicationId);
        }
        public IList<NAA.Data.BEAN.ApplicationBEAN> GetUniversityApplications(int universityId)
        {
            return _applicationDAO.GetUniversityApplications(universityId);
        }
        public ApplicationBEAN UpdateOfferOfApplication(ApplicationBEAN application)
        {
            _applicationDAO.UpdateApplication(application);
            return _applicationDAO.GetApplication(application.Id);
        }
    }
}
