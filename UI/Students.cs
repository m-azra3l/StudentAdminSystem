using Microsoft.VisualBasic;
using StudentAdministrator.DataLayer;
using StudentAdministrator.Helpers;
using StudentAdministrator.LogicAPI.Interfaces;
using StudentAdministrator.LogicAPI;
using StudentAdministrator.Models;

namespace StudentAdministrator.UI
{
    public partial class Students : Form
    {

        private readonly IStudentLogic studentLogic;
        public Students(IStudentLogic studentLogic)
        {
            InitializeComponent();
            this.studentLogic = studentLogic;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            listView1.Items.Clear();
            List<StudentModel> students = studentLogic.GetAllStudents();
            foreach (StudentModel student in students)
            {
                ListViewItem item = new ListViewItem(student.ID);
                item.SubItems.Add(student.FirstName);
                item.SubItems.Add(student.LastName);
                item.SubItems.Add(student.ProgramId);
                item.SubItems.Add(student.CohortId);
                item.Tag = student;

                listView1.Items.Add(item);
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            IDataHandler dataHandler = new DataHandler();
            IdHelper idHelper = new IdHelper();
            IDegreeLogic degreeLogic = new DegreeLogic(dataHandler);
            IModuleLogic moduleLogic = new ModuleLogic(dataHandler);
            ICohortLogic cohortLogic = new CohortLogic(dataHandler);
            IStudentLogic studentLogic = new StudentLogic(dataHandler);
            StudentProfile addEditForm = new StudentProfile(studentLogic, cohortLogic, degreeLogic, moduleLogic, idHelper);
            addEditForm.IsAdding = true;

            DialogResult result = addEditForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadStudents();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = Interaction.InputBox("Enter Student Id:", "Search Student", "");

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    StudentModel student = studentLogic.GetStudentById(searchTerm);

                    if (student != null)
                    {
                        listView1.Items.Clear();

                        ListViewItem item = new ListViewItem(student.ID);
                        item.SubItems.Add(student.FirstName);
                        item.SubItems.Add(student.LastName);
                        item.SubItems.Add(student.ProgramId);
                        item.SubItems.Add(student.CohortId);
                        item.Tag = student;

                        listView1.Items.Add(item);
                    }
                    else
                    {
                        MessageBox.Show("No matching student found.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            LoadStudents();
        }

        private void viewGrade_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                IDataHandler dataHandler = new DataHandler();
                IdHelper idHelper = new IdHelper();
                IAssessmentLogic assessmentLogic = new AssessmentLogic(dataHandler);
                IModuleLogic moduleLogic = new ModuleLogic(dataHandler);
                AcademicRecord recordForm = new AcademicRecord(assessmentLogic, moduleLogic);
                StudentModel selectedStudent = (StudentModel)listView1.SelectedItems[0].Tag;
                recordForm.StdId = selectedStudent.ID;
                recordForm.StdName = selectedStudent.FirstName + " " + selectedStudent.LastName;
                recordForm.ProgramId = selectedStudent.ProgramId;

                DialogResult result = recordForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadStudents();
                }
            }
            else
            {
                MessageBox.Show("Please select a student to view grade.", "View Student Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
