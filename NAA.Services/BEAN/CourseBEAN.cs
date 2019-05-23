using NAA.Services.uk.ac.shu.hallam.webteach_net;
using NAA.Services.uk.ac.shu.hallam.webteach_net1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Data.BEAN
{
    public class CourseBEAN
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Degree { get; set; }


        public CourseBEAN(Course course)
        {
            Id = course.Id;
            Name = course.Name;
            Description = course.Description;
            Degree = course.Qualification;
        }

        public CourseBEAN(SHUCourse course)
        {
            Id = course.CourseId;
            Name = course.CName;
            Description = course.CDescription;
            Degree = course.CDegree;
        }
    }
}
