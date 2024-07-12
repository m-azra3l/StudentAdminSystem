using Microsoft.VisualBasic;
using StudentAdministrator.DataLayer;
using StudentAdministrator.Helpers;
using StudentAdministrator.LogicAPI.Interfaces;
using StudentAdministrator.LogicAPI;
using StudentAdministrator.Models;

namespace StudentAdministrator.UI
{
    public partial class Assessments : Form
    {
        private readonly IAssessmentLogic assessmentLogic;
        public Assessments(IAssessmentLogic assessmentLogic)
        {
            InitializeComponent();
            this.assessmentLogic = assessmentLogic;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Assessments_Load(object sender, EventArgs e)
        {
            LoadAssessments();
        }

        private void LoadAssessments()
        {
            listView1.Items.Clear();

            List<Assessment> assessments = assessmentLogic.GetAllAssessments();

            foreach (Assessment assessment in assessments)
            {
                ListViewItem item = new ListViewItem(assessment.Id);
                item.SubItems.Add(assessment.Name);
                item.SubItems.Add(assessment.MaxMarks.ToString());
                item.SubItems.Add(assessment.WeightPercentage.ToString());
                item.Tag = assessment;

                listView1.Items.Add(item);
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            IDataHandler dataHandler = new DataHandler();
            IdHelper idHelper = new IdHelper();
            IAssessmentLogic assessmentLogic = new AssessmentLogic(dataHandler);
            AddEditAssessment addEditForm = new AddEditAssessment(assessmentLogic, idHelper);
            addEditForm.IsAdding = true;

            DialogResult result = addEditForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadAssessments();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = Interaction.InputBox("Enter Assessment Id:", "Search Assessment", "");

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    Assessment assessment = assessmentLogic.GetAssessmentById(searchTerm);

                    if (assessment != null)
                    {
                        listView1.Items.Clear();

                        ListViewItem item = new ListViewItem(assessment.Id);
                        item.SubItems.Add(assessment.Name);
                        item.SubItems.Add(assessment.MaxMarks.ToString());
                        item.SubItems.Add(assessment.WeightPercentage.ToString());
                        item.Tag = assessment;

                        listView1.Items.Add(item);
                    }
                    else
                    {
                        MessageBox.Show("No matching assessment found.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadAssessments();
        }
    }
}
