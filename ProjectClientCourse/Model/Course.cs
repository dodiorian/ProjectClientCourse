using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClientCourse.Model
{
    internal class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public int? Credits { get; set; }
        public int? TopicsId { get; set; }
        public int? ProfessorsId { get; set; }
        public bool? Status { get; set; }
    }
}
