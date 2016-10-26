using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAcaLib.Entities
{
    public partial class Student : Person
    {
        
        public Student():base() { this.Enrollments = new List<Enrollment>(); }

        public Student(String address, String id, String name, int zipcode,String iban) 
            :base (address,id,name,zipcode) {
            this.IBAN = iban;
            this.Enrollments = new List<Enrollment>();
            
        }

    }
}
