namespace TeacherManagement.Business
{
  public interface ITeacherManager
  {
    TeacherResponseDTO InsertTeacher(TeacherInsertRequestDTO insertModel);
    TeacherResponseDTO UpdateTeacher(TeacherUpdateRequestDTO insertModel);
    TeacherResponseDTO GetTeacherById(TeacherGetTeacherRequestDTO teacherRequestDto);
  }
}