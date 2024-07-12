using StudentAdministrator.Models;

namespace StudentAdministrator.LogicAPI.Interfaces
{
    public interface IStudentLogic
    {
        bool RegisterStudent(
            string id,
            string fName,
            string lName,
            string progId,
            string cohortId
         );
        StudentModel GetStudentById(string studentId);
        List<StudentModel> GetAllStudents();
        List<Module> GetStudentModules(string studentId);
        List<Assessment> GetStudentAssessments(string studentId);
    }
}
