using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAcaLib.Entities
{
    public partial class TaughtCourse
    {
        DateTime endTime, startDateTime;
        int id, quota, sessionDuration, totalPrice;
        String teachingDay;

        public TaughtCourse() { }

        public TaughtCourse(int id, int quota, int sessionDuration, int totalPrice, DateTime endTime, DateTime startDateTime, string teachingDay,Course co )
        {
            this.id = id;
            this.quota = quota;
            this.sessionDuration = sessionDuration;
            this.totalPrice = totalPrice;
            this.endTime = endTime;
            this.startDateTime = startDateTime;
            this.teachingDay = teachingDay;
            this.Enrollments = new List<Enrollment>();
            this.Course = co;
            //faltan las listas
        }
    }
}
