using NAA.Services.uk.ac.shu.hallam.webteach_net;
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
        public string Description { get; set; }

        public CourseBEAN(Course course)
        {
            Id = course.Id;
            Description = course.Description;
        }
    }
}
