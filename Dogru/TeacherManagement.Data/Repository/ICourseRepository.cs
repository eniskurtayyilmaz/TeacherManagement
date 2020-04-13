using System.Collections.Generic;

namespace TeacherManagement.Data
{
  public interface ICourseRepository
  {
    Course InsertCourse(Course Course);
    Course UpdateCourse(Course Course);
    Course GetCourseByCourseId(int Id);
    List<Course> GetCourses();
  }
}