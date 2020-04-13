using System;

namespace TeacherManagement.Business
{
  public class CourseInsertRequestDTO
  {
    public int TeacherId;
    public string CourseName;
    public DateTime CourseStartDate;
    public DateTime? CourseFinishDate;
  }
}