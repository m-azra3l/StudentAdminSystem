namespace StudentAdministrator.Models
{
    public class StudentAssessment
    {
        public string? StudentId { get; set; }
        public string? AssessmentId { get; set; }
        public string? AssessmentName { get; set; }
        public string? ModuleCode { get; set; }
        public int MarkScored { get; set; }
        public int MaxMarks { get; set; }
        public int WeightPercentage { get; set; }
    }
}
