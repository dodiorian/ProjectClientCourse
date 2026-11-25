using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClientCourse.Model
{
    internal class Registation
    {
        public int RegId { get; set; }
        public int? StudentId { get; set; }
        public int? CourseId { get; set; }
        public string RegDate { get; set; }
        public string StatusReg { get; set; }
        public bool? Status { get; set; }

    }
}
