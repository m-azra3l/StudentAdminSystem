using Microsoft.VisualBasic;
using StudentAdministrator.DataLayer;
using StudentAdministrator.Helpers;
using StudentAdministrator.LogicAPI.Interfaces;
using StudentAdministrator.LogicAPI;
using StudentAdministrator.Models;

namespace StudentAdministrator.UI
{
    public partial class Modules : Form
    {
        private readonly IModuleLogic moduleLogic;
        public Modules(IModuleLogic moduleLogic)
        {
            InitializeComponent();
            this.moduleLogic = moduleLogic;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modules_Load(object sender, EventArgs e)
        {
            LoadModules();
        }

        private void LoadModules()
        {
            listView1.Items.Clear();

            List<Module> modules = moduleLogic.GetAllModules();

            foreach (Module module in modules)
            {
                ListViewItem item = new ListViewItem(module.Code);
                item.SubItems.Add(module.Title);
                item.SubItems.Add(module.ProgramId);
                item.SubItems.Add(module.isOptional ? "Yes" : "No");
                item.Tag = module;

                listView1.Items.Add(item);
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            IDataHandler dataHandler = new DataHandler();
            IdHelper idHelper = new IdHelper();
            IModuleLogic moduleLogic = new ModuleLogic(dataHandler);
            IDegreeLogic degreeLogic = new DegreeLogic(dataHandler);
            IAssessmentLogic assessmentLogic = new AssessmentLogic(dataHandler);
            AddEditModule addEditForm = new AddEditModule(moduleLogic, assessmentLogic, degreeLogic, idHelper);
            addEditForm.IsAdding = true;

            DialogResult result = addEditForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadModules();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = Interaction.InputBox("Enter Module Code:", "Search Module", "");

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                Module module = moduleLogic.GetModuleByCode(searchTerm);

                if (module != null)
                {
                    listView1.Items.Clear();

                    ListViewItem item = new ListViewItem(module.Code);
                    item.SubItems.Add(module.Title);
                    item.SubItems.Add(module.ProgramId);
                    item.SubItems.Add(module.isOptional ? "Yes" : "No");
                    item.Tag = module;

                    listView1.Items.Add(item);
                }
                else
                {
                    MessageBox.Show("No matching module found.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadModules();
        }
    }
}
