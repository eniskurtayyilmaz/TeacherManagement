using System;

namespace TeacherManagement.Business
{
  public class CourseUpdateRequestDTO
  {
    public int Id;
    public int TeacherId;
    public string CourseName;
    public DateTime CourseStartDate;
    public DateTime? CourseFinishDate;
  }
}