using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TeacherManagement.Presentation.Models;

namespace TeacherManagement.Presentation.Controllers
{
  public class TeacherController : Controller
  {
    private readonly DbContext dbContext = new DbContext();

    public IActionResult InsertTeacher(Teacher teacherModel)
    {
      if (string.IsNullOrEmpty(teacherModel?.Name))
      {
        throw new Exception("Öðretmen adý boþ olamaz");
      }

      if (string.IsNullOrEmpty(teacherModel?.Surname))
      {
        throw new Exception("Öðretmen soyadý boþ olamaz");
      }

      var result = dbContext.InsertTeacher(teacherModel);
      if (result == false)
      {
        throw new Exception("Öðretmen sisteme kayýt edilemedi");
      }

      return View(teacherModel);
    }
  }
}