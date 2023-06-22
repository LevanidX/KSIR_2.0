using System;
using System.Windows.Forms;

namespace Main_System_Stroitelstvo_I_Remont
{
    public partial class CompaniesDataBase : Form
    {
        AppNavigation appNavigation = new AppNavigation();
        Viewing viewing = new Viewing();

        public CompaniesDataBase()
        {
            InitializeComponent();
        }

        private void CompaniesDataBase_Load(object sender, EventArgs e)
        {
            this.companiesTableAdapter.Fill(this.stroidtelstvo_i_remontDataSet.companies);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            viewing.Searching(companiesDataGridView, searchTextBox);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            viewing.ClearAll(companiesDataGridView, companiesBindingSource, searchTextBox);
        }

        private void BtnExitForm_Click(object sender, EventArgs e)
        {
            appNavigation.QuitToMainMenu(this);
        }
    }
}
