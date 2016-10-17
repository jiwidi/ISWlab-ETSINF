using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAcaLib.Entities
{
    public partial class Student : Person
    {
        String iban;
        List<Enrollment> enrollments;
        public Student() { enrollments = new List<Enrollment>(); }

        public Student(String address, String id, String name, int zipcode,String iban) 
            :base (address,id,name,zipcode) {
            this.iban = iban;
            enrollments = new List<Enrollment>();

        }

    }
}
