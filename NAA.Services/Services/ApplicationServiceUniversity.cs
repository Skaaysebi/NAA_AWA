using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.Data;
using NAA.Data.DAO;
using NAA.Data.iDAO;


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
        public void UpdateOfferOfApplication(int applicationId, NAA.Data.BEAN.ApplicationBEAN application)
        {
            _applicationDAO.UpdateOfferOfApplication(applicationId, application);
        }
    }
}
