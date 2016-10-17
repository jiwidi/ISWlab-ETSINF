using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAcaLib.Entities
{
    public partial class Teacher
    {
        public Teacher()
        {
            this.TaughtCourses = new List<TaughtCourse>();
        }
        public Teacher(string s)
        {
            this.Ssn = s;
            this.TaughtCourses = new List<TaughtCourse>();
            
        }
    }
}
