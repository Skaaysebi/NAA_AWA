﻿using NAA.Data;
using NAA.Data.BEAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Services.IServices
{
    public interface IApplicationService
    {
        void CreateApplicant(Applicant applicant);
        void UpdateApplicant(Applicant applicant);

        List<University> GetUniversities();
        List<CourseBEAN> GetCourses(int universityId);

        void CreateApplication(ApplicationBEAN application);
        void UpdateApplication(ApplicationBEAN application);
        IList<ApplicationBEAN> GetApplicantApplications(int universityId);
        ApplicationBEAN GetApplication(int applicationId);
        void DeleteApplication(int applicationId);
    }
}
