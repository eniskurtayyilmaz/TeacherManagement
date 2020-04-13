using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TeacherManagement.Business;
using TeacherManagement.Presentation.Models;

namespace TeacherManagement.Presentation.Controllers
{
  public class TeacherController : Controller
  {
    private readonly ITeacherManager _teacherManager;
    public TeacherController()
    {
      _teacherManager = new TeacherService();
    }

    public IActionResult InsertTeacher(TeacherWebInsertRequestModel teacherModel)
    {
      var teacherInsertRequestModel = new TeacherInsertRequestDTO()
      {
        Name = teacherModel.TeacherName,
        Surname = teacherModel.TeacherSurname
      };

      var resultInsert = _teacherManager.InsertTeacher(teacherInsertRequestModel);
      var responseModel = new TeacherWebViewResponseModel()
      {
        TeacherId = resultInsert.Id,
        TeacherName = resultInsert.Name,
        TeacherSurname = resultInsert.Surname
      };

      return View(responseModel);
    }
  }
}