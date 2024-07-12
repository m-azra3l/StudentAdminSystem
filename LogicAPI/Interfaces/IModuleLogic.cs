using StudentAdministrator.Models;

namespace StudentAdministrator.LogicAPI.Interfaces
{
    public interface IModuleLogic
    {
        bool CreateModule(string moduleCode, string title, bool isOptional, string programId);
        Module GetModuleByCode(string moduleCode);
        List<Module> GetAllModules();
        List<Module> GetOptionalModules(string programId);        
        List<Module> GetProgramModules(string programId);
        List<StudentAssessment> GetModuleAssessments(string moduleCode);
        string DetermineModuleResult(string studentId, string moduleCode);
        double CalculateProgramScore(string studentId, string programId);
        string DetermineProgramResult(int programScore);
    }
}
