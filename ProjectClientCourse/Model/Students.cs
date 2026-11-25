using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClientCourse.Model
{
    internal class Students
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Degree { get; set; }
        public bool? Status { get; set; }
        public int CodeStudent { get; set; }
    }
}
