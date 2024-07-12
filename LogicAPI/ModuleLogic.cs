using StudentAdministrator.DataLayer;
using StudentAdministrator.LogicAPI.Interfaces;
using StudentAdministrator.Models;

namespace StudentAdministrator.LogicAPI
{
    public class ModuleLogic : IModuleLogic
    {
        private readonly IDataHandler dataHandler;

        public ModuleLogic(IDataHandler dataHandler)
        {
            this.dataHandler = dataHandler;
        }

        public bool CreateModule(string moduleCode, string title, bool isOptional, string programId)
        {
            var module = dataHandler.GetModuleByCode(moduleCode);
            if (module == null)
            {
                var newModule = new Module { 
                    Code = moduleCode,
                    Title = title,
                    isOptional = isOptional,
                    ProgramId = programId,
                };

                dataHandler.CreateModule(newModule);
                return true;
            }
            else
            {
                throw new ArgumentException("Module already exist.");
            }
        }


        public Module GetModuleByCode(string moduleCode)
        {
            return dataHandler.GetModuleByCode(moduleCode);
        }

        public List<Module> GetAllModules()
        {
            return dataHandler.GetAllModules();
        }

        public List<Module> GetOptionalModules(string programId)
        {
            return dataHandler.GetOptionalModules(programId);
        }

        public List<Module> GetProgramModules(string programId)
        {
            return dataHandler.GetProgramModules(programId);
        }

        public List<StudentAssessment> GetModuleAssessments(string moduleCode)
        {
            return dataHandler.GetModuleAssessments(moduleCode);
        }

        public string DetermineModuleResult(string studentId, string moduleCode)
        {
            int totalMarksScored = 0;
            int totalMaxMarks = 0;
            List<StudentAssessment> studentAssessments = dataHandler.GetStudentAssessmentsByStudentID(studentId, moduleCode);

            if(studentAssessments != null)
            {
                if (studentAssessments.Count == 0)
                {
                    return "Undefined";
                }
            }
            
            foreach (StudentAssessment studentAssessment in studentAssessments)
            {
                int markScored = studentAssessment.MarkScored;
                int maxMark = studentAssessment.MaxMarks;
                int weightPercentage = studentAssessment.WeightPercentage;
                totalMarksScored += markScored;
                totalMaxMarks += maxMark;

            }
            if (totalMarksScored == 0)
            {
                return "Undefined";
            }
            double moduleScore = (totalMarksScored * 100) / totalMaxMarks;
            if (moduleScore >= 50)
            {
                return "Pass";
            }
            else if (moduleScore >= 45 && moduleScore < 50)
            {
                return "PassCompensatory";
            }
            else
            {
                return "Fail";
            }
        }
        public double CalculateProgramScore(string studentId, string programId)
        {
            List<Module> moduleCodes = GetProgramModules(programId);

            int totalMarksScored = 0;
            int totalMaxMarks = 0;
            double programScore = 0;

            foreach (Module moduleCode in moduleCodes)
            {
                List<StudentAssessment> studentAssessments = dataHandler.GetStudentAssessmentsByStudentID(studentId, moduleCode.Code);

                List<string> selectedAssessments = new List<string>();

                foreach (StudentAssessment studentAssessment in studentAssessments)
                {
                    int markScored = studentAssessment.MarkScored;
                    int maxMark = studentAssessment.MaxMarks;
                    int weightPercentage = studentAssessment.WeightPercentage;
                    totalMarksScored += markScored;
                    totalMaxMarks += maxMark;
                }
            }
            if(totalMaxMarks > 0)
            {

                programScore = (totalMarksScored * 100) / totalMaxMarks;
            }
            return programScore;
        }

        public string DetermineProgramResult(int programScore)
        {
            if (programScore >= 70 && programScore <= 100)
            {
                return "Distinction";
            }
            else if (programScore >= 50 && programScore < 70)
            {
                return "Pass";
            }
            else
            {
                return "Fail";
            }
        }
    }
}
