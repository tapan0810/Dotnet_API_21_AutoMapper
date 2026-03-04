using AutoMapper;
using Dotnet_API_21_.Entities.Dtos;
using Dotnet_API_21_.Entities.Models;

namespace Dotnet_API_21_.Mapping
{
    public class StudentMappingProfile:Profile
    {
        public StudentMappingProfile()
        {
            CreateMap<CreateStudentDto, Student>();

            CreateMap<UpdateStudentDto,Student>();

            CreateMap<Student, GetAllStudentsDto>();

            CreateMap<Student,GetStudentByIdDto>();
        }
    }
}
