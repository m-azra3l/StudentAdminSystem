using StudentAdministrator.LogicAPI.Interfaces;
using StudentAdministrator.Models;

namespace StudentAdministrator.UI
{
    public partial class AssessmentRecord : Form
    {
        private readonly IStudentLogic studentLogic;
        private readonly IDegreeLogic degreeLogic;
        private readonly ICohortLogic cohortLogic;
        private readonly IModuleLogic moduleLogic;
        private readonly IAssessmentLogic assessmentLogic;
        public AssessmentRecord(
            IStudentLogic studentLogic,
            IDegreeLogic degreeLogic,
            ICohortLogic cohortLogic,
            IModuleLogic moduleLogic,
            IAssessmentLogic assessmentLogic)
        {
            InitializeComponent();
            this.studentLogic = studentLogic;
            this.degreeLogic = degreeLogic;
            this.cohortLogic = cohortLogic;
            this.moduleLogic = moduleLogic;
            this.assessmentLogic = assessmentLogic;
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchParams = stdIdBox.Text.ToString();
            if (!string.IsNullOrEmpty(searchParams) && searchParams.Length >= 10)
            {
                try
                {
                    StudentModel student = studentLogic.GetStudentById(searchParams);
                    if (student != null)
                    {
                        fNameBox.Text = student.FirstName;
                        lNameBox.Text = student.LastName;
                        DegreeProgram degree = degreeLogic.GetDegreeById(student.ProgramId);
                        dProgramBox.Text = degree.Title;
                        StudentCohort cohort = cohortLogic.GetStudentCohortById(student.CohortId);
                        cohortBox.Text = cohort.AcademicSession;
                        List<Module> modules = moduleLogic.GetProgramModules(student.ProgramId);
                        moduleBox.DataSource = modules;
                        moduleBox.DisplayMember = "Title";
                        moduleBox.ValueMember = "Code";
                        List<Assessment> assessments = assessmentLogic.GetAllAssessments();
                        assessBox.DataSource = assessments;
                        assessBox.DisplayMember = "Name";
                        assessBox.ValueMember = "Id";
                        LoadAssessment();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Provide a valid Student Id in the Id box", "Error");
                return;
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (stdIdBox.Text != "" && assessBox.SelectedValue != null && scoreBox.Text != "")
                {
                    string studId = stdIdBox.Text.ToString();
                    int markScored = Convert.ToInt32(scoreBox.Text.ToString());
                    string moduleCode = moduleBox.SelectedValue.ToString();
                    string assessId = assessBox.SelectedValue.ToString();
                    Assessment assessment = assessmentLogic.GetAssessmentById(assessId);
                    StudentAssessment studentAssessment = assessmentLogic.GetSingleAssessment(studId, assessId, moduleCode);
                    List<StudentAssessment> moduleAssessments = assessmentLogic.GetStudentAssessmentsByStudentID(studId, moduleCode);
                    int totalMaxMarks = 0;

                    if (studentAssessment == null)
                    {
                        foreach (StudentAssessment moduleAssessment in moduleAssessments)
                        {
                            int maxMark = moduleAssessment.MaxMarks;
                            totalMaxMarks += maxMark;
                        }
                        if (totalMaxMarks == 100)
                        {
                            MessageBox.Show("Assessment recording failed, total marks reached.", "Error");
                            return;
                        }
                        if (markScored <= assessment.MaxMarks && markScored > -1)
                        {
                            bool success = assessmentLogic.RecordAssessment(studId, assessId, assessment.Name, moduleCode, markScored, assessment.MaxMarks, assessment.WeightPercentage);
                            if (success)
                            {
                                MessageBox.Show("Assessment recorded.", "Success");
                                LoadAssessment();
                            }
                            else
                            {
                                MessageBox.Show("Assessment recording failed, not recorded.", "Error");
                                return;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Assessment recording failed, mark scored is invalid.", "Error");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Assessment exist.", "Error");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }
        }

        private void LoadAssessment()
        {
            try
            {
                Module module = (Module)moduleBox.SelectedItem;
                string moduleCode = module.Code;
                string StdId = stdIdBox.Text.ToString();
                List<StudentAssessment> studentAssessments = assessmentLogic.GetStudentAssessmentsByStudentID(StdId, moduleCode);
                assessList.Items.Clear();
                foreach (StudentAssessment studentAssessment in studentAssessments)
                {
                    int markScored = studentAssessment.MarkScored;
                    int maxMarks = studentAssessment.MaxMarks;
                    double percentage = (markScored * 100) / maxMarks;
                    double maxPercentage = studentAssessment.WeightPercentage;
                    ListViewItem item = new ListViewItem(studentAssessment.AssessmentId);
                    item.SubItems.Add(studentAssessment.AssessmentName);
                    item.SubItems.Add(studentAssessment.ModuleCode);
                    item.SubItems.Add(markScored.ToString());
                    item.SubItems.Add(maxMarks.ToString());
                    item.SubItems.Add(percentage.ToString());
                    item.SubItems.Add(maxPercentage.ToString());
                    assessList.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void assessBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Assessment assess = (Assessment)assessBox.SelectedItem;
            string max = assess.MaxMarks.ToString();
            label5.Text = $"Max: {max}";
        }

        private void moduleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAssessment();
        }
    }
}
