using System;
using TeacherManagement.Data;

namespace TeacherManagement.Business
{
  public class TeacherService : ITeacherManager
  {
    private readonly ITeacherRepository _teacherRepository;
    public TeacherService()
    {
      _teacherRepository = new TeacherRepository();
    }

    public TeacherResponseDTO InsertTeacher(TeacherInsertRequestDTO insertModel)
    {
      if (string.IsNullOrEmpty(insertModel?.Name))
      {
        throw new Exception("Öğretmen adı boş olamaz");
      }

      if (string.IsNullOrEmpty(insertModel?.Surname))
      {
        throw new Exception("Öğretmen soyadı boş olamaz");
      }

      var insertNewTeacher = new Teacher()
      {
        Id = 0,
        Name = insertModel.Name,
        Surname = insertModel.Surname,
        CreatedDateTime = DateTime.Now,
      };

      var result = _teacherRepository.InsertTeacher(insertNewTeacher);
      return new TeacherResponseDTO()
      {
        Id = result.Id,
        Name = result.Name,
        Surname = result.Surname
      };
    }

    public TeacherResponseDTO UpdateTeacher(TeacherUpdateRequestDTO insertModel)
    {
      throw new NotImplementedException();
    }

    public TeacherResponseDTO GetTeacherById(TeacherGetTeacherRequestDTO teacherRequestDto)
    {
      if (teacherRequestDto?.TeacherId == 0)
      {
        throw new Exception("Öğretmen değeri boş olamaz");
      }

      var result = _teacherRepository.GetTeacherByTeacherId(teacherRequestDto.TeacherId);
      if (result == null)
      {
        throw new Exception("Öğretmen bulunamadı");
      }

      return new TeacherResponseDTO()
      {
        Id = result.Id,
        Name = result.Name,
        Surname = result.Surname
      };
    }
  }
}
