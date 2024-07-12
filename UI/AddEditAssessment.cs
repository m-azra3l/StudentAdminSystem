using StudentAdministrator.Helpers;
using StudentAdministrator.LogicAPI;
using StudentAdministrator.LogicAPI.Interfaces;
using StudentAdministrator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAdministrator.UI
{
    public partial class AddEditAssessment : Form
    {
        private readonly IAssessmentLogic assessmentLogic;
        private IdHelper idHelper;
        public Assessment? SelectedAssessment { get; set; }
        public bool IsAdding { get; set; } = true;
        public string? AssessId { get; set; }
        public string? AssessName { get; set; }
        public int MaxScore { get; set; }
        public int Percentage { get; set; }
        public AddEditAssessment(IAssessmentLogic assessmentLogic, IdHelper idHelper)
        {
            InitializeComponent();
            this.assessmentLogic = assessmentLogic;
            this.idHelper = idHelper;
        }


        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (IsAdding)
            {
                AddAssessment();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void AddEditAssessment_Load(object sender, EventArgs e)
        {
            updateBtn.Text = IsAdding ? "Create" : "Update";
            nameBox.Text = IsAdding ? "" : AssessName;
            idBox.Text = IsAdding ? idHelper.GenerateAssessmentId() : AssessId;
            maxBox.Text = IsAdding ? "" : MaxScore.ToString();
            percentBox.Text = IsAdding ? "" : Percentage.ToString();
        }

        public void AddAssessment()
        {
            try
            {
                string assessName = nameBox.Text.ToString();
                string assessId = idBox.Text.ToString();
                int maxScore = int.Parse(maxBox.Text.ToString());
                int percentage = int.Parse(percentBox.Text.ToString());

                if (assessName != "" && assessId != "")
                {
                    bool success = assessmentLogic.CreateAssessment(assessId, assessName, maxScore, percentage);

                    if (success)
                    {
                        MessageBox.Show("Assessment added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add Assessment. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
