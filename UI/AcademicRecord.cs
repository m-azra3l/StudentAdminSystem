using StudentAdministrator.LogicAPI.Interfaces;
using StudentAdministrator.Models;

namespace StudentAdministrator.UI
{
    public partial class AcademicRecord : Form
    {
        public string? StdId { get; set; }

        public string? StdName { get; set; }
        public string? ProgramId { get; set; }

        private readonly IAssessmentLogic assessmentLogic;
        private readonly IModuleLogic moduleLogic;

        public AcademicRecord(
            IAssessmentLogic assessmentLogic,
            IModuleLogic moduleLogic)
        {
            InitializeComponent();
            this.assessmentLogic = assessmentLogic;
            this.moduleLogic = moduleLogic;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }


        private void LoadAssessment(string moduleCode)
        {
            try
            {
                List<StudentAssessment> studentAssessments = assessmentLogic.GetStudentAssessmentsByStudentID(StdId, moduleCode);
                if (studentAssessments.Count == 0)
                {
                    ListViewItem item = new ListViewItem("Undefined");
                    item.SubItems.Add("Undefined");
                    item.SubItems.Add("Undefined");
                    item.SubItems.Add("Undefined");
                    item.SubItems.Add("Undefined");
                    item.SubItems.Add("Undefined");

                    assessmentList.Items.Add(item);
                }
                else
                {
                    foreach (StudentAssessment studentAssessment in studentAssessments)
                    {
                        int markScored = studentAssessment.MarkScored;
                        int maxMarks = studentAssessment.MaxMarks;

                        double percentage = (markScored * 100) / maxMarks;
                        double maxPercentage = studentAssessment.WeightPercentage;
                        ListViewItem item = new ListViewItem(studentAssessment.AssessmentId);
                        item.SubItems.Add(studentAssessment.AssessmentName);
                        item.SubItems.Add(markScored.ToString());
                        item.SubItems.Add(maxMarks.ToString());
                        item.SubItems.Add(percentage.ToString());
                        item.SubItems.Add(maxPercentage.ToString());

                        assessmentList.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void selectModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            assessmentList.Items.Clear();
            Module module = (Module)selectModule.SelectedItem;
            string moduleCode = module.Code;
            LoadAssessment(moduleCode);
            double modulescore = assessmentLogic.CalculateModuleMark(StdId, moduleCode);
            string moduleResult = moduleLogic.DetermineModuleResult(StdId, moduleCode);
            double programScore = moduleLogic.CalculateProgramScore(StdId, ProgramId);
            string programResult = moduleLogic.DetermineProgramResult(Convert.ToInt32(programScore));
            /*if (modulescore >= 50)
            {
                moduleGrade.Text = "Pass";
            }
            else if (modulescore >= 45 && modulescore < 50)
            {
                moduleGrade.Text = "PassCompensatory";
            }
            else
            {
                moduleGrade.Text = "Fail";
            }
            moduleScore.Text = modulescore.ToString();
            textBox1.Text = programScore.ToString();
            textBox2.Text = programResult;*/
            if (moduleResult == "Undefined")
            {
                moduleScore.Text = "Undefined";
                moduleGrade.Text = "Undefined";
                textBox1.Text = "Undefined";
                textBox2.Text = "Undefined";
            }
            else
            {
                moduleScore.Text = modulescore.ToString();
                moduleGrade.Text = moduleResult;
                textBox1.Text = programScore.ToString();
                textBox2.Text = programResult;
            }

        }

        private void AcademicRecord_Load(object sender, EventArgs e)
        {
            stdId.Text = StdId;
            stdName.Text = StdName;
            List<Module> modules = moduleLogic.GetProgramModules(ProgramId);
            selectModule.DataSource = modules;
            selectModule.DisplayMember = "Title";
            selectModule.ValueMember = "Code";
        }
    }
}
