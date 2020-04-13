using System;

namespace TeacherManagement.Data
{
  public abstract class BaseEntity
  {
    public int Id { get; set; }
    public DateTime CreatedDateTime { get; set; }
    public DateTime? UpdatedDateTime { get; set; }
  }
}