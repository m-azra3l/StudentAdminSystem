using Microsoft.VisualBasic;
using StudentAdministrator.DataLayer;
using StudentAdministrator.Helpers;
using StudentAdministrator.LogicAPI.Interfaces;
using StudentAdministrator.LogicAPI;
using StudentAdministrator.Models;

namespace StudentAdministrator.UI
{
    public partial class DegreePrograms : Form
    {
        private readonly IDegreeLogic degreeLogic;
        public DegreePrograms(IDegreeLogic degreeLogic)
        {
            InitializeComponent();
            this.degreeLogic = degreeLogic;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DegreePrograms_Load(object sender, EventArgs e)
        {
            LoadDegrees();
        }

        private void LoadDegrees()
        {
            List<DegreeProgram> degrees = degreeLogic.GetAllDegreePrograms();
            PopulateDegreeListView(degrees);
        }

        private void PopulateDegreeListView(List<DegreeProgram> degrees)
        {
            listView1.Items.Clear();

            foreach (DegreeProgram degree in degrees)
            {
                ListViewItem item = new ListViewItem(degree.ProgramID);
                item.SubItems.Add(degree.Title);
                item.SubItems.Add(degree.DurationInYears);
                item.Tag = degree;

                listView1.Items.Add(item);
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            IDataHandler dataHandler = new DataHandler();
            IdHelper idHelper = new IdHelper();

            IDegreeLogic degreeLogic = new DegreeLogic(dataHandler);

            AddEditProgram addForm = new AddEditProgram(degreeLogic, idHelper);

            addForm.IsAdding = true;

            DialogResult result = addForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadDegrees();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = Interaction.InputBox("Enter Program ID:", "Search Program", "");

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                DegreeProgram degree = degreeLogic.GetDegreeById(searchTerm);

                if (degree != null)
                {
                    listView1.Items.Clear();

                    ListViewItem item = new ListViewItem(degree.ProgramID);
                    item.SubItems.Add(degree.Title);
                    item.SubItems.Add(degree.DurationInYears.ToString());
                    item.Tag = degree;

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
            LoadDegrees();
        }
    }
}
