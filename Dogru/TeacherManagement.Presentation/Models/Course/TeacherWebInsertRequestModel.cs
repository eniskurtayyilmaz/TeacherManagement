using System;

namespace TeacherManagement.Presentation.Models
{
  public class CourseWebInsertRequestModel
  {
    public int TeacherId { get; set; }
    public string CourseName { get; set; }

    public DateTime CourseStartDate;
    public DateTime? CourseFinishDate;
  }

  public class CourseWebViewResponseModel
  {
    public string TeacherName { get; set; }
    public int CourseId { get; set; }
    public string CourseName { get; set; }

    public DateTime CourseStartDate;
    public DateTime? CourseFinishDate;
  }
}