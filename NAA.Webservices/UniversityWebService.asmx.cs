using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using NAA.Services;
using NAA.Data;
using NAA.Services.Services;
using NAA.Data.BEAN;
using NAA.Services.BEAN;
using System.Web.Services.Protocols;

namespace NAA.Webservices
{
    /// <summary>
    /// Summary description for UniversityWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UniversityWebService : System.Web.Services.WebService
    {

        private ApplicationServiceUniversity _universityService;

        public UniversityWebService()
        {
            _universityService = new ApplicationServiceUniversity();
        }

        [WebMethod]
        public Applicant GetApplicantByApplication(int applicationId)
        {
            try
            {
                return _universityService.GetApplicantByApplication(applicationId);
            }
            catch (Exception e)
            {
                Context.Response.StatusCode = (int)System.Net.HttpStatusCode.BadRequest;
                return null;
            }
        }

        [WebMethod]
        public List<ApplicationBEAN> GetApplications(int universityId)
        {
            try
            {
                return _universityService.GetUniversityApplications(universityId).ToList();
            } catch (Exception e)
            {
                Context.Response.StatusCode = (int)System.Net.HttpStatusCode.BadRequest;
                return null;
            }
        }

        [WebMethod]
        public ApplicationUniversityBean ChangeOfferOfApplication(int applicationId, string State)
        {
            try { 
                var applicant = _universityService.UpdateOfferOfApplication(applicationId, State);
                return new ApplicationUniversityBean(applicant);
            }
            catch (Exception e)
            {
                Context.Response.StatusCode = (int)System.Net.HttpStatusCode.BadRequest;
                return null;
            }
        }
    }
}
