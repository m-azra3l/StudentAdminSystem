namespace StudentAdministrator.Models
{
    public class StudentCohort
    {
        public string? CohortID { get; set; }
        public string? AcademicSession { get; set; }
        public string? ProgramId { get; set; }
        public List<StudentModel> Students { get; set; } = new List<StudentModel>();
    }

}
