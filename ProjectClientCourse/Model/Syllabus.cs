using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClientCourse.Model
{
    internal class Syllabus
    {
        public int SyllabusId { get; set; }
        public int? CourseId { get; set; }
        public string LessonTopic { get; set; }
        public int? LessonCount { get; set; }
        public bool? Status { get; set; }

    }
}
