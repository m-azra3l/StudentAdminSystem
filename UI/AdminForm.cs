using static System.Runtime.InteropServices.JavaScript.JSType;
using StudentAdministrator.DataLayer;
using StudentAdministrator.Helpers;
using StudentAdministrator.LogicAPI.Interfaces;
using StudentAdministrator.LogicAPI;

namespace StudentAdministrator.UI
{
    public partial class AdminForm : Form
    {
        private int childFormNumber = 0;
        public string? adminId { get; set; }
        public string? adminFName { get; set; }
        public string? adminLName { get; set; }
        public string? adminRole { get; set; }

        public AdminForm()
        {
            InitializeComponent();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDataHandler dataHandler = new DataHandler();
            IStudentLogic studentLogic = new StudentLogic(dataHandler);
            Students students = new Students(studentLogic);
            students.MdiParent = this;
            students.Show();
        }

        private void assessmentRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDataHandler dataHandler = new DataHandler();
            IdHelper idHelper = new IdHelper();
            ICohortLogic cohortLogic = new CohortLogic(dataHandler);
            IDegreeLogic degreeLogic = new DegreeLogic(dataHandler);
            IModuleLogic moduleLogic = new ModuleLogic(dataHandler);
            IAssessmentLogic assessmentLogic = new AssessmentLogic(dataHandler);
            IStudentLogic studentLogic = new StudentLogic(dataHandler);
            AssessmentRecord assessmentRecord = new AssessmentRecord(studentLogic, degreeLogic, cohortLogic, moduleLogic, assessmentLogic);
            assessmentRecord.MdiParent = this;
            assessmentRecord.Show();
        }

        private void cohortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IDataHandler dataHandler = new DataHandler();
            ICohortLogic cohortLogic = new CohortLogic(dataHandler);
            Cohorts cohorts = new Cohorts(cohortLogic);
            cohorts.MdiParent = this;
            cohorts.Show();
        }

        private void degreeProgramToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IDataHandler dataHandler = new DataHandler();
            IDegreeLogic degreeLogic = new DegreeLogic(dataHandler);
            DegreePrograms degreePrograms = new DegreePrograms(degreeLogic);
            degreePrograms.MdiParent = this;
            degreePrograms.Show();
        }

        private void modulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDataHandler dataHandler = new DataHandler();
            IModuleLogic moduleLogic = new ModuleLogic(dataHandler);
            Modules modules = new Modules(moduleLogic);
            modules.MdiParent = this;
            modules.Show();
        }

        private void assessmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDataHandler dataHandler = new DataHandler();
            IAssessmentLogic assessmentLogic = new AssessmentLogic(dataHandler);
            Assessments assessments = new Assessments(assessmentLogic);
            assessments.MdiParent = this;
            assessments.Show();
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            IDataHandler dataHandler = new DataHandler();
            IStudentLogic studentLogic = new StudentLogic(dataHandler);
            Students students = new Students(studentLogic);
            students.MdiParent = this;
            students.Show();
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
    }
}
