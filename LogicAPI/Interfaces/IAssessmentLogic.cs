using StudentAdministrator.Models;

namespace StudentAdministrator.LogicAPI.Interfaces
{
    public interface IAssessmentLogic
    {
        bool CreateAssessment(string id, string assessmentName, int weightPercentage, int maxMarks);
        Assessment GetAssessmentById(string id);
        List<Assessment> GetAssessmentsByIds(List<string> assessmentIds);
        List<Assessment> GetAllAssessments();
        List<Module> GetAssessmentModules(string id);
        List<StudentAssessment> GetAllStudentAssessments();
        List<StudentAssessment> GetStudentAssessmentsByStudentID(string studentID, string moduleCode);
        StudentAssessment GetSingleAssessment(string studentId, string assessmentId, string moduleCode);
        bool RecordAssessment(string studentId, string assessmentId, string assessmentName, string moduleCode, int markScored, int maxMark, int weight);
        double CalculateModuleMark(string studentId, string moduleCode);
        bool ValidateAssessment(Assessment assessment);
        bool ValidateModuleAssessments(List<Assessment> assessments);
    }
}
