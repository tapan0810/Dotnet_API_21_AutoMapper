using AutoMapper;
using Dotnet_API_21_.Data;
using Dotnet_API_21_.Entities.Dtos;
using Dotnet_API_21_.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_API_21_.Service
{
    public class StudentService(IMapper _mapper, StudentDbContext _context) : IStudentService
    {
        public async Task<GetStudentByIdDto?> CreateStudent(CreateStudentDto student)
        {
            var stud = _mapper.Map<Student>(student);
             _context.DbSet.Add(stud);
            await _context.SaveChangesAsync();

            return _mapper.Map<GetStudentByIdDto>(stud);
        }

        public async Task<bool> DeleteStudent(int id)
        {
            var stud =await  _context.DbSet.FirstOrDefaultAsync(x=>x.StudentId == id);

            if(stud is null) return false;

            _context.DbSet.Remove(stud);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<List<GetAllStudentsDto>> GetAllStudents()
        {
            var students = await _context.DbSet.ToListAsync();

            return _mapper.Map<List<GetAllStudentsDto>>(students);
        }

        public async Task<GetStudentByIdDto> GetStudentById(int studentId)
        {
            var stud = await _context.DbSet.FirstOrDefaultAsync(X => X.StudentId == studentId);

            if (stud is null) return null;

            return _mapper.Map<GetStudentByIdDto>(stud);
        }

        public async Task<bool> UpdateStudent(int id, UpdateStudentDto student)
        {
            var stud = await _context.DbSet.FirstOrDefaultAsync(x => x.StudentId == id);

            if(stud is null) return false;

            _mapper.Map(student, stud);

            await _context.SaveChangesAsync();
            return true;
        }
    }
}
