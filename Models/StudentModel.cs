namespace StudentAdministrator.Models
{
    public class StudentModel
    {
        public string? ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public List<Module> Modules { get; set; } = new List<Module>();
        public List<Assessment> Assessments { get; set; } = new List<Assessment>();
        public string? ProgramId { get; set; }
        public string? CohortId { get; set; }
    }

}
