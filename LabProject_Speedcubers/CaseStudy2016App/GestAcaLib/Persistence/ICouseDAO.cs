using GestAcaLib.Entities;
using System.Collections.Generic;
namespace GestAcaLib.Persistence
{
    public interface ICouseDAO
    {
        ICollection<Course> findAllCourse();
        void addCourse(Course co);
        void removeCourse(Course co);
        Course findCourseByID(string id);

    }
}