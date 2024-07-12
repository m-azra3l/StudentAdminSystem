using StudentAdministrator.Models;

namespace StudentAdministrator.LogicAPI.Interfaces
{
    public interface ICohortLogic
    {
        bool CreateStudentCohort(string cohortId, string academicSession, string programId);
        StudentCohort GetStudentCohortById(string cohortId);
        List<StudentCohort> GetAllStudentCohorts();
        List<StudentCohort> GetProgramCohorts(string programId);
    }
}
