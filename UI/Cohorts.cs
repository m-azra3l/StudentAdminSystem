using Microsoft.VisualBasic;
using StudentAdministrator.DataLayer;
using StudentAdministrator.Helpers;
using StudentAdministrator.LogicAPI.Interfaces;
using StudentAdministrator.LogicAPI;
using StudentAdministrator.Models;

namespace StudentAdministrator.UI
{
    public partial class Cohorts : Form
    {
        private readonly ICohortLogic cohortLogic;
        public string? cohortId;
        public Cohorts(ICohortLogic cohortLogic)
        {
            InitializeComponent();
            this.cohortLogic = cohortLogic;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulateCohortListView(List<StudentCohort> cohorts)
        {
            listView1.Items.Clear();

            foreach (StudentCohort cohort in cohorts)
            {
                ListViewItem item = new ListViewItem(cohort.CohortID);
                item.SubItems.Add(cohort.AcademicSession);
                item.SubItems.Add(cohort.ProgramId);
                item.Tag = cohort;
                //item.SubItems.Add(cohort.isOptional ? "Optional" : "Not Optional");

                listView1.Items.Add(item);
            }
        }

        private void Cohorts_Load(object sender, EventArgs e)
        {
            LoadStudentCohorts();
        }

        private void LoadStudentCohorts()
        {
            List<StudentCohort> cohorts = cohortLogic.GetAllStudentCohorts();
            PopulateCohortListView(cohorts);
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            IDataHandler dataHandler = new DataHandler();
            IdHelper idHelper = new IdHelper();

            ICohortLogic cohortLogic = new CohortLogic(dataHandler);
            IDegreeLogic degreeLogic = new DegreeLogic(dataHandler);

            AddEditCohort addForm = new AddEditCohort(cohortLogic, degreeLogic, idHelper);

            addForm.IsAdding = true;

            DialogResult result = addForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadStudentCohorts();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = Interaction.InputBox("Enter Cohort ID:", "Search Cohort", "");

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                StudentCohort cohort = cohortLogic.GetStudentCohortById(searchTerm);

                if (cohort != null)
                {
                    listView1.Items.Clear();

                    ListViewItem item = new ListViewItem(cohort.CohortID);
                    item.SubItems.Add(cohort.AcademicSession);
                    item.SubItems.Add(cohort.ProgramId);
                    item.Tag = cohort;

                    listView1.Items.Add(item);
                }
                else
                {
                    MessageBox.Show("No matching student cohorts found.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadStudentCohorts();
        }
    }
}
