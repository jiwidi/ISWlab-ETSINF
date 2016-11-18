using GestAcaLib.Entities;
using System.Collections.Generic;
namespace GestAcaLib.Persistence
{
    public interface ITaughtCourseDAO
    {
        ICollection<TaughtCourse> findAllTeacher();
        void addTaughtCourse(TaughtCourse tau);
        void removeTaughtCourse(TaughtCourse tau);
        TaughtCourse findTaughtCourseByID(string id);
    }
}