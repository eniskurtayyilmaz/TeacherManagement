using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeacherManagement.Presentation.Models
{
  public class DbContext
  {
    public IList<Teacher> GetTeachers()
    {
      return new List<Teacher>();
    }

    public bool InsertTeacher(Teacher teacher)
    {
      /* DB Insert */
      return true;
    }
  }
}
