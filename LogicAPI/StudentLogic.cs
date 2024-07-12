using StudentAdministrator.DataLayer;
using StudentAdministrator.LogicAPI.Interfaces;
using StudentAdministrator.Models;

namespace StudentAdministrator.LogicAPI
{
    public class StudentLogic : IStudentLogic
    {
        private readonly IDataHandler dataHandler;

        public StudentLogic(IDataHandler dataHandler)
        {
            this.dataHandler = dataHandler;
        }

        public bool RegisterStudent(
            string id, 
            string fName, 
            string lName, 
            string progId, 
            string cohortId)
        {

            StudentModel student = dataHandler.GetStudentById(id);
            if (student == null)
            {
                var newStudent = new StudentModel
                {
                    ID = id,
                    FirstName = fName,
                    LastName = lName,
                    ProgramId = progId,
                    CohortId = cohortId,
                };
                dataHandler.RegisterStudent(newStudent);
                return true;
            }
            else
            {
                throw new Exception($"Student already exist.");
            }

        }


        public StudentModel GetStudentById(string studentId)
        {
            return dataHandler.GetStudentById(studentId);
        }

        public List<StudentModel> GetAllStudents()
        {
            return dataHandler.GetAllStudents();
        }

        public List<Module> GetStudentModules(string studentId)
        {
            return dataHandler.GetStudentModules(studentId);
        }

        public List<Assessment> GetStudentAssessments(string studentId)
        {
            return dataHandler.GetStudentAssessments(studentId);
        }
    }
}
