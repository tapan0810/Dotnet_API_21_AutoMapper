namespace Dotnet_API_21_.Entities.Dtos
{
    public class UpdateStudentDto
    {
        public string StudentName { get; set; } = string.Empty;
        public string StudentEmail { get; set; } = string.Empty;
        public string StudentPhone { get; set; } = string.Empty;
        public bool IsActive { get; set; } = false;
    }
}
