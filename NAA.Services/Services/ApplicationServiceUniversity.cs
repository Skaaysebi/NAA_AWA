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
        public ApplicationBEAN UpdateOfferOfApplication(int applicationId, string State)
        {   
            var application = _applicationDAO.GetApplication(applicationId);
            var applicationBeforeUpdate = _applicationDAO.GetApplication(application.Id);

            /* Business rules */

            if(State != "C" || State != "U" || State != "R" || State != "P")
                throw new Exception("You have to use State with C, U, R or P");

            if (applicationBeforeUpdate.UniversityOffer == "U" && State == "C")
                throw new Exception("You can't change from unconditional to conditional offer.");

            if (applicationBeforeUpdate.UniversityOffer == "C" && State == "P")
                throw new Exception("You can't change from conditional to pending offer.");

            if (applicationBeforeUpdate.UniversityOffer == "U" && State == "P")
                throw new Exception("You can't change from unconditional to pending offer.");

            if (applicationBeforeUpdate.UniversityOffer == "R" && State == "P")
                throw new Exception("You can't change from rejected to pending offer.");

            /*END Business rules */

            application.UniversityOffer = State;
            _applicationDAO.UpdateApplication(application);
            return _applicationDAO.GetApplication(application.Id);
        }
    }
}
