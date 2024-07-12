namespace StudentAdministrator.Models
{
    public class DegreeProgram
    {
        public string? ProgramID { get; set; }
        public string? Title { get; set; }
        public string? DurationInYears { get; set; }
        public List<Module>? Modules { get; set; } = new List<Module>();
    }

}
