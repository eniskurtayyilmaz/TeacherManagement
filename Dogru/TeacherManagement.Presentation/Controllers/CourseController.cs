using Microsoft.AspNetCore.Mvc;
using TeacherManagement.Business;
using TeacherManagement.Presentation.Models;

namespace TeacherManagement.Presentation.Controllers
{
  public class CourseController : Controller
  {
    private readonly ICourseManager _courseManager;
    public CourseController()
    {
      _courseManager = new CourseService();
    }

    public IActionResult InsertCourse(CourseWebInsertRequestModel CourseModel)
    {
      var CourseInsertRequestModel = new CourseInsertRequestDTO()
      {
        TeacherId = CourseModel.TeacherId,
        CourseName = CourseModel.CourseName,
        CourseStartDate = CourseModel.CourseStartDate,
        CourseFinishDate = CourseModel.CourseFinishDate
      };

      var resultInsert = _courseManager.InsertCourse(CourseInsertRequestModel);
      var responseModel = new CourseWebViewResponseModel()
      {
        CourseId = resultInsert.Id,
        CourseName = resultInsert.Name,
        CourseStartDate = CourseModel.CourseStartDate,
        CourseFinishDate = CourseModel.CourseFinishDate,
        TeacherName = resultInsert.Teacher.Name + " " + resultInsert.Teacher.Surname,
      };

      return View(responseModel);
    }
  }
}