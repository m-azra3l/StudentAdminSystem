using StudentAdministrator.Models;

namespace StudentAdministrator.LogicAPI.Interfaces
{
    public interface IDegreeLogic
    {
        bool CreateDegreeProgram(string programId, string title, string durationInYears);
        DegreeProgram GetDegreeById(string programID);
        List<DegreeProgram> GetAllDegreePrograms();
        List<Module> GetAllProgramModules(string programId);
        int CalculateProgrammeMark(List<int> moduleMarks);
        bool IsProgrammeMarkUndefined(List<int> moduleMarks);
        string DetermineProgrammeResult(int programmeMark);
    }
}
