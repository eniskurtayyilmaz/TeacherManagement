using System;

namespace TeacherManagement.Data
{
  public sealed class Course : BaseEntity
  {
    public int TeacherId;
    public string Name;
    public DateTime StartDate;
    public DateTime? FinishDate;
  }
}