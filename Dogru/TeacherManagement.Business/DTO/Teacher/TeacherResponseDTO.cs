using System;

namespace TeacherManagement.Business
{
  public class TeacherResponseDTO
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
  }

  public class CourseResponseDTO
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CourseStartDate;
    public DateTime? CourseFinishDate;
    public TeacherResponseDTO Teacher;
  }
}