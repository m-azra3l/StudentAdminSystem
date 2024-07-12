using StudentAdministrator.Helpers;
using StudentAdministrator.LogicAPI.Interfaces;
using StudentAdministrator.Models;

namespace StudentAdministrator.UI
{
    public partial class AddEditProgram : Form
    {
        private readonly IDegreeLogic degreeLogic;
        private IdHelper idHelper;
        public bool IsAdding { get; set; } = true;
        public DegreeProgram? SelectedDegree { get; set; }
        public string? Title { get; set; }
        public string? DurationInYears { get; set; }
        public string? ProgramID { get; set; }
        public AddEditProgram(IDegreeLogic degreeLogic, IdHelper idHelper)
        {
            InitializeComponent();
            this.degreeLogic = degreeLogic;
            this.idHelper = idHelper;
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (IsAdding)
            {
                AddDegree();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void AddEditProgram_Load(object sender, EventArgs e)
        {
            idBox.Text = IsAdding ? idHelper.GenerateDegreeProgramId() : ProgramID;
            updateBtn.Text = IsAdding ? "Create" : "Update";
            titleBox.Text = IsAdding ? "" : Title;
            durationBox.Text = IsAdding ? "" : DurationInYears;
        }

        public void AddDegree()
        {
            try
            {
                string programID = idBox.Text.ToString();
                string title = titleBox.Text.ToString();
                string duration = durationBox.Text.ToString();

                if (programID != "" && duration != "" && duration != "")
                {
                    bool success = degreeLogic.CreateDegreeProgram(programID, title, duration);

                    if (success)
                    {
                        MessageBox.Show("Degree added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add degree. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
