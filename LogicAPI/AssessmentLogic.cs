using StudentAdministrator.DataLayer;
using StudentAdministrator.LogicAPI.Interfaces;
using StudentAdministrator.Models;

namespace StudentAdministrator.LogicAPI
{
    public class AssessmentLogic : IAssessmentLogic
    {
        private readonly IDataHandler dataHandler;

        public AssessmentLogic(IDataHandler dataHandler) 
        {
            this.dataHandler = dataHandler;
        }

        public bool CreateAssessment(
            string id, string assessmentName, int maxMarks, int weightPercentage)
        {
            var assessment = dataHandler.GetAssessmentById(id);
            if (assessment == null)
            {
                var newAssess = new Assessment {
                    Id = id,
                    Name = assessmentName,
                    WeightPercentage = weightPercentage,
                    MaxMarks = maxMarks,
                };

                dataHandler.CreateAssessment(newAssess);

                return true;
            }
            else
            {
                throw new ArgumentException("Assessment exists");
            }
            
        }

        public Assessment GetAssessmentById(string id)
        {
            return dataHandler.GetAssessmentById(id);
        }

        public List<Assessment> GetAllAssessments()
        {
            return dataHandler.GetAllAssessments();
        }

        public List<Module> GetAssessmentModules(string id)
        {
            return dataHandler.GetAssessmentModules(id);
        }

        public List<Assessment> GetAssessmentsByIds(List<string> assessmentIds)
        {
            return dataHandler.GetAssessmentsByIds(assessmentIds);
        }

        public List<StudentAssessment> GetAllStudentAssessments()
        {
            return dataHandler.GetAllStudentAssessments();
        }

        public List<StudentAssessment> GetStudentAssessmentsByStudentID(string studentID, string moduleCode)
        {
            return dataHandler.GetStudentAssessmentsByStudentID(studentID, moduleCode);
        }

        public StudentAssessment GetSingleAssessment(string studentId, string assessmentId, string moduleCode)
        {
            return dataHandler.GetSingleAssessment(studentId, assessmentId, moduleCode);
        }

        public bool RecordAssessment(string studentId, string assessmentId, string assessmentName, string moduleCode, int markScored, int maxMark, int weight)
        {
            var assessment = new StudentAssessment { 
                StudentId = studentId,
                AssessmentId = assessmentId,
                AssessmentName = assessmentName,
                ModuleCode = moduleCode,
                MarkScored = markScored,
                MaxMarks = maxMark,
                WeightPercentage = weight
            };
           
            dataHandler.RecordAssessment(assessment);
            return true;
        }

        public double CalculateModuleMark(string studentId, string moduleCode)
        {
            int totalMarksScored = 0;
            int totalMaxMarks = 0;
            double moduleScore = 0;
            List<StudentAssessment> studentAssessments = GetStudentAssessmentsByStudentID(studentId, moduleCode);

            List<string> selectedAssessments = new List<string>();
            foreach (StudentAssessment studentAssessment in studentAssessments)
            {
                selectedAssessments.Add(studentAssessment.AssessmentId);
                int markScored = studentAssessment.MarkScored;
                int maxMark = studentAssessment.MaxMarks;
                int weightPercentage = studentAssessment.WeightPercentage;
                totalMarksScored += markScored;
                totalMaxMarks += maxMark;
            }
            if (totalMarksScored != 0 && totalMaxMarks != 0)
            {
                moduleScore = (totalMarksScored * 100) / totalMaxMarks;
            }

            return moduleScore;
        }

        public bool ValidateAssessment(Assessment assessment)
        {
            if (assessment.MaxMarks <= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidateModuleAssessments(List<Assessment> assessments)
        {
            int totalMaxMarks = assessments.Sum(a => a.MaxMarks);

            if (totalMaxMarks <= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
