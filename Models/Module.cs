namespace StudentAdministrator.Models
{
    public class Module
    {
        public string? Code { get; set; }
        public string? Title { get; set; }
        public bool isOptional { get; set; }
        public string? ProgramId { get; set; }
        public List<StudentModel> Students { get; set; } = new List<StudentModel>();
        public List<Assessment> Assessments { get; set; } = new List<Assessment>();
    }

}
