using System;
using TeacherManagement.Data;

namespace TeacherManagement.Business
{
  public class CourseService : ICourseManager
  {
    private readonly ICourseRepository _courseRepository;
    private readonly ITeacherManager _teacherManager;

    public CourseService()
    {
      _courseRepository = new CourseRepository();
      _teacherManager = new TeacherService();
    }

    public CourseResponseDTO InsertCourse(CourseInsertRequestDTO insertModel)
    {
      if (string.IsNullOrEmpty(insertModel?.CourseName))
      {
        throw new Exception("Kurs adı boş olamaz");
      }

      if (insertModel?.CourseStartDate.Year < DateTime.Now.Year)
      {
        throw new Exception("Kurs başlangıç tarihi yanlış");
      }

      var existTeacher = _teacherManager.GetTeacherById(new TeacherGetTeacherRequestDTO() { TeacherId = insertModel.TeacherId });
      
      var insertNewCourse = new Course()
      {
        Id = 0,
        TeacherId = existTeacher.Id,
        Name = insertModel.CourseName,
        StartDate = insertModel.CourseStartDate,
        FinishDate = insertModel.CourseFinishDate,
        CreatedDateTime = DateTime.Now,
      };

      var result = _courseRepository.InsertCourse(insertNewCourse);
      return new CourseResponseDTO()
      {
        Id = result.Id,
        Name = result.Name,
        CourseStartDate = result.StartDate,
        CourseFinishDate = result.FinishDate,
        Teacher = existTeacher
      };
    }

    public CourseResponseDTO UpdateCourse(CourseUpdateRequestDTO insertModel)
    {
      throw new NotImplementedException();
    }
  }
}