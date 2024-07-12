using StudentAdministrator.Models;

namespace StudentAdministrator.DataLayer
{
    public interface IDataHandler
    {
        // Student operations
        void RegisterStudent(StudentModel student);
        StudentModel GetStudentById(string studentId);
        List<StudentModel> GetAllStudents();
        List<Module> GetStudentModules(string studentId);
        List<Assessment> GetStudentAssessments(string studentId);

        // StudentCohort operations
        void CreateStudentCohort(StudentCohort cohort);
        StudentCohort? GetStudentCohortById(string cohortID);
        List<StudentCohort> GetAllStudentCohorts();
        List<StudentCohort> GetProgramCohorts(string programId);

        // DegreeProgram operations
        void CreateDegreeProgram(DegreeProgram program);
        DegreeProgram? GetDegreeProgramById(string programID);
        List<DegreeProgram> GetAllDegreePrograms();
        List<Module> GetAllProgramModules(string programId);

        // Module operation
        void CreateModule(Module module);
        Module GetModuleByCode(string moduleCode);
        List<Module> GetAllModules();
        List<Module> GetOptionalModules(string programId);
        List<Module> GetProgramModules(string programId);
        List<StudentAssessment> GetModuleAssessments(string moduleCode);

        // Assessment operation
        void CreateAssessment(Assessment assessment);
        Assessment GetAssessmentById(string assessmentId);
        List<Assessment> GetAssessmentsByIds(List<string> assessmentIds);
        List<Assessment> GetAllAssessments();
        List<Module> GetAssessmentModules(string assessmentName);

        // Student Assessment Operations
        List<StudentAssessment> GetAllStudentAssessments();
        List<StudentAssessment> GetStudentAssessmentsByStudentID(string studentID, string moduleCode);
        StudentAssessment GetSingleAssessment(string studentId, string assessmentId, string moduleCode);
        void RecordAssessment(StudentAssessment association);
    }
}
