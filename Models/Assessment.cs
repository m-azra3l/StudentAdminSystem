namespace StudentAdministrator.Models
{
    public class Assessment
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public int WeightPercentage { get; set; }
        public int MaxMarks { get; set; }
        public List<Module> Modules { get; set; } = new List<Module>();
    }

}
