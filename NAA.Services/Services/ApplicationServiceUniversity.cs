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
    public class ApplicationServiceUniversity : IApplicationServiceUniversity
    {
        private IApplicationDAO _dao;

        public ApplicationServiceUniversity()
        {
            _dao = new ApplicationDAO();
        }

        public Applicant GetApplicantByApplication(int applicationId)
        {
            return _dao.GetApplicantByApplication(applicationId);
        }

        public IList<ApplicationBEAN> GetUniversityApplications(int applicantId)
        {
            throw new NotImplementedException();
        }

        public void UpdateOfferOfApplication(int applicationId, ApplicationBEAN application)
        {
            throw new NotImplementedException();
        }
    }
}
