using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAcaLib.Entities
{
    public partial class Teacher
    {
        public Teacher():base()
        {
            this.TaughtCourses = new List<TaughtCourse>();
        }
        public Teacher(String address, String id, String name, int zipcode, String s)
        : base(address, id, name, zipcode)
        {
            this.Ssn = s;
            this.TaughtCourses = new List<TaughtCourse>();
           
        }
    }
}
