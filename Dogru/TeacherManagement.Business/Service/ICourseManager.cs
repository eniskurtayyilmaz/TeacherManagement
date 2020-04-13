namespace TeacherManagement.Business
{
  public interface ICourseManager
  {
    CourseResponseDTO InsertCourse(CourseInsertRequestDTO insertModel);
    CourseResponseDTO UpdateCourse(CourseUpdateRequestDTO insertModel);
  }
}