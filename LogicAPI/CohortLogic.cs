using StudentAdministrator.DataLayer;
using StudentAdministrator.LogicAPI.Interfaces;
using StudentAdministrator.Models;

namespace StudentAdministrator.LogicAPI
{
    public class CohortLogic : ICohortLogic
    {
        private readonly IDataHandler dataHandler;

        public CohortLogic(IDataHandler dataHandler)
        {
            this.dataHandler = dataHandler;
        }

        public bool CreateStudentCohort(string cohortId, string academicSession, string programId)
        {
            StudentCohort? cohort = dataHandler.GetStudentCohortById(cohortId);
            if (cohort == null)
            {
                var newCohort = new StudentCohort
                {
                    CohortID = cohortId,
                    AcademicSession = academicSession,
                    ProgramId = programId
                };
                dataHandler.CreateStudentCohort(newCohort);
                return true;
            }
            else
            {
                throw new Exception($"Cohort already exist.");
            }
        }

        public StudentCohort GetStudentCohortById(string cohortId)
        {
            var cohort = dataHandler.GetStudentCohortById(cohortId);
            if (cohort == null)
            {
                throw new Exception($"Cohort with ID {cohortId} not found.");
            }
            return cohort;
        }

        public List<StudentCohort> GetAllStudentCohorts()
        {
            return dataHandler.GetAllStudentCohorts();
        }


        public List<StudentCohort> GetProgramCohorts(string programId)
        {
            return dataHandler.GetProgramCohorts(programId);
        }
    }
}
