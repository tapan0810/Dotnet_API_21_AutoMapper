using Dotnet_API_21_.Entities.Dtos;

namespace Dotnet_API_21_.Service
{
    public interface IStudentService
    {
        public Task<List<GetAllStudentsDto>> GetAllStudents();
        public Task<GetStudentByIdDto> GetStudentById(int studentId);
        public Task<GetStudentByIdDto> CreateStudent(CreateStudentDto student);
        public Task<bool> UpdateStudent(int id,UpdateStudentDto student);
        public Task<bool> DeleteStudent(int id);
    }
}
