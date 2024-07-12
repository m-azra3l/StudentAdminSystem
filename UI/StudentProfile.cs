using StudentAdministrator.Helpers;
using StudentAdministrator.LogicAPI.Interfaces;
using StudentAdministrator.Models;

namespace StudentAdministrator.UI
{
    public partial class StudentProfile : Form
    {
        public bool IsAdding { get; set; } = true;
        public StudentModel? SelectedStudent { get; set; }
        public string? StdId { get; set; }
        public string? StdFName { get; set; }
        public string? StdLName { get; set; }
        public string? ProgramId { get; set; }
        public string? CohortId { get; set; }

        private readonly IStudentLogic studentLogic;
        private readonly ICohortLogic cohortLogic;
        private readonly IDegreeLogic degreeLogic;
        private readonly IModuleLogic moduleLogic;

        private IdHelper idHelper;
        public StudentProfile(
            IStudentLogic studentLogic,
            ICohortLogic cohortLogic,
            IDegreeLogic degreeLogic,
            IModuleLogic moduleLogic,
            IdHelper idHelper)
        {
            InitializeComponent();
            this.studentLogic = studentLogic;
            this.cohortLogic = cohortLogic;
            this.degreeLogic = degreeLogic;
            this.moduleLogic = moduleLogic;
            this.idHelper = idHelper;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentProfile_Load(object sender, EventArgs e)
        {
            updateBtn.Text = IsAdding ? "Create" : "Update";
            idBox.Text = IsAdding ? "" : StdId;
            firstNameBox.Text = IsAdding ? "" : StdFName;
            lastNameBox.Text = IsAdding ? "" : StdLName;
            List<DegreeProgram> programs = degreeLogic.GetAllDegreePrograms();
            degreeBox.DataSource = programs;
            degreeBox.DisplayMember = "Title";
            degreeBox.ValueMember = "ProgramID";
            degreeBox_SelectedIndexChanged(degreeBox, EventArgs.Empty);
            if (!IsAdding)
            {
                degreeBox.SelectedValue = ProgramId;
                cohortBox.SelectedValue = CohortId;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (IsAdding)
            {
                AddStudent();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void AddStudent()
        {
            try
            {
                string studentId = idBox.Text.ToString();
                string firstName = firstNameBox.Text.ToString();
                string lastName = lastNameBox.Text.ToString();
                string programId = degreeBox.SelectedValue.ToString();
                string cohortId = cohortBox.SelectedValue.ToString();

                if (!string.IsNullOrWhiteSpace(studentId) && !string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName) &&
                    !string.IsNullOrWhiteSpace(programId) && !string.IsNullOrWhiteSpace(cohortId))
                {
                    bool success = studentLogic.RegisterStudent(studentId, firstName, lastName, programId, cohortId);

                    if (success)
                    {
                        MessageBox.Show("Student added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add student. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void cohortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedAcademicSession = cohortBox.Text.ToString();
            idBox.Text = idHelper.GenerateStudentId(selectedAcademicSession);
        }

        private void degreeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string programId = degreeBox.SelectedValue.ToString();
            List<StudentCohort> cohorts = cohortLogic.GetProgramCohorts(programId);
            cohortBox.DataSource = cohorts;
            cohortBox.DisplayMember = "AcademicSession";
            cohortBox.ValueMember = "CohortId";
        }
    }
}
