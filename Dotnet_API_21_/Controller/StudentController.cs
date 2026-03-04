using Dotnet_API_21_.Entities.Dtos;
using Dotnet_API_21_.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_API_21_.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController(IStudentService studentService) : ControllerBase
    {
        [HttpGet("GetAllStudents")]
        public async Task<ActionResult<List<GetAllStudentsDto>>> GetAllStudents()
        {
            var stud = await studentService.GetAllStudents();
            if (stud == null)
            {
                return NotFound();
            }
            return Ok(stud);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<GetStudentByIdDto?>> GetStudentById(int id)
        {
            var stud = await studentService.GetStudentById(id);

            if(stud is null)
                return NotFound();
            return Ok(stud);
        }

        [HttpPost("AddStudent")]
        public async Task<ActionResult<GetStudentByIdDto>> CreateStudent(CreateStudentDto studentDto)
        {
            var stud = await studentService.CreateStudent(studentDto);

            if (stud is null)
                return BadRequest("Invalid Student");

            return CreatedAtAction(nameof(CreateStudent), new { id = stud.StudentId }, stud);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<bool>> UpdateStudent(int id, UpdateStudentDto studentDto)
        {
            var stud = await studentService.UpdateStudent(id, studentDto);

            if (stud == false)
                return BadRequest("Invalid Student");
            return Ok(stud);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<bool>> DeleteStudent(int id)
        {
            var stud = await studentService.DeleteStudent(id);

            if (stud is false)
                return BadRequest("Student not available");
            return Ok(stud);

        }
    }
}
