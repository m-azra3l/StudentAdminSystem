using StudentAdministrator.Helpers;
using StudentAdministrator.LogicAPI.Interfaces;
using StudentAdministrator.Models;

namespace StudentAdministrator.UI
{
    public partial class AddEditCohort : Form
    {
        private readonly ICohortLogic cohortLogic;
        private readonly IDegreeLogic degreeLogic;
        private IdHelper idHelper;
        public bool IsAdding { get; set; } = true;
        public StudentCohort? SelectedCohort { get; set; }
        public string? CohortID { get; set; }
        public string? AcademicSession { get; set; }
        public string? ProgramID { get; set; }
        public AddEditCohort(ICohortLogic cohortLogic, IDegreeLogic degreeLogic, IdHelper idHelper)
        {
            InitializeComponent();
            this.cohortLogic = cohortLogic;
            this.degreeLogic = degreeLogic;
            this.idHelper = idHelper;
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEditCohort_Load(object sender, EventArgs e)
        {
            idBox.Text = IsAdding ? idHelper.GenerateCohortId() : CohortID;
            updateBtn.Text = IsAdding ? "Create" : "Update";
            sessionBox.Text = IsAdding ? "" : AcademicSession;

            List<DegreeProgram> programs = degreeLogic.GetAllDegreePrograms();
            programBox.DataSource = programs;
            programBox.DisplayMember = "Title";
            programBox.ValueMember = "ProgramID";

            if (!IsAdding)
            {
                programBox.SelectedValue = ProgramID;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (IsAdding)
            {
                AddStudentCohort();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void AddStudentCohort()
        {
            try
            {
                string cohortID = idBox.Text.ToString();
                string academicSession = sessionBox.Text.ToString();
                string programID = programBox.SelectedValue.ToString();

                if (cohortID != "" && academicSession != "" && programID != "")
                {
                    bool success = cohortLogic.CreateStudentCohort(cohortID, academicSession, programID);

                    if (success)
                    {
                        MessageBox.Show("Student cohort added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add student cohort. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    }
}
