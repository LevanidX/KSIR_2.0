using System;
using System.Windows.Forms;

namespace Main_System_Stroitelstvo_I_Remont
{
    public partial class WorkersDataBase : Form
    {
        AppNavigation appNavigation = new AppNavigation();
        Viewing viewing = new Viewing();

        public WorkersDataBase()
        {
            InitializeComponent();
        }

        private void WorkersDataBase_Load(object sender, EventArgs e)
        {
            this.workersTableAdapter.Fill(this.stroidtelstvo_i_remontDataSet.workers);
        }

        private void BtnExitForm_Click(object sender, EventArgs e)
        {
            appNavigation.QuitToMainMenu(this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            viewing.Searching(workersDataGridView, searchTextBox);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            viewing.ClearAll(workersDataGridView, workersBindingSource, searchTextBox);
        }
    }
}
