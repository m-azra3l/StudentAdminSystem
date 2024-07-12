using StudentAdministrator.DataLayer;
using StudentAdministrator.LogicAPI.Interfaces;
using StudentAdministrator.Models;

namespace StudentAdministrator.LogicAPI
{
    public class DegreeLogic : IDegreeLogic
    {
        private readonly IDataHandler dataHandler;

        public DegreeLogic(IDataHandler dataHandler)
        {
            this.dataHandler = dataHandler;
        }

        public bool CreateDegreeProgram(string programId, string title, string durationInYears)
        {

            DegreeProgram? program = dataHandler.GetDegreeProgramById(programId);
            if (program == null)
            {
                var degree = new DegreeProgram
                {
                    ProgramID = programId,
                    Title = title,
                    DurationInYears = durationInYears
                };
                dataHandler.CreateDegreeProgram(degree);
                return true;
            }
            else
            {
                throw new Exception($"DegreeProgram already exist.");
            }

        }


        public List<DegreeProgram> GetAllDegreePrograms()
        {
            return dataHandler.GetAllDegreePrograms();
        }

        public DegreeProgram GetDegreeById(string id)
        {
            var program = dataHandler.GetDegreeProgramById(id);
            if(program == null) 
            { 

                throw new Exception($"DegreeProgram with ID {id} not found.");
            }
            return program;
        }

        public List<Module> GetAllProgramModules(string programId)
        {
            return dataHandler.GetAllProgramModules(programId);
        }

        public int CalculateProgrammeMark(List<int> moduleMarks)
        {
            int totalMarks = moduleMarks.Sum();
            int numberOfModules = moduleMarks.Count;

            return totalMarks / numberOfModules;
        }

        public bool IsProgrammeMarkUndefined(List<int> moduleMarks)
        {
            return moduleMarks.Any(mark => mark < 0); // Assuming a mark below 0 is considered undefined
        }

        public string DetermineProgrammeResult(int programmeMark)
        {
            if (programmeMark >= 70)
            {
                return "Distinction";
            }
            else if (programmeMark >= 50 && programmeMark < 70)
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
