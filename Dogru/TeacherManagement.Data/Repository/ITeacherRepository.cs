using System.Collections.Generic;

namespace TeacherManagement.Data
{
  public interface ITeacherRepository
  {
    Teacher InsertTeacher(Teacher teacher);
    Teacher UpdateTeacher(Teacher teacher);
    Teacher GetTeacherByTeacherId(int Id);
    List<Teacher> GetTeachers();
  }
}