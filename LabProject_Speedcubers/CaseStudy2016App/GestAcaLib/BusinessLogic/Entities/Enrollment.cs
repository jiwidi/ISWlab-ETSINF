using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAcaLib.Entities
{
    public partial class Enrollment
    {
        public Enrollment()
        {
            Absences = new List<Absence>();
        }
        public Enrollment(DateTime enrollment,DateTime cancellation, Boolean unique, int Id,Student estu)
        {
            this.Id = Id;
            this.UniquePayment = unique;
            this.EnrollmentDate = enrollment;
            this.CancellationDate = cancellation;
            Absences = new List<Absence>();
            this.Student = estu;
        }

    }
}
