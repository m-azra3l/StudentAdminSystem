using StudentAdministrator.Models;
using System.Drawing;

namespace StudentAdministrator.DataLayer
{
    public partial class DataHandler : IDataHandler
    {

        private const string StudentFilePath = "StudentAdmin\\Student.txt";
        private const string StudentCohortFilePath = "StudentAdmin\\StudentCohort.txt";
        private const string DegreeProgramFilePath = "StudentAdmin\\DegreeProgrm.txt";
        private const string ModuleFilePath = "StudentAdmin\\Module.txt";
        private const string AssessmentFilePath = "StudentAdmin\\Assessment.txt";
        private string StudentAssessmentFilePath = "StudentAdmin\\StudentAssessment.txt";


        #region Student

        public void RegisterStudent(StudentModel student)
        {
            string studentData = $"{student.ID},{student.FirstName}, {student.LastName},{student.ProgramId},{student.CohortId}";

            using (StreamWriter writer = File.AppendText(StudentFilePath))
            {
                writer.WriteLine(studentData);
            }

        }


        public StudentModel GetStudentById(string studentId)
        {
            List<StudentModel> students = GetAllStudents();
            return students.FirstOrDefault(s => s.ID == studentId);
        }

        public List<StudentModel> GetAllStudents()
        {
            List<StudentModel> students = new List<StudentModel>();

            if (File.Exists(StudentFilePath))
            {
                string[] lines = File.ReadAllLines(StudentFilePath);

                foreach (string line in lines)
                {
                    string trimmedLine = line.Trim();

                    if (string.IsNullOrEmpty(trimmedLine))
                        continue; // Skip empty lines

                    string[] parts = trimmedLine.Split(',');

                    if (parts.Length != 5)
                    {
                        // Log the error or handle it appropriately
                        Console.WriteLine($"Invalid line format: {trimmedLine}");
                        continue;
                    }

                    StudentModel student = new StudentModel
                    {
                        ID = parts[0],
                        FirstName = parts[1],
                        LastName = parts[2],
                        ProgramId = parts[3],
                        CohortId = parts[4],
                    };

                    students.Add(student);
                }
            }

            return students;
        }


        public List<Module> GetStudentModules(string studentId)
        {
            List<StudentModel> students = GetAllStudents();
            StudentModel student = students.FirstOrDefault(s => s.ID == studentId);

            return student?.Modules;
        }

        public List<Assessment> GetStudentAssessments(string studentId)
        {
            List<StudentModel> students = GetAllStudents();
            StudentModel student = students.FirstOrDefault(s => s.ID == studentId);

            List<Assessment> assessments = new List<Assessment>();

            if (student != null)
            {
                foreach (Module module in student.Modules)
                {
                    assessments.AddRange(module.Assessments);
                }
            }

            return assessments;
        }

        #endregion

        #region StudentCohort

        public void CreateStudentCohort(StudentCohort cohort)
        {
            string cohortData = $"{cohort.CohortID},{cohort.AcademicSession},{cohort.ProgramId}";

            using (StreamWriter writer = File.AppendText(StudentCohortFilePath))
            {
                writer.WriteLine(cohortData);
            }
        }


        public StudentCohort GetStudentCohortById(string cohortId)
        {
            List<StudentCohort> cohorts = GetAllStudentCohorts();
            return cohorts.FirstOrDefault(c => c.CohortID == cohortId);
        }

        public List<StudentCohort> GetAllStudentCohorts()
        {
            List<StudentCohort> cohorts = new List<StudentCohort>();

            if (File.Exists(StudentCohortFilePath))
            {
                string[] lines = File.ReadAllLines(StudentCohortFilePath);

                foreach (string line in lines)
                {
                    // Trim the line to remove leading and trailing whitespaces
                    string trimmedLine = line.Trim();

                    // Skip empty lines
                    if (string.IsNullOrEmpty(trimmedLine))
                        continue;

                    string[] parts = trimmedLine.Split(',');

                    // Check if parts array has the expected number of elements
                    if (parts.Length != 3)
                    {
                        // Log the error or handle it appropriately
                        Console.WriteLine($"Invalid line format: {trimmedLine}");
                        continue;
                    }

                    StudentCohort cohort = new StudentCohort
                    {
                        CohortID = parts[0],
                        AcademicSession = parts[1],
                        ProgramId = parts[2]
                    };

                    cohorts.Add(cohort);
                }
            }

            return cohorts;
        }


        public List<StudentCohort> GetProgramCohorts(string programId)
        {
            List<StudentCohort> cohorts = new List<StudentCohort>();
            List<StudentCohort> studentCohorts = GetAllStudentCohorts();

            foreach (StudentCohort cohort in studentCohorts)
            {
                if (cohort.ProgramId == programId)
                {
                    cohorts.Add(cohort);
                }
            }

            return cohorts;
        }

        #endregion

        #region DegreeProgram

        public void CreateDegreeProgram(DegreeProgram program)
        {
            string programData = $"{program.ProgramID},{program.Title},{program.DurationInYears}";

            using (StreamWriter writer = File.AppendText(DegreeProgramFilePath))
            {
                writer.WriteLine(programData);
            }
        }

        public DegreeProgram? GetDegreeProgramById(string programID)
        {
            List<DegreeProgram?> programs = GetAllDegreePrograms();
            return programs.FirstOrDefault(p => p.ProgramID == programID);
        }

        public List<DegreeProgram> GetAllDegreePrograms()
        {
            List<DegreeProgram> programs = new List<DegreeProgram>();

            if (File.Exists(DegreeProgramFilePath))
            {
                string[] lines = File.ReadAllLines(DegreeProgramFilePath);

                foreach (string line in lines)
                {
                    // Trim the line to remove leading and trailing whitespaces
                    string trimmedLine = line.Trim();

                    // Skip empty lines
                    if (string.IsNullOrEmpty(trimmedLine))
                        continue;

                    string[] parts = trimmedLine.Split(',');

                    // Check if parts array has the expected number of elements
                    if (parts.Length != 3)
                    {
                        // Log the error or handle it appropriately
                        Console.WriteLine($"Invalid line format: {trimmedLine}");
                        continue;
                    }

                    DegreeProgram program = new DegreeProgram
                    {
                        ProgramID = parts[0],
                        Title = parts[1],
                        DurationInYears = parts[2]
                    };

                    programs.Add(program);
                }
            }

            return programs;
        }


        public List<Module> GetAllProgramModules(string programId)
        {
            List<Module> modules = GetAllModules();

            return modules.Where(m => m.ProgramId == programId).ToList();
        }

        #endregion

        #region Module

        public void CreateModule(Module module)
        {
            string moduleData = $"{module.Code},{module.Title},{module.isOptional},{module.ProgramId}";

            using (StreamWriter writer = File.AppendText(ModuleFilePath))
            {
                writer.WriteLine(moduleData);
            }
        }

        public Module GetModuleByCode(string moduleCode)
        {
            List<Module> modules = GetAllModules();

           return modules.FirstOrDefault(m => m.Code == moduleCode);
        }

        public List<Module> GetAllModules()
        {
            List<Module> modules = new List<Module>();

            if (File.Exists(ModuleFilePath))
            {
                string[] lines = File.ReadAllLines(ModuleFilePath);

                foreach (string line in lines)
                {
                    // Trim the line to remove leading and trailing whitespaces
                    string trimmedLine = line.Trim();

                    // Skip empty lines
                    if (string.IsNullOrEmpty(trimmedLine))
                        continue;

                    string[] parts = trimmedLine.Split(',');

                    // Check if parts array has the expected number of elements
                    if (parts.Length != 4)
                    {
                        // Log the error or handle it appropriately
                        Console.WriteLine($"Invalid line format: {trimmedLine}");
                        continue;
                    }

                    // Safely parsing boolean value
                    bool.TryParse(parts[2], out bool isOptional);

                    Module module = new Module
                    {
                        Code = parts[0],
                        Title = parts[1],
                        isOptional = isOptional,
                        ProgramId = parts[3]
                    };

                    modules.Add(module);
                }
            }

            return modules;
        }


        public List<Module> GetOptionalModules(string programId)
        {
            List<Module> optionalModules = new List<Module>();
            List<Module> modules = GetAllModules();

            foreach (Module module in modules)
            {
                if (module.isOptional && module.ProgramId == programId)
                {
                    optionalModules.Add(module);
                }
            }

            return optionalModules;
        }

        public List<Module> GetProgramModules(string programId)
        {
            List<Module> programModules = new List<Module>();
            List<Module> modules = GetAllModules();

            foreach (Module module in modules)
            {
                if (module.ProgramId == programId)
                {
                    programModules.Add(module);
                }
            }

            return programModules;
        }

        public List<StudentAssessment> GetModuleAssessments(string moduleCode)
        {
            List<StudentAssessment> associations = new List<StudentAssessment>();

            if (File.Exists(StudentAssessmentFilePath))
            {
                string[] lines = File.ReadAllLines(StudentAssessmentFilePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts[1] == moduleCode)
                    {
                        StudentAssessment association = new StudentAssessment
                        {
                            StudentId = parts[0],
                            AssessmentId = parts[1],
                            MarkScored = int.Parse(parts[2])
                        };

                        associations.Add(association);
                    }
                }
            }

            return associations;
        }

        #endregion

        #region Assessment

        public void CreateAssessment(Assessment assessment)
        {
            string assessmentData = $"{assessment.Id},{assessment.Name},{assessment.WeightPercentage},{assessment.MaxMarks}";
            
            using (StreamWriter writer = File.AppendText(AssessmentFilePath))
            {
                writer.WriteLine(assessmentData);
            }
        }

        public Assessment GetAssessmentById(string assessmentId)
        {
            List<Assessment> assessments = GetAllAssessments();
            return assessments.FirstOrDefault(a => a.Id == assessmentId);
        }

        public List<Assessment> GetAllAssessments()
        {
            List<Assessment> assessments = new List<Assessment>();

            if (File.Exists(AssessmentFilePath))
            {
                string[] lines = File.ReadAllLines(AssessmentFilePath);

                foreach (string line in lines)
                {
                    // Trim the line to remove leading and trailing whitespaces
                    string trimmedLine = line.Trim();

                    // Skip empty lines
                    if (string.IsNullOrEmpty(trimmedLine))
                        continue;

                    string[] parts = trimmedLine.Split(',');

                    // Check if parts array has the expected number of elements
                    if (parts.Length != 4)
                    {
                        // Log the error or handle it appropriately
                        Console.WriteLine($"Invalid line format: {trimmedLine}");
                        continue;
                    }

                    // Safely parsing integer values
                    int.TryParse(parts[3], out int maxMarks);
                    int.TryParse(parts[2], out int weightPercentage);

                    Assessment assessment = new Assessment
                    {
                        Id = parts[0],
                        Name = parts[1],
                        MaxMarks = maxMarks,
                        WeightPercentage = weightPercentage
                    };

                    assessments.Add(assessment);
                }
            }

            return assessments;
        }


        public List<Assessment> GetAssessmentsByIds(List<string> assessmentIds)
        {
            List<Assessment> assessments = new List<Assessment>();

            foreach (string assessmentId in assessmentIds)
            {
                Assessment assessment = GetAssessmentById(assessmentId);
                if (assessment != null)
                {
                    assessments.Add(assessment);
                }
            }

            return assessments;
        }


        public List<Module> GetAssessmentModules(string assessmentName)
        {
            List<Module> modules = GetAllModules();

            List<Module> linkedModules = modules.Where(module => module.Assessments.Any(a => a.Name == assessmentName)).ToList();

            return linkedModules;
        }

        #endregion

        #region StudentAssessment

        public List<StudentAssessment> GetAllStudentAssessments()
        {
            List<StudentAssessment> assessments = new List<StudentAssessment>();

            if (File.Exists(StudentAssessmentFilePath))
            {
                string[] lines = File.ReadAllLines(StudentAssessmentFilePath);

                foreach (string line in lines)
                {
                    // Trim the line to remove leading and trailing whitespaces
                    string trimmedLine = line.Trim();

                    // Skip empty lines
                    if (string.IsNullOrEmpty(trimmedLine))
                        continue;

                    string[] parts = trimmedLine.Split(',');

                    // Check if parts array has the expected number of elements
                    if (parts.Length != 7)
                    {
                        // Log the error or handle it appropriately
                        Console.WriteLine($"Invalid line format: {trimmedLine}");
                        continue;
                    }

                    // Safely parsing integer values
                    int.TryParse(parts[4], out int markScored);
                    int.TryParse(parts[5], out int maxMarks);
                    int.TryParse(parts[6], out int weightPercentage);

                    StudentAssessment assessment = new StudentAssessment
                    {
                        StudentId = parts[0],
                        AssessmentId = parts[1],
                        AssessmentName = parts[2],
                        ModuleCode = parts[3],
                        MarkScored = markScored,
                        MaxMarks = maxMarks,
                        WeightPercentage = weightPercentage,
                    };

                    assessments.Add(assessment);
                }
            }

            return assessments;
        }


        public List<StudentAssessment> GetStudentAssessmentsByStudentID(string studentID, string moduleCode)
        {
            List<StudentAssessment> associations = new List<StudentAssessment>();

            if (File.Exists(StudentAssessmentFilePath))
            {
                string[] lines = File.ReadAllLines(StudentAssessmentFilePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts[0] == studentID && parts[3] == moduleCode)
                    {
                        StudentAssessment association = new StudentAssessment
                        {
                            StudentId = parts[0],
                            AssessmentId = parts[1],
                            AssessmentName = parts[2],
                            ModuleCode = parts[3],
                            MarkScored = int.Parse(parts[4]),
                            MaxMarks = int.Parse(parts[5]),
                            WeightPercentage = int.Parse(parts[6]),
                        };

                        associations.Add(association);
                    }
                }
            }

            return associations;
        }

        public StudentAssessment GetSingleAssessment(string studentId, string assessmentId, string moduleCode)
        {
            List<StudentAssessment> assessments = GetAllStudentAssessments();

            return assessments.FirstOrDefault(assessment =>
                assessment.StudentId == studentId &&
                assessment.AssessmentId == assessmentId && assessment.ModuleCode == moduleCode);
        }


        public void RecordAssessment(StudentAssessment association)
        {
            using (StreamWriter writer = File.AppendText(StudentAssessmentFilePath))
            {
                writer.WriteLine($"{association.StudentId},{association.AssessmentId},{association.AssessmentName},{association.ModuleCode},{association.MarkScored},{association.MaxMarks},{association.WeightPercentage}");
            }
        }

        #endregion
    }
}
