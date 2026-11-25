using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClientCourse.Model
{
    internal class Schedule
    {
        public int ScheduleId { get; set; }
        public int? CourseId { get; set; }
        public string Day { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Classroom { get; set; }
        public bool? Status { get; set; }
    }
}
