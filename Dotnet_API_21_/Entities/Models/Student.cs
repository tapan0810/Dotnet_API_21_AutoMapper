namespace Dotnet_API_21_.Entities.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; } =string.Empty;
        public string StudentEmail { get; set;} =string.Empty;
        public string StudentPhone { get; set; } = string.Empty;
        public bool IsActive { get; set; } = false;
    }
}
