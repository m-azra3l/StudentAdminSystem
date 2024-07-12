using StudentAdministrator.Helpers;
using StudentAdministrator.LogicAPI.Interfaces;
using StudentAdministrator.Models;

namespace StudentAdministrator.UI
{
    public partial class AddEditModule : Form
    {
        private readonly IModuleLogic moduleLogic;
        private readonly IAssessmentLogic assessmentLogic;
        private readonly IDegreeLogic degreeLogic;
        private IdHelper idHelper;
        public bool IsAdding { get; set; } = true;
        public Module? SelectedModule { get; set; }
        public string? Code { get; set; }
        public string? Title { get; set; }
        public bool isOptional { get; set; }
        public string? ProgramId { get; set; }
        public AddEditModule(
            IModuleLogic moduleLogic,
            IAssessmentLogic assessmentLogic,
            IDegreeLogic degreeLogic,
            IdHelper idHelper)
        {
            InitializeComponent();
            this.moduleLogic = moduleLogic;
            this.assessmentLogic = assessmentLogic;
            this.degreeLogic = degreeLogic;
            this.idHelper = idHelper;
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEditModule_Load(object sender, EventArgs e)
        {
            idBox.Text = IsAdding ? idHelper.GenerateModuleCode() : Code;
            updateBtn.Text = IsAdding ? "Create" : "Update";
            titleBox.Text = IsAdding ? "" : Title;
            optionCheck.Checked = IsAdding ? false : isOptional;
            List<DegreeProgram> programs = degreeLogic.GetAllDegreePrograms();
            programBox.DataSource = programs;
            programBox.DisplayMember = "Title";
            programBox.ValueMember = "ProgramID";
            List<Assessment> assessments = assessmentLogic.GetAllAssessments();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (IsAdding)
            {
                AddModule();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void AddModule()
        {
            try
            {
                string moduleTitle = titleBox.Text.ToString();
                string moduleCode = idBox.Text.ToString();
                string programId = programBox.SelectedValue.ToString();
                bool isOptional = optionCheck.Checked;

                if (moduleCode != "" && moduleTitle != "" && programId != "")
                {
                    bool success = moduleLogic.CreateModule(moduleCode, moduleTitle, isOptional, programId);

                    if (success)
                    {
                        MessageBox.Show("Module added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add Module. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
